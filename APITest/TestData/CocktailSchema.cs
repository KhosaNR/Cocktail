using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailAPIResponseTest.TestData
{
    public class CocktailSchema
    {
        public string cocktailSchemaString
        {

            get
            {
                return @"
                {
                  '$schema': 'http://json-schema.org/draft-04/schema#',
                  'type': 'object',
                  'properties': {
                    'drinks': {
                      'type': 'array',
                      'contains': [
                        {
                          'type': 'object',
                          'properties': {
			                'idDrink': {
                              'type': 'string'
                            },
                            'strDrink': {
                              'type':['string','null']
                            },
                            'strDrinkAlternate': {
                              'type': ['string','null']
                            },
                            'strTags': {
                              'type': ['string','null']
                            },
                            'strVideo': {
                              'type': ['string','null']
                            },
                            'strCategory': {
                              'type': ['string','null']
                            },
                            'strIBA': {
                              'type': ['string','null']
                            },
                            'strAlcoholic': {
                              'type': ['string','null']
                            },
                            'strGlass': {
                              'type': ['string','null']
                            },
                            'strInstructions': {
                              'type': ['string','null']
                            },
                            'strInstructionsES': {
                              'type': ['string','null']
                            },
                            'strInstructionsDE': {
                              'type': ['string','null']
                            },
                            'strInstructionsFR': {
                              'type': ['string','null']
                            },
                            'strInstructionsIT': {
                              'type': ['string','null']
                            },
                            'strInstructionsZH-HANS': {
                              'type': ['string','null']
                            },
                            'strInstructionsZH-HANT': {
                              'type': ['string','null']
                            },
                            'strDrinkThumb': {
                              'type': ['string','null']
                            },
                            'strIngredient1': {
                              'type':['string','null']
                            },
                            'strIngredient2': {
                              'type': ['string','null']
                            },
                            'strIngredient3': {
                              'type': ['string','null']
                            },
                            'strIngredient4': {
                              'type': ['string','null']
                            },
                            'strIngredient5': {
                              'type': ['string','null']
                            },
                            'strIngredient6': {
                              'type': ['string','null']
                            },
                            'strIngredient7': {
                              'type': ['string','null']
                            },
                            'strIngredient8': {
                              'type': ['string','null']
                            },
                            'strIngredient9': {
                              'type': ['string','null']
                            },
                            'strIngredient10': {
                              'type': ['string','null']
                            },
                            'strIngredient11': {
                              'type': ['string','null']
                            },
                            'strIngredient12': {
                              'type': ['string','null']
                            },
                            'strIngredient13': {
                              'type': ['string','null']
                            },
                            'strIngredient14': {
                              'type': ['string','null']
                            },
                            'strIngredient15': {
                              'type': ['string','null']
                            },
                            'strMeasure1': {
                              'type': ['string','null']
                            },
                            'strMeasure2': {
                              'type': ['string','null']
                            },
                            'strMeasure3': {
                              'type': ['string','null']
                            },
                            'strMeasure4': {
                              'type': ['string','null']
                            },
                            'strMeasure5': {
                              'type': ['string','null']
                            },
                            'strMeasure6': {
                              'type': ['string','null']
                            },
                            'strMeasure7': {
                              'type': ['string','null']
                            },
                            'strMeasure8': {
                              'type': ['string','null']
                            },
                            'strMeasure9': {
                              'type': ['string','null']
                            },
                            'strMeasure10': {
                              'type': ['string','null']
                            },
                            'strMeasure11': {
                              'type': ['string','null']
                            },
                            'strMeasure12': {
                              'type': ['string','null']
                            },
                            'strMeasure13': {
                              'type': ['string','null']
                            },
                            'strMeasure14': {
                              'type': ['string','null']
                            },
                            'strMeasure15': {
                              'type': ['string','null']
                            },
                            'strImageSource': {
                              'type': ['string','null']
                            },
                            'strImageAttribution': {
                              'type': ['string','null']
                            },
                            'strCreativeCommonsConfirmed': {
                              'type': ['string','null']
                            },
                            'dateModified': {
                              'type': ['string','null']
                            }
                          },
                          'required': [
                            'idDrink',
                            'strDrink',
                            'strTags',
                            'strCategory',
                            'strAlcoholic',
                            'strGlass',
                            'strInstructions',
                            'strIngredient1',
                            'strMeasure1',
                            'strCreativeCommonsConfirmed',
                            'dateModified'
                          ]
                        }
                      ]
                    }
                  },
                  'required': [
                    'drinks'
                  ]
                }
                            ";
            }
        }

        public JSchema GetSchema()
        {

            JSchema drink = new JSchema
            {
                Type = JSchemaType.Object,
                Properties =
    {
                            {"idDrink", new JSchema { Type = JSchemaType.String}},
                            {"strDrink", new JSchema { Type = JSchemaType.String } },
                            {"strDrinkAlternate", new JSchema { Type = JSchemaType.String}},
                            {"strTags", new JSchema { Type = JSchemaType.String}},
                            {"strVideo", new JSchema { Type = JSchemaType.String}},
                            {"strCategory", new JSchema { Type = JSchemaType.String}},
                            {"strIBA", new JSchema { Type = JSchemaType.String}},
                            {"strAlcoholic", new JSchema { Type = JSchemaType.String}},
                            {"strGlass", new JSchema { Type = JSchemaType.String}},
                            {"strInstructions", new JSchema { Type = JSchemaType.String}},
                            {"strInstructionsES", new JSchema { Type = JSchemaType.String}},
                            {"strInstructionsDE", new JSchema { Type = JSchemaType.String}},
                            {"strInstructionsFR", new JSchema { Type = JSchemaType.String}},
                            {"strInstructionsIT", new JSchema { Type = JSchemaType.String}},
                            {"strInstructionsZH-HANS", new JSchema { Type = JSchemaType.String}},
                            {"strInstructionsZH-HANT", new JSchema { Type = JSchemaType.String}},
                            {"strDrinkThumb", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient1", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient2", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient3", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient4", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient5", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient6", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient7", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient8", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient9", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient10", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient11", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient12", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient13", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient14", new JSchema { Type = JSchemaType.String}},
                            {"strIngredient15", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure1", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure2", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure3", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure4", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure5", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure6", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure7", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure8", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure9", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure10", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure11", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure12", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure13", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure14", new JSchema { Type = JSchemaType.String}},
                            {"strMeasure15", new JSchema { Type = JSchemaType.String}},
                            {"strImageSource", new JSchema { Type = JSchemaType.String}},
                            {"strImageAttribution", new JSchema { Type = JSchemaType.String}},
                            {"strCreativeCommonsConfirmed", new JSchema { Type = JSchemaType.String}},
                            {"dateModified", new JSchema { Type = JSchemaType.String}},

    },
                Required = {
                            "idDrink",
                            "strDrink",
                            "strTags",
                            "strCategory",
                            "strAlcoholic",
                            "strGlass",
                            "strInstructions",
                            "strIngredient1",
                            "strMeasure1",
                            "strCreativeCommonsConfirmed",
                            "dateModified"}
            };

            JSchema cocktailSchema = new JSchema
            {
                Type = JSchemaType.Object,
                Properties =
                {
                    {
                        "drinks", new JSchema
                        {
                            Type = JSchemaType.Array,
                            Items = {
                                new JSchema{Type = JSchemaType.Object,
                                Properties =
                                    {
                                        {"idDrink", new JSchema { Type = JSchemaType.String}},
                                        {"strDrink", new JSchema { Type = JSchemaType.String } },
                                        {"strDrinkAlternate", new JSchema { Type = JSchemaType.String}},
                                        {"strTags", new JSchema { Type = JSchemaType.String}},
                                        {"strVideo", new JSchema { Type = JSchemaType.String}},
                                        {"strCategory", new JSchema { Type = JSchemaType.String}},
                                        {"strIBA", new JSchema { Type = JSchemaType.String}},
                                        {"strAlcoholic", new JSchema { Type = JSchemaType.String}},
                                        {"strGlass", new JSchema { Type = JSchemaType.String}},
                                        {"strInstructions", new JSchema { Type = JSchemaType.String}},
                                        {"strInstructionsES", new JSchema { Type = JSchemaType.String}},
                                        {"strInstructionsDE", new JSchema { Type = JSchemaType.String}},
                                        {"strInstructionsFR", new JSchema { Type = JSchemaType.String}},
                                        {"strInstructionsIT", new JSchema { Type = JSchemaType.String}},
                                        {"strInstructionsZH-HANS", new JSchema { Type = JSchemaType.String}},
                                        {"strInstructionsZH-HANT", new JSchema { Type = JSchemaType.String}},
                                        {"strDrinkThumb", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient1", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient2", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient3", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient4", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient5", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient6", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient7", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient8", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient9", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient10", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient11", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient12", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient13", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient14", new JSchema { Type = JSchemaType.String}},
                                        {"strIngredient15", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure1", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure2", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure3", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure4", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure5", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure6", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure7", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure8", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure9", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure10", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure11", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure12", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure13", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure14", new JSchema { Type = JSchemaType.String}},
                                        {"strMeasure15", new JSchema { Type = JSchemaType.String}},
                                        {"strImageSource", new JSchema { Type = JSchemaType.String}},
                                        {"strImageAttribution", new JSchema { Type = JSchemaType.String}},
                                        {"strCreativeCommonsConfirmed", new JSchema { Type = JSchemaType.String}},
                                        {"dateModified", new JSchema { Type = JSchemaType.String}},
                                    }
                                }
                             }
                        }
                    }
                },
                Required = {"drink"}

            };

            return cocktailSchema;

        }
    }
}
