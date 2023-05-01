using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Data.Repositories
{
    public interface IEstudioRepository
    {
        Task CreateAsync(Estudio entity);
        Task DeleteAsync(Estudio entity);
        Task<IEnumerable<Estudio>> GetAllAsync();
        Task<Estudio> GetByIdAsync(int id);
        Task UpdateAsync(Estudio entity);
    }
}