using System;
using WhatsForDinner.JsonModels;
using WhatsForDinner.ViewControllers.ViewControllerFactory.Contracts;

namespace WhatsForDinner.ViewControllers.Contracts
{
    public interface IngredientsViewControllerInterface : BaseWhatsForDinnerViewInterface
    {
        Action<string, string> FindRecipesClickCallback { get; set; }
        void SetUpTextViewBorders();
        void FailTextViewFields(bool noIngredients, bool noNumRecipes);
        void MoveToRecipesViewController(RecipeByIngredientJsonModel[] recipes);
    }
}

