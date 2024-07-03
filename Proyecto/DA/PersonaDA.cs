using Abstracciones.DA;
using Dapper;
using Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public  class PersonaDA : IPersonaDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public PersonaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorioDapper();
        }

        public async Task<Guid> AgregarAsync(Abstracciones.Modelos.Persona persona)
        {
            string sql = @"AgregarPersona";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Persona>(sql, new { Id = persona.Id, Nombre = persona.Nombre });
            return persona.Id;
        }

        public async Task<Guid> Editar(Abstracciones.Modelos.Persona persona)
        {
            string sql = @"ActualizarPersona";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Persona>(sql, new { Id = persona.Id, Nombre = persona.Nombre });
            return persona.Id;
        }

        public async Task<Guid> Eliminar(Guid Id)
        {
            string sql = @"EliminarPersona";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Persona>(sql, new { Id = Id });
            return Id;
        }

        public async Task<IEnumerable<Abstracciones.Modelos.Persona>> Obtener()
        {
            string sql = @"ObtenerTodosPersona";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Persona>(sql);
            if (!resultadoConsulta.Any())
                return null;
            return ConvertirPersonaAModelo(resultadoConsulta);
        }

        public async Task<Abstracciones.Modelos.Persona> Obtener(Guid Id)
        {
            string sql = @"ObtenerPersona";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Persona>(sql, new { Id = Id });
            if (!resultadoConsulta.Any())
                return null;
            return ConvertirPersonaAModelo(resultadoConsulta.First());
        }

        #region Convertidores

        private Abstracciones.Modelos.Persona ConvertirPersonaAModelo(Abstracciones.Entidades.Persona persona)
        {
            var resultadoConversion = Convertidor.Convertir<Abstracciones.Entidades.Persona, Abstracciones.Modelos.Persona>(persona);
            return resultadoConversion;
        }
        private IEnumerable<Abstracciones.Modelos.Persona> ConvertirPersonaAModelo(IEnumerable<Abstracciones.Entidades.Persona> persona)
        {
            var resultadoConversion = Convertidor.ConvertirLista<Abstracciones.Entidades.Persona, Abstracciones.Modelos.Persona>(persona);
            return resultadoConversion;
        }
        #endregion
    }
}