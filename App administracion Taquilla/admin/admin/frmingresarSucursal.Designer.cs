namespace admin
{
    partial class frmingresarSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmingresarSucursal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cciudad = new System.Windows.Forms.ComboBox();
            this.bguardar = new System.Windows.Forms.Button();
            this.cestadoSucursal = new System.Windows.Forms.ComboBox();
            this.txtdireccionSucursal = new System.Windows.Forms.TextBox();
            this.lestadoSucursal = new System.Windows.Forms.Label();
            this.lciudad = new System.Windows.Forms.Label();
            this.lnombreSucursal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cciudad);
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.cestadoSucursal);
            this.groupBox1.Controls.Add(this.txtdireccionSucursal);
            this.groupBox1.Controls.Add(this.lestadoSucursal);
            this.groupBox1.Controls.Add(this.lciudad);
            this.groupBox1.Controls.Add(this.lnombreSucursal);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // cciudad
            // 
            this.cciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cciudad.FormattingEnabled = true;
            this.cciudad.Location = new System.Drawing.Point(160, 32);
            this.cciudad.Name = "cciudad";
            this.cciudad.Size = new System.Drawing.Size(285, 27);
            this.cciudad.TabIndex = 0;
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Image = global::admin.Properties.Resources.save;
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(175, 164);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(110, 50);
            this.bguardar.TabIndex = 3;
            this.bguardar.Text = "          Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // cestadoSucursal
            // 
            this.cestadoSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cestadoSucursal.FormattingEnabled = true;
            this.cestadoSucursal.Location = new System.Drawing.Point(160, 108);
            this.cestadoSucursal.Name = "cestadoSucursal";
            this.cestadoSucursal.Size = new System.Drawing.Size(285, 27);
            this.cestadoSucursal.TabIndex = 2;
            // 
            // txtdireccionSucursal
            // 
            this.txtdireccionSucursal.Location = new System.Drawing.Point(160, 70);
            this.txtdireccionSucursal.Name = "txtdireccionSucursal";
            this.txtdireccionSucursal.Size = new System.Drawing.Size(285, 27);
            this.txtdireccionSucursal.TabIndex = 1;
            this.txtdireccionSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccionSucursal_KeyPress);
            // 
            // lestadoSucursal
            // 
            this.lestadoSucursal.AutoSize = true;
            this.lestadoSucursal.Location = new System.Drawing.Point(6, 108);
            this.lestadoSucursal.Name = "lestadoSucursal";
            this.lestadoSucursal.Size = new System.Drawing.Size(151, 19);
            this.lestadoSucursal.TabIndex = 2;
            this.lestadoSucursal.Text = "Estado de la Sucursal:";
            // 
            // lciudad
            // 
            this.lciudad.AutoSize = true;
            this.lciudad.Location = new System.Drawing.Point(6, 35);
            this.lciudad.Name = "lciudad";
            this.lciudad.Size = new System.Drawing.Size(58, 19);
            this.lciudad.TabIndex = 1;
            this.lciudad.Text = "Ciudad:";
            // 
            // lnombreSucursal
            // 
            this.lnombreSucursal.AutoSize = true;
            this.lnombreSucursal.Location = new System.Drawing.Point(6, 73);
            this.lnombreSucursal.Name = "lnombreSucursal";
            this.lnombreSucursal.Size = new System.Drawing.Size(64, 19);
            this.lnombreSucursal.TabIndex = 0;
            this.lnombreSucursal.Text = "Nombre:";
            // 
            // frmingresarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 251);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmingresarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Registro de Sucursal";
            this.Load += new System.EventHandler(this.frmingresarSucursal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lestadoSucursal;
        private System.Windows.Forms.Label lciudad;
        private System.Windows.Forms.Label lnombreSucursal;
        private System.Windows.Forms.ComboBox cestadoSucursal;
        private System.Windows.Forms.TextBox txtdireccionSucursal;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.ComboBox cciudad;
    }
}