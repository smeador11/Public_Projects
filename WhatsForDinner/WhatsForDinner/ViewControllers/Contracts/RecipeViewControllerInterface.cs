using System;
using WhatsForDinner.JsonModels;

namespace WhatsForDinner.ViewControllers.Contracts
{
    public interface RecipeViewControllerInterface : BaseWhatsForDinnerViewInterface
    {
        Action<IngredientJsonModel[], IngredientJsonModel[]> ShoppingListButtonClicked { get; set; }

        void MoveToShoppingListViewController(IngredientJsonModel[] missingIngredients, IngredientJsonModel[] usedIngredients);
        void SetViewData(RecipeJsonModel recipe);
    }
}

