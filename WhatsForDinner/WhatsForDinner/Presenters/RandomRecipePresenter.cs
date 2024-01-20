using System;
using WhatsForDinner.Entities;
using WhatsForDinner.Entities.Contracts;
using WhatsForDinner.JsonModels;
using WhatsForDinner.Presenters.Contracts;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters
{
    public class RandomRecipePresenter : RandomRecipePresenterInterface
    {
        RandomRecipeViewControllerInterface View;
        RecipesInterface RecipeEntity = new RecipesEntity();
        RecipeJsonModel RandomRecipe;
        public RandomRecipePresenter()
        {
        }

        public void BindToView(RandomRecipeViewControllerInterface view)
        {
            View = view;
            View.RequestRandomRecipe = async (numberOfRecipes, tags) =>
            {
                //Tags (can be diets, meal types, cuisines, or intolerances) that the recipe must have.
                //numberOfRecipes max == 100
                View.BeginBackgroundTask();
                var recipes = await RecipeEntity.RequestRandomRecipes(numberOfRecipes, tags);
                View.EndBackgroundTask();
                RandomRecipe = recipes.RecipesArray[0];
                View.SetViewData(RandomRecipe);
            };
            View.GetRandomRecipeCallback = () =>
            {
                //Giving blank ingredients array to used ingredients
                //Random recipe will assume they have no ingredients for the Random Recipe
                View.MoveToRecipeScreen(RandomRecipe, RandomRecipe.RecipeExtendedIngredients, new IngredientJsonModel[0]);
            };
        }
    }
}

