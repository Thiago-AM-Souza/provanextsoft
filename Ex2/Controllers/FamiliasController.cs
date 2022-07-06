using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex2.Models;
using Ex2.Services;

namespace Ex2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliasController : ControllerBase
    {
        private readonly FamiliaService _service;

        public FamiliasController(FamiliaService service)
        {
            _service = service;
        }

        // GET: api/Familias
        [HttpGet]
        public async Task<IEnumerable<Familia>> FindAll()
        {
            return await _service.FindAll();
        }

        // GET: api/Familias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Familia>> FindById(int id)
        {
            var Familia = await _service.FindById(id);
            if (Familia == null)
            {
                return NotFound("Id não encontrado.");
            }
            else
            {
                return Familia;
            }
        }

        //PUT: api/Familias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Familia familia)
        {
            if (id != familia.Id)
            {
                return NotFound("Id não encontrado.");
            }
            await _service.Update(id, familia);
            return CreatedAtAction("Update", new { id = familia.Id }, familia);
        }

        // POST: api/Familias       
        [HttpPost]
        public async Task<ActionResult<Familia>> Insert(Familia familia)
        {
            await _service.Insert(familia);
            return CreatedAtAction("Insert", new { id = familia.Id }, familia);
        }

        // DELETE: api/Familias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var familia = await _service.FindById(id);
            if (familia == null)
            {
                return NotFound("Id não encontrado.");
            }
            await _service.Delete(familia.Id);
            return Ok();
        }
    }
}
