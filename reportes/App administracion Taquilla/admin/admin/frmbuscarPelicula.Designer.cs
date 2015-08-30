namespace admin
{
    partial class frmbuscarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbuscarPelicula));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bcancelarPelicula = new System.Windows.Forms.Button();
            this.baceptarPelicula = new System.Windows.Forms.Button();
            this.txtbuscarFormatoPeli = new System.Windows.Forms.TextBox();
            this.lformatoPelicula = new System.Windows.Forms.Label();
            this.txtbuscarClasificacionPeli = new System.Windows.Forms.TextBox();
            this.lclasificacionPelicula = new System.Windows.Forms.Label();
            this.lgeneroPelicula = new System.Windows.Forms.Label();
            this.txtbuscarGeneroPelicula = new System.Windows.Forms.TextBox();
            this.txtbuscarsubtitulo = new System.Windows.Forms.TextBox();
            this.lpeliculaSubtitulada = new System.Windows.Forms.Label();
            this.bbuscarPelicula = new System.Windows.Forms.Button();
            this.grdinformacionPelicula = new System.Windows.Forms.DataGridView();
            this.txtbuscarPelicula = new System.Windows.Forms.TextBox();
            this.lnombrePelicula = new System.Windows.Forms.Label();
            this.bnuevabusqueda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdinformacionPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnuevabusqueda);
            this.groupBox1.Controls.Add(this.bcancelarPelicula);
            this.groupBox1.Controls.Add(this.baceptarPelicula);
            this.groupBox1.Controls.Add(this.txtbuscarFormatoPeli);
            this.groupBox1.Controls.Add(this.lformatoPelicula);
            this.groupBox1.Controls.Add(this.txtbuscarClasificacionPeli);
            this.groupBox1.Controls.Add(this.lclasificacionPelicula);
            this.groupBox1.Controls.Add(this.lgeneroPelicula);
            this.groupBox1.Controls.Add(this.txtbuscarGeneroPelicula);
            this.groupBox1.Controls.Add(this.txtbuscarsubtitulo);
            this.groupBox1.Controls.Add(this.lpeliculaSubtitulada);
            this.groupBox1.Controls.Add(this.bbuscarPelicula);
            this.groupBox1.Controls.Add(this.grdinformacionPelicula);
            this.groupBox1.Controls.Add(this.txtbuscarPelicula);
            this.groupBox1.Controls.Add(this.lnombrePelicula);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bcancelarPelicula
            // 
            this.bcancelarPelicula.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelarPelicula.Image = global::admin.Properties.Resources.cancelar;
            this.bcancelarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcancelarPelicula.Location = new System.Drawing.Point(436, 434);
            this.bcancelarPelicula.Name = "bcancelarPelicula";
            this.bcancelarPelicula.Size = new System.Drawing.Size(110, 40);
            this.bcancelarPelicula.TabIndex = 13;
            this.bcancelarPelicula.Text = "       Cancelar";
            this.bcancelarPelicula.UseVisualStyleBackColor = true;
            this.bcancelarPelicula.Click += new System.EventHandler(this.bcancelarPelicula_Click);
            // 
            // baceptarPelicula
            // 
            this.baceptarPelicula.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptarPelicula.Image = global::admin.Properties.Resources.aceptar;
            this.baceptarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baceptarPelicula.Location = new System.Drawing.Point(195, 435);
            this.baceptarPelicula.Name = "baceptarPelicula";
            this.baceptarPelicula.Size = new System.Drawing.Size(110, 40);
            this.baceptarPelicula.TabIndex = 12;
            this.baceptarPelicula.Text = "       Aceptar";
            this.baceptarPelicula.UseVisualStyleBackColor = true;
            this.baceptarPelicula.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbuscarFormatoPeli
            // 
            this.txtbuscarFormatoPeli.Location = new System.Drawing.Point(436, 105);
            this.txtbuscarFormatoPeli.Name = "txtbuscarFormatoPeli";
            this.txtbuscarFormatoPeli.Size = new System.Drawing.Size(198, 27);
            this.txtbuscarFormatoPeli.TabIndex = 11;
            // 
            // lformatoPelicula
            // 
            this.lformatoPelicula.AutoSize = true;
            this.lformatoPelicula.Location = new System.Drawing.Point(364, 108);
            this.lformatoPelicula.Name = "lformatoPelicula";
            this.lformatoPelicula.Size = new System.Drawing.Size(66, 19);
            this.lformatoPelicula.TabIndex = 10;
            this.lformatoPelicula.Text = "Formato:";
            // 
            // txtbuscarClasificacionPeli
            // 
            this.txtbuscarClasificacionPeli.Location = new System.Drawing.Point(436, 72);
            this.txtbuscarClasificacionPeli.Name = "txtbuscarClasificacionPeli";
            this.txtbuscarClasificacionPeli.Size = new System.Drawing.Size(198, 27);
            this.txtbuscarClasificacionPeli.TabIndex = 9;
            // 
            // lclasificacionPelicula
            // 
            this.lclasificacionPelicula.AutoSize = true;
            this.lclasificacionPelicula.Location = new System.Drawing.Point(335, 75);
            this.lclasificacionPelicula.Name = "lclasificacionPelicula";
            this.lclasificacionPelicula.Size = new System.Drawing.Size(95, 19);
            this.lclasificacionPelicula.TabIndex = 8;
            this.lclasificacionPelicula.Text = "Clasificacion:";
            // 
            // lgeneroPelicula
            // 
            this.lgeneroPelicula.AutoSize = true;
            this.lgeneroPelicula.Location = new System.Drawing.Point(61, 108);
            this.lgeneroPelicula.Name = "lgeneroPelicula";
            this.lgeneroPelicula.Size = new System.Drawing.Size(60, 19);
            this.lgeneroPelicula.TabIndex = 7;
            this.lgeneroPelicula.Text = "Genero:";
            // 
            // txtbuscarGeneroPelicula
            // 
            this.txtbuscarGeneroPelicula.Location = new System.Drawing.Point(127, 105);
            this.txtbuscarGeneroPelicula.Name = "txtbuscarGeneroPelicula";
            this.txtbuscarGeneroPelicula.Size = new System.Drawing.Size(198, 27);
            this.txtbuscarGeneroPelicula.TabIndex = 6;
            // 
            // txtbuscarsubtitulo
            // 
            this.txtbuscarsubtitulo.Location = new System.Drawing.Point(127, 72);
            this.txtbuscarsubtitulo.Name = "txtbuscarsubtitulo";
            this.txtbuscarsubtitulo.Size = new System.Drawing.Size(198, 27);
            this.txtbuscarsubtitulo.TabIndex = 5;
            // 
            // lpeliculaSubtitulada
            // 
            this.lpeliculaSubtitulada.AutoSize = true;
            this.lpeliculaSubtitulada.Location = new System.Drawing.Point(51, 75);
            this.lpeliculaSubtitulada.Name = "lpeliculaSubtitulada";
            this.lpeliculaSubtitulada.Size = new System.Drawing.Size(70, 19);
            this.lpeliculaSubtitulada.TabIndex = 4;
            this.lpeliculaSubtitulada.Text = "Subtitulo:";
            // 
            // bbuscarPelicula
            // 
            this.bbuscarPelicula.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscarPelicula.Image = global::admin.Properties.Resources.search1;
            this.bbuscarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbuscarPelicula.Location = new System.Drawing.Point(650, 23);
            this.bbuscarPelicula.Name = "bbuscarPelicula";
            this.bbuscarPelicula.Size = new System.Drawing.Size(110, 48);
            this.bbuscarPelicula.TabIndex = 3;
            this.bbuscarPelicula.Text = "       Buscar";
            this.bbuscarPelicula.UseVisualStyleBackColor = true;
            this.bbuscarPelicula.Click += new System.EventHandler(this.bbuscarPelicula_Click);
            // 
            // grdinformacionPelicula
            // 
            this.grdinformacionPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdinformacionPelicula.Location = new System.Drawing.Point(18, 159);
            this.grdinformacionPelicula.Name = "grdinformacionPelicula";
            this.grdinformacionPelicula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdinformacionPelicula.Size = new System.Drawing.Size(742, 270);
            this.grdinformacionPelicula.TabIndex = 2;
            // 
            // txtbuscarPelicula
            // 
            this.txtbuscarPelicula.Location = new System.Drawing.Point(213, 30);
            this.txtbuscarPelicula.Name = "txtbuscarPelicula";
            this.txtbuscarPelicula.Size = new System.Drawing.Size(385, 27);
            this.txtbuscarPelicula.TabIndex = 1;
            // 
            // lnombrePelicula
            // 
            this.lnombrePelicula.AutoSize = true;
            this.lnombrePelicula.Location = new System.Drawing.Point(52, 33);
            this.lnombrePelicula.Name = "lnombrePelicula";
            this.lnombrePelicula.Size = new System.Drawing.Size(155, 19);
            this.lnombrePelicula.TabIndex = 0;
            this.lnombrePelicula.Text = "Nombre de la Pelicula:";
            // 
            // bnuevabusqueda
            // 
            this.bnuevabusqueda.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevabusqueda.Image = global::admin.Properties.Resources.icono_busqueda;
            this.bnuevabusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnuevabusqueda.Location = new System.Drawing.Point(652, 77);
            this.bnuevabusqueda.Name = "bnuevabusqueda";
            this.bnuevabusqueda.Size = new System.Drawing.Size(108, 50);
            this.bnuevabusqueda.TabIndex = 15;
            this.bnuevabusqueda.Text = " Nueva Busqueda";
            this.bnuevabusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnuevabusqueda.UseVisualStyleBackColor = true;
            this.bnuevabusqueda.Click += new System.EventHandler(this.bnuevabusqueda_Click);
            // 
            // frmbuscarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(815, 505);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbuscarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Busqueda";
            this.Load += new System.EventHandler(this.frmbuscarPelicula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdinformacionPelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdinformacionPelicula;
        private System.Windows.Forms.TextBox txtbuscarPelicula;
        private System.Windows.Forms.Label lnombrePelicula;
        private System.Windows.Forms.Button bbuscarPelicula;
        private System.Windows.Forms.TextBox txtbuscarFormatoPeli;
        private System.Windows.Forms.Label lformatoPelicula;
        private System.Windows.Forms.TextBox txtbuscarClasificacionPeli;
        private System.Windows.Forms.Label lclasificacionPelicula;
        private System.Windows.Forms.Label lgeneroPelicula;
        private System.Windows.Forms.TextBox txtbuscarGeneroPelicula;
        private System.Windows.Forms.TextBox txtbuscarsubtitulo;
        private System.Windows.Forms.Label lpeliculaSubtitulada;
        private System.Windows.Forms.Button bcancelarPelicula;
        private System.Windows.Forms.Button baceptarPelicula;
        private System.Windows.Forms.Button bnuevabusqueda;
    }
}