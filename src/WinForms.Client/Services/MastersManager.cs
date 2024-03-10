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
        private readonly IMastersManagerService _mastersManagerService;
        public MastersManager(IMastersManagerService mastersManagerService)
        {
            _mastersManagerService = mastersManagerService;
        }

        public async Task<IEnumerable<Master>> GetAllAsync() => await _mastersManagerService.GetAllAsync();

        public async Task AddAsync(Master master) => await _mastersManagerService.AddAsync(master);

        public async Task UpdateAsync(Master master) => await _mastersManagerService.UpdateAsync(master);

        public async Task DeleteAsync(string symbol) => await _mastersManagerService.DeleteAsync(symbol);
    }
}
