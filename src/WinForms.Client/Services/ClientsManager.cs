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
        Task DeleteAsync(int id);

    }
    public class ClientsManager : IClientsManager
    {
        private readonly IClientsManagerService _clientsManagerService;
        public ClientsManager(IClientsManagerService clientsManagerService)
        {
            _clientsManagerService = clientsManagerService;
        }

        public async Task AddAsync(Library.Models.Client client) => await _clientsManagerService.AddAsync(client);
        public async Task UpdateAsync(Library.Models.Client client) => await _clientsManagerService.UpdateAsync(client);
        public async Task<IEnumerable<Library.Models.Client>> GetAllAsync() => await _clientsManagerService.GetAllAsync();
        public async Task DeleteAsync(int acctNbr) => await _clientsManagerService.DeleteAsync(acctNbr);
    }
}
