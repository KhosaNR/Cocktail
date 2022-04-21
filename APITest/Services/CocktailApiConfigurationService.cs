using CocktailAPIResponseTest.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailAPIResponseTest.Services
{
    public class CocktailApiConfigurationService
    {
        public IConfigurationRoot configuration { get; set; }
        public IServiceCollection services { get; set; }

        public CocktailApiConfigurationService()
        {

            configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            services = new ServiceCollection();
        }
        public IServiceCollection AddHttpClientToService()
        {
            services.AddRefitClient<ICocktailApi>()
                .ConfigureHttpClient(HttpClient =>
                    { HttpClient.BaseAddress = new Uri(configuration["cocktailsearch:baseurl"]); }
            );

            return services;

        }

        public ICocktailApi GetApiClient()
        {
            if(services.Count == 0)
            {
                AddHttpClientToService();
            }
            var serviceBuilder = services.BuildServiceProvider();
            var client = serviceBuilder.GetRequiredService<ICocktailApi>();
            return client;
        }

        public IServiceCollection GetServices()
        {
            return services;
        }
    }
}
