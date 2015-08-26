namespace admin
{
    partial class frmingresarSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmingresarSala));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.csucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bguardar = new System.Windows.Forms.Button();
            this.ctipoSala = new System.Windows.Forms.ComboBox();
            this.ltipoSala = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.csucursal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.ctipoSala);
            this.groupBox1.Controls.Add(this.ltipoSala);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // csucursal
            // 
            this.csucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.csucursal.FormattingEnabled = true;
            this.csucursal.Location = new System.Drawing.Point(160, 29);
            this.csucursal.Name = "csucursal";
            this.csucursal.Size = new System.Drawing.Size(285, 27);
            this.csucursal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sucursal:";
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Image = global::admin.Properties.Resources.save;
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(135, 134);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(110, 50);
            this.bguardar.TabIndex = 4;
            this.bguardar.Text = "          Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // ctipoSala
            // 
            this.ctipoSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctipoSala.FormattingEnabled = true;
            this.ctipoSala.Location = new System.Drawing.Point(160, 80);
            this.ctipoSala.Name = "ctipoSala";
            this.ctipoSala.Size = new System.Drawing.Size(285, 27);
            this.ctipoSala.TabIndex = 3;
            // 
            // ltipoSala
            // 
            this.ltipoSala.AutoSize = true;
            this.ltipoSala.Location = new System.Drawing.Point(6, 80);
            this.ltipoSala.Name = "ltipoSala";
            this.ltipoSala.Size = new System.Drawing.Size(92, 19);
            this.ltipoSala.TabIndex = 1;
            this.ltipoSala.Text = "Tipo de Sala:";
            // 
            // frmingresarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 229);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmingresarSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Registro de Sala";
            this.Load += new System.EventHandler(this.frmingresarSala_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.ComboBox ctipoSala;
        private System.Windows.Forms.Label ltipoSala;
        private System.Windows.Forms.ComboBox csucursal;
        private System.Windows.Forms.Label label1;
    }
}