using Abstracciones.DA;
using Abstracciones.Modelos;
using Dapper;
using Helpers;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class TareaDA : ITareaDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public TareaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorioDapper();
        }
        public async Task<Guid> AgregarAsync(Abstracciones.Modelos.Tarea tarea)
        {
            string sql = @"CrearTarea";
            await _sqlConnection.QueryAsync<Abstracciones.Entidades.Tarea>(sql, new { Id = tarea.Id, Nombre = tarea.Nombre, Descripcion = tarea.Descripcion, FechaIni = tarea.FechaIni, Asignado = tarea.Asignado, Estado = tarea.Estado });
            return tarea.Id;
        }
        public Task<Guid> Editar(Tarea tarea)
        {
            throw new NotImplementedException();
        }
        public Task<Guid> Eliminar(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tarea>> Obtener()
        {
            string sql = @"SELECT * FROM Tareas";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Tarea>(sql);
            if (!resultadoConsulta.Any())
                return null;
            return ConvertirTareaAModelo(resultadoConsulta);
        }

        public async Task<Tarea> ObtenerTodas(Guid Id)
        {
            string sql = @"SELECT * FROM Tareas WHERE IdUser = @Id";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Tarea>(sql, new { Id = Id });
            if (!resultadoConsulta.Any())
                return null;
            return ConvertirTareaAModelo(resultadoConsulta.First());
        }

        #region Convertidores

        private Abstracciones.Modelos.Tarea ConvertirTareaAModelo(Abstracciones.Entidades.Tarea tarea)
        {
            var resultadoConversion = Convertidor.Convertir<Abstracciones.Entidades.Tarea, Abstracciones.Modelos.Tarea>(tarea);
            return resultadoConversion;
        }
        private IEnumerable<Abstracciones.Modelos.Tarea> ConvertirTareaAModelo(IEnumerable<Abstracciones.Entidades.Tarea> tarea)
        {
            var resultadoConversion = Convertidor.ConvertirLista<Abstracciones.Entidades.Tarea, Abstracciones.Modelos.Tarea>(tarea);
            return resultadoConversion;
        }
        #endregion
    }
}
