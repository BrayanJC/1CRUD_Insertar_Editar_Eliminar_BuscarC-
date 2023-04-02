using _1CRUD_Insertar_Editar_Eliminar_Buscar_.REPOSITORIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1CRUD_Insertar_Editar_Eliminar_Buscar_
{
    public partial class Mantenimiento : Form
    {

        public Mantenimiento()
        {
            InitializeComponent();
        }
        public _4Valores Estado;
        public int id = 0;
        private Image defaultPhoto = Properties.Resources.userProfile;


        private byte[] ConvertirImg()
        {
            var ms = new MemoryStream();
            PIB_Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }

        private void BNT_Guardar_Click(object sender, EventArgs e)
        {
            if (TXT_Nombre.Text != "" & TXT_Apellido.Text != "" & CMB_Tipo.Text != "" & TXT_Tratamiento.Text != "")
            {
                if (MessageBox.Show("Se realizará el proceso, ¿Está seguro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Pacinte_Ejecutar();
                }
            }
            else
            {
                MessageBox.Show("¡Error!, No Pueden Haber Campos Vacíos", "Llene Todos Los Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Pacinte_Ejecutar()
        {
            try
            {
                switch (Estado)
                {
                    case var @case when @case == _4Valores.Agregar:
                        {
                            AGREGAR();
                            break;
                        }
                    case var case1 when case1 == _4Valores.Editar:
                        {
                            EDITAR();
                            break;
                        }
                    case var case2 when case2 == _4Valores.Borrar:
                        {
                            ELIMINAR();
                            break;
                        }
                }
            }
            catch (Exception)
            {
            }
        }





        public void AGREGAR()
        {
            try
            {
                var obj = new _3Funciones();
                Estado = _4Valores.Agregar;
                obj.estado = Estado;
                obj.Nombres1 = TXT_Nombre.Text;
                obj.Apellidos1 = TXT_Apellido.Text;
                obj.Tipo1 = CMB_Tipo.Text;
                obj.Tratamiento1 = TXT_Tratamiento.Text;
                obj.Imagen1 = ConvertirImg();
                obj.Grabar_PACIENTE();
                limpiar();
                this.Close();
            }
            catch (Exception)
            {
            }
        }




        public void EDITAR()
        {
            try
            {
                var obj = new _3Funciones();
                Estado = _4Valores.Editar;
                obj.estado = Estado;
                obj.Id1 = id;
                obj.Nombres1 = TXT_Nombre.Text;
                obj.Apellidos1 = TXT_Apellido.Text;
                obj.Tipo1 = CMB_Tipo.Text;
                obj.Tratamiento1 = TXT_Tratamiento.Text;
                obj.Imagen1 = ConvertirImg();
                obj.Grabar_PACIENTE();
                limpiar();
                this.Close();
            }
            catch (Exception)
            {
            }
        }



        public void ELIMINAR()
        {
            try
            {
                var obj = new _3Funciones();
                Estado = _4Valores.Borrar;
                obj.estado = Estado;
                obj.Id1 = id;
                obj.Grabar_PACIENTE();
                limpiar();
                this.Close();
            }
            catch (Exception)
            {
            }
        }
        public void limpiar()
        {
            TXT_Nombre.Text = "";
            TXT_Apellido.Text = "";
            CMB_Tipo.Text = "";
            TXT_Tratamiento.Text = "";
            PIB_Imagen.Image = defaultPhoto;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PIB_Imagen.Image = new Bitmap(openFile.FileName);
            }
        }
    }
}
