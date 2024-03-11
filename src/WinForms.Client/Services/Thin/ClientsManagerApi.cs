using Library.Constants;
using Newtonsoft.Json;
using WinForms.Client.Interfaces;

namespace WinForms.Client.Services.Thin
{
    public class ClientsManagerApi : BaseApiClinet<Library.Models.Client>, IClientsManager
    {
        public ClientsManagerApi(HttpClient httpClient) : base(httpClient) { }

        public async Task AddAsync(Library.Models.Client client) => await base.AddAsync($"api/clients/{ClientsControllerRoutes.Add}", client);

        public Task DeleteAsync(int acctNbr) => HttpClient.DeleteAsync($"api/clients/{ClientsControllerRoutes.Delete}?acctNbr={acctNbr}");

        public async Task<IEnumerable<Library.Models.Client>> GetAllAsync() => await base.GetAllAsync($"api/clients/{ClientsControllerRoutes.All}");

        public async Task UpdateAsync(Library.Models.Client client) => await base.UpdateAsync($"api/clients/{ClientsControllerRoutes.Update}", client);
    }
}
