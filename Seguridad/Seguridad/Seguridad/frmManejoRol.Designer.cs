namespace Manejo_Rol
{
    partial class frmManejoRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoRol));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarUsuario = new System.Windows.Forms.Button();
            this.rbAplicaciones = new System.Windows.Forms.RadioButton();
            this.rbPerfiles = new System.Windows.Forms.RadioButton();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.lblAppAsignadas = new System.Windows.Forms.Label();
            this.lblQuitar = new System.Windows.Forms.Label();
            this.lblAsignar = new System.Windows.Forms.Label();
            this.lblAppDisponibles = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblPerfilesDispo = new System.Windows.Forms.Label();
            this.tvAppYUserAsignado = new System.Windows.Forms.TreeView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnQuitarSimple = new System.Windows.Forms.Button();
            this.lblQuitarMuchos = new System.Windows.Forms.Button();
            this.btnAsignarMuchos = new System.Windows.Forms.Button();
            this.btnAsignarSimple = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lbPerfiles = new System.Windows.Forms.ListBox();
            this.lbAppDisponibles = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(538, 536);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 34);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(415, 536);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(107, 34);
            this.btnLimpiarUsuario.TabIndex = 41;
            this.btnLimpiarUsuario.Text = "Limpiar Usuario";
            this.btnLimpiarUsuario.UseVisualStyleBackColor = true;
            // 
            // rbAplicaciones
            // 
            this.rbAplicaciones.AutoSize = true;
            this.rbAplicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAplicaciones.Location = new System.Drawing.Point(119, 526);
            this.rbAplicaciones.Name = "rbAplicaciones";
            this.rbAplicaciones.Size = new System.Drawing.Size(106, 19);
            this.rbAplicaciones.TabIndex = 40;
            this.rbAplicaciones.TabStop = true;
            this.rbAplicaciones.Text = "Aplicaciones";
            this.rbAplicaciones.UseVisualStyleBackColor = true;
            // 
            // rbPerfiles
            // 
            this.rbPerfiles.AutoSize = true;
            this.rbPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerfiles.Location = new System.Drawing.Point(29, 526);
            this.rbPerfiles.Name = "rbPerfiles";
            this.rbPerfiles.Size = new System.Drawing.Size(74, 19);
            this.rbPerfiles.TabIndex = 39;
            this.rbPerfiles.TabStop = true;
            this.rbPerfiles.Text = "Perfiles";
            this.rbPerfiles.UseVisualStyleBackColor = true;
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.Location = new System.Drawing.Point(289, 451);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(64, 16);
            this.lblGuardar.TabIndex = 38;
            this.lblGuardar.Text = "Guardar";
            // 
            // lblAppAsignadas
            // 
            this.lblAppAsignadas.AutoSize = true;
            this.lblAppAsignadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppAsignadas.Location = new System.Drawing.Point(397, 125);
            this.lblAppAsignadas.Name = "lblAppAsignadas";
            this.lblAppAsignadas.Size = new System.Drawing.Size(176, 16);
            this.lblAppAsignadas.TabIndex = 35;
            this.lblAppAsignadas.Text = "Aplicaciones Asignadas";
            // 
            // lblQuitar
            // 
            this.lblQuitar.AutoSize = true;
            this.lblQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitar.Location = new System.Drawing.Point(297, 299);
            this.lblQuitar.Name = "lblQuitar";
            this.lblQuitar.Size = new System.Drawing.Size(49, 16);
            this.lblQuitar.TabIndex = 32;
            this.lblQuitar.Text = "Quitar";
            // 
            // lblAsignar
            // 
            this.lblAsignar.AutoSize = true;
            this.lblAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignar.Location = new System.Drawing.Point(292, 127);
            this.lblAsignar.Name = "lblAsignar";
            this.lblAsignar.Size = new System.Drawing.Size(61, 16);
            this.lblAsignar.TabIndex = 29;
            this.lblAsignar.Text = "Asignar";
            // 
            // lblAppDisponibles
            // 
            this.lblAppDisponibles.AutoSize = true;
            this.lblAppDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDisponibles.Location = new System.Drawing.Point(48, 331);
            this.lblAppDisponibles.Name = "lblAppDisponibles";
            this.lblAppDisponibles.Size = new System.Drawing.Size(185, 16);
            this.lblAppDisponibles.TabIndex = 27;
            this.lblAppDisponibles.Text = "Aplicaciones Disponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.lblNombreUsuario);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 100);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario Seleccionado";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(103, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(113, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(100, 32);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(116, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Codigo Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(330, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(121, 16);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(270, 55);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(259, 27);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblPerfilesDispo
            // 
            this.lblPerfilesDispo.AutoSize = true;
            this.lblPerfilesDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilesDispo.Location = new System.Drawing.Point(68, 125);
            this.lblPerfilesDispo.Name = "lblPerfilesDispo";
            this.lblPerfilesDispo.Size = new System.Drawing.Size(148, 16);
            this.lblPerfilesDispo.TabIndex = 24;
            this.lblPerfilesDispo.Text = "Perfiles Disponibles";
            // 
            // tvAppYUserAsignado
            // 
            this.tvAppYUserAsignado.Location = new System.Drawing.Point(359, 153);
            this.tvAppYUserAsignado.Name = "tvAppYUserAsignado";
            this.tvAppYUserAsignado.Size = new System.Drawing.Size(273, 367);
            this.tvAppYUserAsignado.TabIndex = 43;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Manejo_Rol.Properties.Resources.guardar;
            this.btnEditar.Location = new System.Drawing.Point(298, 470);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 50);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarSimple
            // 
            this.btnQuitarSimple.Image = global::Manejo_Rol.Properties.Resources.asignar4;
            this.btnQuitarSimple.Location = new System.Drawing.Point(299, 389);
            this.btnQuitarSimple.Name = "btnQuitarSimple";
            this.btnQuitarSimple.Size = new System.Drawing.Size(47, 50);
            this.btnQuitarSimple.TabIndex = 34;
            this.btnQuitarSimple.UseVisualStyleBackColor = true;
            // 
            // lblQuitarMuchos
            // 
            this.lblQuitarMuchos.Image = global::Manejo_Rol.Properties.Resources.asignar3;
            this.lblQuitarMuchos.Location = new System.Drawing.Point(299, 333);
            this.lblQuitarMuchos.Name = "lblQuitarMuchos";
            this.lblQuitarMuchos.Size = new System.Drawing.Size(47, 50);
            this.lblQuitarMuchos.TabIndex = 33;
            this.lblQuitarMuchos.UseVisualStyleBackColor = true;
            // 
            // btnAsignarMuchos
            // 
            this.btnAsignarMuchos.Image = global::Manejo_Rol.Properties.Resources.asignar2;
            this.btnAsignarMuchos.Location = new System.Drawing.Point(299, 211);
            this.btnAsignarMuchos.Name = "btnAsignarMuchos";
            this.btnAsignarMuchos.Size = new System.Drawing.Size(47, 50);
            this.btnAsignarMuchos.TabIndex = 31;
            this.btnAsignarMuchos.UseVisualStyleBackColor = true;
            // 
            // btnAsignarSimple
            // 
            this.btnAsignarSimple.Image = global::Manejo_Rol.Properties.Resources.asginar;
            this.btnAsignarSimple.Location = new System.Drawing.Point(298, 155);
            this.btnAsignarSimple.Name = "btnAsignarSimple";
            this.btnAsignarSimple.Size = new System.Drawing.Size(47, 50);
            this.btnAsignarSimple.TabIndex = 30;
            this.btnAsignarSimple.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Manejo_Rol.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(22, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lbPerfiles
            // 
            this.lbPerfiles.FormattingEnabled = true;
            this.lbPerfiles.Location = new System.Drawing.Point(10, 153);
            this.lbPerfiles.Name = "lbPerfiles";
            this.lbPerfiles.ScrollAlwaysVisible = true;
            this.lbPerfiles.Size = new System.Drawing.Size(271, 160);
            this.lbPerfiles.TabIndex = 44;
            // 
            // lbAppDisponibles
            // 
            this.lbAppDisponibles.FormattingEnabled = true;
            this.lbAppDisponibles.Location = new System.Drawing.Point(10, 360);
            this.lbAppDisponibles.Name = "lbAppDisponibles";
            this.lbAppDisponibles.ScrollAlwaysVisible = true;
            this.lbAppDisponibles.Size = new System.Drawing.Size(271, 160);
            this.lbAppDisponibles.TabIndex = 45;
            // 
            // frmManejoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 584);
            this.Controls.Add(this.lbAppDisponibles);
            this.Controls.Add(this.lbPerfiles);
            this.Controls.Add(this.tvAppYUserAsignado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarUsuario);
            this.Controls.Add(this.rbAplicaciones);
            this.Controls.Add(this.rbPerfiles);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblAppAsignadas);
            this.Controls.Add(this.btnQuitarSimple);
            this.Controls.Add(this.lblQuitarMuchos);
            this.Controls.Add(this.lblQuitar);
            this.Controls.Add(this.btnAsignarMuchos);
            this.Controls.Add(this.btnAsignarSimple);
            this.Controls.Add(this.lblAsignar);
            this.Controls.Add(this.lblAppDisponibles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPerfilesDispo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManejoRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Roles";
            this.Load += new System.EventHandler(this.frmManejoRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarUsuario;
        private System.Windows.Forms.RadioButton rbAplicaciones;
        private System.Windows.Forms.RadioButton rbPerfiles;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblAppAsignadas;
        private System.Windows.Forms.Button btnQuitarSimple;
        private System.Windows.Forms.Button lblQuitarMuchos;
        private System.Windows.Forms.Label lblQuitar;
        private System.Windows.Forms.Button btnAsignarMuchos;
        private System.Windows.Forms.Button btnAsignarSimple;
        private System.Windows.Forms.Label lblAsignar;
        private System.Windows.Forms.Label lblAppDisponibles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblPerfilesDispo;
        private System.Windows.Forms.TreeView tvAppYUserAsignado;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtNombreUsuario;
        public System.Windows.Forms.ListBox lbPerfiles;
        public System.Windows.Forms.ListBox lbAppDisponibles;
    }
}

