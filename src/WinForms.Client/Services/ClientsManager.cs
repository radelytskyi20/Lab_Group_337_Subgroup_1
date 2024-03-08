using Library.Data;
using Library.Models;
using Library.Services;

namespace WinForms.Client.Services
{
    public interface IClientsManager
    {
        Task AddAsync(Library.Models.Client client);
        Task UpdateAsync(Library.Models.Client client);
        Task<IEnumerable<Library.Models.Client>> GetAllAsync();
        Task DeletetAsync(int id);

    }
    public class ClientsManager : IClientsManager
    {
        public async Task AddAsync(Library.Models.Client client)
        {
            using var context = new ApplicationDbContext();
            IClientsManagerService clientsManagerService = new ClientsManagerService(context);
            await clientsManagerService.AddAsync(client);
        }
        public async Task UpdateAsync(Library.Models.Client client)
        {
            using var context = new Library.Data.ApplicationDbContext();
            IClientsManagerService clientsManagerService = new ClientsManagerService(context);
            await clientsManagerService.UpdateAsync(client);
        }
        public async Task<IEnumerable<Library.Models.Client>> GetAllAsync()
        {
            using var context = new ApplicationDbContext();
            IClientsManagerService clientsManagerService = new ClientsManagerService(context);
            return await clientsManagerService.GetAllAsync();
        }
        public async Task DeletetAsync(int acctNbr)
        {
            using var context = new ApplicationDbContext();
            IClientsManagerService clientsManagerService = new ClientsManagerService(context);
            await clientsManagerService.DeleteAsync(acctNbr);
        }
    }
}
