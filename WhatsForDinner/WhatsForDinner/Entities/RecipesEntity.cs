using System;
using System.Threading.Tasks;
using WhatsForDinner.Entities.Contracts;
using System.Net.Http;
using System.Text.Json;
using Foundation;
using Newtonsoft.Json;
using WhatsForDinner.JsonModels;
using SQLitePCL;
using WhatsForDinner.Constants;

namespace WhatsForDinner.Entities
{
    public class RecipesEntity : RecipesInterface
    {
        HttpClient Client;
        const string BASE_ADDRESS = "https://api.spoonacular.com/";


        public RecipesEntity()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(BASE_ADDRESS);
        }

        public async Task<RecipeByIngredientJsonModel[]> RequestRecipesByIngredients(string ingredients, string numberOfRecipes)
        {
            ingredients = ingredients.Replace(" ", "");
            try
            {
                HttpResponseMessage reponse = await Client.GetAsync(string.Format("recipes/findByIngredients?apiKey={0}&ingredients={1}&number={2}", ApiKeyConstant.API_KEY, ingredients, numberOfRecipes));
                string responseBody = await reponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RecipeByIngredientJsonModel[]>(responseBody);
                
            }
            catch
            {
                throw;
            }
        }

        public async Task<RecipeJsonModel> RequestRecipeById(int id, bool includeNutrition)
        {
            string recipeId = id.ToString();

            try
            {
                HttpResponseMessage reponse = await Client.GetAsync(string.Format("recipes/{0}/information?apiKey={1}&includeNutrition={2}", recipeId, ApiKeyConstant.API_KEY, includeNutrition));
                string responseBody = await reponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RecipeJsonModel>(responseBody);
            }
            catch
            {
                throw;
            }
        }
    }
}

