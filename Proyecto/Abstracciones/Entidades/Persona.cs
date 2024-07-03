using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Entidades
{
    public interface Persona
    {
        public Guid Id { get; set; }

        public string? Nombre { get; set; }

        public string? Extracto { get; set; } // Es como una descripcion acerca de mi

        public int? Contacto { get; set; } // se va tomar como # de telefono unicamente

        public string? Foto { get; set; }
    }
}
