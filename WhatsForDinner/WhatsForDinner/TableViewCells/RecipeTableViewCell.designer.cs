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
	[Register ("RecipeTableViewCell")]
	partial class RecipeTableViewCell
	{
		[Outlet]
		UIKit.UILabel MissedIngredientsCountLabel { get; set; }

		[Outlet]
		UIKit.UIImageView RecipeImageView { get; set; }

		[Outlet]
		UIKit.UILabel RecipeLikesLabel { get; set; }

		[Outlet]
		UIKit.UILabel RecipeTitleLabel { get; set; }

		[Outlet]
		UIKit.UILabel UsedIngredientsCountLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (RecipeTitleLabel != null) {
				RecipeTitleLabel.Dispose ();
				RecipeTitleLabel = null;
			}

			if (RecipeImageView != null) {
				RecipeImageView.Dispose ();
				RecipeImageView = null;
			}

			if (UsedIngredientsCountLabel != null) {
				UsedIngredientsCountLabel.Dispose ();
				UsedIngredientsCountLabel = null;
			}

			if (MissedIngredientsCountLabel != null) {
				MissedIngredientsCountLabel.Dispose ();
				MissedIngredientsCountLabel = null;
			}

			if (RecipeLikesLabel != null) {
				RecipeLikesLabel.Dispose ();
				RecipeLikesLabel = null;
			}
		}
	}
}
