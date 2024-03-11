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

        public async Task<Holding?> GetOneAsync(Guid id) => await Table.FirstOrDefaultAsync(holding => holding.Id == id);
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
            var holding = await GetOneAsync(id);
            if (holding is not null)
            {
                Table.Remove(holding);
                await DbContext.SaveChangesAsync();
            }
        }
    }
}
