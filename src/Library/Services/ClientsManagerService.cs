using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public interface IClientsManagerService
    {
        Task<Client?> GetOneAsync(int acctNbr);
        Task<IEnumerable<Client>> GetAllAsync();
        Task AddAsync(Client client);
        Task UpdateAsync(Client client);
        Task DeleteAsync(int acctNbr);
    }
    public class ClientsManagerService : IClientsManagerService
    {
        public DbSet<Client> Table { get; init; }
        public ApplicationDbContext DbContext { get; init; }

        public ClientsManagerService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            Table = dbContext.Clients;
        }
        public async Task<Client?> GetOneAsync(int acctNbr) => await Table.FirstOrDefaultAsync(client => client.AcctNbr == acctNbr);
        public async Task<IEnumerable<Client>> GetAllAsync() => await Table.ToListAsync();
        public async Task AddAsync(Client client)
        {
            Table.Add(client);
            await DbContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(Client client)
        {
            Table.Update(client);
            await DbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int acctNbr)
        {
            var client = await GetOneAsync(acctNbr);
            if (client is not null)
            {
                Table.Remove(client);
                await DbContext.SaveChangesAsync();
            }
        }
    }
}
