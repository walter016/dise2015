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
            this.bcancelar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.beditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttipoSala = new System.Windows.Forms.TextBox();
            this.chorarioPelicula = new System.Windows.Forms.ComboBox();
            this.bguardar = new System.Windows.Forms.Button();
            this.dgvinfoPeliculas = new System.Windows.Forms.DataGridView();
            this.lhorapeli = new System.Windows.Forms.Label();
            this.cestadopeli = new System.Windows.Forms.ComboBox();
            this.lestado = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.lfechapeli = new System.Windows.Forms.Label();
            this.cnoSala = new System.Windows.Forms.ComboBox();
            this.lnoSala = new System.Windows.Forms.Label();
            this.csucursal = new System.Windows.Forms.ComboBox();
            this.lsucursal = new System.Windows.Forms.Label();
            this.cnombrePelicula = new System.Windows.Forms.ComboBox();
            this.lnombre = new System.Windows.Forms.Label();
            this.baceptarPelicula = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfoPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.baceptarPelicula);
            this.groupBox1.Controls.Add(this.bcancelar);
            this.groupBox1.Controls.Add(this.beliminar);
            this.groupBox1.Controls.Add(this.beditar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttipoSala);
            this.groupBox1.Controls.Add(this.chorarioPelicula);
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.dgvinfoPeliculas);
            this.groupBox1.Controls.Add(this.lhorapeli);
            this.groupBox1.Controls.Add(this.cestadopeli);
            this.groupBox1.Controls.Add(this.lestado);
            this.groupBox1.Controls.Add(this.dtpfecha);
            this.groupBox1.Controls.Add(this.lfechapeli);
            this.groupBox1.Controls.Add(this.cnoSala);
            this.groupBox1.Controls.Add(this.lnoSala);
            this.groupBox1.Controls.Add(this.csucursal);
            this.groupBox1.Controls.Add(this.lsucursal);
            this.groupBox1.Controls.Add(this.cnombrePelicula);
            this.groupBox1.Controls.Add(this.lnombre);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horarios";
            // 
            // bcancelar
            // 
            this.bcancelar.Enabled = false;
            this.bcancelar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.Image = global::admin.Properties.Resources.cancelar;
            this.bcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcancelar.Location = new System.Drawing.Point(606, 374);
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
            this.beliminar.Location = new System.Drawing.Point(490, 374);
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
            this.beditar.Location = new System.Drawing.Point(258, 374);
            this.beditar.Name = "beditar";
            this.beditar.Size = new System.Drawing.Size(110, 50);
            this.beditar.TabIndex = 45;
            this.beditar.Text = "          Editar";
            this.beditar.UseVisualStyleBackColor = true;
            this.beditar.Click += new System.EventHandler(this.beditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tipo:";
            // 
            // txttipoSala
            // 
            this.txttipoSala.Enabled = false;
            this.txttipoSala.Location = new System.Drawing.Point(351, 64);
            this.txttipoSala.Name = "txttipoSala";
            this.txttipoSala.Size = new System.Drawing.Size(54, 27);
            this.txttipoSala.TabIndex = 43;
            // 
            // chorarioPelicula
            // 
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
            this.chorarioPelicula.Location = new System.Drawing.Point(555, 100);
            this.chorarioPelicula.Name = "chorarioPelicula";
            this.chorarioPelicula.Size = new System.Drawing.Size(188, 27);
            this.chorarioPelicula.TabIndex = 42;
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Image = global::admin.Properties.Resources.save;
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(142, 374);
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
            this.dgvinfoPeliculas.Location = new System.Drawing.Point(129, 133);
            this.dgvinfoPeliculas.Name = "dgvinfoPeliculas";
            this.dgvinfoPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvinfoPeliculas.Size = new System.Drawing.Size(614, 226);
            this.dgvinfoPeliculas.TabIndex = 28;
            this.dgvinfoPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lhorapeli
            // 
            this.lhorapeli.AutoSize = true;
            this.lhorapeli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhorapeli.Location = new System.Drawing.Point(450, 100);
            this.lhorapeli.Name = "lhorapeli";
            this.lhorapeli.Size = new System.Drawing.Size(99, 19);
            this.lhorapeli.TabIndex = 26;
            this.lhorapeli.Text = "Hora Pelicula:";
            // 
            // cestadopeli
            // 
            this.cestadopeli.FormattingEnabled = true;
            this.cestadopeli.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cestadopeli.Location = new System.Drawing.Point(162, 97);
            this.cestadopeli.Name = "cestadopeli";
            this.cestadopeli.Size = new System.Drawing.Size(188, 27);
            this.cestadopeli.TabIndex = 25;
            // 
            // lestado
            // 
            this.lestado.AutoSize = true;
            this.lestado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lestado.Location = new System.Drawing.Point(99, 100);
            this.lestado.Name = "lestado";
            this.lestado.Size = new System.Drawing.Size(57, 19);
            this.lestado.TabIndex = 24;
            this.lestado.Text = "Estado:";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(555, 63);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(119, 27);
            this.dtpfecha.TabIndex = 23;
            this.dtpfecha.Value = new System.DateTime(2015, 8, 15, 0, 0, 0, 0);
            // 
            // lfechapeli
            // 
            this.lfechapeli.AutoSize = true;
            this.lfechapeli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfechapeli.Location = new System.Drawing.Point(423, 67);
            this.lfechapeli.Name = "lfechapeli";
            this.lfechapeli.Size = new System.Drawing.Size(126, 19);
            this.lfechapeli.TabIndex = 22;
            this.lfechapeli.Text = "Fecha Asignacion:";
            // 
            // cnoSala
            // 
            this.cnoSala.FormattingEnabled = true;
            this.cnoSala.Location = new System.Drawing.Point(162, 64);
            this.cnoSala.Name = "cnoSala";
            this.cnoSala.Size = new System.Drawing.Size(136, 27);
            this.cnoSala.TabIndex = 21;
            this.cnoSala.TextChanged += new System.EventHandler(this.cnoSala_TextChanged);
            // 
            // lnoSala
            // 
            this.lnoSala.AutoSize = true;
            this.lnoSala.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnoSala.Location = new System.Drawing.Point(89, 67);
            this.lnoSala.Name = "lnoSala";
            this.lnoSala.Size = new System.Drawing.Size(66, 19);
            this.lnoSala.TabIndex = 20;
            this.lnoSala.Text = "No. Sala:";
            // 
            // csucursal
            // 
            this.csucursal.FormattingEnabled = true;
            this.csucursal.Location = new System.Drawing.Point(555, 30);
            this.csucursal.Name = "csucursal";
            this.csucursal.Size = new System.Drawing.Size(224, 27);
            this.csucursal.TabIndex = 19;
            // 
            // lsucursal
            // 
            this.lsucursal.AutoSize = true;
            this.lsucursal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsucursal.Location = new System.Drawing.Point(482, 33);
            this.lsucursal.Name = "lsucursal";
            this.lsucursal.Size = new System.Drawing.Size(67, 19);
            this.lsucursal.TabIndex = 18;
            this.lsucursal.Text = "Sucursal:";
            // 
            // cnombrePelicula
            // 
            this.cnombrePelicula.FormattingEnabled = true;
            this.cnombrePelicula.Location = new System.Drawing.Point(161, 30);
            this.cnombrePelicula.Name = "cnombrePelicula";
            this.cnombrePelicula.Size = new System.Drawing.Size(300, 27);
            this.cnombrePelicula.TabIndex = 17;
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombre.Location = new System.Drawing.Point(36, 33);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(119, 19);
            this.lnombre.TabIndex = 1;
            this.lnombre.Text = "Nombre Pelicula:";
            // 
            // baceptarPelicula
            // 
            this.baceptarPelicula.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptarPelicula.Image = global::admin.Properties.Resources.aceptar;
            this.baceptarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baceptarPelicula.Location = new System.Drawing.Point(374, 374);
            this.baceptarPelicula.Name = "baceptarPelicula";
            this.baceptarPelicula.Size = new System.Drawing.Size(110, 50);
            this.baceptarPelicula.TabIndex = 48;
            this.baceptarPelicula.Text = "       Aceptar";
            this.baceptarPelicula.UseVisualStyleBackColor = true;
            this.baceptarPelicula.Click += new System.EventHandler(this.baceptarPelicula_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(28, 65);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(55, 27);
            this.txtid.TabIndex = 49;
            this.txtid.Visible = false;
            // 
            // frmingresarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 482);
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
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label lhorapeli;
        public System.Windows.Forms.ComboBox cestadopeli;
        private System.Windows.Forms.Label lestado;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lfechapeli;
        public System.Windows.Forms.ComboBox cnoSala;
        private System.Windows.Forms.Label lnoSala;
        public System.Windows.Forms.ComboBox csucursal;
        private System.Windows.Forms.Label lsucursal;
        public System.Windows.Forms.ComboBox cnombrePelicula;
        public System.Windows.Forms.Button bguardar;
        public System.Windows.Forms.ComboBox chorarioPelicula;
        private System.Windows.Forms.TextBox txttipoSala;
        private System.Windows.Forms.DataGridView dgvinfoPeliculas;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bcancelar;
        public System.Windows.Forms.Button beliminar;
        public System.Windows.Forms.Button beditar;
        private System.Windows.Forms.Button baceptarPelicula;
        private System.Windows.Forms.TextBox txtid;
    }
}