using Abstracciones.API;
using Abstracciones.BW;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase, IUsuarioAPI
    {
        private IUsuarioBW _usuarioBW;

        public UsuarioController(IUsuarioBW usuarioBW)
        {
            _usuarioBW = usuarioBW;
        }

        [HttpPost]
        public async Task<IActionResult> AgregarAsync(Usuario usuario)
        {
            var resultado = await _usuarioBW.AgregarAsync(usuario);
            return CreatedAtAction(nameof(Obtener), new { Id = resultado }, usuario);
        }

        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
           return Ok(await _usuarioBW.Obtener());
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid Id)
        {
            return Ok(await _usuarioBW.Obtener(Id));
        }
    }
}
