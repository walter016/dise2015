namespace admin
{
    partial class frminiciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminiciarSesion));
            this.plogo = new System.Windows.Forms.PictureBox();
            this.biniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBxContra = new System.Windows.Forms.TextBox();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.plogo)).BeginInit();
            this.SuspendLayout();
            // 
            // plogo
            // 
            this.plogo.Image = global::admin.Properties.Resources.logo;
            this.plogo.Location = new System.Drawing.Point(12, 18);
            this.plogo.Name = "plogo";
            this.plogo.Size = new System.Drawing.Size(248, 225);
            this.plogo.TabIndex = 1;
            this.plogo.TabStop = false;
            // 
            // biniciarSesion
            // 
            this.biniciarSesion.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biniciarSesion.Image = global::admin.Properties.Resources.login;
            this.biniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biniciarSesion.Location = new System.Drawing.Point(287, 200);
            this.biniciarSesion.Name = "biniciarSesion";
            this.biniciarSesion.Size = new System.Drawing.Size(110, 50);
            this.biniciarSesion.TabIndex = 0;
            this.biniciarSesion.Text = "Iniciar Sesión";
            this.biniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.biniciarSesion.UseVisualStyleBackColor = true;
            this.biniciarSesion.Click += new System.EventHandler(this.biniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(404, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBxContra
            // 
            this.txtBxContra.Location = new System.Drawing.Point(360, 133);
            this.txtBxContra.Name = "txtBxContra";
            this.txtBxContra.Size = new System.Drawing.Size(154, 20);
            this.txtBxContra.TabIndex = 5;
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Location = new System.Drawing.Point(360, 68);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(154, 20);
            this.txtBxNombre.TabIndex = 6;
            // 
            // frminiciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(534, 262);
            this.Controls.Add(this.txtBxNombre);
            this.Controls.Add(this.txtBxContra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plogo);
            this.Controls.Add(this.biniciarSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frminiciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.plogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button biniciarSesion;
        private System.Windows.Forms.PictureBox plogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBxContra;
        private System.Windows.Forms.TextBox txtBxNombre;
    }
}

