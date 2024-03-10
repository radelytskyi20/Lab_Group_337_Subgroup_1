using Library.Models;

namespace WinForms.Client.Interfaces
{
    public interface IHoldingsManager
    {
        Task AddAsync(Holding holding);
        Task<IEnumerable<Holding>> GetAllAsync(int acctNbr);
        Task UpdateAsync(Holding holding);
        Task<IEnumerable<Holding>> GetAllAsync();
        Task DeleteAsync(Guid id);
    }
}
