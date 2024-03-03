using Library.Models;
using System.Xml;

namespace DbSeeder
{
    public static class MasterAttributes
    {
        public const string SYMBOL = "SYMBOL";
        public const string CO_NAME = "CO_NAME";
        public const string EXCHANGE = "EXCHANGE";
        public const string CUR_PRICE = "CUR_PRICE";
        public const string YRL_HIGH = "YRL_HIGH";
        public const string YRL_LOW = "YRL_LOW";
        public const string P_E_RATIO = "P_E_RATIO";
        public const string BETA = "BETA";
        public const string PROJ_GRTH = "PROJ_GRTH";
        public const string INDUSTRY = "INDUSTRY";
        public const string PRICE_CHG = "PRICE_CHG";
        public const string SAFETY = "SAFETY";
        public const string RATING = "RATING";
        public const string RANK = "RANK";
        public const string OUTLOOK = "OUTLOOK";
        public const string RCMNDATION = "RCMNDATION";
        public const string RISK = "RISK";
    }

    public class MasterXmlParser
    {
        public static IEnumerable<Master> Parse(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(xml));

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            if (xmlDoc.DocumentElement is null)
                throw new InvalidOperationException("Xml document has no root element");

            var rowData = xmlDoc.DocumentElement.LastChild ?? throw new InvalidOperationException("Xml document has no data");
            var masters = new List<Master>();

            foreach (XmlElement element in rowData)
            {
                var master = new Master()
                {
                    Symbol = element.Attributes.GetNamedItem(MasterAttributes.SYMBOL)?.Value!,
                    CoName = element.Attributes.GetNamedItem(MasterAttributes.CO_NAME)?.Value,
                    Exchange = element.Attributes.GetNamedItem(MasterAttributes.EXCHANGE)?.Value,
                    CurPrice = decimal.Parse(element.Attributes.GetNamedItem(MasterAttributes.CUR_PRICE)?.Value!),
                    YrlHigh = decimal.Parse(element.Attributes.GetNamedItem(MasterAttributes.YRL_HIGH)?.Value!),
                    YrlLow = decimal.Parse(element.Attributes.GetNamedItem(MasterAttributes.YRL_LOW)?.Value!),
                    PERatio = decimal.Parse(element.Attributes.GetNamedItem(MasterAttributes.P_E_RATIO)?.Value!),
                    Beta = decimal.Parse(element.Attributes.GetNamedItem(MasterAttributes.BETA)?.Value!),
                    ProjGrth = int.Parse(element.Attributes.GetNamedItem(MasterAttributes.PROJ_GRTH)?.Value!),
                    Industry = int.Parse(element.Attributes.GetNamedItem(MasterAttributes.INDUSTRY)?.Value!),
                    PriceChg = int.Parse(element.Attributes.GetNamedItem(MasterAttributes.PRICE_CHG)?.Value!),
                    Safety = int.Parse(element.Attributes.GetNamedItem(MasterAttributes.SAFETY)?.Value!),
                    Rating = element.Attributes.GetNamedItem(MasterAttributes.RATING)?.Value,
                    Bank = int.Parse(element.Attributes.GetNamedItem(MasterAttributes.RANK)?.Value!),
                    Outlook = int.Parse(element.Attributes.GetNamedItem(MasterAttributes.OUTLOOK)?.Value!),
                    Rcmndation = element.Attributes.GetNamedItem(MasterAttributes.RCMNDATION)?.Value,
                    Risk = element.Attributes.GetNamedItem(MasterAttributes.RISK)?.Value
                };

                masters.Add(master);
            }

            return masters;
        }
    }
}
