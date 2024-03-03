using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Client
    {
        [Key]
        public int AcctNbr { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public DateTime DateOpen { get; set; }
        public int SsNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string? RiskLevel { get; set; }
        public string? Occupation { get; set; }
        public string? Objectives { get; set; }
        public string? Interests { get; set; }

        public virtual ICollection<Holding> Holdings { get; set; } = new List<Holding>();
    }
}
