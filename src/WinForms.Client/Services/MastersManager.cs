using Library.Data;
using Library.Models;
using Library.Services;

namespace WinForms.Client.Services
{
    public interface IMastersManager
    {
        Task<IEnumerable<Master>> GetAllAsync();
        Task AddAsync(Master master);
        Task UpdateAsync(Master master);
        Task DeleteAsync(string symbol);
    }

    public class MastersManager : IMastersManager
    {
        public async Task<IEnumerable<Master>> GetAllAsync()
        {
            using var context = new ApplicationDbContext();
            IMastersManagerService mastersManagerService = new MastersManagerService(context);
            return await mastersManagerService.GetAllAsync();
        }

        public async Task AddAsync(Master master)
        {
            using var context = new ApplicationDbContext();
            IMastersManagerService mastersManagerService = new MastersManagerService(context);
            await mastersManagerService.AddAsync(master);
        }

        public async Task UpdateAsync(Master master)
        {
            using var context = new ApplicationDbContext();
            IMastersManagerService mastersManagerService = new MastersManagerService(context);
            await mastersManagerService.UpdateAsync(master);
        }

        public async Task DeleteAsync(string symbol)
        {
            using var context = new ApplicationDbContext();
            IMastersManagerService mastersManagerService = new MastersManagerService(context);
            await mastersManagerService.DeleteAsync(symbol);
        }
    }
}
