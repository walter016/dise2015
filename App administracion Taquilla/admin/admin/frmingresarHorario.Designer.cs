namespace admin
{
    partial class frmingresarHorario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.lblciudad = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttipoSala = new System.Windows.Forms.TextBox();
            this.chorarioPelicula = new System.Windows.Forms.ComboBox();
            this.lhorapeli = new System.Windows.Forms.Label();
            this.cestadopeli = new System.Windows.Forms.ComboBox();
            this.lestado = new System.Windows.Forms.Label();
            this.lfechapeli = new System.Windows.Forms.Label();
            this.cnoSala = new System.Windows.Forms.ComboBox();
            this.lnoSala = new System.Windows.Forms.Label();
            this.csucursal = new System.Windows.Forms.ComboBox();
            this.lsucursal = new System.Windows.Forms.Label();
            this.cnombrePelicula = new System.Windows.Forms.ComboBox();
            this.lnombre = new System.Windows.Forms.Label();
            this.baceptarPelicula = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.beditar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.dgvinfoPeliculas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfoPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpfecha);
            this.groupBox1.Controls.Add(this.cbCiudad);
            this.groupBox1.Controls.Add(this.lblciudad);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttipoSala);
            this.groupBox1.Controls.Add(this.chorarioPelicula);
            this.groupBox1.Controls.Add(this.lhorapeli);
            this.groupBox1.Controls.Add(this.cestadopeli);
            this.groupBox1.Controls.Add(this.lestado);
            this.groupBox1.Controls.Add(this.lfechapeli);
            this.groupBox1.Controls.Add(this.cnoSala);
            this.groupBox1.Controls.Add(this.lnoSala);
            this.groupBox1.Controls.Add(this.csucursal);
            this.groupBox1.Controls.Add(this.lsucursal);
            this.groupBox1.Controls.Add(this.cnombrePelicula);
            this.groupBox1.Controls.Add(this.lnombre);
            this.groupBox1.Controls.Add(this.baceptarPelicula);
            this.groupBox1.Controls.Add(this.bcancelar);
            this.groupBox1.Controls.Add(this.beliminar);
            this.groupBox1.Controls.Add(this.beditar);
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.dgvinfoPeliculas);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horarios";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(546, 111);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(116, 27);
            this.dtpfecha.TabIndex = 69;
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(115, 71);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(277, 27);
            this.cbCiudad.TabIndex = 68;
            this.cbCiudad.TextChanged += new System.EventHandler(this.cbCiudad_TextChanged_1);
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciudad.Location = new System.Drawing.Point(37, 74);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(58, 19);
            this.lblciudad.TabIndex = 67;
            this.lblciudad.Text = "Ciudad:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(16, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(55, 27);
            this.txtid.TabIndex = 66;
            this.txtid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Tipo:";
            // 
            // txttipoSala
            // 
            this.txttipoSala.Enabled = false;
            this.txttipoSala.Location = new System.Drawing.Point(338, 107);
            this.txttipoSala.Name = "txttipoSala";
            this.txttipoSala.Size = new System.Drawing.Size(54, 27);
            this.txttipoSala.TabIndex = 64;
            // 
            // chorarioPelicula
            // 
            this.chorarioPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chorarioPelicula.FormattingEnabled = true;
            this.chorarioPelicula.Items.AddRange(new object[] {
            "2:00 PM - 3:30 PM",
            "4:00 PM - 5:30 PM",
            "6:00 PM - 7:30 PM",
            "8:00 PM - 9:30 PM",
            "-------------------",
            "1:30 PM - 3:30 PM",
            "4:00 PM - 6:30 PM",
            "7:30 PM - 9:00 PM"});
            this.chorarioPelicula.Location = new System.Drawing.Point(546, 144);
            this.chorarioPelicula.Name = "chorarioPelicula";
            this.chorarioPelicula.Size = new System.Drawing.Size(188, 27);
            this.chorarioPelicula.TabIndex = 63;
            // 
            // lhorapeli
            // 
            this.lhorapeli.AutoSize = true;
            this.lhorapeli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhorapeli.Location = new System.Drawing.Point(409, 147);
            this.lhorapeli.Name = "lhorapeli";
            this.lhorapeli.Size = new System.Drawing.Size(99, 19);
            this.lhorapeli.TabIndex = 62;
            this.lhorapeli.Text = "Hora Pelicula:";
            // 
            // cestadopeli
            // 
            this.cestadopeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cestadopeli.FormattingEnabled = true;
            this.cestadopeli.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cestadopeli.Location = new System.Drawing.Point(115, 144);
            this.cestadopeli.Name = "cestadopeli";
            this.cestadopeli.Size = new System.Drawing.Size(188, 27);
            this.cestadopeli.TabIndex = 61;
            // 
            // lestado
            // 
            this.lestado.AutoSize = true;
            this.lestado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lestado.Location = new System.Drawing.Point(38, 144);
            this.lestado.Name = "lestado";
            this.lestado.Size = new System.Drawing.Size(57, 19);
            this.lestado.TabIndex = 60;
            this.lestado.Text = "Estado:";
            // 
            // lfechapeli
            // 
            this.lfechapeli.AutoSize = true;
            this.lfechapeli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfechapeli.Location = new System.Drawing.Point(409, 110);
            this.lfechapeli.Name = "lfechapeli";
            this.lfechapeli.Size = new System.Drawing.Size(126, 19);
            this.lfechapeli.TabIndex = 59;
            this.lfechapeli.Text = "Fecha Asignacion:";
            // 
            // cnoSala
            // 
            this.cnoSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cnoSala.FormattingEnabled = true;
            this.cnoSala.Location = new System.Drawing.Point(115, 107);
            this.cnoSala.Name = "cnoSala";
            this.cnoSala.Size = new System.Drawing.Size(136, 27);
            this.cnoSala.TabIndex = 58;
            this.cnoSala.TextChanged += new System.EventHandler(this.cnoSala_TextChanged_1);
            // 
            // lnoSala
            // 
            this.lnoSala.AutoSize = true;
            this.lnoSala.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnoSala.Location = new System.Drawing.Point(29, 111);
            this.lnoSala.Name = "lnoSala";
            this.lnoSala.Size = new System.Drawing.Size(66, 19);
            this.lnoSala.TabIndex = 57;
            this.lnoSala.Text = "No. Sala:";
            // 
            // csucursal
            // 
            this.csucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.csucursal.FormattingEnabled = true;
            this.csucursal.Location = new System.Drawing.Point(482, 71);
            this.csucursal.Name = "csucursal";
            this.csucursal.Size = new System.Drawing.Size(252, 27);
            this.csucursal.TabIndex = 56;
            // 
            // lsucursal
            // 
            this.lsucursal.AutoSize = true;
            this.lsucursal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsucursal.Location = new System.Drawing.Point(409, 74);
            this.lsucursal.Name = "lsucursal";
            this.lsucursal.Size = new System.Drawing.Size(67, 19);
            this.lsucursal.TabIndex = 55;
            this.lsucursal.Text = "Sucursal:";
            // 
            // cnombrePelicula
            // 
            this.cnombrePelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cnombrePelicula.FormattingEnabled = true;
            this.cnombrePelicula.Location = new System.Drawing.Point(261, 26);
            this.cnombrePelicula.Name = "cnombrePelicula";
            this.cnombrePelicula.Size = new System.Drawing.Size(300, 27);
            this.cnombrePelicula.TabIndex = 54;
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombre.Location = new System.Drawing.Point(136, 29);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(119, 19);
            this.lnombre.TabIndex = 53;
            this.lnombre.Text = "Nombre Pelicula:";
            // 
            // baceptarPelicula
            // 
            this.baceptarPelicula.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptarPelicula.Image = global::admin.Properties.Resources.aceptar;
            this.baceptarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baceptarPelicula.Location = new System.Drawing.Point(335, 428);
            this.baceptarPelicula.Name = "baceptarPelicula";
            this.baceptarPelicula.Size = new System.Drawing.Size(110, 50);
            this.baceptarPelicula.TabIndex = 48;
            this.baceptarPelicula.Text = "       Aceptar";
            this.baceptarPelicula.UseVisualStyleBackColor = true;
            this.baceptarPelicula.Click += new System.EventHandler(this.baceptarPelicula_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Enabled = false;
            this.bcancelar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.Image = global::admin.Properties.Resources.cancelar;
            this.bcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcancelar.Location = new System.Drawing.Point(567, 428);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(110, 50);
            this.bcancelar.TabIndex = 47;
            this.bcancelar.Text = "          Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Enabled = false;
            this.beliminar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.Image = global::admin.Properties.Resources.eliminar;
            this.beliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beliminar.Location = new System.Drawing.Point(451, 428);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(110, 50);
            this.beliminar.TabIndex = 46;
            this.beliminar.Text = "          Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // beditar
            // 
            this.beditar.Enabled = false;
            this.beditar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beditar.Image = global::admin.Properties.Resources.editar1;
            this.beditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beditar.Location = new System.Drawing.Point(219, 428);
            this.beditar.Name = "beditar";
            this.beditar.Size = new System.Drawing.Size(110, 50);
            this.beditar.TabIndex = 45;
            this.beditar.Text = "          Editar";
            this.beditar.UseVisualStyleBackColor = true;
            this.beditar.Click += new System.EventHandler(this.beditar_Click);
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Image = global::admin.Properties.Resources.save;
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(103, 428);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(110, 50);
            this.bguardar.TabIndex = 40;
            this.bguardar.Text = "          Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // dgvinfoPeliculas
            // 
            this.dgvinfoPeliculas.AllowUserToOrderColumns = true;
            this.dgvinfoPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfoPeliculas.Location = new System.Drawing.Point(90, 187);
            this.dgvinfoPeliculas.Name = "dgvinfoPeliculas";
            this.dgvinfoPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvinfoPeliculas.Size = new System.Drawing.Size(614, 226);
            this.dgvinfoPeliculas.TabIndex = 28;
            this.dgvinfoPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmingresarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 518);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmingresarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Horarios";
            this.Load += new System.EventHandler(this.frmingresarHorario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfoPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.DataGridView dgvinfoPeliculas;
        public System.Windows.Forms.Button bcancelar;
        public System.Windows.Forms.Button beliminar;
        public System.Windows.Forms.Button beditar;
        private System.Windows.Forms.Button baceptarPelicula;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        public System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttipoSala;
        public System.Windows.Forms.ComboBox chorarioPelicula;
        private System.Windows.Forms.Label lhorapeli;
        public System.Windows.Forms.ComboBox cestadopeli;
        private System.Windows.Forms.Label lestado;
        private System.Windows.Forms.Label lfechapeli;
        public System.Windows.Forms.ComboBox cnoSala;
        private System.Windows.Forms.Label lnoSala;
        public System.Windows.Forms.ComboBox csucursal;
        private System.Windows.Forms.Label lsucursal;
        public System.Windows.Forms.ComboBox cnombrePelicula;
        private System.Windows.Forms.Label lnombre;
    }
}