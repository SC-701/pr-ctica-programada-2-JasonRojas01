using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.API
{
    public interface IUsuarioAPI
    {
        [HttpGet]
        public Task<IActionResult> Obtener();
        [HttpGet]
        public Task<IActionResult> Obtener(Guid Id);
        [HttpPost]
        public Task<IActionResult> AgregarAsync(Usuario usuario);
    }
}
