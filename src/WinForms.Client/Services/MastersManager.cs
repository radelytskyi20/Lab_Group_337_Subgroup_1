using Library.Data;
using Library.Models;
using Library.Services;

namespace WinForms.Client.Services
{
    public interface IMastersManager
    {
        Task<IEnumerable<Master>> GetAllAsync();
    }

    public class MastersManager : IMastersManager
    {
        public async Task<IEnumerable<Master>> GetAllAsync()
        {
            using var context = new ApplicationDbContext();
            IMastersManagerService mastersManagerService = new MastersManagerService(context);
            return await mastersManagerService.GetAllAsync();
        }
    }
}
