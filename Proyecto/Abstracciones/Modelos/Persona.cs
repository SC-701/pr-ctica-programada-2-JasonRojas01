using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class Persona
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string? Nombre { get; set; }

        public string? Extracto { get; set; } // Es como una descripcion acerca de mi

        [MaxLength(8, ErrorMessage ="El numero no cumple con los 8 dijitos")]
        public int? Contacto { get; set; } // se va tomar como # de telefono unicamente

        public string? Foto { get; set; }
    }
}
