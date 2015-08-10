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
            this.registrarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeAcumuladoDePuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeGananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeHorariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDePeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cateleraToolStripMenuItem,
            this.salaToolStripMenuItem,
            this.sucursalToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bitacoraDeIngresosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cateleraToolStripMenuItem
            // 
            this.cateleraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPeliculaToolStripMenuItem,
            this.editarInformacionDePeliculaToolStripMenuItem});
            this.cateleraToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.cateleraToolStripMenuItem.Image = global::admin.Properties.Resources.billboard;
            this.cateleraToolStripMenuItem.Name = "cateleraToolStripMenuItem";
            this.cateleraToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.cateleraToolStripMenuItem.Text = "Catelera";
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
            this.registrarSucursalToolStripMenuItem,
            this.busquedaDeSucursalToolStripMenuItem});
            this.sucursalToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.sucursalToolStripMenuItem.Image = global::admin.Properties.Resources.cinema_hall;
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.sucursalToolStripMenuItem.Text = "Sucursal";
            // 
            // registrarSucursalToolStripMenuItem
            // 
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
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.manualToolStripMenuItem.Image = global::admin.Properties.Resources.manual_user;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.manualToolStripMenuItem.Text = "Manual";
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroUsuarioToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::admin.Properties.Resources.agregar_usuario;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 23);
            this.toolStripMenuItem1.Text = "Registo Empleados ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // registroUsuarioToolStripMenuItem
            // 
            this.registroUsuarioToolStripMenuItem.Name = "registroUsuarioToolStripMenuItem";
            this.registroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registroUsuarioToolStripMenuItem.Text = "Registro Usuario";
            this.registroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroUsuarioToolStripMenuItem_Click);
            // 
            // bitacoraDeIngresosToolStripMenuItem
            // 
            this.bitacoraDeIngresosToolStripMenuItem.Image = global::admin.Properties.Resources.estadisticas;
            this.bitacoraDeIngresosToolStripMenuItem.Name = "bitacoraDeIngresosToolStripMenuItem";
            this.bitacoraDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(141, 23);
            this.bitacoraDeIngresosToolStripMenuItem.Text = "Bitacora de Ingresos";
            this.bitacoraDeIngresosToolStripMenuItem.Click += new System.EventHandler(this.bitacoraDeIngresosToolStripMenuItem_Click);
            // 
            // frmmenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::admin.Properties.Resources.cinemabackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(813, 432);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraDeIngresosToolStripMenuItem;
    }
}