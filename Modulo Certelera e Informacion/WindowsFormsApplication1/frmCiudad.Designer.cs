namespace WindowsFormsApplication1
{
    partial class frmCiudad
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiudad));
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbCine = new System.Windows.Forms.ComboBox();
            this.btnCartelera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(60, 105);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(179, 27);
            this.cmbCiudad.TabIndex = 0;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // cmbCine
            // 
            this.cmbCine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCine.FormattingEnabled = true;
            this.cmbCine.Location = new System.Drawing.Point(290, 105);
            this.cmbCine.Name = "cmbCine";
            this.cmbCine.Size = new System.Drawing.Size(204, 27);
            this.cmbCine.TabIndex = 1;
            // 
            // btnCartelera
            // 
            this.btnCartelera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartelera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCartelera.Image = global::WindowsFormsApplication1.Properties.Resources._1438150045_popcorn;
            this.btnCartelera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartelera.Location = new System.Drawing.Point(215, 176);
            this.btnCartelera.Name = "btnCartelera";
            this.btnCartelera.Size = new System.Drawing.Size(114, 60);
            this.btnCartelera.TabIndex = 2;
            this.btnCartelera.Text = "Ver Cartelera";
            this.btnCartelera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCartelera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCartelera.UseVisualStyleBackColor = true;
            this.btnCartelera.Click += new System.EventHandler(this.btnCartelera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cine";
            // 
            // frmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(538, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCartelera);
            this.Controls.Add(this.cmbCine);
            this.Controls.Add(this.cmbCiudad);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbCine;
        private System.Windows.Forms.Button btnCartelera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

