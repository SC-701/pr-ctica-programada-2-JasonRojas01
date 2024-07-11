using Abstracciones.DA;
using Abstracciones.Modelos;
using Dapper;
using Helpers;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class UsuarioDA : IUsuarioDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public UsuarioDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorioDapper();
        }

        public async Task<Guid> AgregarAsync(Abstracciones.Modelos.Usuario usuario)
        {
            string sql = @"CrearUsuario";
            await _sqlConnection.QueryAsync<Abstracciones.Entidades.Usuario>(sql, new { Id = usuario.Id, Nombre = usuario.Nombre, Correo = usuario.Correo });
            return usuario.Id;
        }

        public async Task<IEnumerable<Usuario>> Obtener()
        {
            string sql = @"SELECT * FROM Usuario";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Usuario>(sql);
            if (!resultadoConsulta.Any())
                return null;
            return ConvertirUsuarioAModelo(resultadoConsulta);
        }

        public async Task<Usuario> Obtener(Guid Id)
        {
            string sql = @"SELECT * FROM Usuario WHERE Id = @Id";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Usuario>(sql, new { Id = Id });
            if (!resultadoConsulta.Any())
                return null;
            return ConvertirUsuarioAModelo(resultadoConsulta.First());
        }

        #region Convertidores

        private Abstracciones.Modelos.Usuario ConvertirUsuarioAModelo(Abstracciones.Entidades.Usuario usuario)
        {
            var resultadoConversion = Convertidor.Convertir<Abstracciones.Entidades.Usuario, Abstracciones.Modelos.Usuario>(usuario);
            return resultadoConversion;
        }
        private IEnumerable<Abstracciones.Modelos.Usuario> ConvertirUsuarioAModelo(IEnumerable<Abstracciones.Entidades.Usuario> usuario)
        {
            var resultadoConversion = Convertidor.ConvertirLista<Abstracciones.Entidades.Usuario, Abstracciones.Modelos.Usuario>(usuario);
            return resultadoConversion;
        }
        #endregion
    }
}
