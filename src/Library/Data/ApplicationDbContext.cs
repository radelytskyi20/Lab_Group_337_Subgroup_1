using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class ApplicationDbContext : DbContext
    {
        private const string DbPath = @"D:\Университет\3 КУРС 2 СЕМЕСТР\Технологии создания программ(Момот)\Labs\holdings.db";
        public ApplicationDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
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
