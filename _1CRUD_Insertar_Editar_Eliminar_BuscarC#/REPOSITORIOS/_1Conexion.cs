using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CRUD_Insertar_Editar_Eliminar_Buscar_.REPOSITORIOS
{
    public abstract partial class _1Conexion
    {
        private string CadenaConexion;
        public _1Conexion()
        {
            CadenaConexion = "Server=(local);DataBase=CRUD_Example; Integrated Security=true";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}




