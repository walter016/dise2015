namespace admin
{
    partial class frmReporteHorarioReservado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteHorarioReservado));
            this.rVReporteHorarioReservado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rVReporteHorarioReservado
            // 
            this.rVReporteHorarioReservado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rVReporteHorarioReservado.LocalReport.ReportEmbeddedResource = "admin.reporteHorario.rdlc";
            this.rVReporteHorarioReservado.Location = new System.Drawing.Point(13, 13);
            this.rVReporteHorarioReservado.Name = "rVReporteHorarioReservado";
            this.rVReporteHorarioReservado.Size = new System.Drawing.Size(667, 366);
            this.rVReporteHorarioReservado.TabIndex = 0;
            // 
            // frmReporteHorarioReservado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 391);
            this.Controls.Add(this.rVReporteHorarioReservado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteHorarioReservado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Horarios Reservados";
            this.Load += new System.EventHandler(this.frmReporteHorarioReservado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rVReporteHorarioReservado;
    }
}