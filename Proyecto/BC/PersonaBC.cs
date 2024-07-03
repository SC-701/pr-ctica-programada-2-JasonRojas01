using Abstracciones.BC;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC
{
    public class PersonaBC : IPersonaBC
    {
        public Persona DarFormato(Persona persona)
        {
            persona.Nombre = NombreMayuscula(persona.Nombre);
            return persona;
        }

        private string NombreMayuscula(string nombre)
        {
            return nombre.ToUpper();
        }
    }
}
