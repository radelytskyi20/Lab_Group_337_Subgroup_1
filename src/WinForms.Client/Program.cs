using Library.Constants;
using Library.Data;
using Library.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WinForms.Client.Interfaces;
using WinForms.Client.Services.Thick;
using WinForms.Client.Services.Thin;

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
                
                //thick services
                //.AddTransient<IClientsManager, ClientsManager>()
                .AddTransient<IHoldingsManager, HoldingsManager>()
                .AddTransient<IMastersManager, MastersManager>()
                .AddTransient<IClientsManagerService, ClientsManagerService>()
                .AddTransient<IHoldingsManagerService, HoldingsManagerService>()
                .AddTransient<IMastersManagerService, MastersManagerService>()
                
                //api services => thin services
                .AddTransient<IClientsManager, ClientsManagerApi>(provider =>
                {
                    return new ClientsManagerApi(new HttpClient());
                })
                .BuildServiceProvider();

            
            var clientsManager = serviceProvoder.GetService<IClientsManager>() ?? throw new Exception();
            var holdingsManager = serviceProvoder.GetService<IHoldingsManager>() ?? throw new Exception();
            var mastersManager = serviceProvoder.GetService<IMastersManager>() ?? throw new Exception();

            Application.Run(new Main(clientsManager, holdingsManager, mastersManager));
        }
    }
}