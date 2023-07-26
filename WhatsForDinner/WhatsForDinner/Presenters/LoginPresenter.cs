using System;
using WhatsForDinner.Presenters.Contracts;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters
{
    public class LoginPresenter : LoginPresenterInterface
    {
        LoginViewControllerInterface View;

        public LoginPresenter()
        {
        }

        public void BindToView(LoginViewControllerInterface view)
        {
            View = view;
            View.LoginButtonClicked = (username, password) =>
            {
                if(string.IsNullOrEmpty(username) | string.IsNullOrEmpty(password))
                {
                    View.ShowAlert("Alert", "You must fill in Username and Password fields.", "OK", null);
                    return;
                }
                View.MoveToHomeScreen();
            };
        }
    }
}

