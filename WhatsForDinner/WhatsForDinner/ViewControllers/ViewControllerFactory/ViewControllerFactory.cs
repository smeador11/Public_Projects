using System;
using System.Diagnostics;
using UIKit;
using WhatsForDinner.JsonModels;
using WhatsForDinner.ViewControllers.ViewControllerFactory.Contracts;

namespace WhatsForDinner.ViewControllers.ViewControllerFactory
{
    public class ViewControllerFactory : ViewControllerFactoryInterface
    {
        private BaseWhatsForDinnerViewController BuildController(UIStoryboard storyboard, string identifier)
        {
            if (storyboard.InstantiateViewController(identifier) is BaseWhatsForDinnerViewController controller)
            {
                return controller;
            }
            else
            {
                throw (new InvalidOperationException(string.Format("Unable to instantiate view controller from storyboard in {0}", new StackFrame(1).GetMethod().Name)));
            }
        }
        public UITabBarController GetHomeTabController(UIStoryboard storyboard)
        {
            if (storyboard.InstantiateViewController("HomeTabBarController") is UITabBarController controller)
            {
                return controller;
            }
            else
            {
                throw (new InvalidOperationException(string.Format("Unable to instantiate view controller from storyboard in {0}", new StackFrame(1).GetMethod().Name)));
            }
        }
        public BaseWhatsForDinnerViewController GetLoginViewController(UIStoryboard storyboard)
        {
            return BuildController(storyboard, "LoginViewController") as LoginViewController;
        }
        public BaseWhatsForDinnerViewController GetIngredientsViewController(UIStoryboard storyboard)
        {
            return BuildController(storyboard, "IngredientsViewController") as IngredientsViewController;
        }
        public BaseWhatsForDinnerViewController GetRecipesViewController(UIStoryboard storyboard, RecipeByIngredientJsonModel[] recipes)
        {
            var controller = BuildController(storyboard, "RecipesViewController") as RecipesViewController;
            controller.Recipes = recipes;
            return controller;
        }
        public BaseWhatsForDinnerViewController GetRecipeViewController(UIStoryboard storyboard, RecipeJsonModel recipe, IngredientJsonModel[] missingIngredient, IngredientJsonModel[] usedIngredients)
        {
            var controller = BuildController(storyboard, "RecipeViewController") as RecipeViewController;
            controller.Recipe = recipe;
            controller.MissingIngredients = missingIngredient;
            controller.UsedIngredients = usedIngredients;
            return controller;
        }
        public BaseWhatsForDinnerViewController GetShoppingListViewController(UIStoryboard storyboard, IngredientJsonModel[] missingIngredients, IngredientJsonModel[] usedIngredients)
        {
            var controller = BuildController(storyboard, "ShoppingListViewController") as ShoppingListViewController;
            controller.MissingIngredients = missingIngredients;
            controller.UsedIngredients = usedIngredients;
            return controller;
        }
    }
}

