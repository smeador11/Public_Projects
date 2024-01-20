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
    public partial class ShoppingListTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString ("ShoppingListTableViewCell");
        public static readonly UINib Nib;
        static Task DownloadTask;
        static UIImage PlaceholderImage;

        static ShoppingListTableViewCell ()
        {
            Nib = UINib.FromName ("ShoppingListTableViewCell", NSBundle.MainBundle);
            PlaceholderImage = UIImage.FromFile("DinnerImagePlaceholder.png");
            DownloadTask = Task.Factory.StartNew(() => { });
        }

        protected ShoppingListTableViewCell (IntPtr handle) : base (handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void SetCellData(IngredientJsonModel ingredient)
        {
            IngredientAmountLabel.Text = string.Format("Amount: {0} {1}", ingredient.IngredientAmount, ingredient.UnitLong);
            IngredientNameLabel.Text = "Ingredient Name: " + ingredient.IngredientName;
            IngredientNotesTextView.Text = ingredient.IngredientOriginalName;
            IngredientImageView.Image = PlaceholderImage;
            try
            {
                BeginDownloadingImageForTableViewCell(ingredient.IngredientImage, this);
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
                    if(data != null)
                    {
                        var image = UIImage.LoadFromData(NSData.FromArray(data));
                        // If the cell is null, it means the user has already scrolled that recipe off-screen.
                        if (cell != null)
                            IngredientImageView.Image = image;
                    }
                }, CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch
            {
                throw;
            }
        }
    }
}
