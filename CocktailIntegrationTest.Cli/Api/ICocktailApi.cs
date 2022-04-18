using CocktailIntegrationTest.Cli.Api.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailIntegrationTest.Cli.Api
{
    public interface ICocktailApi
    {
        [Get("/search.php?i={cocktailIngredient}")]
        Task<IngredientSearchResponse> SearchByCocktailIgredient(string cocktailIngredient);
    }
}
