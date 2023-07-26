using System;
using WhatsForDinner.Presenters.Contracts;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters
{
    public class ShoppingListPresenter : ShoppingListPresenterInterface
    {
        ShoppingIngredientsViewControllerInterface View;

        public ShoppingListPresenter()
        {
        }

        public void BindToView(ShoppingIngredientsViewControllerInterface view)
        {
            View = view;
        }
    }
}

