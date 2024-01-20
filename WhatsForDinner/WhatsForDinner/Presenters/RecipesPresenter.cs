using System;
using System.Linq;
using WhatsForDinner.Entities;
using WhatsForDinner.JsonModels;
using WhatsForDinner.Presenters.Contracts;
using WhatsForDinner.ViewControllers.Contracts;
using static WhatsForDinner.Constants.SortConstants;

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
                var thing = recipes.Where(recipe => recipe.RecipeId == recipeId).FirstOrDefault();

                View.MoveToRecipeViewController(chosenRecipe, thing.MissedIngredients, thing.UsedIngredients);
            };

            View.SortButtonClicked = View.ShowSortMenu;

            View.SortChoiceClicked = delegate (RecipeByIngredientSort chosenSort)
            {

            };
        }
    }
}

