using Abstracciones.API;
using Abstracciones.BW;
using Abstracciones.Modelos;
using BW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase, ITareaAPI
    {
        private readonly ITareaBW _tareaBW;

        public TareaController(ITareaBW tareaBW)
        {
            _tareaBW = tareaBW;
        }

        [HttpPost]
        public async Task<IActionResult> AgregarAsync([FromBody] Tarea tarea)
        {
            var resultado = await _tareaBW.AgregarAsync(tarea);
            return CreatedAtAction(nameof(Obtener), new { Id = resultado }, tarea);
        }

        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Tarea tarea)
        {
            var tareaExiste = await _tareaBW.ObtenerTodas(tarea.Id);
            if (tareaExiste == null)
                return NotFound();
            return Ok(await _tareaBW.Editar(tarea));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Eliminar([FromRoute] Guid Id)
        {
            var tareaExiste = await _tareaBW.ObtenerTodas(Id);
            if (tareaExiste == null)
                return NotFound();
            await _tareaBW.Eliminar(Id);
            return NoContent();
        }

        [HttpGet("Todas")]
        public async Task<IActionResult> Obtener()
        {
            return Ok(await _tareaBW.Obtener());
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> ObtenerTodas([FromRoute] Guid Id)
        {
            return Ok(await _tareaBW.ObtenerTodas(Id));
        }
    }
}
