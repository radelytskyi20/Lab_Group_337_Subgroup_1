using Library.Constants;
using Library.Data;
using Library.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WinForms.Client.Services;

namespace WinForms.Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceProvoder = new ServiceCollection()
                .AddDbContext<ApplicationDbContext>(options => options.UseSqlite($"Data Source={ConnectionStrings.Default}"))
                .AddTransient<IClientsManager, ClientsManager>()
                .AddTransient<IHoldingsManager, HoldingsManager>()
                .AddTransient<IMastersManager, MastersManager>()
                .AddTransient<IClientsManagerService, ClientsManagerService>()
                .AddTransient<IHoldingsManagerService, HoldingsManagerService>()
                .AddTransient<IMastersManagerService, MastersManagerService>()
                .BuildServiceProvider();


            var clientsManager = serviceProvoder.GetService<IClientsManager>() ?? throw new Exception();
            var holdingsManager = serviceProvoder.GetService<IHoldingsManager>() ?? throw new Exception();
            var mastersManager = serviceProvoder.GetService<IMastersManager>() ?? throw new Exception();

            Application.Run(new Main(clientsManager, holdingsManager, mastersManager));
        }
    }
}