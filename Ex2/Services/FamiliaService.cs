using Ex2.Models;
using Ex2.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ex2.Services
{
    public class FamiliaService
    {
        private readonly IFamiliaRepository _repository;

        public FamiliaService(IFamiliaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Familia>> FindAll()
        {
            return await _repository.FindAll();
        }

        public async Task<Familia> FindById(int id)
        {
            return await _repository.FindById(id);
        }

        public async Task Insert(Familia Familia)
        {
            await _repository.Insert(Familia);
        }

        public async Task Update(int id, Familia Familia)
        {
            await _repository.Update(id, Familia);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
