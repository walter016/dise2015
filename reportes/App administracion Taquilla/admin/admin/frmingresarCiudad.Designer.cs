namespace admin
{
    partial class frmingresarCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmingresarCiudad));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bguardar = new System.Windows.Forms.Button();
            this.txtnombreCiudad = new System.Windows.Forms.TextBox();
            this.lnombreCiudad = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.txtnombreCiudad);
            this.groupBox1.Controls.Add(this.lnombreCiudad);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Image = global::admin.Properties.Resources.save;
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(152, 75);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(110, 50);
            this.bguardar.TabIndex = 6;
            this.bguardar.Text = "          Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // txtnombreCiudad
            // 
            this.txtnombreCiudad.Location = new System.Drawing.Point(86, 32);
            this.txtnombreCiudad.Name = "txtnombreCiudad";
            this.txtnombreCiudad.Size = new System.Drawing.Size(285, 27);
            this.txtnombreCiudad.TabIndex = 3;
            this.txtnombreCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreCiudad_KeyPress);
            // 
            // lnombreCiudad
            // 
            this.lnombreCiudad.AutoSize = true;
            this.lnombreCiudad.Location = new System.Drawing.Point(6, 32);
            this.lnombreCiudad.Name = "lnombreCiudad";
            this.lnombreCiudad.Size = new System.Drawing.Size(64, 19);
            this.lnombreCiudad.TabIndex = 0;
            this.lnombreCiudad.Text = "Nombre:";
            // 
            // frmingresarCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 158);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmingresarCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Registro de Ciudad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.TextBox txtnombreCiudad;
        private System.Windows.Forms.Label lnombreCiudad;
    }
}