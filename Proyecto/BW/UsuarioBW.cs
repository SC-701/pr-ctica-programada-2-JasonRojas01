
using Abstracciones.BW;
using Abstracciones.DA;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW
{
    public class UsuarioBW : IUsuarioBW
    {
        private IUsuarioDA _usuarioDA;

        public UsuarioBW(IUsuarioDA usuarioDA)
        {
            _usuarioDA = usuarioDA;
        }

        public async Task<Guid> AgregarAsync(Abstracciones.Modelos.Usuario usuario)
        {
            return await _usuarioDA.AgregarAsync(usuario);
        }

        public Task<IEnumerable<Abstracciones.Modelos.Usuario>> Obtener()
        {
            return _usuarioDA.Obtener();
        }

        public Task<Abstracciones.Modelos.Usuario> Obtener(Guid Id)
        {
            return _usuarioDA.Obtener(Id);
        }
    }
}
