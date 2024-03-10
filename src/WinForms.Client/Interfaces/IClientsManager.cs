namespace WinForms.Client.Interfaces
{
    public interface IClientsManager
    {
        Task AddAsync(Library.Models.Client client);
        Task UpdateAsync(Library.Models.Client client);
        Task<IEnumerable<Library.Models.Client>> GetAllAsync();
        Task DeleteAsync(int id);

    }
}
