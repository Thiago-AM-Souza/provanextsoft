using Ex2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ex2.Repositories
{
    public class ICondominioRepository : IBaseRepository<Condominio>
    {
        private readonly Context _context;

        public ICondominioRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Condominio>> FindAll()
        {
            return await _context.Condominio.Include(cond => cond.Apartamentos).ToListAsync();
        }

        public async Task<Condominio> FindById(int id)
        {
            return await _context.Condominio.FindAsync(id);
        }

        public async Task Insert(Condominio condominio)
        {
            _context.Condominio.Add(condominio);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, Condominio condominio)
        {
            _context.Entry(condominio).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var condominio = FindById(id).Result;
            _context.Condominio.Remove(condominio);
            await _context.SaveChangesAsync();
        }
    }
}
