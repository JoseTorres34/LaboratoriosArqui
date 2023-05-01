using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repositories
{
    public class TelefonoRepository : ITelefonoRepository
    {
        private readonly PersonaDbContext _dbContext;

        public TelefonoRepository(PersonaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Telefono> GetByIdAsync(string id)
        {
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return await _dbContext.Telefonos
                .Include(t => t.DuenioNavigation)
                .FirstOrDefaultAsync(t => t.Num == id);
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }

        public async Task<IEnumerable<Telefono>> GetAllAsync()
        {
            return await _dbContext.Telefonos
                .Include(t => t.DuenioNavigation)
                .ToListAsync();
        }

        public async Task<IEnumerable<Telefono>> GetByOwnerIdAsync(int ownerId)
        {
            return await _dbContext.Telefonos
                .Where(t => t.Duenio == ownerId)
                .Include(t => t.DuenioNavigation)
                .ToListAsync();
        }

        public async Task AddAsync(Telefono telefono)
        {
            _dbContext.Telefonos.Add(telefono);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Telefono telefono)
        {
            _dbContext.Telefonos.Update(telefono);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Telefono telefono)
        {
            _dbContext.Telefonos.Remove(telefono);
            await _dbContext.SaveChangesAsync();
        }
    }
}
