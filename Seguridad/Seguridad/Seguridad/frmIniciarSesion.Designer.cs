namespace Bitacora
{
    partial class frmIniciarSesion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBxContra = new System.Windows.Forms.TextBox();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.biniciarSesion = new System.Windows.Forms.Button();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(58, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 79);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtBxContra
            // 
            this.txtBxContra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxContra.Location = new System.Drawing.Point(107, 147);
            this.txtBxContra.Name = "txtBxContra";
            this.txtBxContra.Size = new System.Drawing.Size(142, 27);
            this.txtBxContra.TabIndex = 19;
            this.txtBxContra.UseSystemPasswordChar = true;
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNombre.Location = new System.Drawing.Point(107, 114);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(142, 27);
            this.txtBxNombre.TabIndex = 18;
            // 
            // biniciarSesion
            // 
            this.biniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biniciarSesion.Location = new System.Drawing.Point(120, 193);
            this.biniciarSesion.Name = "biniciarSesion";
            this.biniciarSesion.Size = new System.Drawing.Size(103, 50);
            this.biniciarSesion.TabIndex = 17;
            this.biniciarSesion.Text = "Ingresar al Sistema";
            this.biniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.biniciarSesion.UseVisualStyleBackColor = true;
            this.biniciarSesion.Click += new System.EventHandler(this.biniciarSesion_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(18, 150);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(83, 19);
            this.Contraseña.TabIndex = 16;
            this.Contraseña.Text = "Contraseña";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(42, 117);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(59, 19);
            this.Usuario.TabIndex = 15;
            this.Usuario.Text = "Usuario";
            // 
            // frmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBxContra);
            this.Controls.Add(this.txtBxNombre);
            this.Controls.Add(this.biniciarSesion);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Name = "frmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIniciarSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBxContra;
        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.Button biniciarSesion;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label Usuario;
    }
}