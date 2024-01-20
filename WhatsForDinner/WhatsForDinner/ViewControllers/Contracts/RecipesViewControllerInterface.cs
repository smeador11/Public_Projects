using System;
using WhatsForDinner.JsonModels;
using static WhatsForDinner.Constants.SortConstants;

namespace WhatsForDinner.ViewControllers.Contracts
{
    public interface RecipesViewControllerInterface : BaseWhatsForDinnerViewInterface
    {
        Action<int> RecipeSelected { get; set; }
        Action SortButtonClicked { get; set; }
        Action<RecipeByIngredientSort> SortChoiceClicked { get; set; }
        void MoveToRecipeViewController(RecipeJsonModel recipe, IngredientJsonModel[] missingIngredients, IngredientJsonModel[] usedIngredients);
        void ShowSortMenu();
    }
}

