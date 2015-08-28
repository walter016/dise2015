namespace WindowsFormsApplication1
{
    partial class frmreservacion
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
            this.PBpelicula = new System.Windows.Forms.PictureBox();
            this.msbarra = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lblclasificacionPeli = new System.Windows.Forms.Label();
            this.lblclasificacion = new System.Windows.Forms.Label();
            this.lblsalaPeli = new System.Windows.Forms.Label();
            this.lblhorarioPeli = new System.Windows.Forms.Label();
            this.lblsubtituloPeli = new System.Windows.Forms.Label();
            this.lblidiomaPeli = new System.Windows.Forms.Label();
            this.lblcategoriaPeli = new System.Windows.Forms.Label();
            this.lblsala = new System.Windows.Forms.Label();
            this.lbltituloPeli = new System.Windows.Forms.Label();
            this.lblhorario = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.lblidioma = new System.Windows.Forms.Label();
            this.lblseleccionBoletos = new System.Windows.Forms.Label();
            this.belegirAciento = new System.Windows.Forms.Button();
            this.lblcantidadBoletos = new System.Windows.Forms.Label();
            this.lblcostoBoleto = new System.Windows.Forms.Label();
            this.lblninios = new System.Windows.Forms.Label();
            this.lbladultos = new System.Windows.Forms.Label();
            this.lblsubtotalPeli = new System.Windows.Forms.Label();
            this.pbimagenCompra = new System.Windows.Forms.PictureBox();
            this.pbimagencompra2 = new System.Windows.Forms.PictureBox();
            this.pbmenosCompra = new System.Windows.Forms.PictureBox();
            this.pbmenosCompra2 = new System.Windows.Forms.PictureBox();
            this.lblcantidadNinios = new System.Windows.Forms.Label();
            this.lblcantidadAdulto = new System.Windows.Forms.Label();
            this.pbimagenMenos2 = new System.Windows.Forms.PictureBox();
            this.pbimagenMas1 = new System.Windows.Forms.PictureBox();
            this.pbimagenMas2 = new System.Windows.Forms.PictureBox();
            this.lblcostoNinio = new System.Windows.Forms.Label();
            this.lblcostoAdulto = new System.Windows.Forms.Label();
            this.lblsubTotalNinio = new System.Windows.Forms.Label();
            this.lblsubtotalAdulto = new System.Windows.Forms.Label();
            this.pbmenosHabilitado = new System.Windows.Forms.PictureBox();
            this.pbmenosHabilitado2 = new System.Windows.Forms.PictureBox();
            this.pbimagenMenos1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltiposala = new System.Windows.Forms.Label();
            this.lbltipoSalaPeli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBpelicula)).BeginInit();
            this.msbarra.SuspendLayout();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagencompra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmenosCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmenosCompra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenMenos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenMas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenMas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmenosHabilitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmenosHabilitado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenMenos1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBpelicula
            // 
            this.PBpelicula.Location = new System.Drawing.Point(14, 52);
            this.PBpelicula.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PBpelicula.Name = "PBpelicula";
            this.PBpelicula.Size = new System.Drawing.Size(256, 383);
            this.PBpelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBpelicula.TabIndex = 12;
            this.PBpelicula.TabStop = false;
            // 
            // msbarra
            // 
            this.msbarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem,
            this.menuPrincipalToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msbarra.Location = new System.Drawing.Point(0, 0);
            this.msbarra.Name = "msbarra";
            this.msbarra.Size = new System.Drawing.Size(992, 31);
            this.msbarra.TabIndex = 23;
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atrasToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.atras;
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipalToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(158, 27);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.salir;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(61, 16);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(61, 23);
            this.lbltitulo.TabIndex = 25;
            this.lbltitulo.Text = "Titulo:";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.lbltipoSalaPeli);
            this.grbInfo.Controls.Add(this.lbltiposala);
            this.grbInfo.Controls.Add(this.lblclasificacionPeli);
            this.grbInfo.Controls.Add(this.lblclasificacion);
            this.grbInfo.Controls.Add(this.lblsalaPeli);
            this.grbInfo.Controls.Add(this.lblhorarioPeli);
            this.grbInfo.Controls.Add(this.lblsubtituloPeli);
            this.grbInfo.Controls.Add(this.lblidiomaPeli);
            this.grbInfo.Controls.Add(this.lblcategoriaPeli);
            this.grbInfo.Controls.Add(this.lblsala);
            this.grbInfo.Controls.Add(this.lbltituloPeli);
            this.grbInfo.Controls.Add(this.lblhorario);
            this.grbInfo.Controls.Add(this.lbltitulo);
            this.grbInfo.Controls.Add(this.lblcategoria);
            this.grbInfo.Controls.Add(this.lblsubtitulo);
            this.grbInfo.Controls.Add(this.lblidioma);
            this.grbInfo.Location = new System.Drawing.Point(301, 52);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(607, 300);
            this.grbInfo.TabIndex = 24;
            this.grbInfo.TabStop = false;
            // 
            // lblclasificacionPeli
            // 
            this.lblclasificacionPeli.AutoSize = true;
            this.lblclasificacionPeli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasificacionPeli.Location = new System.Drawing.Point(122, 48);
            this.lblclasificacionPeli.Name = "lblclasificacionPeli";
            this.lblclasificacionPeli.Size = new System.Drawing.Size(104, 23);
            this.lblclasificacionPeli.TabIndex = 36;
            this.lblclasificacionPeli.Text = "Clasificacion";
            // 
            // lblclasificacion
            // 
            this.lblclasificacion.AutoSize = true;
            this.lblclasificacion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasificacion.Location = new System.Drawing.Point(9, 48);
            this.lblclasificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclasificacion.Name = "lblclasificacion";
            this.lblclasificacion.Size = new System.Drawing.Size(113, 23);
            this.lblclasificacion.TabIndex = 35;
            this.lblclasificacion.Text = "Clasificacion:";
            // 
            // lblsalaPeli
            // 
            this.lblsalaPeli.AutoSize = true;
            this.lblsalaPeli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalaPeli.Location = new System.Drawing.Point(122, 225);
            this.lblsalaPeli.Name = "lblsalaPeli";
            this.lblsalaPeli.Size = new System.Drawing.Size(41, 23);
            this.lblsalaPeli.TabIndex = 34;
            this.lblsalaPeli.Text = "Sala";
            // 
            // lblhorarioPeli
            // 
            this.lblhorarioPeli.AutoSize = true;
            this.lblhorarioPeli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorarioPeli.Location = new System.Drawing.Point(122, 188);
            this.lblhorarioPeli.Name = "lblhorarioPeli";
            this.lblhorarioPeli.Size = new System.Drawing.Size(69, 23);
            this.lblhorarioPeli.TabIndex = 33;
            this.lblhorarioPeli.Text = "Horario";
            // 
            // lblsubtituloPeli
            // 
            this.lblsubtituloPeli.AutoSize = true;
            this.lblsubtituloPeli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtituloPeli.Location = new System.Drawing.Point(122, 154);
            this.lblsubtituloPeli.Name = "lblsubtituloPeli";
            this.lblsubtituloPeli.Size = new System.Drawing.Size(80, 23);
            this.lblsubtituloPeli.TabIndex = 32;
            this.lblsubtituloPeli.Text = "Subtitulo";
            // 
            // lblidiomaPeli
            // 
            this.lblidiomaPeli.AutoSize = true;
            this.lblidiomaPeli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidiomaPeli.Location = new System.Drawing.Point(122, 118);
            this.lblidiomaPeli.Name = "lblidiomaPeli";
            this.lblidiomaPeli.Size = new System.Drawing.Size(64, 23);
            this.lblidiomaPeli.TabIndex = 31;
            this.lblidiomaPeli.Text = "Idioma";
            // 
            // lblcategoriaPeli
            // 
            this.lblcategoriaPeli.AutoSize = true;
            this.lblcategoriaPeli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoriaPeli.Location = new System.Drawing.Point(122, 82);
            this.lblcategoriaPeli.Name = "lblcategoriaPeli";
            this.lblcategoriaPeli.Size = new System.Drawing.Size(83, 23);
            this.lblcategoriaPeli.TabIndex = 30;
            this.lblcategoriaPeli.Text = "Categoria";
            // 
            // lblsala
            // 
            this.lblsala.AutoSize = true;
            this.lblsala.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsala.Location = new System.Drawing.Point(42, 225);
            this.lblsala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsala.Name = "lblsala";
            this.lblsala.Size = new System.Drawing.Size(79, 23);
            this.lblsala.TabIndex = 29;
            this.lblsala.Text = "No. Sala:";
            // 
            // lbltituloPeli
            // 
            this.lbltituloPeli.AutoSize = true;
            this.lbltituloPeli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloPeli.Location = new System.Drawing.Point(122, 16);
            this.lbltituloPeli.Name = "lbltituloPeli";
            this.lbltituloPeli.Size = new System.Drawing.Size(115, 23);
            this.lbltituloPeli.TabIndex = 28;
            this.lbltituloPeli.Text = "Titulo Pelicula";
            // 
            // lblhorario
            // 
            this.lblhorario.AutoSize = true;
            this.lblhorario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorario.Location = new System.Drawing.Point(46, 188);
            this.lblhorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhorario.Name = "lblhorario";
            this.lblhorario.Size = new System.Drawing.Size(75, 23);
            this.lblhorario.TabIndex = 27;
            this.lblhorario.Text = "Horario:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(30, 82);
            this.lblcategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(91, 23);
            this.lblcategoria.TabIndex = 12;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.Location = new System.Drawing.Point(34, 154);
            this.lblsubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(87, 23);
            this.lblsubtitulo.TabIndex = 16;
            this.lblsubtitulo.Text = "Subtitulo:";
            // 
            // lblidioma
            // 
            this.lblidioma.AutoSize = true;
            this.lblidioma.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidioma.Location = new System.Drawing.Point(52, 118);
            this.lblidioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidioma.Name = "lblidioma";
            this.lblidioma.Size = new System.Drawing.Size(69, 23);
            this.lblidioma.TabIndex = 14;
            this.lblidioma.Text = "Idioma:";
            // 
            // lblseleccionBoletos
            // 
            this.lblseleccionBoletos.AutoSize = true;
            this.lblseleccionBoletos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseleccionBoletos.Location = new System.Drawing.Point(543, 355);
            this.lblseleccionBoletos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblseleccionBoletos.Name = "lblseleccionBoletos";
            this.lblseleccionBoletos.Size = new System.Drawing.Size(223, 29);
            this.lblseleccionBoletos.TabIndex = 25;
            this.lblseleccionBoletos.Text = "Seleccion de boletos:";
            // 
            // belegirAciento
            // 
            this.belegirAciento.Enabled = false;
            this.belegirAciento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belegirAciento.Image = global::WindowsFormsApplication1.Properties.Resources.flecha_derecha;
            this.belegirAciento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.belegirAciento.Location = new System.Drawing.Point(608, 566);
            this.belegirAciento.Name = "belegirAciento";
            this.belegirAciento.Size = new System.Drawing.Size(110, 50);
            this.belegirAciento.TabIndex = 50;
            this.belegirAciento.Text = "Elige tus Asientos";
            this.belegirAciento.UseVisualStyleBackColor = true;
            this.belegirAciento.Click += new System.EventHandler(this.belegirAciento_Click);
            // 
            // lblcantidadBoletos
            // 
            this.lblcantidadBoletos.AutoSize = true;
            this.lblcantidadBoletos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadBoletos.Location = new System.Drawing.Point(544, 397);
            this.lblcantidadBoletos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidadBoletos.Name = "lblcantidadBoletos";
            this.lblcantidadBoletos.Size = new System.Drawing.Size(71, 19);
            this.lblcantidadBoletos.TabIndex = 51;
            this.lblcantidadBoletos.Text = "Cantidad:";
            // 
            // lblcostoBoleto
            // 
            this.lblcostoBoleto.AutoSize = true;
            this.lblcostoBoleto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostoBoleto.Location = new System.Drawing.Point(681, 397);
            this.lblcostoBoleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcostoBoleto.Name = "lblcostoBoleto";
            this.lblcostoBoleto.Size = new System.Drawing.Size(50, 19);
            this.lblcostoBoleto.TabIndex = 52;
            this.lblcostoBoleto.Text = "Costo:";
            // 
            // lblninios
            // 
            this.lblninios.AutoSize = true;
            this.lblninios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblninios.Location = new System.Drawing.Point(412, 447);
            this.lblninios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblninios.Name = "lblninios";
            this.lblninios.Size = new System.Drawing.Size(50, 19);
            this.lblninios.TabIndex = 53;
            this.lblninios.Text = "Niños:";
            // 
            // lbladultos
            // 
            this.lbladultos.AutoSize = true;
            this.lbladultos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladultos.Location = new System.Drawing.Point(404, 511);
            this.lbladultos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladultos.Name = "lbladultos";
            this.lbladultos.Size = new System.Drawing.Size(62, 19);
            this.lbladultos.TabIndex = 54;
            this.lbladultos.Text = "Adultos:";
            // 
            // lblsubtotalPeli
            // 
            this.lblsubtotalPeli.AutoSize = true;
            this.lblsubtotalPeli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotalPeli.Location = new System.Drawing.Point(774, 397);
            this.lblsubtotalPeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubtotalPeli.Name = "lblsubtotalPeli";
            this.lblsubtotalPeli.Size = new System.Drawing.Size(66, 19);
            this.lblsubtotalPeli.TabIndex = 56;
            this.lblsubtotalPeli.Text = "Subtotal:";
            // 
            // pbimagenCompra
            // 
            this.pbimagenCompra.Image = global::WindowsFormsApplication1.Properties.Resources.Mas_habilitado;
            this.pbimagenCompra.Location = new System.Drawing.Point(608, 437);
            this.pbimagenCompra.Name = "pbimagenCompra";
            this.pbimagenCompra.Size = new System.Drawing.Size(41, 39);
            this.pbimagenCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagenCompra.TabIndex = 57;
            this.pbimagenCompra.TabStop = false;
            this.pbimagenCompra.MouseEnter += new System.EventHandler(this.pbimagenCompra_MouseEnter);
            // 
            // pbimagencompra2
            // 
            this.pbimagencompra2.Image = global::WindowsFormsApplication1.Properties.Resources.cambio;
            this.pbimagencompra2.Location = new System.Drawing.Point(608, 437);
            this.pbimagencompra2.Name = "pbimagencompra2";
            this.pbimagencompra2.Size = new System.Drawing.Size(41, 39);
            this.pbimagencompra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagencompra2.TabIndex = 58;
            this.pbimagencompra2.TabStop = false;
            this.pbimagencompra2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbimagencompra2_MouseClick);
            this.pbimagencompra2.MouseLeave += new System.EventHandler(this.pbimagencompra2_MouseLeave);
            // 
            // pbmenosCompra
            // 
            this.pbmenosCompra.Image = global::WindowsFormsApplication1.Properties.Resources.menos;
            this.pbmenosCompra.Location = new System.Drawing.Point(514, 437);
            this.pbmenosCompra.Name = "pbmenosCompra";
            this.pbmenosCompra.Size = new System.Drawing.Size(41, 39);
            this.pbmenosCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmenosCompra.TabIndex = 59;
            this.pbmenosCompra.TabStop = false;
            // 
            // pbmenosCompra2
            // 
            this.pbmenosCompra2.Image = global::WindowsFormsApplication1.Properties.Resources.guardarhover;
            this.pbmenosCompra2.Location = new System.Drawing.Point(514, 437);
            this.pbmenosCompra2.Name = "pbmenosCompra2";
            this.pbmenosCompra2.Size = new System.Drawing.Size(41, 39);
            this.pbmenosCompra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmenosCompra2.TabIndex = 60;
            this.pbmenosCompra2.TabStop = false;
            this.pbmenosCompra2.Visible = false;
            this.pbmenosCompra2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbmenosCompra2_MouseClick);
            // 
            // lblcantidadNinios
            // 
            this.lblcantidadNinios.AutoSize = true;
            this.lblcantidadNinios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadNinios.Location = new System.Drawing.Point(573, 447);
            this.lblcantidadNinios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidadNinios.Name = "lblcantidadNinios";
            this.lblcantidadNinios.Size = new System.Drawing.Size(17, 19);
            this.lblcantidadNinios.TabIndex = 61;
            this.lblcantidadNinios.Text = "0";
            this.lblcantidadNinios.TextChanged += new System.EventHandler(this.lblcantidadNinios_TextChanged);
            // 
            // lblcantidadAdulto
            // 
            this.lblcantidadAdulto.AutoSize = true;
            this.lblcantidadAdulto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadAdulto.Location = new System.Drawing.Point(573, 511);
            this.lblcantidadAdulto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidadAdulto.Name = "lblcantidadAdulto";
            this.lblcantidadAdulto.Size = new System.Drawing.Size(17, 19);
            this.lblcantidadAdulto.TabIndex = 66;
            this.lblcantidadAdulto.Text = "0";
            this.lblcantidadAdulto.TextChanged += new System.EventHandler(this.lblcantidadAdulto_TextChanged);
            // 
            // pbimagenMenos2
            // 
            this.pbimagenMenos2.Image = global::WindowsFormsApplication1.Properties.Resources.guardarhover;
            this.pbimagenMenos2.Location = new System.Drawing.Point(514, 501);
            this.pbimagenMenos2.Name = "pbimagenMenos2";
            this.pbimagenMenos2.Size = new System.Drawing.Size(41, 39);
            this.pbimagenMenos2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagenMenos2.TabIndex = 65;
            this.pbimagenMenos2.TabStop = false;
            this.pbimagenMenos2.Visible = false;
            this.pbimagenMenos2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbimagenMenos2_MouseClick);
            this.pbimagenMenos2.MouseLeave += new System.EventHandler(this.pbimagenMenos2_MouseLeave);
            // 
            // pbimagenMas1
            // 
            this.pbimagenMas1.Image = global::WindowsFormsApplication1.Properties.Resources.Mas_habilitado;
            this.pbimagenMas1.Location = new System.Drawing.Point(608, 501);
            this.pbimagenMas1.Name = "pbimagenMas1";
            this.pbimagenMas1.Size = new System.Drawing.Size(41, 39);
            this.pbimagenMas1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagenMas1.TabIndex = 62;
            this.pbimagenMas1.TabStop = false;
            this.pbimagenMas1.MouseEnter += new System.EventHandler(this.pbimagenMas1_MouseEnter);
            // 
            // pbimagenMas2
            // 
            this.pbimagenMas2.Image = global::WindowsFormsApplication1.Properties.Resources.cambio;
            this.pbimagenMas2.Location = new System.Drawing.Point(608, 501);
            this.pbimagenMas2.Name = "pbimagenMas2";
            this.pbimagenMas2.Size = new System.Drawing.Size(41, 39);
            this.pbimagenMas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagenMas2.TabIndex = 63;
            this.pbimagenMas2.TabStop = false;
            this.pbimagenMas2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbimagenMas2_MouseClick);
            this.pbimagenMas2.MouseLeave += new System.EventHandler(this.pbimagenMas2_MouseLeave);
            // 
            // lblcostoNinio
            // 
            this.lblcostoNinio.AutoSize = true;
            this.lblcostoNinio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostoNinio.Location = new System.Drawing.Point(685, 447);
            this.lblcostoNinio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcostoNinio.Name = "lblcostoNinio";
            this.lblcostoNinio.Size = new System.Drawing.Size(46, 19);
            this.lblcostoNinio.TabIndex = 67;
            this.lblcostoNinio.Text = "Costo";
            // 
            // lblcostoAdulto
            // 
            this.lblcostoAdulto.AutoSize = true;
            this.lblcostoAdulto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostoAdulto.Location = new System.Drawing.Point(685, 511);
            this.lblcostoAdulto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcostoAdulto.Name = "lblcostoAdulto";
            this.lblcostoAdulto.Size = new System.Drawing.Size(46, 19);
            this.lblcostoAdulto.TabIndex = 68;
            this.lblcostoAdulto.Text = "Costo";
            // 
            // lblsubTotalNinio
            // 
            this.lblsubTotalNinio.AutoSize = true;
            this.lblsubTotalNinio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubTotalNinio.Location = new System.Drawing.Point(791, 447);
            this.lblsubTotalNinio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubTotalNinio.Name = "lblsubTotalNinio";
            this.lblsubTotalNinio.Size = new System.Drawing.Size(37, 19);
            this.lblsubTotalNinio.TabIndex = 69;
            this.lblsubTotalNinio.Text = "0.00";
            // 
            // lblsubtotalAdulto
            // 
            this.lblsubtotalAdulto.AutoSize = true;
            this.lblsubtotalAdulto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotalAdulto.Location = new System.Drawing.Point(791, 511);
            this.lblsubtotalAdulto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubtotalAdulto.Name = "lblsubtotalAdulto";
            this.lblsubtotalAdulto.Size = new System.Drawing.Size(37, 19);
            this.lblsubtotalAdulto.TabIndex = 70;
            this.lblsubtotalAdulto.Text = "0.00";
            // 
            // pbmenosHabilitado
            // 
            this.pbmenosHabilitado.Image = global::WindowsFormsApplication1.Properties.Resources.menos_habilitado;
            this.pbmenosHabilitado.Location = new System.Drawing.Point(514, 437);
            this.pbmenosHabilitado.Name = "pbmenosHabilitado";
            this.pbmenosHabilitado.Size = new System.Drawing.Size(41, 39);
            this.pbmenosHabilitado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmenosHabilitado.TabIndex = 71;
            this.pbmenosHabilitado.TabStop = false;
            this.pbmenosHabilitado.Visible = false;
            this.pbmenosHabilitado.MouseEnter += new System.EventHandler(this.pbmenosHabilitado_MouseEnter);
            // 
            // pbmenosHabilitado2
            // 
            this.pbmenosHabilitado2.Image = global::WindowsFormsApplication1.Properties.Resources.menos_habilitado;
            this.pbmenosHabilitado2.Location = new System.Drawing.Point(514, 501);
            this.pbmenosHabilitado2.Name = "pbmenosHabilitado2";
            this.pbmenosHabilitado2.Size = new System.Drawing.Size(41, 39);
            this.pbmenosHabilitado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmenosHabilitado2.TabIndex = 72;
            this.pbmenosHabilitado2.TabStop = false;
            this.pbmenosHabilitado2.Visible = false;
            this.pbmenosHabilitado2.MouseEnter += new System.EventHandler(this.pbmenosHabilitado2_MouseEnter);
            // 
            // pbimagenMenos1
            // 
            this.pbimagenMenos1.Image = global::WindowsFormsApplication1.Properties.Resources.menos;
            this.pbimagenMenos1.Location = new System.Drawing.Point(514, 501);
            this.pbimagenMenos1.Name = "pbimagenMenos1";
            this.pbimagenMenos1.Size = new System.Drawing.Size(41, 39);
            this.pbimagenMenos1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagenMenos1.TabIndex = 73;
            this.pbimagenMenos1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(774, 447);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "Q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 511);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Q";
            // 
            // lbltiposala
            // 
            this.lbltiposala.AutoSize = true;
            this.lbltiposala.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiposala.Location = new System.Drawing.Point(36, 260);
            this.lbltiposala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltiposala.Name = "lbltiposala";
            this.lbltiposala.Size = new System.Drawing.Size(85, 23);
            this.lbltiposala.TabIndex = 37;
            this.lbltiposala.Text = "Tipo Sala:";
            // 
            // lbltipoSalaPeli
            // 
            this.lbltipoSalaPeli.AutoSize = true;
            this.lbltipoSalaPeli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoSalaPeli.Location = new System.Drawing.Point(122, 260);
            this.lbltipoSalaPeli.Name = "lbltipoSalaPeli";
            this.lbltipoSalaPeli.Size = new System.Drawing.Size(78, 23);
            this.lbltipoSalaPeli.TabIndex = 38;
            this.lbltipoSalaPeli.Text = "Tipo Sala";
            // 
            // frmreservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbmenosCompra);
            this.Controls.Add(this.pbimagenMenos1);
            this.Controls.Add(this.pbmenosHabilitado2);
            this.Controls.Add(this.pbmenosHabilitado);
            this.Controls.Add(this.lblsubtotalAdulto);
            this.Controls.Add(this.lblsubTotalNinio);
            this.Controls.Add(this.lblcostoAdulto);
            this.Controls.Add(this.lblcostoNinio);
            this.Controls.Add(this.lblcantidadAdulto);
            this.Controls.Add(this.pbimagenMenos2);
            this.Controls.Add(this.pbimagenMas1);
            this.Controls.Add(this.pbimagenMas2);
            this.Controls.Add(this.lblcantidadNinios);
            this.Controls.Add(this.pbmenosCompra2);
            this.Controls.Add(this.pbimagenCompra);
            this.Controls.Add(this.pbimagencompra2);
            this.Controls.Add(this.lblsubtotalPeli);
            this.Controls.Add(this.lbladultos);
            this.Controls.Add(this.lblninios);
            this.Controls.Add(this.lblcostoBoleto);
            this.Controls.Add(this.lblcantidadBoletos);
            this.Controls.Add(this.belegirAciento);
            this.Controls.Add(this.lblseleccionBoletos);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.msbarra);
            this.Controls.Add(this.PBpelicula);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmreservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservacion Pelicula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmreservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBpelicula)).EndInit();
            this.msbarra.ResumeLayout(false);
            this.msbarra.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagencompra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmenosCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmenosCompra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenMenos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenMas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenMas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmenosHabilitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmenosHabilitado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagenMenos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox PBpelicula;
        private System.Windows.Forms.MenuStrip msbarra;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblhorario;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Label lblidioma;
        private System.Windows.Forms.Label lblseleccionBoletos;
        private System.Windows.Forms.Button belegirAciento;
        private System.Windows.Forms.Label lblcantidadBoletos;
        private System.Windows.Forms.Label lblcostoBoleto;
        private System.Windows.Forms.Label lblninios;
        private System.Windows.Forms.Label lbladultos;
        private System.Windows.Forms.Label lblsubtotalPeli;
        private System.Windows.Forms.PictureBox pbimagenCompra;
        private System.Windows.Forms.PictureBox pbimagencompra2;
        private System.Windows.Forms.PictureBox pbmenosCompra;
        private System.Windows.Forms.PictureBox pbmenosCompra2;
        private System.Windows.Forms.Label lblcantidadNinios;
        private System.Windows.Forms.Label lblcantidadAdulto;
        private System.Windows.Forms.PictureBox pbimagenMenos2;
        private System.Windows.Forms.PictureBox pbimagenMas1;
        private System.Windows.Forms.PictureBox pbimagenMas2;
        private System.Windows.Forms.Label lblcostoNinio;
        private System.Windows.Forms.Label lblcostoAdulto;
        private System.Windows.Forms.Label lblsubTotalNinio;
        private System.Windows.Forms.Label lblsubtotalAdulto;
        private System.Windows.Forms.Label lbltituloPeli;
        private System.Windows.Forms.Label lblsalaPeli;
        private System.Windows.Forms.Label lblhorarioPeli;
        private System.Windows.Forms.Label lblsubtituloPeli;
        private System.Windows.Forms.Label lblidiomaPeli;
        private System.Windows.Forms.Label lblcategoriaPeli;
        private System.Windows.Forms.Label lblsala;
        private System.Windows.Forms.Label lblclasificacionPeli;
        private System.Windows.Forms.Label lblclasificacion;
        private System.Windows.Forms.PictureBox pbmenosHabilitado;
        private System.Windows.Forms.PictureBox pbmenosHabilitado2;
        private System.Windows.Forms.PictureBox pbimagenMenos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltipoSalaPeli;
        private System.Windows.Forms.Label lbltiposala;
    }
}