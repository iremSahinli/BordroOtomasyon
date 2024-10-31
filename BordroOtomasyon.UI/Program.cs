using BordroOtomasyon.Infrastructure.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BordroOtomasyon.UI
{
    internal static class Program
    {
        private static ServiceProvider serviceProvider; //kuruldu.


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Json")
            .Build();


            var serviceColection = new ServiceCollection();
            ConfigureServices(serviceColection, configuration);

            serviceProvider = serviceColection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<Form1>();

            //Extenstions Services Method:
            services.AddInfrastructureServices(configuration);

        }
    }
}