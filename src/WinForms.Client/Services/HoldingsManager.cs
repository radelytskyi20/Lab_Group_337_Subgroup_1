using Library.Data;
using Library.Models;
using Library.Services;

namespace WinForms.Client.Services
{
    public interface IHoldingsManager
    {
        Task AddAsync(Holding holding);
        Task<IEnumerable<Holding>> GetAllAsync(int acctNbr);
    }
    public class HoldingsManager : IHoldingsManager
    {
        public Task AddAsync(Holding holding)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Holding>> GetAllAsync(int acctNbr)
        {
            using var context = new ApplicationDbContext();
            IHoldingsManagerService holdingsManagerService = new HoldingsManagerService(context);
            var holdings = await holdingsManagerService.GetAllAsync();

            return holdings.Where(h => h.AcctNbr == acctNbr)
                .ToList();
        }
    }
}
