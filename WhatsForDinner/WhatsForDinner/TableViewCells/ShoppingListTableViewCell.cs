using System;

using Foundation;
using UIKit;
using WhatsForDinner.JsonModels;

namespace WhatsForDinner.TableViewCells
{
    public partial class ShoppingListTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString ("ShoppingListTableViewCell");
        public static readonly UINib Nib;

        static ShoppingListTableViewCell ()
        {
            Nib = UINib.FromName ("ShoppingListTableViewCell", NSBundle.MainBundle);
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
            IngredientImageView.Image = ViewControllers.ViewUtilities.iOSViewUtilities.DownloadImageFromUrl(ingredient.IngredientImage);
        }
    }
}
