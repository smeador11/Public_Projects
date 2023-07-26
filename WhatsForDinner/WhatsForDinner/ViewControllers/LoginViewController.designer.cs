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
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UIButton LogInButton { get; set; }

		[Outlet]
		UIKit.UITextField PasswordTextField { get; set; }

		[Outlet]
		UIKit.UIButton RegisterButton { get; set; }

		[Outlet]
		UIKit.UITextField UsernameTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (UsernameTextField != null) {
				UsernameTextField.Dispose ();
				UsernameTextField = null;
			}

			if (PasswordTextField != null) {
				PasswordTextField.Dispose ();
				PasswordTextField = null;
			}

			if (LogInButton != null) {
				LogInButton.Dispose ();
				LogInButton = null;
			}

			if (RegisterButton != null) {
				RegisterButton.Dispose ();
				RegisterButton = null;
			}
		}
	}
}
