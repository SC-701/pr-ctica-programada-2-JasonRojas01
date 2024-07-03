using Abstracciones.API;
using Abstracciones.BW;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase, IPersonaAPI
    {
        private IPersonaBW _personaBW;

        public PersonaController(IPersonaBW personaBW)
        {
            _personaBW = personaBW;
        }
        [HttpPost]
        public async Task<IActionResult> AgregarAsync([FromBody] Persona persona)
        {
            var resultado = await _personaBW.AgregarAsync(persona);
            return CreatedAtAction(nameof(Obtener), new { Id = resultado }, persona);
        }
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Abstracciones.Modelos.Persona persona)
        {
            var personaExiste = await _personaBW.Obtener(persona.Id);
            if (personaExiste == null)
                return NotFound();
            return Ok(await _personaBW.Editar(persona));
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Eliminar([FromRoute] Guid Id)
        {
            var personaExiste = await _personaBW.Obtener(Id);
            if (personaExiste == null)
                return NotFound();
            await _personaBW.Eliminar(Id);
            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            return Ok(await _personaBW.Obtener());
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid Id)
        {
            return Ok(await _personaBW.Obtener(Id));
        }
    }
}
