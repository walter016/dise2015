namespace admin
{
    partial class frmRePeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRePeliculas));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSemanaMesP = new System.Windows.Forms.ComboBox();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar :";
            // 
            // cmbSemanaMesP
            // 
            this.cmbSemanaMesP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemanaMesP.FormattingEnabled = true;
            this.cmbSemanaMesP.Items.AddRange(new object[] {
            "Reporte por Mes",
            "Reporte por Semana"});
            this.cmbSemanaMesP.Location = new System.Drawing.Point(110, 16);
            this.cmbSemanaMesP.Name = "cmbSemanaMesP";
            this.cmbSemanaMesP.Size = new System.Drawing.Size(256, 21);
            this.cmbSemanaMesP.TabIndex = 1;
            this.cmbSemanaMesP.SelectedIndexChanged += new System.EventHandler(this.cmbSemanaMes_SelectedIndexChanged);
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(132, 68);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(110, 48);
            this.btnVerReporte.TabIndex = 2;
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // frmRePeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 133);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.cmbSemanaMesP);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRePeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Peliculas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSemanaMesP;
        private System.Windows.Forms.Button btnVerReporte;
    }
}