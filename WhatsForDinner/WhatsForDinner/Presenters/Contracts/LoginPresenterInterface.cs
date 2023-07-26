using System;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters.Contracts
{
    public interface LoginPresenterInterface
    {
        void BindToView(LoginViewControllerInterface view);
    }
}

