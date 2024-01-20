using System;
using WhatsForDinner.JsonModels;

namespace WhatsForDinner.ViewControllers.Contracts
{
    public interface RandomRecipeViewControllerInterface : BaseWhatsForDinnerViewInterface
    {
        Action<string, string> RequestRandomRecipe { get; set; }
        Action GetRandomRecipeCallback { get; set; }
        void SetViewData(RecipeJsonModel recipe);
        void MoveToRecipeScreen(RecipeJsonModel recipe, IngredientJsonModel[] missingIngredients, IngredientJsonModel[] usedIngredients);
    }
}

