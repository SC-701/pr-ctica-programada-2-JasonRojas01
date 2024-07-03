using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.DA
{
    public interface IPersonaDA
    {
        public Task<IEnumerable<Persona>> Obtener();
        public Task<Persona> Obtener(Guid Id);
        
        public Task<Guid> AgregarAsync(Persona persona);
        public Task<Guid> Editar(Persona persona);
        public Task<Guid> Eliminar(Guid Id);
    }
}
