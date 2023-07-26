using System;
using System.Text;
using System.Threading.Tasks;
using WhatsForDinner.Entities;
using WhatsForDinner.Entities.Contracts;
using WhatsForDinner.JsonModels;
using WhatsForDinner.Presenters.Contracts;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters
{
    public class IngredientsPresenter : IngredientsPresenterInterface
    {
        IngredientsViewControllerInterface View;
        RecipesInterface RecipesInterface = new RecipesEntity();

        public IngredientsPresenter()
        {
        }

        public void BindToView(IngredientsViewControllerInterface view)
        {
            View = view;

            View.FindRecipesClickCallback = async (string ingredients, string numOfRecipes) =>
            {
                if(!string.IsNullOrEmpty(ingredients) && !string.IsNullOrEmpty(numOfRecipes))
                {
                    try
                    {
                        View.SetUpTextViewBorders();
                        View.BeginBackgroundTask();
                        var recipes = await RecipesInterface.RequestRecipesByIngredients(ingredients, numOfRecipes);
                        if(recipes.Length > 0)
                        {
                            View.MoveToRecipesViewController(recipes);
                            View.EndBackgroundTask();
                        }
                        else
                        {
                            View.EndBackgroundTask();
                            View.ShowAlert("ALERT", "No recipes found for given ingredients", "OK", null);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        View.EndBackgroundTask();
                        View.ShowAlert("ERROR", ex.Message, "OK", null);
                    }
                }
                else
                {
                    View.ShowAlert("ALERT", "Please fill in all fields!", "OK", () =>
                    {
                        View.FailTextViewFields(string.IsNullOrEmpty(ingredients), string.IsNullOrEmpty(numOfRecipes));
                    });
                }
                
            };
        }
    }
}

