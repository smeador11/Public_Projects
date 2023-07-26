using System;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters.Contracts
{
    public interface ShoppingListPresenterInterface
    {
        void BindToView(ShoppingIngredientsViewControllerInterface view);
    }
}

