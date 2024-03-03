using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Holding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey("AcctNbr")]
        [Required]
        public int AcctNbr { get; set; }

        [ForeignKey("Symbol")]
        [Required]
        public string Symbol { get; set; } = null!;
        public int Shares { get; set; }
        public decimal PurPrice { get; set; }
        public DateTime PurDate { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual Master Master { get; set; } = null!;
    }
}
