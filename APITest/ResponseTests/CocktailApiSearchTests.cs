using CocktailAPIResponseTest.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;
using System.Net.Http;

namespace cocktailApiClientResponseTest.ResponseTests
{
    [TestClass]
    public  class cocktailApiClientSearchTests
    {
        private static readonly HttpClient client = new HttpClient();
        private const string APIsearchURL = @"https://www.thecocktaildb.com/api/json/v1/1/search.php?s=";


        [TestMethod]
        public void WhenSearchingByCocktailName_Then_ReponseIsReceived()
        {
            var cocktailName = "margarita";
            var apiConfigService = new CocktailApiConfigurationService();
            var cocktailApiClient = apiConfigService.GetApiClient();
            var response = cocktailApiClient.SearchByName(cocktailName);
            var result = response.Result;
            Assert.IsNotNull(response);
        }

        public void WhenSearchingByCocktailName_Then_ReponseSchemaIsValid()
        {
            var cocktailName = "margarita";
            var apiConfigService = new CocktailApiConfigurationService();
            var cocktailApiClient = apiConfigService.GetApiClient();
            
            var response = cocktailApiClient.SearchByName(cocktailName).Result;
            Assert.IsNotNull(response);
        }
    }
}
