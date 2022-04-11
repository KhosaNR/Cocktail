using CocktailAPIResponseTest.TestData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace CocktailAPIResponseTest
{
    [TestClass]
    public class FilterNonAlcoholic
    {
        private static readonly HttpClient client = new HttpClient();
        private const string APIsearchNonAlcoholicURL = @"https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Non_Alcoholic";

        [TestMethod]

        public void WhenFilteringNonAlcoholic_Then_AllDrinksHaveDrinkIDs()
        {
            var response = client.GetAsync($"{APIsearchNonAlcoholicURL}");

            string responseBody = response.Result.Content.ReadAsStringAsync().Result;
            JObject drinkRoot = JsonConvert.DeserializeObject<JObject>(responseBody);
            var drinks = drinkRoot["drinks"].Children();

            foreach (var drink in drinks)
            {
                Assert.AreNotEqual(drink["idDrink"].ToString(), "null");
            }

        }

    }
}
