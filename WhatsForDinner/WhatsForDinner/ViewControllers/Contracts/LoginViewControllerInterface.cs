using System;
namespace WhatsForDinner.ViewControllers.Contracts
{
    public interface LoginViewControllerInterface : BaseWhatsForDinnerViewInterface
    {
        Action<string, string> LoginButtonClicked { get; set; }

        void MoveToHomeScreen();
    }
}

