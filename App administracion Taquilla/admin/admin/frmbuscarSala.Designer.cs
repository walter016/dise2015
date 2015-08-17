namespace admin
{
    partial class frmbuscarSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbuscarSala));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnuevabusqueda = new System.Windows.Forms.Button();
            this.txtcapacidadSala = new System.Windows.Forms.TextBox();
            this.lcapacidadSala = new System.Windows.Forms.Label();
            this.grdinformacionSala = new System.Windows.Forms.DataGridView();
            this.lnombreSala = new System.Windows.Forms.Label();
            this.txtbuscarSala = new System.Windows.Forms.TextBox();
            this.bbuscarSala = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdinformacionSala)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnuevabusqueda);
            this.groupBox1.Controls.Add(this.txtcapacidadSala);
            this.groupBox1.Controls.Add(this.lcapacidadSala);
            this.groupBox1.Controls.Add(this.grdinformacionSala);
            this.groupBox1.Controls.Add(this.lnombreSala);
            this.groupBox1.Controls.Add(this.txtbuscarSala);
            this.groupBox1.Controls.Add(this.bbuscarSala);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // bnuevabusqueda
            // 
            this.bnuevabusqueda.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevabusqueda.Image = global::admin.Properties.Resources.icono_busqueda;
            this.bnuevabusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnuevabusqueda.Location = new System.Drawing.Point(626, 26);
            this.bnuevabusqueda.Name = "bnuevabusqueda";
            this.bnuevabusqueda.Size = new System.Drawing.Size(99, 50);
            this.bnuevabusqueda.TabIndex = 6;
            this.bnuevabusqueda.Text = " Nueva Busqueda";
            this.bnuevabusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnuevabusqueda.UseVisualStyleBackColor = true;
            this.bnuevabusqueda.Click += new System.EventHandler(this.bnuevabusqueda_Click);
            // 
            // txtcapacidadSala
            // 
            this.txtcapacidadSala.Location = new System.Drawing.Point(102, 68);
            this.txtcapacidadSala.Name = "txtcapacidadSala";
            this.txtcapacidadSala.Size = new System.Drawing.Size(107, 27);
            this.txtcapacidadSala.TabIndex = 5;
            // 
            // lcapacidadSala
            // 
            this.lcapacidadSala.AutoSize = true;
            this.lcapacidadSala.Location = new System.Drawing.Point(15, 71);
            this.lcapacidadSala.Name = "lcapacidadSala";
            this.lcapacidadSala.Size = new System.Drawing.Size(81, 19);
            this.lcapacidadSala.TabIndex = 4;
            this.lcapacidadSala.Text = "Capacidad:";
            // 
            // grdinformacionSala
            // 
            this.grdinformacionSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdinformacionSala.Location = new System.Drawing.Point(28, 111);
            this.grdinformacionSala.Name = "grdinformacionSala";
            this.grdinformacionSala.Size = new System.Drawing.Size(659, 257);
            this.grdinformacionSala.TabIndex = 3;
            // 
            // lnombreSala
            // 
            this.lnombreSala.AutoSize = true;
            this.lnombreSala.Location = new System.Drawing.Point(15, 29);
            this.lnombreSala.Name = "lnombreSala";
            this.lnombreSala.Size = new System.Drawing.Size(72, 19);
            this.lnombreSala.TabIndex = 2;
            this.lnombreSala.Text = "Tipo Sala:";
            // 
            // txtbuscarSala
            // 
            this.txtbuscarSala.Location = new System.Drawing.Point(102, 26);
            this.txtbuscarSala.Name = "txtbuscarSala";
            this.txtbuscarSala.Size = new System.Drawing.Size(385, 27);
            this.txtbuscarSala.TabIndex = 1;
            // 
            // bbuscarSala
            // 
            this.bbuscarSala.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscarSala.Image = global::admin.Properties.Resources.search;
            this.bbuscarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbuscarSala.Location = new System.Drawing.Point(510, 26);
            this.bbuscarSala.Name = "bbuscarSala";
            this.bbuscarSala.Size = new System.Drawing.Size(110, 50);
            this.bbuscarSala.TabIndex = 0;
            this.bbuscarSala.Text = "       Buscar";
            this.bbuscarSala.UseVisualStyleBackColor = true;
            this.bbuscarSala.Click += new System.EventHandler(this.bbuscarSala_Click);
            // 
            // frmbuscarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 399);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbuscarSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Busqueda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdinformacionSala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bbuscarSala;
        private System.Windows.Forms.TextBox txtbuscarSala;
        private System.Windows.Forms.Label lnombreSala;
        private System.Windows.Forms.DataGridView grdinformacionSala;
        private System.Windows.Forms.TextBox txtcapacidadSala;
        private System.Windows.Forms.Label lcapacidadSala;
        private System.Windows.Forms.Button bnuevabusqueda;
    }
}