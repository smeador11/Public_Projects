// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WhatsForDinner.ViewControllers
{
	[Register ("RecipeViewController")]
	partial class RecipeViewController
	{
		[Outlet]
		UIKit.UIImageView RecipeImageView { get; set; }

		[Outlet]
		UIKit.UILabel RecipeInstructionsLabel { get; set; }

		[Outlet]
		UIKit.UITextView RecipeInstructionsTextView { get; set; }

		[Outlet]
		UIKit.UILabel RecipeReadyMinsLabel { get; set; }

		[Outlet]
		UIKit.UILabel RecipeServingsLabel { get; set; }

		[Outlet]
		UIKit.UILabel RecipeTitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (RecipeImageView != null) {
				RecipeImageView.Dispose ();
				RecipeImageView = null;
			}

			if (RecipeInstructionsLabel != null) {
				RecipeInstructionsLabel.Dispose ();
				RecipeInstructionsLabel = null;
			}

			if (RecipeReadyMinsLabel != null) {
				RecipeReadyMinsLabel.Dispose ();
				RecipeReadyMinsLabel = null;
			}

			if (RecipeTitleLabel != null) {
				RecipeTitleLabel.Dispose ();
				RecipeTitleLabel = null;
			}

			if (RecipeServingsLabel != null) {
				RecipeServingsLabel.Dispose ();
				RecipeServingsLabel = null;
			}

			if (RecipeInstructionsTextView != null) {
				RecipeInstructionsTextView.Dispose ();
				RecipeInstructionsTextView = null;
			}
		}
	}
}
