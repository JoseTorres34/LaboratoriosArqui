using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Data.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly PersonaDbContext _context;

        public PersonaRepository(PersonaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Persona>> GetAll()
        {
            return await _context.Personas.ToListAsync();
        }

        public async Task<Persona> GetById(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task Create(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Persona persona)
        {
            _context.Entry(persona).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var persona = await GetById(id);
            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();
        }
    }
}
