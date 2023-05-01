using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repositories
{
    public interface ITelefonoRepository
    {
        Task AddAsync(Telefono telefono);
        Task DeleteAsync(Telefono telefono);
        Task<IEnumerable<Telefono>> GetAllAsync();
        Task<Telefono> GetByIdAsync(string id);
        Task<IEnumerable<Telefono>> GetByOwnerIdAsync(int ownerId);
        Task UpdateAsync(Telefono telefono);
    }
}