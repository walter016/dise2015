namespace WindowsFormsApplication1
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Atras = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btna1 = new System.Windows.Forms.Button();
            this.btna2 = new System.Windows.Forms.Button();
            this.btna4 = new System.Windows.Forms.Button();
            this.btna3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.Atras,
            this.toolStripButton2,
            this.toolStripLabel2,
            this.toolStripButton3,
            this.toolStripLabel3,
            this.toolStripButton4,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1175, 47);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WindowsFormsApplication1.Properties.Resources.atras;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton1.Text = "Atras";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Atras
            // 
            this.Atras.Enabled = false;
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(43, 44);
            this.Atras.Text = "Atras";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton2.Text = "Menu Principal";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Enabled = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(106, 44);
            this.toolStripLabel2.Text = "Menu Principal";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = global::WindowsFormsApplication1.Properties.Resources._1438150008_ticket;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton3.Text = "Reservar";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Enabled = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(61, 44);
            this.toolStripLabel3.Text = "Reserva";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::WindowsFormsApplication1.Properties.Resources.salir;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton4.Text = "Salir";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Enabled = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(37, 44);
            this.toolStripLabel4.Text = "Salir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.compras;
            this.pictureBox1.Location = new System.Drawing.Point(1018, 618);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1014, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Comprar Boletos";
            // 
            // btna1
            // 
            this.btna1.BackColor = System.Drawing.Color.Transparent;
            this.btna1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btna1.Image = global::WindowsFormsApplication1.Properties.Resources.asiento2;
            this.btna1.Location = new System.Drawing.Point(265, 153);
            this.btna1.Margin = new System.Windows.Forms.Padding(0);
            this.btna1.Name = "btna1";
            this.btna1.Size = new System.Drawing.Size(92, 95);
            this.btna1.TabIndex = 12;
            this.btna1.Text = "A1";
            this.btna1.UseVisualStyleBackColor = true;
            this.btna1.Click += new System.EventHandler(this.btna1_Click);
            // 
            // btna2
            // 
            this.btna2.BackColor = System.Drawing.Color.Transparent;
            this.btna2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btna2.Image = global::WindowsFormsApplication1.Properties.Resources.asiento2;
            this.btna2.Location = new System.Drawing.Point(375, 153);
            this.btna2.Margin = new System.Windows.Forms.Padding(0);
            this.btna2.Name = "btna2";
            this.btna2.Padding = new System.Windows.Forms.Padding(6);
            this.btna2.Size = new System.Drawing.Size(92, 95);
            this.btna2.TabIndex = 13;
            this.btna2.Text = "A2";
            this.btna2.UseVisualStyleBackColor = true;
            this.btna2.Click += new System.EventHandler(this.btna2_Click);
            // 
            // btna4
            // 
            this.btna4.BackColor = System.Drawing.Color.Transparent;
            this.btna4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btna4.Image = global::WindowsFormsApplication1.Properties.Resources.asiento2;
            this.btna4.Location = new System.Drawing.Point(588, 153);
            this.btna4.Margin = new System.Windows.Forms.Padding(0);
            this.btna4.Name = "btna4";
            this.btna4.Padding = new System.Windows.Forms.Padding(6);
            this.btna4.Size = new System.Drawing.Size(92, 95);
            this.btna4.TabIndex = 15;
            this.btna4.Text = "A4";
            this.btna4.UseVisualStyleBackColor = true;
            this.btna4.Click += new System.EventHandler(this.btna4_Click);
            // 
            // btna3
            // 
            this.btna3.BackColor = System.Drawing.Color.Transparent;
            this.btna3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btna3.Image = global::WindowsFormsApplication1.Properties.Resources.asiento2;
            this.btna3.Location = new System.Drawing.Point(481, 153);
            this.btna3.Margin = new System.Windows.Forms.Padding(0);
            this.btna3.Name = "btna3";
            this.btna3.Padding = new System.Windows.Forms.Padding(6);
            this.btna3.Size = new System.Drawing.Size(92, 95);
            this.btna3.TabIndex = 14;
            this.btna3.Text = "A3";
            this.btna3.UseVisualStyleBackColor = true;
            this.btna3.Click += new System.EventHandler(this.btna3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(951, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Boletos";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 731);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btna4);
            this.Controls.Add(this.btna3);
            this.Controls.Add(this.btna2);
            this.Controls.Add(this.btna1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.venta_FormClosed);
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel Atras;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btna1;
        private System.Windows.Forms.Button btna2;
        private System.Windows.Forms.Button btna4;
        private System.Windows.Forms.Button btna3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}