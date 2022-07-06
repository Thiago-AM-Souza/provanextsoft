using Ex2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ex2.Repositories
{
    public class IFamiliaRepository : IBaseRepository<Familia>
    {
        private readonly Context _context;

        public IFamiliaRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Familia>> FindAll()
        {
            return await _context.Familia.Include(fam => fam.Moradores).ToListAsync();
        }

        public async Task<Familia> FindById(int id)
        {
            return await _context.Familia.FindAsync(id);
        }

        public async Task Insert(Familia familia)
        {
            _context.Familia.Add(familia);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, Familia familia)
        {
            _context.Entry(familia).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var familia = FindById(id).Result;
            _context.Familia.Remove(familia);
            await _context.SaveChangesAsync();
        }
    }
}
