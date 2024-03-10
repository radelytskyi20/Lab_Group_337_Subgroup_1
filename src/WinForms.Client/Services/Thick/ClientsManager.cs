using Library.Services;
using WinForms.Client.Interfaces;

namespace WinForms.Client.Services.Thick
{
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
