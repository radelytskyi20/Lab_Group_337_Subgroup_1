namespace Library.Constants
{
    public static class MasterData
    {
        public static readonly string[] Exchange = new[]
        {
            "NYSE",
            "NONE",
            "TSE",
            "ASE"
        };
        public static readonly int[] Safety = new[] { 1, 2, 3, 4, 5 };
        public static readonly string[] Rating = new[] { "A", "B", "C", "D", "E" };
        public static readonly int[] Bank = { 0, 1, 2, 3 };
        public static readonly int[] Outlook = { 1, 2, 3, 4, 5 };
        public static readonly string[] Rcmndation = new[]
        {
            "SELL",
            "BUY",
            "HOLD"
        };
        public static readonly string[] Risk = new[]
        {
            "HIGH",
            "LOW",
            "MED"
        };
    }
}
