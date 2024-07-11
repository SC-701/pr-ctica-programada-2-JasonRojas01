using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.BW
{
    public interface IUsuarioBW
    {
        public Task<IEnumerable<Usuario>> Obtener();
        public Task<Usuario> Obtener(Guid Id);
        public Task<Guid> AgregarAsync(Usuario usuario);

    }
}
