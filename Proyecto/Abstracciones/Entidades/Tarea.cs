using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Entidades
{
    public class Tarea
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? FechaIni { get; set; }
        public string? Asignado { get; set; }
        public string? Estado { get; set; }
    }
}
