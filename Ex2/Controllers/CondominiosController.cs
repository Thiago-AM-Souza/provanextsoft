using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex2.Models;
using Ex2.Services;

namespace Ex2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondominiosController : ControllerBase
    {
        private readonly CondominioService _service;

        public CondominiosController(CondominioService service)
        {
            _service = service;
        }

        // GET: api/Condominios
        [HttpGet]
        public async Task<IEnumerable<Condominio>> FindAll()
        {
            return await _service.FindAll();
        }

        // GET: api/Condominio/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Condominio>> FindById(int id)
        {
            var condominio = await _service.FindById(id);
            if (condominio == null)
            {
                return NotFound("Id não encontrado.");
            }
            else
            {
                return condominio;
            }
        }

        //PUT: api/Condominios/id
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Condominio condominio)
        {
            if (id != condominio.Id)
            {
                return NotFound("Id não encontrado.");
            }
            await _service.Update(id, condominio);
            return CreatedAtAction("Update", new { id = condominio.Id }, condominio);
        }

        // POST: api/Condominios      
        [HttpPost]
        public async Task<ActionResult<Condominio>> Insert(Condominio condominio)
        {
            await _service.Insert(condominio);
            return CreatedAtAction("Insert", new { id = condominio.Id }, condominio);
        }

        // DELETE: api/Condominios/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var condominio = await _service.FindById(id);
            if (condominio == null)
            {
                return NotFound("Id não encontrado.");
            }
            await _service.Delete(condominio.Id);
            return Ok();
        }
    }
}
