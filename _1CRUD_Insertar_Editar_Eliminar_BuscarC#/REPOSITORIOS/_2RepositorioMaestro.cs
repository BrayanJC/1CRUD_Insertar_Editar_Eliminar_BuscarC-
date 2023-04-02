using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace _1CRUD_Insertar_Editar_Eliminar_Buscar_.REPOSITORIOS
{
    public partial class _2RepositorioMaestro : _1Conexion
    {
        protected List<SqlParameter> parametros;
        protected void ExecuteNonQuery(string transactSql) // Ejecutar sentencias de texto insert, update, delete con parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parametros)
                        comando.Parameters.Add(item);
                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }
        protected DataTable ExecuteReader(string transactSql) // Devolver tablas ejecutando consultas de texto con parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parametros)
                        comando.Parameters.Add(item);
                    SqlDataReader lector = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }
        protected DataTable ExecuteReader2(string transactSql) // Devolver tablas ejecutando consultas de texto sin parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lector = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }

    }
}
