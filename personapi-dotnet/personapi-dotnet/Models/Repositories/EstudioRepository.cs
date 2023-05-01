using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Data.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        private readonly PersonaDbContext _dbContext;

        public EstudioRepository(PersonaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Estudio>> GetAllAsync()
        {
            return await _dbContext.Estudios.ToListAsync();
        }

        public async Task<Estudio> GetByIdAsync(int id)
        {
            return await _dbContext.Estudios.FindAsync(id);
        }

        public async Task CreateAsync(Estudio entity)
        {
            await _dbContext.Estudios.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Estudio entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estudio entity)
        {
            _dbContext.Estudios.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}

