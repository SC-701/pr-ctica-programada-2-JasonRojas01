using Abstracciones.DA;
using Abstracciones.BW;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW
{
    public class TareaBW : ITareaBW
    {
        private ITareaDA _tareaDA;

        public TareaBW(ITareaDA tareaDA)
        {
            _tareaDA = tareaDA;
        }

        public async Task<Guid> AgregarAsync(Abstracciones.Modelos.Tarea tarea)
        {
            return await _tareaDA.AgregarAsync(tarea);
        }

        public async Task<Guid> Editar(Abstracciones.Modelos.Tarea tarea)
        {
            return await _tareaDA.Editar(tarea);
        }

        public Task<Guid> Eliminar(Guid Id)
            {
            return _tareaDA.Eliminar(Id);
        }

        public Task<IEnumerable<Abstracciones.Modelos.Tarea>> Obtener()
        {
            return _tareaDA.Obtener();
        }

        public Task<Abstracciones.Modelos.Tarea> ObtenerTodas(Guid Id)
        {
            return _tareaDA.ObtenerTodas(Id);
        }
    }
}
