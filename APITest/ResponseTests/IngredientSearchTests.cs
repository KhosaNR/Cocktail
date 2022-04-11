using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;


namespace CocktailAPIResponsetest
{
    [TestClass]
    public class IngredientSearchTests
    {
        private static readonly HttpClient client = new HttpClient();
        private const string APIsearchURL = @"https://www.thecocktaildb.com/api/json/v1/1/search.php?i=";
        
        [TestMethod]
        public void WhenSearchingByIngredient_ValidFieldsAreReturned()
        {

            var response = client.GetAsync($"{APIsearchURL}=vodka");

            string responseBody = response.Result.Content.ReadAsStringAsync().Result;            

            JObject ingredientsRoot = JsonConvert.DeserializeObject<JObject>(responseBody);
            var Ingredients = ingredientsRoot["ingredients"].Children();

            foreach (var ingredient in Ingredients)
            {
                JObject currentIgredient = ingredient.ToObject<JObject>();
                Assert.IsTrue(currentIgredient.Count == 5);

                Assert.IsTrue(currentIgredient.ContainsKey("idIngredient") &&
                currentIgredient.ContainsKey("strIngredient") &&
                currentIgredient.ContainsKey("strDescription") &&
                currentIgredient.ContainsKey("strType") &&
                currentIgredient.ContainsKey("strAlcohol") &&
                currentIgredient.ContainsKey("strABV"));
            }
        }

        [TestMethod]
        public void IfIngredientIsAlcoholic_Then_AlcoholIsYes_And_ABVIsNotNull()
        {
            var response = client.GetAsync($"{APIsearchURL}=vodka");

            string responseBody = response.Result.Content.ReadAsStringAsync().Result;
            JObject ingredientsRoot = JsonConvert.DeserializeObject<JObject>(responseBody);
            var Ingredients = ingredientsRoot["ingredients"].Children();

            foreach (var ingredient in Ingredients)
            {
                Assert.Equals(ingredient["strAlcohol"].ToString(), "yes");
                Assert.IsNotNull(ingredient["strABV"]);
            }
        }


        [TestMethod]
        public void IfIngredientIsNonAlcoholic_Then_AlcoholIsNull_And_ABVIsNul()
        {
            var response = client.GetAsync($"{APIsearchURL}=sugar");

            string responseBody = response.Result.Content.ReadAsStringAsync().Result;
            JObject ingredientsRoot = JsonConvert.DeserializeObject<JObject>(responseBody);
            var Ingredients = ingredientsRoot["ingredients"].Children();

            foreach (var ingredient in Ingredients)
            {
                Assert.Equals(ingredient["strAlcohol"].ToString(), "null");
                Assert.Equals(ingredient["strABV"].ToString(), "null");
            }
        }
    }
}
