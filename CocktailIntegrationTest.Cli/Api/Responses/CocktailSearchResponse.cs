using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CocktailIntegrationTest.Cli.Api.Responses
{
    public record IngredientSearchResponse
    {
        [JsonPropertyName("ingredients")]
        public IReadOnlyList<CocktailIngredientResponse> Ingredients { get; set; }    
    }
}
