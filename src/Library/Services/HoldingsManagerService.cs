using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public interface IHoldingsManagerService
    {
        Task<Holding?> GetOneAsync(Guid id);
        Task<IEnumerable<Holding>> GetAllAsync();
        Task AddAsync(Holding holding);
        Task UpdateAsync(Holding holding);
        Task DeleteAsync(Guid id);
    }
    public class HoldingsManagerService : IHoldingsManagerService
    {
        public DbSet<Holding> Table { get; init; }
        public ApplicationDbContext DbContext { get; init; }

        public HoldingsManagerService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            Table = dbContext.Holdings;
        }

        public async Task<Holding?> GetOneAsync(Guid id) => await Table.FindAsync(id);
        public async Task<IEnumerable<Holding>> GetAllAsync() => await Table.ToListAsync();
        public async Task AddAsync(Holding holding)
        {
            Table.Add(holding);
            await DbContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(Holding holding)
        {
            Table.Update(holding);
            await DbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var client = await GetOneAsync(id);
            if (client is not null)
            {
                Table.Remove(client);
                await DbContext.SaveChangesAsync();
            }
        }
    }
}
