// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WhatsForDinner.TableViewCells
{
	[Register ("ShoppingListTableViewCell")]
	partial class ShoppingListTableViewCell
	{
		[Outlet]
		UIKit.UILabel IngredientAmountLabel { get; set; }

		[Outlet]
		UIKit.UIImageView IngredientImageView { get; set; }

		[Outlet]
		UIKit.UILabel IngredientNameLabel { get; set; }

		[Outlet]
		UIKit.UITextView IngredientNotesTextView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (IngredientImageView != null) {
				IngredientImageView.Dispose ();
				IngredientImageView = null;
			}

			if (IngredientNameLabel != null) {
				IngredientNameLabel.Dispose ();
				IngredientNameLabel = null;
			}

			if (IngredientAmountLabel != null) {
				IngredientAmountLabel.Dispose ();
				IngredientAmountLabel = null;
			}

			if (IngredientNotesTextView != null) {
				IngredientNotesTextView.Dispose ();
				IngredientNotesTextView = null;
			}
		}
	}
}
