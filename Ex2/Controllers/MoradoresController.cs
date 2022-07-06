using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex2.Models;
using Ex2.Services;

namespace Ex2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoradoresController : ControllerBase
    {
        private readonly MoradorService _service;

        public MoradoresController(MoradorService service)
        {
            _service = service;
        }

        // GET: api/Moradors
        [HttpGet]
        public async Task<IEnumerable<Morador>> FindAll()
        {
            return await _service.FindAll();
        }

        // GET: api/Moradors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Morador>> FindById(int id)
        {
            var morador = await _service.FindById(id);
            if (morador == null)
            {
                return NotFound("Id não encontrado.");
            }
            else
            {
                return morador;
            }
        }

        //PUT: api/Moradors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Morador morador)
        {
            if (id != morador.Id)
            {
                return NotFound("Id não encontrado.");
            }
            await _service.Update(id, morador);
            return CreatedAtAction("Update", new { id = morador.Id }, morador);
        }

        // POST: api/Moradors       
        [HttpPost]
        public async Task<ActionResult<Morador>> Insert(Morador morador)
        {
            await _service.Insert(morador);
            return CreatedAtAction("Insert", new { id = morador.Id }, morador);
        }

        // DELETE: api/Moradors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var morador = await _service.FindById(id);
            if (morador == null)
            {
                return NotFound("Id não encontrado.");
            }
            await _service.Delete(morador.Id);
            return Ok();
        }
    }
}
