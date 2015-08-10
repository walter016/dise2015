namespace admin
{
    partial class frmingresarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmingresarPelicula));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ccategoriaPelicula = new System.Windows.Forms.ComboBox();
            this.txtpuntosBonificacion = new System.Windows.Forms.TextBox();
            this.lpuntosBonificacion = new System.Windows.Forms.Label();
            this.txtelencoPelicula = new System.Windows.Forms.TextBox();
            this.txtduracionPelicula = new System.Windows.Forms.TextBox();
            this.lelencoPelicula = new System.Windows.Forms.Label();
            this.lduracionPelicula = new System.Windows.Forms.Label();
            this.lcategoriaPelicula = new System.Windows.Forms.Label();
            this.bseleccionarImagen = new System.Windows.Forms.Button();
            this.txtrutaImagen = new System.Windows.Forms.TextBox();
            this.pimagenPelicula = new System.Windows.Forms.PictureBox();
            this.bguardar = new System.Windows.Forms.Button();
            this.csubtitulo = new System.Windows.Forms.ComboBox();
            this.cidioma = new System.Windows.Forms.ComboBox();
            this.cestablecimiento = new System.Windows.Forms.ComboBox();
            this.cdepartamento = new System.Windows.Forms.ComboBox();
            this.cclasificacionContenidos = new System.Windows.Forms.ComboBox();
            this.csalasCine = new System.Windows.Forms.ComboBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lsubtitulo = new System.Windows.Forms.Label();
            this.lidioma = new System.Windows.Forms.Label();
            this.lestablecimiento = new System.Windows.Forms.Label();
            this.ldepartamento = new System.Windows.Forms.Label();
            this.lclasificacion = new System.Windows.Forms.Label();
            this.lsalasCine = new System.Windows.Forms.Label();
            this.ldescuento = new System.Windows.Forms.Label();
            this.lcosto = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimagenPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ccategoriaPelicula);
            this.groupBox1.Controls.Add(this.txtpuntosBonificacion);
            this.groupBox1.Controls.Add(this.lpuntosBonificacion);
            this.groupBox1.Controls.Add(this.txtelencoPelicula);
            this.groupBox1.Controls.Add(this.txtduracionPelicula);
            this.groupBox1.Controls.Add(this.lelencoPelicula);
            this.groupBox1.Controls.Add(this.lduracionPelicula);
            this.groupBox1.Controls.Add(this.lcategoriaPelicula);
            this.groupBox1.Controls.Add(this.bseleccionarImagen);
            this.groupBox1.Controls.Add(this.txtrutaImagen);
            this.groupBox1.Controls.Add(this.pimagenPelicula);
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.csubtitulo);
            this.groupBox1.Controls.Add(this.cidioma);
            this.groupBox1.Controls.Add(this.cestablecimiento);
            this.groupBox1.Controls.Add(this.cdepartamento);
            this.groupBox1.Controls.Add(this.cclasificacionContenidos);
            this.groupBox1.Controls.Add(this.csalasCine);
            this.groupBox1.Controls.Add(this.txtdescuento);
            this.groupBox1.Controls.Add(this.txtcosto);
            this.groupBox1.Controls.Add(this.txttitulo);
            this.groupBox1.Controls.Add(this.lsubtitulo);
            this.groupBox1.Controls.Add(this.lidioma);
            this.groupBox1.Controls.Add(this.lestablecimiento);
            this.groupBox1.Controls.Add(this.ldepartamento);
            this.groupBox1.Controls.Add(this.lclasificacion);
            this.groupBox1.Controls.Add(this.lsalasCine);
            this.groupBox1.Controls.Add(this.ldescuento);
            this.groupBox1.Controls.Add(this.lcosto);
            this.groupBox1.Controls.Add(this.lnombre);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 638);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Hrs.";
            // 
            // ccategoriaPelicula
            // 
            this.ccategoriaPelicula.FormattingEnabled = true;
            this.ccategoriaPelicula.Items.AddRange(new object[] {
            "Animación",
            "Terror",
            "Drama",
            "Comedia",
            "Romance",
            "Thriller"});
            this.ccategoriaPelicula.Location = new System.Drawing.Point(115, 266);
            this.ccategoriaPelicula.Name = "ccategoriaPelicula";
            this.ccategoriaPelicula.Size = new System.Drawing.Size(285, 27);
            this.ccategoriaPelicula.TabIndex = 37;
            // 
            // txtpuntosBonificacion
            // 
            this.txtpuntosBonificacion.Location = new System.Drawing.Point(164, 497);
            this.txtpuntosBonificacion.Name = "txtpuntosBonificacion";
            this.txtpuntosBonificacion.Size = new System.Drawing.Size(236, 27);
            this.txtpuntosBonificacion.TabIndex = 36;
            // 
            // lpuntosBonificacion
            // 
            this.lpuntosBonificacion.AutoSize = true;
            this.lpuntosBonificacion.Location = new System.Drawing.Point(6, 497);
            this.lpuntosBonificacion.Name = "lpuntosBonificacion";
            this.lpuntosBonificacion.Size = new System.Drawing.Size(160, 19);
            this.lpuntosBonificacion.TabIndex = 35;
            this.lpuntosBonificacion.Text = "Puntos de Bonificación:";
            // 
            // txtelencoPelicula
            // 
            this.txtelencoPelicula.Location = new System.Drawing.Point(115, 304);
            this.txtelencoPelicula.Name = "txtelencoPelicula";
            this.txtelencoPelicula.Size = new System.Drawing.Size(285, 27);
            this.txtelencoPelicula.TabIndex = 32;
            // 
            // txtduracionPelicula
            // 
            this.txtduracionPelicula.Location = new System.Drawing.Point(115, 146);
            this.txtduracionPelicula.Name = "txtduracionPelicula";
            this.txtduracionPelicula.Size = new System.Drawing.Size(285, 27);
            this.txtduracionPelicula.TabIndex = 30;
            // 
            // lelencoPelicula
            // 
            this.lelencoPelicula.AutoSize = true;
            this.lelencoPelicula.Location = new System.Drawing.Point(6, 304);
            this.lelencoPelicula.Name = "lelencoPelicula";
            this.lelencoPelicula.Size = new System.Drawing.Size(56, 19);
            this.lelencoPelicula.TabIndex = 29;
            this.lelencoPelicula.Text = "Elenco:";
            // 
            // lduracionPelicula
            // 
            this.lduracionPelicula.AutoSize = true;
            this.lduracionPelicula.Location = new System.Drawing.Point(6, 146);
            this.lduracionPelicula.Name = "lduracionPelicula";
            this.lduracionPelicula.Size = new System.Drawing.Size(71, 19);
            this.lduracionPelicula.TabIndex = 28;
            this.lduracionPelicula.Text = "Duración:";
            // 
            // lcategoriaPelicula
            // 
            this.lcategoriaPelicula.AutoSize = true;
            this.lcategoriaPelicula.Location = new System.Drawing.Point(6, 266);
            this.lcategoriaPelicula.Name = "lcategoriaPelicula";
            this.lcategoriaPelicula.Size = new System.Drawing.Size(76, 19);
            this.lcategoriaPelicula.TabIndex = 27;
            this.lcategoriaPelicula.Text = "Categoría:";
            // 
            // bseleccionarImagen
            // 
            this.bseleccionarImagen.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bseleccionarImagen.Location = new System.Drawing.Point(558, 298);
            this.bseleccionarImagen.Name = "bseleccionarImagen";
            this.bseleccionarImagen.Size = new System.Drawing.Size(110, 50);
            this.bseleccionarImagen.TabIndex = 26;
            this.bseleccionarImagen.Text = "Seleccion Imagen";
            this.bseleccionarImagen.UseVisualStyleBackColor = true;
            this.bseleccionarImagen.Click += new System.EventHandler(this.bseleccionarImagen_Click);
            // 
            // txtrutaImagen
            // 
            this.txtrutaImagen.Location = new System.Drawing.Point(463, 260);
            this.txtrutaImagen.Name = "txtrutaImagen";
            this.txtrutaImagen.Size = new System.Drawing.Size(285, 27);
            this.txtrutaImagen.TabIndex = 25;
            // 
            // pimagenPelicula
            // 
            this.pimagenPelicula.Location = new System.Drawing.Point(540, 32);
            this.pimagenPelicula.Name = "pimagenPelicula";
            this.pimagenPelicula.Size = new System.Drawing.Size(139, 203);
            this.pimagenPelicula.TabIndex = 24;
            this.pimagenPelicula.TabStop = false;
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Image = global::admin.Properties.Resources.save;
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(558, 475);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(110, 50);
            this.bguardar.TabIndex = 22;
            this.bguardar.Text = "          Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // csubtitulo
            // 
            this.csubtitulo.FormattingEnabled = true;
            this.csubtitulo.Items.AddRange(new object[] {
            "Subtitulos en Español",
            "Subtitulos en Ingles",
            "Sin Subtitulos"});
            this.csubtitulo.Location = new System.Drawing.Point(115, 456);
            this.csubtitulo.Name = "csubtitulo";
            this.csubtitulo.Size = new System.Drawing.Size(285, 27);
            this.csubtitulo.TabIndex = 21;
            // 
            // cidioma
            // 
            this.cidioma.FormattingEnabled = true;
            this.cidioma.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Portugues",
            "Frances",
            "Italiano",
            "Aleman",
            "Ruso",
            "Chino",
            "Japones"});
            this.cidioma.Location = new System.Drawing.Point(115, 418);
            this.cidioma.Name = "cidioma";
            this.cidioma.Size = new System.Drawing.Size(285, 27);
            this.cidioma.TabIndex = 20;
            // 
            // cestablecimiento
            // 
            this.cestablecimiento.FormattingEnabled = true;
            this.cestablecimiento.Location = new System.Drawing.Point(125, 380);
            this.cestablecimiento.Name = "cestablecimiento";
            this.cestablecimiento.Size = new System.Drawing.Size(275, 27);
            this.cestablecimiento.TabIndex = 19;
            // 
            // cdepartamento
            // 
            this.cdepartamento.FormattingEnabled = true;
            this.cdepartamento.Items.AddRange(new object[] {
            "Guatemala",
            "Escuintla",
            "Quetzaltenango"});
            this.cdepartamento.Location = new System.Drawing.Point(115, 342);
            this.cdepartamento.Name = "cdepartamento";
            this.cdepartamento.Size = new System.Drawing.Size(285, 27);
            this.cdepartamento.TabIndex = 18;
            // 
            // cclasificacionContenidos
            // 
            this.cclasificacionContenidos.FormattingEnabled = true;
            this.cclasificacionContenidos.Items.AddRange(new object[] {
            "AA(Apto para todo público, en especial para niños)",
            "A (Apto para todo público)",
            "B (Apto para mayores de 12 años)",
            "B- para mayores de o 15 años si es para el cine con 11 años esta bien )",
            "C (Mayores de 18 años)",
            "D (Mayores de 21 años)"});
            this.cclasificacionContenidos.Location = new System.Drawing.Point(197, 228);
            this.cclasificacionContenidos.Name = "cclasificacionContenidos";
            this.cclasificacionContenidos.Size = new System.Drawing.Size(203, 27);
            this.cclasificacionContenidos.TabIndex = 17;
            // 
            // csalasCine
            // 
            this.csalasCine.FormattingEnabled = true;
            this.csalasCine.Items.AddRange(new object[] {
            "3D",
            "4D ",
            "IMAX"});
            this.csalasCine.Location = new System.Drawing.Point(115, 190);
            this.csalasCine.Name = "csalasCine";
            this.csalasCine.Size = new System.Drawing.Size(285, 27);
            this.csalasCine.TabIndex = 16;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(115, 108);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(285, 27);
            this.txtdescuento.TabIndex = 13;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(115, 70);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(285, 27);
            this.txtcosto.TabIndex = 12;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(115, 32);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(285, 27);
            this.txttitulo.TabIndex = 11;
            // 
            // lsubtitulo
            // 
            this.lsubtitulo.AutoSize = true;
            this.lsubtitulo.Location = new System.Drawing.Point(6, 456);
            this.lsubtitulo.Name = "lsubtitulo";
            this.lsubtitulo.Size = new System.Drawing.Size(86, 19);
            this.lsubtitulo.TabIndex = 10;
            this.lsubtitulo.Text = "Subtitulado:";
            // 
            // lidioma
            // 
            this.lidioma.AutoSize = true;
            this.lidioma.Location = new System.Drawing.Point(6, 418);
            this.lidioma.Name = "lidioma";
            this.lidioma.Size = new System.Drawing.Size(57, 19);
            this.lidioma.TabIndex = 9;
            this.lidioma.Text = "Idioma:";
            // 
            // lestablecimiento
            // 
            this.lestablecimiento.AutoSize = true;
            this.lestablecimiento.Location = new System.Drawing.Point(6, 380);
            this.lestablecimiento.Name = "lestablecimiento";
            this.lestablecimiento.Size = new System.Drawing.Size(117, 19);
            this.lestablecimiento.TabIndex = 8;
            this.lestablecimiento.Text = "Establecimiento:";
            // 
            // ldepartamento
            // 
            this.ldepartamento.AutoSize = true;
            this.ldepartamento.Location = new System.Drawing.Point(6, 342);
            this.ldepartamento.Name = "ldepartamento";
            this.ldepartamento.Size = new System.Drawing.Size(106, 19);
            this.ldepartamento.TabIndex = 7;
            this.ldepartamento.Text = "Departamento:";
            // 
            // lclasificacion
            // 
            this.lclasificacion.AutoSize = true;
            this.lclasificacion.Location = new System.Drawing.Point(6, 228);
            this.lclasificacion.Name = "lclasificacion";
            this.lclasificacion.Size = new System.Drawing.Size(185, 19);
            this.lclasificacion.TabIndex = 6;
            this.lclasificacion.Text = "Clasificacion de Contenido:";
            // 
            // lsalasCine
            // 
            this.lsalasCine.AutoSize = true;
            this.lsalasCine.Location = new System.Drawing.Point(6, 190);
            this.lsalasCine.Name = "lsalasCine";
            this.lsalasCine.Size = new System.Drawing.Size(100, 19);
            this.lsalasCine.TabIndex = 5;
            this.lsalasCine.Text = "Salas de Cine:";
            // 
            // ldescuento
            // 
            this.ldescuento.AutoSize = true;
            this.ldescuento.Location = new System.Drawing.Point(6, 108);
            this.ldescuento.Name = "ldescuento";
            this.ldescuento.Size = new System.Drawing.Size(113, 19);
            this.ldescuento.TabIndex = 2;
            this.ldescuento.Text = "Descuento:    Q.";
            // 
            // lcosto
            // 
            this.lcosto.AutoSize = true;
            this.lcosto.Location = new System.Drawing.Point(6, 70);
            this.lcosto.Name = "lcosto";
            this.lcosto.Size = new System.Drawing.Size(113, 19);
            this.lcosto.TabIndex = 1;
            this.lcosto.Text = "Costo:            Q.";
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(6, 32);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(50, 19);
            this.lnombre.TabIndex = 0;
            this.lnombre.Text = "Título:";
            // 
            // frmingresarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(780, 549);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmingresarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Registro de Pelicula";
            this.Load += new System.EventHandler(this.frmingresarPelicula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimagenPelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lsubtitulo;
        private System.Windows.Forms.Label lidioma;
        private System.Windows.Forms.Label lestablecimiento;
        private System.Windows.Forms.Label ldepartamento;
        private System.Windows.Forms.Label lclasificacion;
        private System.Windows.Forms.Label lsalasCine;
        private System.Windows.Forms.Label ldescuento;
        private System.Windows.Forms.Label lcosto;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.ComboBox csubtitulo;
        private System.Windows.Forms.ComboBox cidioma;
        private System.Windows.Forms.ComboBox cestablecimiento;
        private System.Windows.Forms.ComboBox cdepartamento;
        private System.Windows.Forms.ComboBox cclasificacionContenidos;
        private System.Windows.Forms.ComboBox csalasCine;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.TextBox txtrutaImagen;
        private System.Windows.Forms.PictureBox pimagenPelicula;
        private System.Windows.Forms.Button bseleccionarImagen;
        private System.Windows.Forms.TextBox txtelencoPelicula;
        private System.Windows.Forms.TextBox txtduracionPelicula;
        private System.Windows.Forms.Label lelencoPelicula;
        private System.Windows.Forms.Label lduracionPelicula;
        private System.Windows.Forms.Label lcategoriaPelicula;
        private System.Windows.Forms.TextBox txtpuntosBonificacion;
        private System.Windows.Forms.Label lpuntosBonificacion;
        private System.Windows.Forms.ComboBox ccategoriaPelicula;
        private System.Windows.Forms.Label label1;
    }
}