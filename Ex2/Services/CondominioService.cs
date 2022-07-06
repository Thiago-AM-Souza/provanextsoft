using Ex2.Models;
using Ex2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2.Services
{
    public class CondominioService
    {
        private readonly ICondominioRepository _repository;

        public CondominioService(ICondominioRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Condominio>> FindAll()
        {
            return await _repository.FindAll();
        }

        public async Task<Condominio> FindById(int id)
        {
            return await _repository.FindById(id);
        }

        public async Task Insert(Condominio condominio)
        {
            await _repository.Insert(condominio);
        }

        public async Task Update(int id, Condominio condominio)
        {
            await _repository.Update(id, condominio);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
