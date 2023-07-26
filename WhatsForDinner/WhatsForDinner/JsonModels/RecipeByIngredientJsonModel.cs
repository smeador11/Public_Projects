using System;
using Newtonsoft.Json;

namespace WhatsForDinner.JsonModels
{
    public class RecipeByIngredientJsonModel
    {
        [JsonProperty("id")]
        public int RecipeId { get; set; }

        [JsonProperty("title")]
        public string RecipeTitle { get; set; }

        [JsonProperty("image")]
        public string RecipeImage { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("usedIngredientCount")]
        public int UsedIngredientCount { get; set; }

        [JsonProperty("missedIngredientCount")]
        public string MissedIngredientCount { get; set; }

        [JsonProperty("missedIngredients")]
        public IngredientJsonModel[] MissedIngredients { get; set; }

        [JsonProperty("usedIngredients")]
        public IngredientJsonModel[] UsedIngredients { get; set; }

        [JsonProperty("unusedIngredients")]
        public IngredientJsonModel[] UnusedIngredients { get; set; }

        [JsonProperty("likes")]
        public string RecipeLikes { get; set; }
    }
}

