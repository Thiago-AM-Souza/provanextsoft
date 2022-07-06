using Ex2.Models;
using Ex2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2.Services
{
    public class MoradorService
    {
        private readonly IMoradorRepository _repository;

        public MoradorService(IMoradorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Morador>> FindAll()
        {
            return await _repository.FindAll();
        }

        public async Task<Morador> FindById(int id)
        {
            return await _repository.FindById(id);
        }

        public async Task Insert(Morador morador)
        {
            await _repository.Insert(morador);
        }

        public async Task Update(int id, Morador morador)
        {
            await _repository.Update(id, morador);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
