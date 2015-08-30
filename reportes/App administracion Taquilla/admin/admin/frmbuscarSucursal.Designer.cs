namespace admin
{
    partial class frmbuscarSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbuscarSucursal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdinformacionSucursal = new System.Windows.Forms.DataGridView();
            this.lnombreSucursal = new System.Windows.Forms.Label();
            this.txtbuscarSucursal = new System.Windows.Forms.TextBox();
            this.bbuscarSucursal = new System.Windows.Forms.Button();
            this.bnuevabusqueda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdinformacionSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnuevabusqueda);
            this.groupBox1.Controls.Add(this.grdinformacionSucursal);
            this.groupBox1.Controls.Add(this.lnombreSucursal);
            this.groupBox1.Controls.Add(this.txtbuscarSucursal);
            this.groupBox1.Controls.Add(this.bbuscarSucursal);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // grdinformacionSucursal
            // 
            this.grdinformacionSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdinformacionSucursal.Location = new System.Drawing.Point(11, 80);
            this.grdinformacionSucursal.Name = "grdinformacionSucursal";
            this.grdinformacionSucursal.Size = new System.Drawing.Size(659, 257);
            this.grdinformacionSucursal.TabIndex = 3;
            // 
            // lnombreSucursal
            // 
            this.lnombreSucursal.AutoSize = true;
            this.lnombreSucursal.Location = new System.Drawing.Point(7, 27);
            this.lnombreSucursal.Name = "lnombreSucursal";
            this.lnombreSucursal.Size = new System.Drawing.Size(158, 19);
            this.lnombreSucursal.TabIndex = 2;
            this.lnombreSucursal.Text = "Nombre de la Sucursal:";
            // 
            // txtbuscarSucursal
            // 
            this.txtbuscarSucursal.Location = new System.Drawing.Point(169, 27);
            this.txtbuscarSucursal.Name = "txtbuscarSucursal";
            this.txtbuscarSucursal.Size = new System.Drawing.Size(274, 27);
            this.txtbuscarSucursal.TabIndex = 1;
            // 
            // bbuscarSucursal
            // 
            this.bbuscarSucursal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscarSucursal.Image = global::admin.Properties.Resources.search;
            this.bbuscarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbuscarSucursal.Location = new System.Drawing.Point(449, 15);
            this.bbuscarSucursal.Name = "bbuscarSucursal";
            this.bbuscarSucursal.Size = new System.Drawing.Size(110, 50);
            this.bbuscarSucursal.TabIndex = 0;
            this.bbuscarSucursal.Text = "       Buscar";
            this.bbuscarSucursal.UseVisualStyleBackColor = true;
            this.bbuscarSucursal.Click += new System.EventHandler(this.bbuscarSucursal_Click);
            // 
            // bnuevabusqueda
            // 
            this.bnuevabusqueda.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevabusqueda.Image = global::admin.Properties.Resources.icono_busqueda;
            this.bnuevabusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnuevabusqueda.Location = new System.Drawing.Point(565, 15);
            this.bnuevabusqueda.Name = "bnuevabusqueda";
            this.bnuevabusqueda.Size = new System.Drawing.Size(108, 50);
            this.bnuevabusqueda.TabIndex = 16;
            this.bnuevabusqueda.Text = " Nueva Busqueda";
            this.bnuevabusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnuevabusqueda.UseVisualStyleBackColor = true;
            this.bnuevabusqueda.Click += new System.EventHandler(this.bnuevabusqueda_Click);
            // 
            // frmbuscarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(699, 368);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbuscarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Busqueda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdinformacionSucursal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bbuscarSucursal;
        private System.Windows.Forms.TextBox txtbuscarSucursal;
        private System.Windows.Forms.Label lnombreSucursal;
        private System.Windows.Forms.DataGridView grdinformacionSucursal;
        private System.Windows.Forms.Button bnuevabusqueda;
    }
}