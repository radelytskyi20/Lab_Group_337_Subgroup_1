using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=holdings.db");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Holdings)
                .WithOne(h => h.Client)
                .HasForeignKey(h => h.AcctNbr)
                .IsRequired(true);

            modelBuilder.Entity<Master>()
                .HasMany(m => m.Holdings)
                .WithOne(h => h.Master)
                .HasForeignKey(h => h.Symbol)
                .IsRequired(true);
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Holding> Holdings { get; set; } = null!;
        public virtual DbSet<Master> Masters { get; set; } = null!;
    }
}
