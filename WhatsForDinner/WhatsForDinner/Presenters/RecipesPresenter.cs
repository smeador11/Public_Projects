using System;
using System.Linq;
using WhatsForDinner.Entities;
using WhatsForDinner.JsonModels;
using WhatsForDinner.Presenters.Contracts;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters
{
    public class RecipesPresenter : RecipesPresenterInterface
    {
        RecipesViewControllerInterface View;
        RecipesEntity RecipesEntity = new RecipesEntity();
        public RecipesPresenter()
        {
        }

        public void BindToView(RecipesViewControllerInterface view, RecipeByIngredientJsonModel[] recipes)
        {
            View = view;

            View.RecipeSelected = async (int recipeId) =>
            {
                var chosenRecipe = await RecipesEntity.RequestRecipeById(recipeId, false);
                View.MoveToRecipeViewController(chosenRecipe, recipes.Where(recipe => recipe.RecipeId == recipeId).FirstOrDefault());
            };
        }
    }
}

