using Library.Models;
using Library.Services;
using WinForms.Client.Interfaces;

namespace WinForms.Client.Services.Thick
{
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
