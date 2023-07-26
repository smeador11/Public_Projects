using System;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters.Contracts
{
    public interface IngredientsPresenterInterface
    {
        void BindToView(IngredientsViewControllerInterface view);
    }
}

