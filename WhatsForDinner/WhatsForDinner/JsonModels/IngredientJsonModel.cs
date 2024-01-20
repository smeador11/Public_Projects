
using System.Collections.Generic;
using Newtonsoft.Json;
using Realms;

namespace WhatsForDinner.JsonModels
{
    public partial class IngredientJsonModel //: IRealmObject
    {
        //[PrimaryKey]
        [JsonProperty("id")]
        public int RecipeId { get; set; }

        [JsonProperty("amount")]
        public double IngredientAmount { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("unitLong")]
        public string UnitLong { get; set; }

        [JsonProperty("unitShort")]
        public string UnitShort { get; set; }

        [JsonProperty("aisle")]
        public string GroceryAisle { get; set; }

        [JsonProperty("name")]
        public string IngredientName { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("originalName")]
        public string IngredientOriginalName { get; set; }

        [JsonProperty("meta")]
        public string[] MetaData { get; }

        [JsonProperty("image")]
        public string IngredientImage { get; set; }
    }
}

