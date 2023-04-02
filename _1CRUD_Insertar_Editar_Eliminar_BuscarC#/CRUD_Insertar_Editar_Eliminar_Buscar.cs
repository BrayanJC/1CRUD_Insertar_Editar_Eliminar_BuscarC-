using _1CRUD_Insertar_Editar_Eliminar_Buscar_.REPOSITORIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1CRUD_Insertar_Editar_Eliminar_Buscar_
{
    public partial class CRUD_Insertar_Editar_Eliminar_Buscar : Form
    {
        public CRUD_Insertar_Editar_Eliminar_Buscar()
        {
            InitializeComponent();
        }
        private void ListarDatos()
        {
            var obj = new _3Funciones();
            DataGridView1.DataSource = obj.MOSTRAR();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                var frm = new Mantenimiento();
                frm.Estado = _4Valores.Editar;
                frm.BNT_Guardar.Text = "Editar";
                frm.BNT_Guardar.BackColor = Color.FromArgb(238, 175, 9);
                frm.id = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
                frm.TXT_Nombre.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.TXT_Apellido.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.CMB_Tipo.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.TXT_Tratamiento.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();

                byte[] img = (byte[])DataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                frm.PIB_Imagen.Image = Image.FromStream(ms);
                frm.ShowDialog();
                ListarDatos();
      
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                var frm = new Mantenimiento();
                frm.Estado = _4Valores.Borrar;
                frm.BNT_Guardar.Text = "Eliminar";
                frm.BNT_Guardar.BackColor = Color.FromArgb(255, 0, 0);
                frm.id = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
                frm.TXT_Nombre.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.TXT_Apellido.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.CMB_Tipo.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.TXT_Tratamiento.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();

                byte[] img = (byte[])DataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                frm.PIB_Imagen.Image = Image.FromStream(ms);
                frm.ShowDialog();
                ListarDatos();

            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var frm = new Mantenimiento();
            frm.Estado = _4Valores.Agregar;
            frm.BNT_Guardar.Text = "Insertar";
            frm.BNT_Guardar.BackColor = Color.FromArgb(0, 139, 139);
            ListarDatos();
            frm.ShowDialog();
            ListarDatos();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ListarDatos();
            TextBox3.Clear();
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            FilterData(TextBox3.Text);
        }
        public void FilterData(string valueToSearch)
        {
            using (var cnn = new SqlConnection("Server=(local);DataBase=CRUD_Example; Integrated Security=true"))
            {
                cnn.Open();
                string ConsultaSQL = "Select * from DBPacientes WHERE CONCAT(id,Nombres,Apellidos) like '%" + valueToSearch + "%'";
                var cmd = new SqlCommand(ConsultaSQL, cnn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                DataGridView1.DataSource = table;
                cnn.Close();
            }
        }
        private void CRUD_Insertar_Editar_Eliminar_Buscar_Load(object sender, EventArgs e)
        {
            ListarDatos();
        }
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                TextBox1.Text = (string) DataGridView1.CurrentRow.Cells[1].Value;
                TextBox2.Text = (string) DataGridView1.CurrentRow.Cells[2].Value;
                ComboBox1.Text = (string) DataGridView1.CurrentRow.Cells[3].Value;
                TextBox4.Text = (string) DataGridView1.CurrentRow.Cells[4].Value;
                byte[] img = (byte[]) DataGridView1.CurrentRow.Cells[5].Value;
                var ms = new MemoryStream(img);
                PictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
            }
        }
    }
}
