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
	[Register ("RandomRecipeViewController")]
	partial class RandomRecipeViewController
	{
		[Outlet]
		UIKit.UIActivityIndicatorView ActivityIndicatorView { get; set; }

		[Outlet]
		UIKit.UILabel CookTimeLabel { get; set; }

		[Outlet]
		UIKit.UIImageView DinnerPlaceholderImageView { get; set; }

		[Outlet]
		UIKit.UIButton GetRecipeButton { get; set; }

		[Outlet]
		UIKit.UILabel LikesLabel { get; set; }

		[Outlet]
		UIKit.UILabel PrepTimeLabel { get; set; }

		[Outlet]
		UIKit.UILabel RecipeTitleLabel { get; set; }

		[Outlet]
		UIKit.UIBarButtonItem RequestNewRecipeButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CookTimeLabel != null) {
				CookTimeLabel.Dispose ();
				CookTimeLabel = null;
			}

			if (DinnerPlaceholderImageView != null) {
				DinnerPlaceholderImageView.Dispose ();
				DinnerPlaceholderImageView = null;
			}

			if (GetRecipeButton != null) {
				GetRecipeButton.Dispose ();
				GetRecipeButton = null;
			}

			if (LikesLabel != null) {
				LikesLabel.Dispose ();
				LikesLabel = null;
			}

			if (PrepTimeLabel != null) {
				PrepTimeLabel.Dispose ();
				PrepTimeLabel = null;
			}

			if (RecipeTitleLabel != null) {
				RecipeTitleLabel.Dispose ();
				RecipeTitleLabel = null;
			}

			if (RequestNewRecipeButton != null) {
				RequestNewRecipeButton.Dispose ();
				RequestNewRecipeButton = null;
			}

			if (ActivityIndicatorView != null) {
				ActivityIndicatorView.Dispose ();
				ActivityIndicatorView = null;
			}
		}
	}
}
