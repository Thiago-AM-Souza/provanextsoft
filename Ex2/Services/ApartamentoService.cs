using Ex2.Models;
using Ex2.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ex2.Services
{
    public class ApartamentoService
    {
        private readonly IApartamentoRepository _repository;
        private readonly ICondominioRepository _condominioRepository;

        public ApartamentoService(IApartamentoRepository repository, ICondominioRepository condominioRepository)
        {
            _repository = repository;
            _condominioRepository = condominioRepository;
        }

        public async Task<IEnumerable<Apartamento>> FindAll()
        {
            return await _repository.FindAll();    
        }

        public async Task<Apartamento> FindById(int id) 
        {
            return await _repository.FindById(id);   
        }

        public async Task Insert(Apartamento apartamento)
        {
            Apartamento ap = new Apartamento();
            ap.Numero = apartamento.Numero;
            ap.AreaTotal = apartamento.AreaTotal;
            var cond = _condominioRepository.FindById(apartamento.CondominioId).Result;
            ap.Condominio = cond;
            ap.FracaoIdeal = Math.Round((ap.AreaTotal * 100) / ap.Condominio.AreaTotal, 2);
            ap.ValorProporcionalIptu = Math.Round((ap.Condominio.ValorIptu * ap.FracaoIdeal) / 100, 2);
            await _repository.Insert(ap);
        }

        public async Task Update(int id, Apartamento apartamento)
        {
            var ap = apartamento;
            var cond = _condominioRepository.FindById(apartamento.CondominioId).Result;
            ap.Condominio = cond;
            ap.FracaoIdeal = Math.Round((ap.AreaTotal * 100) / ap.Condominio.AreaTotal, 2);
            ap.ValorProporcionalIptu = Math.Round((ap.Condominio.ValorIptu * ap.FracaoIdeal) / 100, 2);
            await _repository.Update(id, ap);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

    }
}
