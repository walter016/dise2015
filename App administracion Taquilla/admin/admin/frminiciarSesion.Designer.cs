namespace admin
{
    partial class frminiciarSesion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminiciarSesion));
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.txtBxContra = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txthora = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.biniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(42, 110);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(59, 19);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(18, 143);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(83, 19);
            this.Contraseña.TabIndex = 1;
            this.Contraseña.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre del Equipo";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hora de Ingreso";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha Sistema";
            this.label8.Visible = false;
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNombre.Location = new System.Drawing.Point(107, 107);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(142, 27);
            this.txtBxNombre.TabIndex = 9;
            // 
            // txtBxContra
            // 
            this.txtBxContra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxContra.Location = new System.Drawing.Point(107, 140);
            this.txtBxContra.Name = "txtBxContra";
            this.txtBxContra.Size = new System.Drawing.Size(142, 27);
            this.txtBxContra.TabIndex = 10;
            this.txtBxContra.UseSystemPasswordChar = true;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(323, 160);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(155, 27);
            this.txtname.TabIndex = 12;
            this.txtname.Visible = false;
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Location = new System.Drawing.Point(323, 103);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(155, 27);
            this.txthora.TabIndex = 11;
            this.txthora.Visible = false;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Location = new System.Drawing.Point(323, 38);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(155, 23);
            this.dtpfecha.TabIndex = 13;
            this.dtpfecha.Value = new System.DateTime(2015, 8, 9, 18, 50, 47, 0);
            this.dtpfecha.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::admin.Properties.Resources.logo22;
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 79);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // biniciarSesion
            // 
            this.biniciarSesion.Image = global::admin.Properties.Resources.aceptar2;
            this.biniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biniciarSesion.Location = new System.Drawing.Point(120, 186);
            this.biniciarSesion.Name = "biniciarSesion";
            this.biniciarSesion.Size = new System.Drawing.Size(103, 50);
            this.biniciarSesion.TabIndex = 8;
            this.biniciarSesion.Text = "Ingresar al Sistema";
            this.biniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.biniciarSesion.UseVisualStyleBackColor = true;
            this.biniciarSesion.Click += new System.EventHandler(this.biniciarSesion_Click_1);
            // 
            // frminiciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.txtBxContra);
            this.Controls.Add(this.txtBxNombre);
            this.Controls.Add(this.biniciarSesion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frminiciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button biniciarSesion;
        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.TextBox txtBxContra;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}