using System;
using System.Threading.Tasks;
using WhatsForDinner.JsonModels;

namespace WhatsForDinner.Entities.Contracts
{
    public interface RecipesInterface
    {
        Task<RecipeByIngredientJsonModel[]> RequestRecipesByIngredients(string ingredients, string numberOfRecipes);
        Task<RecipeJsonModel> RequestRecipeById(int id, bool includeNutrition);
        Task<RandomRecipeJsonModel> RequestRandomRecipes(string numberOfRecipes, string tags);
    }
}

