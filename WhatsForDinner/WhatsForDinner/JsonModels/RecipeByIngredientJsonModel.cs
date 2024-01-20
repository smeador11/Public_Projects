
using Realms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WhatsForDinner.JsonModels
{
    public partial class RecipeByIngredientJsonModel //: IRealmObject
    {
        //[PrimaryKey]
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
        public IngredientJsonModel[] MissedIngredients { get; }

        [JsonProperty("usedIngredients")]
        public IngredientJsonModel[] UsedIngredients { get; }

        [JsonProperty("unusedIngredients")]
        public IngredientJsonModel UnusedIngredients { get; }

        [JsonProperty("likes")]
        public string RecipeLikes { get; set; }
    }
}

