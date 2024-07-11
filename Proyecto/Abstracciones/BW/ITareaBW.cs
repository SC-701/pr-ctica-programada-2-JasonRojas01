using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.BW
{
    public interface ITareaBW
    {
        public Task<IEnumerable<Tarea>> Obtener();
        public Task<Tarea> ObtenerTodas(Guid Id);
        public Task<Guid> AgregarAsync(Tarea tarea);
        public Task<Guid> Editar(Tarea tarea);
        public Task<Guid> Eliminar(Guid Id);
    }
}
