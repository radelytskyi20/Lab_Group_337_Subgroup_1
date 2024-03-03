using Library.Models;
using System.Globalization;
using System.Xml;

namespace DbSeeder
{
    public static class ClientAttributes
    {
        public const string LAST_NAME = "LAST_NAME";
        public const string FIRST_NAME = "FIRST_NAME";
        public const string ACCT_NBR = "ACCT_NBR";
        public const string ADDRESS_1 = "ADDRESS_1";
        public const string CITY = "CITY";
        public const string STATE = "STATE";
        public const string ZIP = "ZIP";
        public const string TELEPHONE = "TELEPHONE";
        public const string DATE_OPEN = "DATE_OPEN";
        public const string SS_NUMBER = "SS_NUMBER";
        public const string BIRTH_DATE = "BIRTH_DATE";
        public const string RISK_LEVEL = "RISK_LEVEL";
        public const string OCCUPATION = "OCCUPATION";
        public const string OBJECTIVES = "OBJECTIVES";
        public const string INTERESTS = "INTERESTS";
    }
    public class ClientXmlParser
    {
        public static IEnumerable<Client> Parse(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(xml));

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            if (xmlDoc.DocumentElement is null)
                throw new InvalidOperationException("Xml document has no root element");

            var rowData = xmlDoc.DocumentElement.LastChild ?? throw new InvalidOperationException("Xml document has no data");
            var clients = new List<Client>();

            foreach (XmlElement element in rowData)
            {
                var client = new Client()
                {
                    FirstName = element.Attributes.GetNamedItem(ClientAttributes.FIRST_NAME)?.Value,
                    LastName = element.Attributes.GetNamedItem(ClientAttributes.LAST_NAME)?.Value,
                    AcctNbr = int.Parse(element.Attributes.GetNamedItem(ClientAttributes.ACCT_NBR)?.Value!),
                    Address = element.Attributes.GetNamedItem(ClientAttributes.ADDRESS_1)?.Value,
                    City = element.Attributes.GetNamedItem(ClientAttributes.CITY)?.Value,
                    State = element.Attributes.GetNamedItem(ClientAttributes.STATE)?.Value,
                    Zip = element.Attributes.GetNamedItem(ClientAttributes.ZIP)?.Value,
                    Phone = element.Attributes.GetNamedItem(ClientAttributes.TELEPHONE)?.Value,
                    DateOpen = DateTime.ParseExact(element.Attributes.GetNamedItem(ClientAttributes.DATE_OPEN)?.Value!, "yyyyMMdd", CultureInfo.InvariantCulture),
                    SsNumber = int.Parse(element.Attributes.GetNamedItem(ClientAttributes.SS_NUMBER)?.Value!),
                    BirthDate = DateTime.ParseExact(element.Attributes.GetNamedItem(ClientAttributes.BIRTH_DATE)?.Value!, "yyyyMMdd", CultureInfo.InvariantCulture),
                    RiskLevel = element.Attributes.GetNamedItem(ClientAttributes.RISK_LEVEL)?.Value,
                    Occupation = element.Attributes.GetNamedItem(ClientAttributes.OCCUPATION)?.Value,
                    Objectives = element.Attributes.GetNamedItem(ClientAttributes.OBJECTIVES)?.Value,
                    Interests = element.Attributes.GetNamedItem(ClientAttributes.INTERESTS)?.Value
                };

                clients.Add(client);
            }

            return clients;
        }
    }
}
