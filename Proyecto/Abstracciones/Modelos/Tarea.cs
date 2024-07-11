using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class Tarea
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Descripcion { get; set; }

        [Required]
        public int? FechaIni { get; set; }

        [Required]
        public string? Asignado { get; set; }

        [Required]
        public string? Estado { get; set; }
    }
}
