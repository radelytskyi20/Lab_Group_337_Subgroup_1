using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public interface IClientsManagerService
    {
        Task<Client?> GetOneAsync(int id);
        Task<IEnumerable<Client>> GetAllAsync();
        Task AddAsync(Client client);
        Task UpdateAsync(Client client);
        Task DeleteAsync(int id);
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
        public async Task<Client?> GetOneAsync(int id) => await Table.FindAsync(id);
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
        public async Task DeleteAsync(int id)
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
