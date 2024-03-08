using DbSeeder;
using Library.Data;
using Library.Services;
using System.Reflection;

using var dbContext = new ApplicationDbContext();
IClientsManagerService clientsManagerService = new ClientsManagerService(dbContext);
IHoldingsManagerService holdingsManagerService = new HoldingsManagerService(dbContext);
IMastersManagerService masterManagerService = new MastersManagerService(dbContext);

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

public class ResourceNames
{
    public const string CLIENTS = "clients.xml";
    public const string HOLDINGS = "holdings.xml";
    public const string MASTER = "master.xml";
}
