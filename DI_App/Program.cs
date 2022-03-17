using DI_App.Interfaces;
using DI_App.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_App
{
    class Program
    {
        static void Main(string[] args)
        {
            PostmanHandler postman;

            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            var scopeFactory = serviceProvider.GetService<IServiceScopeFactory>();

            postman = serviceProvider.GetService<PostmanHandler>();

            postman.PickUpLetter();
            postman = serviceProvider.GetService<PostmanHandler>();
            postman.DeliverLetter();
            postman = serviceProvider.GetService<PostmanHandler>();
            postman.GetSignature();
            postman = serviceProvider.GetService<PostmanHandler>();
            postman.HandOverLetter();

            Console.WriteLine("-----------------Scope changed!---------------------");

            using (var scope = scopeFactory.CreateScope())
            {
                postman = scope.ServiceProvider.GetService<PostmanHandler>();

                postman.PickUpLetter();
                postman = serviceProvider.GetService<PostmanHandler>();
                postman.DeliverLetter();
                postman = serviceProvider.GetService<PostmanHandler>();
                postman.GetSignature();
                postman = serviceProvider.GetService<PostmanHandler>();
                postman.HandOverLetter();
            }

            Console.ReadKey();
        }
        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<ITransientPostmanService, PostmanService>();
            services.AddScoped<IScopedPostmanService, PostmanService>();
            services.AddSingleton<ISingletonPostmanService, PostmanService>();

            services.AddTransient<PostmanHandler>();

            services.AddLogging(loggerBuilder =>
            {
                loggerBuilder.ClearProviders();
                loggerBuilder.AddConsole();
            });

            return services;
        }
    }
}
