using System;
using System.Threading.Tasks;
using WhatsForDinner.Entities.Contracts;
using System.Net.Http;
using Newtonsoft.Json;
using WhatsForDinner.JsonModels;
using WhatsForDinner.Constants;
using Realms;

namespace WhatsForDinner.Entities
{
    public class RecipesEntity : RecipesInterface
    {
        HttpClient Client;
        const string BASE_ADDRESS = "https://api.spoonacular.com/";
        Realm RealmDb;//Default path is default.realm

        public RecipesEntity()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(BASE_ADDRESS);
            try
            {
                RealmDb = Realm.GetInstance();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error creating local Realm. {0}", ex.Message));
            }
            
        }

        public async Task<RecipeByIngredientJsonModel[]> RequestRecipesByIngredients(string ingredients, string numberOfRecipes)
        {
            ingredients = ingredients.Replace(" ", "");
            try
            {
                HttpResponseMessage reponse = await Client.GetAsync(string.Format("recipes/findByIngredients?apiKey={0}&ingredients={1}&number={2}", ApiKeyConstant.API_KEY, ingredients, numberOfRecipes));
                string responseBody = await reponse.Content.ReadAsStringAsync();
                if (!responseBody.Contains("failure"))
                {
                    return JsonConvert.DeserializeObject<RecipeByIngredientJsonModel[]>(responseBody);
                }
                else
                {
                    throw new HttpRequestException("Http Request Failure");
                }
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

        public async Task<RandomRecipeJsonModel> RequestRandomRecipes(string numberOfRecipes, string tags)
        {
            try
            {
                HttpResponseMessage reponse = await Client.GetAsync(string.Format("recipes/random?number={0}&tags={1}&apiKey={2}", numberOfRecipes, tags, ApiKeyConstant.API_KEY));
                string responseBody = await reponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RandomRecipeJsonModel>(responseBody);
            }
            catch
            {
                throw;
            }
        }
        
    }
}

