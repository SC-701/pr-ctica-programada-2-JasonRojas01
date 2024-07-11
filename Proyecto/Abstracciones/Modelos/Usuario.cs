//using Abstracciones.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class Usuario
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string? Nombre { get; set; }

        [Required]
        public string? Correo { get; set; }
    }
}
