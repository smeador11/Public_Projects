using System;
using System.Threading;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using WhatsForDinner.JsonModels;
using WhatsForDinner.Utilities;
using WhatsForDinner.ViewControllers.ViewUtilities;

namespace WhatsForDinner.TableViewCells
{
    public partial class RecipeTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString ("RecipeTableViewCell");
        public static readonly UINib Nib;
        static UIImage PlaceholderImage;
        static Task DownloadTask;

        static RecipeTableViewCell ()
        {
            Nib = UINib.FromName ("RecipeTableViewCell", NSBundle.MainBundle);
            PlaceholderImage = UIImage.FromFile("DinnerImagePlaceholder.png");
            DownloadTask = Task.Factory.StartNew(() => { });
        }

        protected RecipeTableViewCell (IntPtr handle) : base (handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        public void SetCellData(RecipeByIngredientJsonModel recipe)
        {
            RecipeTitleLabel.Text = recipe.RecipeTitle;
            UsedIngredientsCountLabel.Text = recipe.UsedIngredientCount.ToString();
            MissedIngredientsCountLabel.Text = recipe.MissedIngredientCount.ToString();
            RecipeLikesLabel.Text = recipe.RecipeLikes;
            RecipeImageView.Image = UIImage.FromFile("DinnerImagePlaceholder.png");
            try
            {
                BeginDownloadingImageForTableViewCell(recipe.RecipeImage, this);
            }
            catch { }
        }
        void BeginDownloadingImageForTableViewCell(string urlString, UITableViewCell cell)
        {
            NSUrl url = new NSUrl(urlString);
            try
            {
                byte[] data = null;
                DownloadTask = DownloadTask.ContinueWith(prevTask =>
                {
                    try
                    {
                        UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
                        var c = new GzipWebClient();
                        data = c.DownloadData(url);
                    }
                    finally
                    {
                        UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
                    }
                });
                DownloadTask = DownloadTask.ContinueWith(t => {
                    var image = UIImage.LoadFromData(NSData.FromArray(data));
                    // If the cell is null, it means the user has already scrolled that recipe off-screen.
                    if (cell != null)
                        RecipeImageView.Image = image;
                }, CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch
            {
                throw;
            }
        }
    }
}
