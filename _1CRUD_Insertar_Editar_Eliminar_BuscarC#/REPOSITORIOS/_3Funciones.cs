using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1CRUD_Insertar_Editar_Eliminar_Buscar_.REPOSITORIOS
{
    
    public class _3Funciones :_2RepositorioMaestro
    {
        public _4Valores estado;
        // '''Paciente 
        private int Id;
        private string Nombres;
        private string Apellidos;
        private string Tipo;
        private string Tratamiento;
        private byte[] Imagen;

        public int Id1 { get => Id; set => Id = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Tratamiento1 { get => Tratamiento; set => Tratamiento = value; }
        public byte[] Imagen1 { get => Imagen; set => Imagen = value; }

       public void INSERTAR()
        {
            string TransactSQL = " insert into DBPacientes values (@Nombres, @Apellidos, @Tipo, @Tratamiento, @Imagen)";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombres", Nombres1));
            parametros.Add(new SqlParameter("@Apellidos", Apellidos1));
            parametros.Add(new SqlParameter("@Tipo", Tipo1));
            parametros.Add(new SqlParameter("@Tratamiento", Tratamiento1));
            parametros.Add(new SqlParameter("@Imagen", Imagen1));
            ExecuteNonQuery(TransactSQL);
        }
        public void EDITAR()
        {
            string TransactSQL = " UPDATE DBPacientes SET Nombres=@Nombres, Apellidos=@Apellidos, Tipo=@Tipo, Tratamiento=@Tratamiento, Imagen=@Imagen WHERE Id = @Id";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombres", Nombres1));
            parametros.Add(new SqlParameter("@Apellidos", Apellidos1));
            parametros.Add(new SqlParameter("@Tipo", Tipo1));
            parametros.Add(new SqlParameter("@Tratamiento", Tratamiento1));
            parametros.Add(new SqlParameter("@Imagen", Imagen1));
            parametros.Add(new SqlParameter("@Id", Id1));
            ExecuteNonQuery(TransactSQL);
        }
        public void ELIMINAR()
        {
            string TrsnsactSQL = " DELETE FROM DBPacientes WHERE Id = @Id";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Id", Id1));
            ExecuteNonQuery(TrsnsactSQL);
        }
        public DataTable MOSTRAR()
        {
            string TransactSQL = "Select * from DBPacientes";
            return ExecuteReader2(TransactSQL);
        }
        public void Grabar_PACIENTE()
        {
            try
            {
                switch (estado)
                {
                    case var @case when @case == _4Valores.Agregar:
                        {
                            INSERTAR();
                            MessageBox.Show("Paciente grabado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case var case1 when case1 == _4Valores.Editar:
                        {
                            EDITAR();
                            MessageBox.Show("Paciente editado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case var case2 when case2 == _4Valores.Borrar:
                        {
                            ELIMINAR();
                            MessageBox.Show("Paciente borrado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                }
            }
            catch (Exception)
            {                  
            }
        }

    }
}
