using Library.Constants;
using Library.Models;
using WinForms.Client.Interfaces;

namespace WinForms.Client.Services.Thin
{
    public class MastersManagerApi : BaseApiClinet<Master>, IMastersManager
    {
        public MastersManagerApi(HttpClient httpClient) : base(httpClient) { }

        public async Task AddAsync(Master master) => await base.AddAsync($"api/masters/{MastersControllerRoutes.Add}", master);

        public async Task DeleteAsync(string symbol) => await HttpClient.DeleteAsync($"api/masters/{MastersControllerRoutes.Delete}?symbol={symbol}");

        public async Task<IEnumerable<Master>> GetAllAsync() => await base.GetAllAsync($"api/masters/{MastersControllerRoutes.All}");

        public async Task UpdateAsync(Master master) => await base.UpdateAsync($"api/masters/{MastersControllerRoutes.Update}", master);
    }
}
