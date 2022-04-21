using CocktailAPIResponseTest.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailAPIResponseTest.Api
{
    public interface ICocktailApi
    {
        [Get("/search.php?i={drinkName}")]
        Task<CocktailSearchResponse> SearchByName(string drinkName);
    }
}
