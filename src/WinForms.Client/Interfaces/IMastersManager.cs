using Library.Models;

namespace WinForms.Client.Interfaces
{
    public interface IMastersManager
    {
        Task<IEnumerable<Master>> GetAllAsync();
        Task AddAsync(Master master);
        Task UpdateAsync(Master master);
        Task DeleteAsync(string symbol);
    }
}
