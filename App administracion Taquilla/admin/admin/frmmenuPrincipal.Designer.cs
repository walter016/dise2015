namespace admin
{
    partial class frmmenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cateleraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarInformacionDePeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeAcumuladoDePuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeGananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeHorariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDePeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cateleraToolStripMenuItem,
            this.salaToolStripMenuItem,
            this.sucursalToolStripMenuItem,
            this.registroEmpleadosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.bitacoraDeIngresosToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.horariosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1019, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cateleraToolStripMenuItem
            // 
            this.cateleraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPeliculaToolStripMenuItem,
            this.editarInformacionDePeliculaToolStripMenuItem});
            this.cateleraToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.cateleraToolStripMenuItem.Image = global::admin.Properties.Resources.billboard;
            this.cateleraToolStripMenuItem.Name = "cateleraToolStripMenuItem";
            this.cateleraToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.cateleraToolStripMenuItem.Text = "Cartelera";
            // 
            // registrarPeliculaToolStripMenuItem
            // 
            this.registrarPeliculaToolStripMenuItem.Image = global::admin.Properties.Resources.register_movie;
            this.registrarPeliculaToolStripMenuItem.Name = "registrarPeliculaToolStripMenuItem";
            this.registrarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.registrarPeliculaToolStripMenuItem.Text = "Registrar Pelicula";
            this.registrarPeliculaToolStripMenuItem.Click += new System.EventHandler(this.registrarPeliculaToolStripMenuItem_Click);
            // 
            // editarInformacionDePeliculaToolStripMenuItem
            // 
            this.editarInformacionDePeliculaToolStripMenuItem.Image = global::admin.Properties.Resources.search;
            this.editarInformacionDePeliculaToolStripMenuItem.Name = "editarInformacionDePeliculaToolStripMenuItem";
            this.editarInformacionDePeliculaToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.editarInformacionDePeliculaToolStripMenuItem.Text = "Busqueda de Pelicula";
            this.editarInformacionDePeliculaToolStripMenuItem.Click += new System.EventHandler(this.editarInformacionDePeliculaToolStripMenuItem_Click);
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarSalaToolStripMenuItem,
            this.busquedaDeSalaToolStripMenuItem});
            this.salaToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.salaToolStripMenuItem.Image = global::admin.Properties.Resources.cinema_studio;
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.salaToolStripMenuItem.Text = "Sala";
            // 
            // ingresarSalaToolStripMenuItem
            // 
            this.ingresarSalaToolStripMenuItem.Image = global::admin.Properties.Resources.cine;
            this.ingresarSalaToolStripMenuItem.Name = "ingresarSalaToolStripMenuItem";
            this.ingresarSalaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.ingresarSalaToolStripMenuItem.Text = "Registrar Sala";
            this.ingresarSalaToolStripMenuItem.Click += new System.EventHandler(this.ingresarSalaToolStripMenuItem_Click);
            // 
            // busquedaDeSalaToolStripMenuItem
            // 
            this.busquedaDeSalaToolStripMenuItem.Image = global::admin.Properties.Resources.search1;
            this.busquedaDeSalaToolStripMenuItem.Name = "busquedaDeSalaToolStripMenuItem";
            this.busquedaDeSalaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.busquedaDeSalaToolStripMenuItem.Text = "Busqueda de Sala";
            this.busquedaDeSalaToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeSalaToolStripMenuItem_Click);
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCiudadToolStripMenuItem,
            this.registrarSucursalToolStripMenuItem,
            this.busquedaDeSucursalToolStripMenuItem});
            this.sucursalToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.sucursalToolStripMenuItem.Image = global::admin.Properties.Resources.cinema_hall;
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.sucursalToolStripMenuItem.Text = "Sucursal";
            // 
            // registrarCiudadToolStripMenuItem
            // 
            this.registrarCiudadToolStripMenuItem.Image = global::admin.Properties.Resources.mapa;
            this.registrarCiudadToolStripMenuItem.Name = "registrarCiudadToolStripMenuItem";
            this.registrarCiudadToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.registrarCiudadToolStripMenuItem.Text = "Registrar Ciudad";
            this.registrarCiudadToolStripMenuItem.Click += new System.EventHandler(this.registrarCiudadToolStripMenuItem_Click);
            // 
            // registrarSucursalToolStripMenuItem
            // 
            this.registrarSucursalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarSucursalToolStripMenuItem.Image")));
            this.registrarSucursalToolStripMenuItem.Name = "registrarSucursalToolStripMenuItem";
            this.registrarSucursalToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.registrarSucursalToolStripMenuItem.Text = "Registrar Sucursal";
            this.registrarSucursalToolStripMenuItem.Click += new System.EventHandler(this.registrarSucursalToolStripMenuItem_Click);
            // 
            // busquedaDeSucursalToolStripMenuItem
            // 
            this.busquedaDeSucursalToolStripMenuItem.Image = global::admin.Properties.Resources.search1;
            this.busquedaDeSucursalToolStripMenuItem.Name = "busquedaDeSucursalToolStripMenuItem";
            this.busquedaDeSucursalToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.busquedaDeSucursalToolStripMenuItem.Text = "Busqueda de Sucursal";
            this.busquedaDeSucursalToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeSucursalToolStripMenuItem_Click);
            // 
            // registroEmpleadosToolStripMenuItem
            // 
            this.registroEmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroUsuarioToolStripMenuItem,
            this.tipoDeUsuarioToolStripMenuItem});
            this.registroEmpleadosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroEmpleadosToolStripMenuItem.Image = global::admin.Properties.Resources.agregar_usuario;
            this.registroEmpleadosToolStripMenuItem.Name = "registroEmpleadosToolStripMenuItem";
            this.registroEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(166, 23);
            this.registroEmpleadosToolStripMenuItem.Text = "Registro Empleados";
            // 
            // registroUsuarioToolStripMenuItem
            // 
            this.registroUsuarioToolStripMenuItem.Image = global::admin.Properties.Resources.registro;
            this.registroUsuarioToolStripMenuItem.Name = "registroUsuarioToolStripMenuItem";
            this.registroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.registroUsuarioToolStripMenuItem.Text = "Registro Usuario";
            this.registroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroUsuarioToolStripMenuItem_Click);
            // 
            // tipoDeUsuarioToolStripMenuItem
            // 
            this.tipoDeUsuarioToolStripMenuItem.Image = global::admin.Properties.Resources.Picture1;
            this.tipoDeUsuarioToolStripMenuItem.Name = "tipoDeUsuarioToolStripMenuItem";
            this.tipoDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.tipoDeUsuarioToolStripMenuItem.Text = "Tipo de Usuario";
            this.tipoDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUsuarioToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeAcumuladoDePuntosToolStripMenuItem,
            this.reporteDeGananciasToolStripMenuItem,
            this.reporteDeHorariosToolStripMenuItem,
            this.reporteDePeliculasToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.reportesToolStripMenuItem.Image = global::admin.Properties.Resources.reports;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeAcumuladoDePuntosToolStripMenuItem
            // 
            this.reporteDeAcumuladoDePuntosToolStripMenuItem.Image = global::admin.Properties.Resources.club_card;
            this.reporteDeAcumuladoDePuntosToolStripMenuItem.Name = "reporteDeAcumuladoDePuntosToolStripMenuItem";
            this.reporteDeAcumuladoDePuntosToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.reporteDeAcumuladoDePuntosToolStripMenuItem.Text = "Reporte de Acumulado de Puntos";
            // 
            // reporteDeGananciasToolStripMenuItem
            // 
            this.reporteDeGananciasToolStripMenuItem.Image = global::admin.Properties.Resources.report_money;
            this.reporteDeGananciasToolStripMenuItem.Name = "reporteDeGananciasToolStripMenuItem";
            this.reporteDeGananciasToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.reporteDeGananciasToolStripMenuItem.Text = "Reporte de Ganancias";
            // 
            // reporteDeHorariosToolStripMenuItem
            // 
            this.reporteDeHorariosToolStripMenuItem.Image = global::admin.Properties.Resources.schedule;
            this.reporteDeHorariosToolStripMenuItem.Name = "reporteDeHorariosToolStripMenuItem";
            this.reporteDeHorariosToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.reporteDeHorariosToolStripMenuItem.Text = "Reporte de Horarios";
            // 
            // reporteDePeliculasToolStripMenuItem
            // 
            this.reporteDePeliculasToolStripMenuItem.Image = global::admin.Properties.Resources.report_movie;
            this.reporteDePeliculasToolStripMenuItem.Name = "reporteDePeliculasToolStripMenuItem";
            this.reporteDePeliculasToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.reporteDePeliculasToolStripMenuItem.Text = "Reporte de Peliculas";
            // 
            // bitacoraDeIngresosToolStripMenuItem
            // 
            this.bitacoraDeIngresosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitacoraDeIngresosToolStripMenuItem.Image = global::admin.Properties.Resources.estadisticas;
            this.bitacoraDeIngresosToolStripMenuItem.Name = "bitacoraDeIngresosToolStripMenuItem";
            this.bitacoraDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(170, 23);
            this.bitacoraDeIngresosToolStripMenuItem.Text = "Bitacora de Ingresos";
            this.bitacoraDeIngresosToolStripMenuItem.Click += new System.EventHandler(this.bitacoraDeIngresosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.manualToolStripMenuItem.Image = global::admin.Properties.Resources.manual_user;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horariosPeliculasToolStripMenuItem});
            this.horariosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horariosToolStripMenuItem.Image = global::admin.Properties.Resources.calendario;
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.horariosToolStripMenuItem.Text = "Horarios";
            // 
            // horariosPeliculasToolStripMenuItem
            // 
            this.horariosPeliculasToolStripMenuItem.Image = global::admin.Properties.Resources.icono_calendario;
            this.horariosPeliculasToolStripMenuItem.Name = "horariosPeliculasToolStripMenuItem";
            this.horariosPeliculasToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.horariosPeliculasToolStripMenuItem.Text = "Horarios Peliculas";
            this.horariosPeliculasToolStripMenuItem.Click += new System.EventHandler(this.horariosPeliculasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.ayudaToolStripMenuItem.Image = global::admin.Properties.Resources.help;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // frmmenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::admin.Properties.Resources.cinemabackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1019, 624);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Software Administrativo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cateleraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeAcumuladoDePuntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeGananciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeHorariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDePeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPeliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarInformacionDePeliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeSalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarSalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraDeIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosPeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsuarioToolStripMenuItem;
    }
}