using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex2.Models;
using Ex2.Services;

namespace Ex2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartamentosController : ControllerBase
    {
        private readonly ApartamentoService _service;

        public ApartamentosController(ApartamentoService service)
        {
            _service = service;
        }

        // GET: api/Apartamentos
        [HttpGet]
        public async Task<IEnumerable<Apartamento>> FindAll()
        {
            return await _service.FindAll();
        }

        // GET: api/Apartamentos/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Apartamento>> FindById(int id)
        {
            var apartamento = await _service.FindById(id);
            if (apartamento == null)
            {
                return NotFound("Id não encontrado.");
            }
            else
            {
                return apartamento;
            }
        }

        //PUT: api/Apartamentos/id
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Apartamento apartamento)
        {
            if (id != apartamento.Id)
            {
                return NotFound("Id não encontrado.");
            }
            await _service.Update(id, apartamento);
            return CreatedAtAction("FindById", new { id = apartamento.Id }, apartamento);
        }

        // POST: api/Apartamentos       
        [HttpPost]
        public async Task<ActionResult<Apartamento>> Insert(Apartamento apartamento)
        {
            await _service.Insert(apartamento);            
            return CreatedAtAction("FindById", new { id = apartamento.Id }, apartamento);
        }

        // DELETE: api/Apartamentos/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var apartamento = await _service.FindById(id);
            if (apartamento == null)
            {
                return NotFound("Id não encontrado.");
            }
            await _service.Delete(apartamento.Id);
            return Ok();
        }
    }
}
