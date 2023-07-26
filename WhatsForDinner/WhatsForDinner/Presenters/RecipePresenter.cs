using System;
using WhatsForDinner.JsonModels;
using WhatsForDinner.Presenters.Contracts;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters
{
    public class RecipePresenter : RecipePresenterInterface
    {
        RecipeViewControllerInterface View;
        RecipeJsonModel Recipe;

        public RecipePresenter()
        {
        }

        public void BindToView(RecipeViewControllerInterface view, RecipeJsonModel recipe)
        {
            View = view;
            Recipe = recipe;
            View.ShoppingListButtonClicked = View.MoveToShoppingListViewController;
            View.SetViewData(recipe);
        }
    }
}

