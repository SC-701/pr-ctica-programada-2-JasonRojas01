using Abstracciones.BC;
using Abstracciones.BW;
using Abstracciones.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW
{
    public class PersonaBW : IPersonaBW
    {
        private IPersonaDA _personaDA;
        private IPersonaBC _personaBC;

        public PersonaBW(IPersonaDA personaDA, IPersonaBC personaBC)
        {
            _personaDA = personaDA;
            _personaBC = personaBC;
        }

        public async Task<Guid> AgregarAsync(Abstracciones.Modelos.Persona persona)
        {
            var personaConFormato = _personaBC.DarFormato(persona);
            return await _personaDA.AgregarAsync(personaConFormato);
        }

        public async Task<Guid> Editar(Abstracciones.Modelos.Persona persona)
        {
            var resultado = await _personaDA.Editar(persona);
            return await _personaDA.Editar(persona);
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            return _personaDA.Eliminar(Id);
        }

        public Task<IEnumerable<Abstracciones.Modelos.Persona>> Obtener()
        {
            return _personaDA.Obtener();
        }

        public Task<Abstracciones.Modelos.Persona> Obtener(Guid Id)
        {
            return _personaDA.Obtener(Id);
        }
    }
}
