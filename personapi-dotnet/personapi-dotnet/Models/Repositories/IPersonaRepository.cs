using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Data.Repositories
{
    public interface IPersonaRepository
    {
        Task Create(Persona persona);
        Task Delete(int id);
        Task<IEnumerable<Persona>> GetAll();
        Task<Persona> GetById(int id);
        Task Update(Persona persona);
    }
}