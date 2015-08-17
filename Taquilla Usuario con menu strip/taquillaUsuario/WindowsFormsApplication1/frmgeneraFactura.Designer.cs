namespace WindowsFormsApplication1
{
    partial class frmgeneraFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtfacturaPelicula = new System.Windows.Forms.TextBox();
            this.txtfacturaSala = new System.Windows.Forms.TextBox();
            this.txtfacturaTotal = new System.Windows.Forms.TextBox();
            this.btnfacturaPagado = new System.Windows.Forms.Button();
            this.txtfacturaAsientos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombreFactura = new System.Windows.Forms.TextBox();
            this.txtfacturaNit = new System.Windows.Forms.TextBox();
            this.txtfacturaTarjeta = new System.Windows.Forms.TextBox();
            this.txtfacturaNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Asientos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre de Pelicula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nit Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(181, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 61);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtfacturaAsientos);
            this.panel1.Controls.Add(this.txtfacturaSala);
            this.panel1.Controls.Add(this.txtfacturaPelicula);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(33, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 324);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtfacturaTarjeta);
            this.panel2.Controls.Add(this.txtfacturaNit);
            this.panel2.Controls.Add(this.txtnombreFactura);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 88);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtfacturaTotal);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(193, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 36);
            this.panel3.TabIndex = 11;
            // 
            // txtfacturaPelicula
            // 
            this.txtfacturaPelicula.Enabled = false;
            this.txtfacturaPelicula.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfacturaPelicula.Location = new System.Drawing.Point(284, 135);
            this.txtfacturaPelicula.Name = "txtfacturaPelicula";
            this.txtfacturaPelicula.Size = new System.Drawing.Size(174, 23);
            this.txtfacturaPelicula.TabIndex = 12;
            // 
            // txtfacturaSala
            // 
            this.txtfacturaSala.Enabled = false;
            this.txtfacturaSala.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfacturaSala.Location = new System.Drawing.Point(284, 180);
            this.txtfacturaSala.Name = "txtfacturaSala";
            this.txtfacturaSala.Size = new System.Drawing.Size(174, 23);
            this.txtfacturaSala.TabIndex = 14;
            // 
            // txtfacturaTotal
            // 
            this.txtfacturaTotal.Enabled = false;
            this.txtfacturaTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfacturaTotal.Location = new System.Drawing.Point(87, 6);
            this.txtfacturaTotal.Name = "txtfacturaTotal";
            this.txtfacturaTotal.Size = new System.Drawing.Size(174, 23);
            this.txtfacturaTotal.TabIndex = 15;
            // 
            // btnfacturaPagado
            // 
            this.btnfacturaPagado.Location = new System.Drawing.Point(247, 446);
            this.btnfacturaPagado.Name = "btnfacturaPagado";
            this.btnfacturaPagado.Size = new System.Drawing.Size(98, 45);
            this.btnfacturaPagado.TabIndex = 12;
            this.btnfacturaPagado.Text = "Terminar Compra";
            this.btnfacturaPagado.UseVisualStyleBackColor = true;
            this.btnfacturaPagado.Click += new System.EventHandler(this.btnfacturaPagado_Click);
            // 
            // txtfacturaAsientos
            // 
            this.txtfacturaAsientos.Enabled = false;
            this.txtfacturaAsientos.Location = new System.Drawing.Point(284, 221);
            this.txtfacturaAsientos.Name = "txtfacturaAsientos";
            this.txtfacturaAsientos.Size = new System.Drawing.Size(174, 20);
            this.txtfacturaAsientos.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "No. Tarjeta";
            // 
            // txtnombreFactura
            // 
            this.txtnombreFactura.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreFactura.Location = new System.Drawing.Point(121, 29);
            this.txtnombreFactura.Name = "txtnombreFactura";
            this.txtnombreFactura.Size = new System.Drawing.Size(337, 23);
            this.txtnombreFactura.TabIndex = 11;
            // 
            // txtfacturaNit
            // 
            this.txtfacturaNit.Enabled = false;
            this.txtfacturaNit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfacturaNit.Location = new System.Drawing.Point(121, 57);
            this.txtfacturaNit.Name = "txtfacturaNit";
            this.txtfacturaNit.Size = new System.Drawing.Size(109, 23);
            this.txtfacturaNit.TabIndex = 13;
            // 
            // txtfacturaTarjeta
            // 
            this.txtfacturaTarjeta.Enabled = false;
            this.txtfacturaTarjeta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfacturaTarjeta.Location = new System.Drawing.Point(311, 59);
            this.txtfacturaTarjeta.Name = "txtfacturaTarjeta";
            this.txtfacturaTarjeta.Size = new System.Drawing.Size(147, 23);
            this.txtfacturaTarjeta.TabIndex = 14;
            // 
            // txtfacturaNo
            // 
            this.txtfacturaNo.Enabled = false;
            this.txtfacturaNo.Location = new System.Drawing.Point(474, 85);
            this.txtfacturaNo.Name = "txtfacturaNo";
            this.txtfacturaNo.Size = new System.Drawing.Size(77, 20);
            this.txtfacturaNo.TabIndex = 16;
            // 
            // frmgeneraFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 490);
            this.Controls.Add(this.txtfacturaNo);
            this.Controls.Add(this.btnfacturaPagado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmgeneraFactura";
            this.Text = "Generar Factura";
            this.Load += new System.EventHandler(this.frmgeneraFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfacturaAsientos;
        private System.Windows.Forms.TextBox txtfacturaSala;
        private System.Windows.Forms.TextBox txtfacturaPelicula;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtfacturaTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtfacturaTarjeta;
        private System.Windows.Forms.TextBox txtfacturaNit;
        private System.Windows.Forms.TextBox txtnombreFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnfacturaPagado;
        private System.Windows.Forms.TextBox txtfacturaNo;
    }
}