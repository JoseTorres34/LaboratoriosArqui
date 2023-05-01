using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Data;
using personapi_dotnet.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace personapi_dotnet.Repositories
{

    public class ProfesionRepository : IProfesionRepository
    {
        private readonly PersonaDbContext _dbContext;

        public ProfesionRepository(PersonaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Profesion> GetAll()
        {
            return _dbContext.Profesions
                .Include(p => p.Estudios)
                .ToList();
        }

        public Profesion GetById(int id)
        {
            return _dbContext.Profesions
                .Include(p => p.Estudios)
                .FirstOrDefault(p => p.Id == id);
        }

        public void Add(Profesion profesion)
        {
            _dbContext.Profesions.Add(profesion);
            _dbContext.SaveChanges();
        }

        public void Update(Profesion profesion)
        {
            _dbContext.Profesions.Update(profesion);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var profesion = GetById(id);

            if (profesion != null)
            {
                _dbContext.Profesions.Remove(profesion);
                _dbContext.SaveChanges();
            }
        }

        public bool Exist(int id)
        {
            return _dbContext.Profesions.Any(p => p.Id == id);
        }
    }
}