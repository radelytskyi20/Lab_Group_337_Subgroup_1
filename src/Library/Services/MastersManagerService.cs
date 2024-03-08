using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public interface IMastersManagerService
    {
        Task<Master?> GetOneAsync(string symbol);
        Task<IEnumerable<Master>> GetAllAsync();
        Task AddAsync(Master master);
        Task UpdateAsync(Master master);
        Task DeleteAsync(string symbol);
    }
    public class MastersManagerService : IMastersManagerService
    {
        public DbSet<Master> Table { get; init; }
        public ApplicationDbContext DbContext { get; init; }

        public MastersManagerService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            Table = dbContext.Masters;
        }
        public async Task<Master?> GetOneAsync(string symbol) => await Table.FindAsync(symbol);
        public async Task<IEnumerable<Master>> GetAllAsync() => await Table.ToListAsync();
        public async Task AddAsync(Master master)
        {
            Table.Add(master);
            await DbContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(Master master)
        {
            Table.Update(master);
            await DbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(string symbol)
        {
            var client = await GetOneAsync(symbol);
            if (client is not null)
            {
                Table.Remove(client);
                await DbContext.SaveChangesAsync();
            }
        }
    }
}
