using System;
using UIKit;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.ViewControllers
{
    public class BaseWhatsForDinnerViewController : UIViewController, BaseWhatsForDinnerViewInterface
    {
        public ViewControllerFactory.ViewControllerFactory ControllerFactory = new ViewControllerFactory.ViewControllerFactory();

        public BaseWhatsForDinnerViewController(IntPtr handle) : base(handle)
        {
        }

        public void ShowAlert(string alertTitle, string alertMessage, string buttonTitle, Action completionAction)
        {
            var alertController = UIAlertController.Create(alertTitle, alertMessage, UIAlertControllerStyle.Alert);
            alertController.AddAction(UIAlertAction.Create(buttonTitle, UIAlertActionStyle.Default, null));
            PresentViewController(alertController, true, completionAction);
        }
        public virtual void BeginBackgroundTask()
        {
            UIApplication.SharedApplication.KeyWindow.UserInteractionEnabled = false;
        }
        public virtual void EndBackgroundTask()
        {
            UIApplication.SharedApplication.KeyWindow.UserInteractionEnabled = true;
        }
    }
}

