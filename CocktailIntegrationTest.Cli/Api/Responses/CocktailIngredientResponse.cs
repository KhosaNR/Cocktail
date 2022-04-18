using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CocktailIntegrationTest.Cli.Api.Responses
{
    public class CocktailIngredientResponse
    {
        [JsonPropertyName("idIngredient")]
        public string IngredientID { get; init; }

        [JsonPropertyName("strIngredient")]
        public string Ingredient { get; init; }

        [JsonPropertyName("strDescription")]
        public string Description { get; init; }

        [JsonPropertyName("strType")]
        public string Type { get; init; }

        [JsonPropertyName("strAlcohol")]
        public string Alcohol { get; init; }

        [JsonPropertyName("strABV")]
        public string ABV { get; init; }
    }
}
