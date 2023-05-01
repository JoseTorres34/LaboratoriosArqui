using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Repositories
{
    public interface IProfesionRepository
    {
        void Add(Profesion profesion);
        void Delete(int id);
        bool Exist(int id);
        IEnumerable<Profesion> GetAll();
        Profesion GetById(int id);
        void Update(Profesion profesion);
    }
}