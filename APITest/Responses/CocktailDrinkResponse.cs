using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailAPIResponseTest.Responses
{
		public class CocktailDrinkResponse
		{
			[JsonProperty("idDrink", Required = Required.Always)]
			public string idDrink { get; init; }

			[JsonProperty("strDrink", Required = Required.Always)]
			public string Drink { get; init; }

			[JsonProperty("strDrinkAlternate", Required = Required.Default)]
			public string DrinkAlternate { get; init; }

			[JsonProperty("strTags", Required = Required.Default)]
			public string Tags { get; init; }

			[JsonProperty("strVideo", Required = Required.Default)]
			public string Video { get; init; }

			[JsonProperty("strCategory", Required = Required.Always)]
			public string Category { get; init; }

			[JsonProperty("strIBA", Required = Required.Default)]
			public string IBA { get; init; }

			[JsonProperty("strAlcoholic", Required = Required.Always)]
			public string Alcoholic { get; init; }

			[JsonProperty("strGlass", Required = Required.Always)]
			public string Glass { get; init; }

			[JsonProperty("strInstructions", Required = Required.Always)]
			public string Instructions { get; init; }

			[JsonProperty("strInstructionsES", Required = Required.Default)]
			public string InstructionsES { get; init; }

			[JsonProperty("strInstructionsDE", Required = Required.Default)]
			public string InstructionsDE { get; init; }

			[JsonProperty("strInstructionsFR", Required = Required.Default)]
			public string InstructionsFR { get; init; }

			[JsonProperty("strInstructionsIT", Required = Required.Default)]
			public string InstructionsIT { get; init; }

			[JsonProperty("strInstructionsZH-HANS", Required = Required.Default)]
			public string InstructionsZH_HANS { get; init; }

			[JsonProperty("strInstructionsZH-HANT", Required = Required.Default)]
			public string InstructionsZH_HANT { get; init; }

			[JsonProperty("strDrinkThumb", Required = Required.Default)]
			public string DrinkThumb { get; init; }

			[JsonProperty("strIngredient1", Required = Required.Always)]
			public string Ingredient1 { get; init; }

			[JsonProperty("strIngredient2", Required = Required.Default)]
			public string Ingredient2 { get; init; }

			[JsonProperty("strIngredient3", Required = Required.Default)]
			public string Ingredient3 { get; init; }

			[JsonProperty("strIngredient4", Required = Required.Default)]
			public string Ingredient4 { get; init; }

			[JsonProperty("strIngredient5", Required = Required.Default)]
			public string Ingredient5 { get; init; }

			[JsonProperty("strIngredient6", Required = Required.Default)]
			public string Ingredient6 { get; init; }

			[JsonProperty("strIngredient7", Required = Required.Default)]
			public string Ingredient7 { get; init; }

			[JsonProperty("strIngredient8", Required = Required.Default)]
			public string Ingredient8 { get; init; }

			[JsonProperty("strIngredient9", Required = Required.Default)]
			public string Ingredient9 { get; init; }

			[JsonProperty("strIngredient10", Required = Required.Default)]
			public string Ingredient10 { get; init; }

			[JsonProperty("strIngredient11", Required = Required.Default)]
			public string Ingredient11 { get; init; }

			[JsonProperty("strIngredient12", Required = Required.Default)]
			public string Ingredient12 { get; init; }

			[JsonProperty("strIngredient13", Required = Required.Default)]
			public string Ingredient13 { get; init; }

			[JsonProperty("strIngredient14", Required = Required.Default)]
			public string Ingredient14 { get; init; }

			[JsonProperty("strIngredient15", Required = Required.Default)]
			public string Ingredient15 { get; init; }

			[JsonProperty("strMeasure1", Required = Required.Always)]
			public string Measure1 { get; init; }

			[JsonProperty("strMeasure2", Required = Required.Default)]
			public string Measure2 { get; init; }

			[JsonProperty("strMeasure3", Required = Required.Default)]
			public string Measure3 { get; init; }

			[JsonProperty("strMeasure4", Required = Required.Default)]
			public string Measure4 { get; init; }

			[JsonProperty("strMeasure5", Required = Required.Default)]
			public string Measure5 { get; init; }

			[JsonProperty("strMeasure6", Required = Required.Default)]
			public string Measure6 { get; init; }

			[JsonProperty("strMeasure7", Required = Required.Default)]
			public string Measure7 { get; init; }

			[JsonProperty("strMeasure8", Required = Required.Default)]
			public string Measure8 { get; init; }

			[JsonProperty("strMeasure9", Required = Required.Default)]
			public string Measure9 { get; init; }

			[JsonProperty("strMeasure10", Required = Required.Default)]
			public string Measure10 { get; init; }

			[JsonProperty("strMeasure11", Required = Required.Default)]
			public string Measure11 { get; init; }

			[JsonProperty("strMeasure12", Required = Required.Default)]
			public string Measure12 { get; init; }

			[JsonProperty("strMeasure13", Required = Required.Default)]
			public string Measure13 { get; init; }

			[JsonProperty("strMeasure14", Required = Required.Default)]
			public string Measure14 { get; init; }

			[JsonProperty("strMeasure15", Required = Required.Default)]
			public string Measure15 { get; init; }

			[JsonProperty("strImageSource", Required = Required.Default)]
			public string ImageSource { get; init; }

			[JsonProperty("strImageAttribution", Required = Required.Default)]
			public string ImageAttribution { get; init; }

			[JsonProperty("strCreativeCommonsConfirmed", Required = Required.Always)]
			public string CreativeCommonsConfirmed { get; init; }

			[JsonProperty("dateModified", Required = Required.Always)]
			public string dateModified { get; init; }


		}
}
