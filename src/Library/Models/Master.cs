using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Master
    {
        [Key]
        public string Symbol { get; set; } = null!;
        public string? CoName { get; set; }
        public string? Exchange { get; set; }
        public decimal CurPrice { get; set; }
        public decimal YrlHigh { get; set; }
        public decimal YrlLow { get; set; }
        public decimal PERatio { get; set; }
        public decimal Beta { get; set; }
        public int ProjGrth { get; set; }
        public int Industry { get; set; }
        public int PriceChg { get; set; }
        public int Safety { get; set; }
        public string? Rating { get; set; }
        public int Bank { get; set; }
        public int Outlook { get; set; }
        public string? Rcmndation { get; set; }
        public string? Risk { get; set; }

        public virtual ICollection<Holding> Holdings { get; set; } = new List<Holding>();
    }
}
