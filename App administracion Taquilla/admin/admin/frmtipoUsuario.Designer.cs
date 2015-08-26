namespace admin
{
    partial class frmtipoUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bguardar = new System.Windows.Forms.Button();
            this.txttipoUsuario = new System.Windows.Forms.TextBox();
            this.ltipoUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.txttipoUsuario);
            this.groupBox1.Controls.Add(this.ltipoUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Image = global::admin.Properties.Resources.save;
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(154, 71);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(110, 50);
            this.bguardar.TabIndex = 6;
            this.bguardar.Text = "          Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // txttipoUsuario
            // 
            this.txttipoUsuario.Location = new System.Drawing.Point(105, 29);
            this.txttipoUsuario.Name = "txttipoUsuario";
            this.txttipoUsuario.Size = new System.Drawing.Size(285, 27);
            this.txttipoUsuario.TabIndex = 3;
            // 
            // ltipoUsuario
            // 
            this.ltipoUsuario.AutoSize = true;
            this.ltipoUsuario.Location = new System.Drawing.Point(6, 32);
            this.ltipoUsuario.Name = "ltipoUsuario";
            this.ltipoUsuario.Size = new System.Drawing.Size(95, 19);
            this.ltipoUsuario.TabIndex = 0;
            this.ltipoUsuario.Text = "Tipo Usuario:";
            // 
            // frmtipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 169);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmtipoUsuario";
            this.Text = "Tipo Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.TextBox txttipoUsuario;
        private System.Windows.Forms.Label ltipoUsuario;
    }
}