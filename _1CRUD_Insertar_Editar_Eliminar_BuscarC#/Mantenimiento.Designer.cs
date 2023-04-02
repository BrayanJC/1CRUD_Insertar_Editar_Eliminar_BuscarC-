namespace _1CRUD_Insertar_Editar_Eliminar_Buscar_
{
    partial class Mantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BNT_Guardar = new System.Windows.Forms.Button();
            this.CMB_Tipo = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TXT_Tratamiento = new System.Windows.Forms.TextBox();
            this.TXT_Apellido = new System.Windows.Forms.TextBox();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PIB_Imagen = new System.Windows.Forms.PictureBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIB_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // BNT_Guardar
            // 
            this.BNT_Guardar.BackColor = System.Drawing.Color.DarkCyan;
            this.BNT_Guardar.FlatAppearance.BorderSize = 0;
            this.BNT_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNT_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNT_Guardar.ForeColor = System.Drawing.Color.White;
            this.BNT_Guardar.Location = new System.Drawing.Point(120, 374);
            this.BNT_Guardar.Name = "BNT_Guardar";
            this.BNT_Guardar.Size = new System.Drawing.Size(239, 40);
            this.BNT_Guardar.TabIndex = 28;
            this.BNT_Guardar.Text = "Insertar";
            this.BNT_Guardar.UseVisualStyleBackColor = false;
            this.BNT_Guardar.Click += new System.EventHandler(this.BNT_Guardar_Click);
            // 
            // CMB_Tipo
            // 
            this.CMB_Tipo.BackColor = System.Drawing.Color.White;
            this.CMB_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Tipo.FormattingEnabled = true;
            this.CMB_Tipo.Items.AddRange(new object[] {
            "Niño",
            "Joven",
            "Adulto"});
            this.CMB_Tipo.Location = new System.Drawing.Point(121, 283);
            this.CMB_Tipo.Name = "CMB_Tipo";
            this.CMB_Tipo.Size = new System.Drawing.Size(287, 23);
            this.CMB_Tipo.TabIndex = 26;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(30, 312);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 16);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "Tratamiento";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(30, 283);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(36, 16);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "Tipo";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(30, 256);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 16);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Apellidos";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(30, 229);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 16);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Nombre";
            // 
            // TXT_Tratamiento
            // 
            this.TXT_Tratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Tratamiento.Location = new System.Drawing.Point(121, 312);
            this.TXT_Tratamiento.Name = "TXT_Tratamiento";
            this.TXT_Tratamiento.Size = new System.Drawing.Size(287, 21);
            this.TXT_Tratamiento.TabIndex = 27;
            // 
            // TXT_Apellido
            // 
            this.TXT_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Apellido.Location = new System.Drawing.Point(121, 256);
            this.TXT_Apellido.Name = "TXT_Apellido";
            this.TXT_Apellido.Size = new System.Drawing.Size(287, 21);
            this.TXT_Apellido.TabIndex = 25;
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Nombre.Location = new System.Drawing.Point(121, 229);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(287, 21);
            this.TXT_Nombre.TabIndex = 24;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(248, 176);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(69, 13);
            this.LinkLabel1.TabIndex = 34;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Subir Imagen";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // PIB_Imagen
            // 
            this.PIB_Imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.PIB_Imagen.Image = global::_1CRUD_Insertar_Editar_Eliminar_Buscar_.Properties.Resources.userProfile;
            this.PIB_Imagen.Location = new System.Drawing.Point(167, 25);
            this.PIB_Imagen.Name = "PIB_Imagen";
            this.PIB_Imagen.Size = new System.Drawing.Size(150, 143);
            this.PIB_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIB_Imagen.TabIndex = 29;
            this.PIB_Imagen.TabStop = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Location = new System.Drawing.Point(12, 13);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(423, 423);
            this.GroupBox1.TabIndex = 23;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos del Paciente";
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 448);
            this.Controls.Add(this.BNT_Guardar);
            this.Controls.Add(this.CMB_Tipo);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TXT_Tratamiento);
            this.Controls.Add(this.TXT_Apellido);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.PIB_Imagen);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.PIB_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BNT_Guardar;
        internal System.Windows.Forms.ComboBox CMB_Tipo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TXT_Tratamiento;
        internal System.Windows.Forms.TextBox TXT_Apellido;
        internal System.Windows.Forms.TextBox TXT_Nombre;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.PictureBox PIB_Imagen;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}