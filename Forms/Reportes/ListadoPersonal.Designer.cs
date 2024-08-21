
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoPersonal
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
            this.rptPersonal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptPersonal
            // 
            this.rptPersonal.LocalReport.ReportEmbeddedResource = "NewWare_Soft.reportePersonal.rdlc";
            this.rptPersonal.Location = new System.Drawing.Point(0, -1);
            this.rptPersonal.Name = "rptPersonal";
            this.rptPersonal.ServerReport.BearerToken = null;
            this.rptPersonal.Size = new System.Drawing.Size(800, 450);
            this.rptPersonal.TabIndex = 0;
            this.rptPersonal.Load += new System.EventHandler(this.rptPersonal_Load);
            // 
            // ListadoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptPersonal);
            this.Name = "ListadoPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Personal por Proyecto";
            this.Load += new System.EventHandler(this.ListadoPersonal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPersonal;
    }
}