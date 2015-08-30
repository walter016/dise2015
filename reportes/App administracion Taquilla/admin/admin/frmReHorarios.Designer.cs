namespace admin
{
    partial class frmReHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReHorarios));
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.cmbSemanaMesH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(132, 68);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(110, 48);
            this.btnVerReporte.TabIndex = 5;
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // cmbSemanaMesH
            // 
            this.cmbSemanaMesH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemanaMesH.FormattingEnabled = true;
            this.cmbSemanaMesH.Items.AddRange(new object[] {
            "Reporte por Mes",
            "Reporte por Semana"});
            this.cmbSemanaMesH.Location = new System.Drawing.Point(110, 16);
            this.cmbSemanaMesH.Name = "cmbSemanaMesH";
            this.cmbSemanaMesH.Size = new System.Drawing.Size(256, 21);
            this.cmbSemanaMesH.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar :";
            // 
            // frmReHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 133);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.cmbSemanaMesH);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Horarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.ComboBox cmbSemanaMesH;
        private System.Windows.Forms.Label label1;
    }
}