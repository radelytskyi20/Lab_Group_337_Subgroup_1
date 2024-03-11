using Library.Constants;
using Library.Models;
using Newtonsoft.Json;
using WinForms.Client.Interfaces;

namespace WinForms.Client.Services.Thin
{
    public class HoldingsManagerApi : BaseApiClinet<Holding>, IHoldingsManager
    {
        public HoldingsManagerApi(HttpClient httpClient) : base(httpClient) { }

        public async Task AddAsync(Holding holding) => await base.AddAsync($"api/holdings/{HoldingsControllerRoutes.Add}", holding);

        public Task DeleteAsync(Guid id) => HttpClient.DeleteAsync($"api/holdings/{HoldingsControllerRoutes.Delete}?id={id}");

        public async Task<IEnumerable<Holding>> GetAllAsync(int acctNbr)
        {
            var response = await HttpClient.GetAsync($"api/holdings/{HoldingsControllerRoutes.AllByAccount}?acctNbr={acctNbr}");
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Error: {response.StatusCode}");
                return Enumerable.Empty<Holding>();
            }

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<Holding>>(content) ?? Enumerable.Empty<Holding>();
        }

        public async Task<IEnumerable<Holding>> GetAllAsync() => await base.GetAllAsync($"api/holdings/{HoldingsControllerRoutes.All}");

        public Task UpdateAsync(Holding holding) => base.UpdateAsync($"api/holdings/{HoldingsControllerRoutes.Update}", holding);
    }
}
