using DbSeeder;
using Library.Constants;
using Library.Data;
using Library.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var serviceProvoder = new ServiceCollection()
    .AddDbContext<ApplicationDbContext>(options => options.UseSqlite($"Data Source={ConnectionStrings.Default}"))
    .AddTransient<IClientsManagerService, ClientsManagerService>()
    .AddTransient<IHoldingsManagerService, HoldingsManagerService>()
    .AddTransient<IMastersManagerService, MastersManagerService>()
    .BuildServiceProvider();

IClientsManagerService clientsManagerService = serviceProvoder.GetService<IClientsManagerService>() ?? throw new Exception();
IHoldingsManagerService holdingsManagerService = serviceProvoder.GetService<IHoldingsManagerService>() ?? throw new Exception();
IMastersManagerService masterManagerService = serviceProvoder.GetService<IMastersManagerService>() ?? throw new Exception();

ApplicationDbContext dbContext = serviceProvoder.GetService<ApplicationDbContext>() ?? throw new Exception();

await dbContext.Database.EnsureDeletedAsync();
await dbContext.Database.MigrateAsync();

Console.WriteLine("Start seeding...");
try
{
    //load clients
    var clientsXml = LoadXmlResource(ResourceNames.CLIENTS);
    if (clientsXml is not null)
    {
        var clients = ClientXmlParser.Parse(clientsXml);
        foreach (var client in clients)
            await clientsManagerService.AddAsync(client);
    }

    //load master
    var masterXml = LoadXmlResource(ResourceNames.MASTER);
    if (masterXml is not null)
    {
        var masters = MasterXmlParser.Parse(masterXml);
        foreach (var master in masters)
            await masterManagerService.AddAsync(master);
    }

    //load holdings
    var holdingsXml = LoadXmlResource(ResourceNames.HOLDINGS);
    if (holdingsXml is not null)
    {
        var holdings = HoldingXmlParser.Parse(holdingsXml);
        foreach (var holding in holdings)
            await holdingsManagerService.AddAsync(holding);
    }

    Console.WriteLine("Seeding completed");
}
catch (Exception ex)
{
    Console.WriteLine("Seeding not completed. Error: {0}", ex.Message);
}

static string? LoadXmlResource(string resourceName)
{
    var resourceLocation = $"DbSeeder.Data.{resourceName}";
    using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceLocation);
    if (stream is null)
    {
        Console.WriteLine("Resource {0} was not found", resourceName);
        return null;
    }

    using var reader = new StreamReader(stream);
    var xml = reader.ReadToEnd();
    return xml;
}

public static class ResourceNames
{
    public const string CLIENTS = "clients.xml";
    public const string HOLDINGS = "holdings.xml";
    public const string MASTER = "master.xml";
}
