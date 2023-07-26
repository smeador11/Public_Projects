using System;
using WhatsForDinner.JsonModels;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters.Contracts
{
    public interface RecipesPresenterInterface
    {
        void BindToView(RecipesViewControllerInterface view, RecipeByIngredientJsonModel[] recipes);
    }
}

