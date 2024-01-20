using System;
using UIKit;
using WhatsForDinner.JsonModels;

namespace WhatsForDinner.ViewControllers.ViewControllerFactory.Contracts
{
    public interface ViewControllerFactoryInterface
    {
        UITabBarController GetHomeTabController(UIStoryboard storyboard);
        BaseWhatsForDinnerViewController GetLoginViewController(UIStoryboard storyboard);
        BaseWhatsForDinnerViewController GetIngredientsViewController(UIStoryboard storyboard);
        BaseWhatsForDinnerViewController GetRecipeViewController(UIStoryboard storyboard, RecipeJsonModel recipe, IngredientJsonModel[] missingIngredient, IngredientJsonModel[] usedIngredients);
    }
}

