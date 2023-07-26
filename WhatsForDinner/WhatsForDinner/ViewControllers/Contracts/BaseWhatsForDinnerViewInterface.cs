using System;
namespace WhatsForDinner.ViewControllers.Contracts
{
    public interface BaseWhatsForDinnerViewInterface
    {
        void ShowAlert(string title, string message, string buttonTitle, Action completionAction);
        void BeginBackgroundTask();
        void EndBackgroundTask();
    }
}

