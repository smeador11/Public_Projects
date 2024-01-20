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
	[Register ("IngredientsViewController")]
	partial class IngredientsViewController
	{
		[Outlet]
		UIKit.UIButton FindRecipesButton { get; set; }

		[Outlet]
		UIKit.UITextView IngredientsTextView { get; set; }

		[Outlet]
		UIKit.UIButton NumRecipesPopUpButton { get; set; }

		[Outlet]
		UIKit.UITextField NumRecipesTextView { get; set; }

		[Outlet]
		UIKit.UIActivityIndicatorView RecipeRequestActivityIndicator { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FindRecipesButton != null) {
				FindRecipesButton.Dispose ();
				FindRecipesButton = null;
			}

			if (IngredientsTextView != null) {
				IngredientsTextView.Dispose ();
				IngredientsTextView = null;
			}

			if (NumRecipesPopUpButton != null) {
				NumRecipesPopUpButton.Dispose ();
				NumRecipesPopUpButton = null;
			}

			if (NumRecipesTextView != null) {
				NumRecipesTextView.Dispose ();
				NumRecipesTextView = null;
			}

			if (RecipeRequestActivityIndicator != null) {
				RecipeRequestActivityIndicator.Dispose ();
				RecipeRequestActivityIndicator = null;
			}
		}
	}
}
