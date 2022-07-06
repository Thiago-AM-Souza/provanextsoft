using Ex2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2.Repositories
{
    public class IMoradorRepository : IBaseRepository<Morador>
    {
        private readonly Context _context;

        public IMoradorRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Morador>> FindAll()
        {
            return await _context.Morador.ToListAsync();
        }

        public async Task<Morador> FindById(int id)
        {
            return await _context.Morador.FindAsync(id);
        }

        public async Task Insert(Morador morador)
        {
            _context.Morador.Add(morador);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, Morador morador)
        {
            _context.Entry(morador).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var morador = FindById(id).Result;
            _context.Morador.Remove(morador);
            await _context.SaveChangesAsync();
        }
    }
}
