namespace admin
{
    partial class frmbuscarSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbuscarSala));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdinformacionSala = new System.Windows.Forms.DataGridView();
            this.lnombreSala = new System.Windows.Forms.Label();
            this.txtbuscarSala = new System.Windows.Forms.TextBox();
            this.bbuscarSala = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdinformacionSala)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdinformacionSala);
            this.groupBox1.Controls.Add(this.lnombreSala);
            this.groupBox1.Controls.Add(this.txtbuscarSala);
            this.groupBox1.Controls.Add(this.bbuscarSala);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // grdinformacionSala
            // 
            this.grdinformacionSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdinformacionSala.Location = new System.Drawing.Point(11, 80);
            this.grdinformacionSala.Name = "grdinformacionSala";
            this.grdinformacionSala.Size = new System.Drawing.Size(659, 257);
            this.grdinformacionSala.TabIndex = 3;
            // 
            // lnombreSala
            // 
            this.lnombreSala.AutoSize = true;
            this.lnombreSala.Location = new System.Drawing.Point(7, 27);
            this.lnombreSala.Name = "lnombreSala";
            this.lnombreSala.Size = new System.Drawing.Size(131, 19);
            this.lnombreSala.TabIndex = 2;
            this.lnombreSala.Text = "Nombre de la Sala:";
            // 
            // txtbuscarSala
            // 
            this.txtbuscarSala.Location = new System.Drawing.Point(169, 27);
            this.txtbuscarSala.Name = "txtbuscarSala";
            this.txtbuscarSala.Size = new System.Drawing.Size(385, 27);
            this.txtbuscarSala.TabIndex = 1;
            // 
            // bbuscarSala
            // 
            this.bbuscarSala.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscarSala.Image = global::admin.Properties.Resources.search;
            this.bbuscarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbuscarSala.Location = new System.Drawing.Point(560, 14);
            this.bbuscarSala.Name = "bbuscarSala";
            this.bbuscarSala.Size = new System.Drawing.Size(110, 50);
            this.bbuscarSala.TabIndex = 0;
            this.bbuscarSala.Text = "       Buscar";
            this.bbuscarSala.UseVisualStyleBackColor = true;
            this.bbuscarSala.Click += new System.EventHandler(this.bbuscarSala_Click);
            // 
            // frmbuscarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(704, 368);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbuscarSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SofTool Systems - Busqueda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdinformacionSala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bbuscarSala;
        private System.Windows.Forms.TextBox txtbuscarSala;
        private System.Windows.Forms.Label lnombreSala;
        private System.Windows.Forms.DataGridView grdinformacionSala;
    }
}