namespace admin
{
    partial class frmregistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmregistroUsuario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.brefrescar = new System.Windows.Forms.Button();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.beliminar = new System.Windows.Forms.Button();
            this.beditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtipousuario = new System.Windows.Forms.ComboBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bguardar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.txtbusuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grdbuscarempleado = new System.Windows.Forms.DataGridView();
            this.txtbidemp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbapellido = new System.Windows.Forms.TextBox();
            this.txtbnombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.baceptarPelicula = new System.Windows.Forms.Button();
            this.btnbuscaremp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdbuscarempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 468);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.brefrescar);
            this.tabPage1.Controls.Add(this.txtidempleado);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.beliminar);
            this.tabPage1.Controls.Add(this.beditar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbtipousuario);
            this.tabPage1.Controls.Add(this.txtpassword);
            this.tabPage1.Controls.Add(this.txtusuario);
            this.tabPage1.Controls.Add(this.txtapellido);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bguardar);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro Empleado";
            // 
            // brefrescar
            // 
            this.brefrescar.Image = global::admin.Properties.Resources.refresh1;
            this.brefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brefrescar.Location = new System.Drawing.Point(338, 359);
            this.brefrescar.Name = "brefrescar";
            this.brefrescar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brefrescar.Size = new System.Drawing.Size(107, 50);
            this.brefrescar.TabIndex = 39;
            this.brefrescar.Text = "Refrescar";
            this.brefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brefrescar.UseVisualStyleBackColor = true;
            this.brefrescar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtidempleado
            // 
            this.txtidempleado.Enabled = false;
            this.txtidempleado.Location = new System.Drawing.Point(350, 92);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(178, 23);
            this.txtidempleado.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(255, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "Id Empleado";
            // 
            // beliminar
            // 
            this.beliminar.Enabled = false;
            this.beliminar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.Image = global::admin.Properties.Resources.eliminar;
            this.beliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beliminar.Location = new System.Drawing.Point(338, 303);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(107, 50);
            this.beliminar.TabIndex = 36;
            this.beliminar.Text = "         Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // beditar
            // 
            this.beditar.Enabled = false;
            this.beditar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beditar.Image = global::admin.Properties.Resources.editar2;
            this.beditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beditar.Location = new System.Drawing.Point(232, 303);
            this.beditar.Name = "beditar";
            this.beditar.Size = new System.Drawing.Size(98, 50);
            this.beditar.TabIndex = 35;
            this.beditar.Text = "          Editar";
            this.beditar.UseVisualStyleBackColor = true;
            this.beditar.Click += new System.EventHandler(this.beditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Registro de Empleados";
            // 
            // cmbtipousuario
            // 
            this.cmbtipousuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipousuario.FormattingEnabled = true;
            this.cmbtipousuario.Location = new System.Drawing.Point(350, 190);
            this.cmbtipousuario.Name = "cmbtipousuario";
            this.cmbtipousuario.Size = new System.Drawing.Size(178, 23);
            this.cmbtipousuario.TabIndex = 33;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(350, 255);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(178, 23);
            this.txtpassword.TabIndex = 32;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(350, 224);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(178, 23);
            this.txtusuario.TabIndex = 31;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(350, 155);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(178, 23);
            this.txtapellido.TabIndex = 30;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(350, 123);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(178, 23);
            this.txtnombre.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Usuario ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tipo de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Apellido Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre Empleado";
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Image = global::admin.Properties.Resources.save;
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(451, 303);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(95, 50);
            this.bguardar.TabIndex = 22;
            this.bguardar.Text = "          Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnrefresh);
            this.tabPage2.Controls.Add(this.txtbusuario);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.grdbuscarempleado);
            this.tabPage2.Controls.Add(this.txtbidemp);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtbapellido);
            this.tabPage2.Controls.Add(this.txtbnombre);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.baceptarPelicula);
            this.tabPage2.Controls.Add(this.btnbuscaremp);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar Empleados";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::admin.Properties.Resources.refresh;
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefresh.Location = new System.Drawing.Point(443, 392);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(108, 42);
            this.btnrefresh.TabIndex = 59;
            this.btnrefresh.Text = "       Refrescar";
            this.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // txtbusuario
            // 
            this.txtbusuario.Location = new System.Drawing.Point(456, 108);
            this.txtbusuario.Name = "txtbusuario";
            this.txtbusuario.Size = new System.Drawing.Size(178, 23);
            this.txtbusuario.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(399, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "Usuario";
            // 
            // grdbuscarempleado
            // 
            this.grdbuscarempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdbuscarempleado.Location = new System.Drawing.Point(21, 184);
            this.grdbuscarempleado.Name = "grdbuscarempleado";
            this.grdbuscarempleado.Size = new System.Drawing.Size(656, 202);
            this.grdbuscarempleado.TabIndex = 49;
            this.grdbuscarempleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdbuscarempleado_CellContentClick);
            // 
            // txtbidemp
            // 
            this.txtbidemp.Location = new System.Drawing.Point(149, 76);
            this.txtbidemp.Name = "txtbidemp";
            this.txtbidemp.Size = new System.Drawing.Size(178, 23);
            this.txtbidemp.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "Id Empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Busqueda de Empleados";
            // 
            // txtbapellido
            // 
            this.txtbapellido.Location = new System.Drawing.Point(149, 109);
            this.txtbapellido.Name = "txtbapellido";
            this.txtbapellido.Size = new System.Drawing.Size(178, 23);
            this.txtbapellido.TabIndex = 41;
            // 
            // txtbnombre
            // 
            this.txtbnombre.Location = new System.Drawing.Point(456, 76);
            this.txtbnombre.Name = "txtbnombre";
            this.txtbnombre.Size = new System.Drawing.Size(178, 23);
            this.txtbnombre.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "Apellido Empleado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 15);
            this.label13.TabIndex = 35;
            this.label13.Text = "Nombre Empleado";
            // 
            // baceptarPelicula
            // 
            this.baceptarPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baceptarPelicula.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptarPelicula.Image = global::admin.Properties.Resources.aceptar;
            this.baceptarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baceptarPelicula.Location = new System.Drawing.Point(317, 392);
            this.baceptarPelicula.Name = "baceptarPelicula";
            this.baceptarPelicula.Size = new System.Drawing.Size(106, 42);
            this.baceptarPelicula.TabIndex = 50;
            this.baceptarPelicula.Text = "       Aceptar";
            this.baceptarPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.baceptarPelicula.UseVisualStyleBackColor = true;
            this.baceptarPelicula.Click += new System.EventHandler(this.baceptarEmpleado_Click);
            // 
            // btnbuscaremp
            // 
            this.btnbuscaremp.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscaremp.Image = global::admin.Properties.Resources.search1;
            this.btnbuscaremp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscaremp.Location = new System.Drawing.Point(578, 3);
            this.btnbuscaremp.Name = "btnbuscaremp";
            this.btnbuscaremp.Size = new System.Drawing.Size(99, 47);
            this.btnbuscaremp.TabIndex = 46;
            this.btnbuscaremp.Text = "          Buscar";
            this.btnbuscaremp.UseVisualStyleBackColor = true;
            this.btnbuscaremp.Click += new System.EventHandler(this.btnbuscaremp_Click);
            // 
            // frmregistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 482);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmregistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Registro";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdbuscarempleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbtipousuario;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbapellido;
        private System.Windows.Forms.TextBox txtbnombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnbuscaremp;
        private System.Windows.Forms.DataGridView grdbuscarempleado;
        private System.Windows.Forms.TextBox txtbidemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbusuario;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button beditar;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button baceptarPelicula;
        private System.Windows.Forms.Button brefrescar;
        private System.Windows.Forms.Button btnrefresh;

    }
}