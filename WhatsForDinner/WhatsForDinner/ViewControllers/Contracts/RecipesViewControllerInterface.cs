using System;
using WhatsForDinner.JsonModels;

namespace WhatsForDinner.ViewControllers.Contracts
{
    public interface RecipesViewControllerInterface : BaseWhatsForDinnerViewInterface
    {
        Action<int> RecipeSelected { get; set; }
        void MoveToRecipeViewController(RecipeJsonModel recipe, RecipeByIngredientJsonModel recipeByIngredient);
    }
}

