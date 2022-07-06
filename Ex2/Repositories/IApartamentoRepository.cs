using Ex2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Ex2.Repositories
{
    public class IApartamentoRepository : IBaseRepository<Apartamento>
    {
        private readonly Context _context;

        public IApartamentoRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Apartamento>> FindAll()
        {
            return await _context.Apartamento.ToListAsync();
        }

        public async Task<Apartamento> FindById(int id)
        {
            return await _context.Apartamento.FindAsync(id);
        }

        public async Task Insert(Apartamento apartamento)
        {
            _context.Apartamento.Add(apartamento);
            await _context.SaveChangesAsync();            
        }

        public async Task Update(int id, Apartamento apartamento)
        {
            _context.Entry(apartamento).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var apartamento = FindById(id).Result;
            _context.Apartamento.Remove(apartamento);
            await _context.SaveChangesAsync();
        }

    }
}
