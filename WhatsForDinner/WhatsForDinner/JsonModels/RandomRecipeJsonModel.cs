using System;
using Newtonsoft.Json;

namespace WhatsForDinner.JsonModels
{
    public class RandomRecipeJsonModel
    {
        //Not using realm
        //This is will unpack into child models that are stored
        [JsonProperty("recipes")]
        public RecipeJsonModel[] RecipesArray { get; set; }
    }
}

