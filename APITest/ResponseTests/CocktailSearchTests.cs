using CocktailAPIResponseTest.TestData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;
using System.Net.Http;

namespace CocktailAPIResponseTest
{
    [TestClass]
    public  class CocktailSearchTests
    {
        private static readonly HttpClient client = new HttpClient();
        private const string APIsearchURL = @"https://www.thecocktaildb.com/api/json/v1/1/search.php?s=";


        [TestMethod]
        public void WhenSearchingByCocktail_And_One_CocktailIsFound_SchemaReturnedIsValid()
        {
            var cocktailSchema = JSchema.Parse(new CocktailSchema().cocktailSchemaString);
            var response = client.GetAsync($"{APIsearchURL}Lemouroudji");


            var responseBody = response.Result.Content.ReadAsStringAsync().Result;

            JObject cocktail = JObject.Parse(responseBody);
            if (cocktail.Count != 1)
            {
                Assert.Fail("Cocktail search did not return only one cocktail");
            }
            Assert.IsTrue(cocktail.IsValid(cocktailSchema));
        }

        [TestMethod]
        public void WhenSearchingByCocktail_And_Multiple_CocktailAreFound_SchemaReturnedIsValid()
        {
            var cocktailSchema = JSchema.Parse(new CocktailSchema().cocktailSchemaString);
            var response = client.GetAsync($"{APIsearchURL}Margarita");


            var responseBody = response.Result.Content.ReadAsStringAsync().Result;

            JObject cocktails = JObject.Parse(responseBody);
            foreach(var cocktailSearchResult in cocktails["drinks"].Children())
            {
                Assert.IsTrue(cocktailSearchResult.IsValid(cocktailSchema));
            }
            
        }

        [TestMethod]
        public void WhenSearchingByCocktail_AndCocktailIsNotFound()
        {

            var response = client.GetAsync($"{APIsearchURL}UnknownDrink");

            string responseBody = response.Result.Content.ReadAsStringAsync().Result;

            JObject cocktailsRoot = JsonConvert.DeserializeObject<JObject>(responseBody);
            Assert.IsTrue(!cocktailsRoot["drinks"].HasValues);

        }

    }
}
