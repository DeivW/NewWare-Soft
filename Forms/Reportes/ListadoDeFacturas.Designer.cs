
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoDeFacturas
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
            this.listadoFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // listadoFacturas
            // 
            this.listadoFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoFacturas.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ListadoDeFacturas.rdlc";
            this.listadoFacturas.Location = new System.Drawing.Point(0, 0);
            this.listadoFacturas.Name = "listadoFacturas";
            this.listadoFacturas.ServerReport.BearerToken = null;
            this.listadoFacturas.Size = new System.Drawing.Size(800, 450);
            this.listadoFacturas.TabIndex = 0;
            this.listadoFacturas.Load += new System.EventHandler(this.listadoFacturas_Load);
            // 
            // ListadoDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listadoFacturas);
            this.Name = "ListadoDeFacturas";
            this.Text = "ListadoDeFacturas";
            this.Load += new System.EventHandler(this.ListadoDeFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer listadoFacturas;
    }
}