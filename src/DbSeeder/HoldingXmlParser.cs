using Library.Models;
using System.Globalization;
using System.Xml;

namespace DbSeeder
{
    public static class HoldingAttributes
    {
        public const string ACCT_NBR = "ACCT_NBR";
        public const string SYMBOL = "SYMBOL";
        public const string SHARES = "SHARES";
        public const string PUR_PRICE = "PUR_PRICE";
        public const string PUR_DATE = "PUR_DATE";
    }

    public class HoldingXmlParser
    {
        public static IEnumerable<Holding> Parse(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(xml));

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            if (xmlDoc.DocumentElement is null)
                throw new InvalidOperationException("Xml document has no root element");

            var rowData = xmlDoc.DocumentElement.LastChild ?? throw new InvalidOperationException("Xml document has no data");
            var holdings = new List<Holding>();

            foreach (XmlElement element in rowData)
            {
                var holding = new Holding()
                {
                    AcctNbr = int.Parse(element.Attributes.GetNamedItem(HoldingAttributes.ACCT_NBR)?.Value!),
                    Symbol = element.Attributes.GetNamedItem(HoldingAttributes.SYMBOL)?.Value!,
                    Shares = int.Parse(element.Attributes.GetNamedItem(HoldingAttributes.SHARES)?.Value!),
                    PurPrice = decimal.Parse(element.Attributes.GetNamedItem(HoldingAttributes.PUR_PRICE)?.Value!),
                    PurDate = DateTime.ParseExact(element.Attributes.GetNamedItem(HoldingAttributes.PUR_DATE)?.Value!, "yyyyMMdd", CultureInfo.InvariantCulture)
                };

                holdings.Add(holding);
            }

            return holdings;
        }
    }
}
