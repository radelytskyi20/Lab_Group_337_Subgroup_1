using Library.Data;
using Library.Models;
using Library.Services;

namespace WinForms.Client.Services
{
    public interface IHoldingsManager
    {
        Task AddAsync(Holding holding);
        Task<IEnumerable<Holding>> GetAllAsync(int acctNbr);
        Task UpdateAsync(Holding holding);
        Task<IEnumerable<Holding>> GetAllAsync();
        Task DeleteAsync(Guid id);
    }
    public class HoldingsManager : IHoldingsManager
    {
        public Task AddAsync(Holding holding)
        {
            using var context = new ApplicationDbContext();
            IHoldingsManagerService holdingsManagerService = new HoldingsManagerService(context);
            return holdingsManagerService.AddAsync(holding);
        }

        public async Task<IEnumerable<Holding>> GetAllAsync(int acctNbr)
        {
            using var context = new ApplicationDbContext();
            IHoldingsManagerService holdingsManagerService = new HoldingsManagerService(context);
            var holdings = await holdingsManagerService.GetAllAsync();

            return holdings.Where(h => h.AcctNbr == acctNbr)
                .ToList();
        }

        public async Task UpdateAsync(Holding holding)
        {
            using var context = new ApplicationDbContext();
            IHoldingsManagerService holdingsManagerService = new HoldingsManagerService(context);
            await holdingsManagerService.UpdateAsync(holding);
        }

        public async Task DeleteAsync(Guid id)
        {
            using var context = new ApplicationDbContext();
            IHoldingsManagerService holdingsManagerService = new HoldingsManagerService(context);
            await holdingsManagerService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Holding>> GetAllAsync()
        {
            using var context = new ApplicationDbContext();
            IHoldingsManagerService holdingsManagerService = new HoldingsManagerService(context);
            return await holdingsManagerService.GetAllAsync();
        }
    }
}
