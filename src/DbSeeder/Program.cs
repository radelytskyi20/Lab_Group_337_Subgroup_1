using DbSeeder;
using System.Reflection;

//load clients
var clientsXml = LoadXmlResource(ResourceNames.CLIENTS);
if (clientsXml is not null)
{
    var clients = ClientXmlParser.Parse(clientsXml);
}


//load holdings
var holdingsXml = LoadXmlResource(ResourceNames.HOLDINGS);
if (holdingsXml is not null)
{
    var holdings = HoldingXmlParser.Parse(holdingsXml);
}

//load master
var masterXml = LoadXmlResource(ResourceNames.MASTER);
if (masterXml is not null)
{
    var master = MasterXmlParser.Parse(masterXml);
}


static string? LoadXmlResource(string resourceName)
{
    var resourceLocation = $"DbSeeder.Data.{resourceName}";
    using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceLocation);
    if (stream is null)
    {
        Console.WriteLine("Resource {0} was not found", ResourceNames.CLIENTS);
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
