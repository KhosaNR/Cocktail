// See https://aka.ms/new-console-template for more information

using CocktailIntegrationTest.Cli.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System.Text.Json;

Console.WriteLine("Hello, World!");

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var services = new ServiceCollection();
services.AddRefitClient<ICocktailApi>()
    .ConfigureHttpClient(httpClient =>
    {
        httpClient.BaseAddress = new Uri(configuration["CocktailApi:BaseAddress"]);
    });

var serviceProvider = services.BuildServiceProvider();
var client = serviceProvider.GetRequiredService<ICocktailApi>();
var response = await client.SearchByCocktailIgredient("sugar");
var responseText = JsonSerializer.Serialize(response, new JsonSerializerOptions
{ WriteIndented = true });
Console.WriteLine(responseText);