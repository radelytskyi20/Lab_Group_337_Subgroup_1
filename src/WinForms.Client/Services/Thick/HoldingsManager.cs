using Library.Models;
using Library.Services;
using WinForms.Client.Interfaces;

namespace WinForms.Client.Services.Thick
{
    public class HoldingsManager : IHoldingsManager
    {
        private readonly IHoldingsManagerService _holdingsManagerService;
        public HoldingsManager(IHoldingsManagerService holdingsManagerService)
        {
            _holdingsManagerService = holdingsManagerService;
        }

        public async Task AddAsync(Holding holding) => await _holdingsManagerService.AddAsync(holding);

        public async Task<IEnumerable<Holding>> GetAllAsync(int acctNbr)
        {
            var holdings = await _holdingsManagerService.GetAllAsync();

            return holdings.Where(h => h.AcctNbr == acctNbr)
                .ToList();
        }

        public async Task UpdateAsync(Holding holding) => await _holdingsManagerService.UpdateAsync(holding);

        public async Task DeleteAsync(Guid id) => await _holdingsManagerService.DeleteAsync(id);

        public async Task<IEnumerable<Holding>> GetAllAsync() => await _holdingsManagerService.GetAllAsync();
    }
}
