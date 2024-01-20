
using System.Collections.Generic;
using Newtonsoft.Json;
using Realms;

namespace WhatsForDinner.JsonModels
{
    public partial class RecipeJsonModel //: IRealmObject
    {
        //[PrimaryKey]
        [JsonProperty("id")]
        public string RecipeId { get; set; }

        [JsonProperty("title")]
        public string RecipeTitle { get; set; }

        [JsonProperty("image")]
        public string RecipeImage { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("sourceName")]
        public string RecipeSourceName { get; set; }

        [JsonProperty("sourceUrl")]
        public string RecipeSourceUrl { get; set; }

        [JsonProperty("spoonacularSourceUrl")]
        public string RecipeApiSourceUrl { get; set; }

        [JsonProperty("healthScore")]
        public int RecipeHealthScore { get; set; }

        [JsonProperty("spoonacularScore")]
        public int RecipeApiScore { get; set; }

        [JsonProperty("cheap")]
        public bool RecipeCheap { get; set; }

        [JsonProperty("creditsText")]
        public string RecipeCreditsText { get; set; }

        //[JsonProperty("cuisines")]
        //public string[] RecipeCuisines { get; set; }

        //[JsonProperty("analyzedInstructions")]
        //public string[] RecipeAnalyzedInstructions { get; set; }

        [JsonProperty("dairyFree")]
        public bool RecipeDairyFree { get; set; }

        //[JsonProperty("diets")]
        //public string[] RecipeDiets { get; set; }

        [JsonProperty("gaps")]
        public string RecipeGaps { get; set; }

        [JsonProperty("glutenFree")]
        public bool RecipeGlutenFree { get; set; }

        [JsonProperty("instructions")]
        public string RecipeInstructions { get; set; }

        [JsonProperty("ketogenic")]
        public bool RecipeKetogenic { get; set; }

        [JsonProperty("lowFodmap")]
        public bool RecipeLowFodmap { get; set; }

        //[JsonProperty("occasions")]
        //public string[] RecipeOccasions { get; set; }

        [JsonProperty("sustainable")]
        public bool RecipeSustainable { get; set; }

        [JsonProperty("vegan")]
        public bool RecipeVegan { get; set; }

        [JsonProperty("vegetarian")]
        public bool RecipeVegetarian { get; set; }

        [JsonProperty("veryHealthy")]
        public bool RecipeVeryHealthy { get; set; }

        [JsonProperty("veryPopular")]
        public bool RecipeVeryPopular { get; set; }

        [JsonProperty("whole30")]
        public bool RecipeWhole30 { get; set; }

        [JsonProperty("weightWatcherSmartPoints")]
        public int RecipewWWSmartPoints { get; set; }

        [JsonProperty("dishTypes")]
        public string[] RecipeDishTypes { get; }

        [JsonProperty("extendedIngredients")]
        public IngredientJsonModel[] RecipeExtendedIngredients { get; }

        [JsonProperty("summary")]
        public string RecipeSummary { get; set; }

        //[JsonProperty("winePairing")] //Multiple nested arrays
        //public string[] RecipeWinePairing { get; set; }

        [JsonProperty("readyInMinutes")]
        public int RecipeReadyInMinutes { get; set; }

        [JsonProperty("servings")]
        public int RecipeServings { get; set; }
    }
}

