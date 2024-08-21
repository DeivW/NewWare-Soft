namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoProyectoMes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_SeleccPatron = new System.Windows.Forms.Button();
            this.lbl_Patron = new System.Windows.Forms.Label();
            this.meses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ReporteProyectoMes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 374);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // btn_SeleccPatron
            // 
            this.btn_SeleccPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeleccPatron.Location = new System.Drawing.Point(582, 30);
            this.btn_SeleccPatron.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SeleccPatron.Name = "btn_SeleccPatron";
            this.btn_SeleccPatron.Size = new System.Drawing.Size(173, 27);
            this.btn_SeleccPatron.TabIndex = 39;
            this.btn_SeleccPatron.Text = "Seleccionar";
            this.btn_SeleccPatron.UseVisualStyleBackColor = true;
            this.btn_SeleccPatron.Click += new System.EventHandler(this.btn_SeleccPatron_Click);
            // 
            // lbl_Patron
            // 
            this.lbl_Patron.AutoSize = true;
            this.lbl_Patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patron.Location = new System.Drawing.Point(34, 35);
            this.lbl_Patron.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Patron.Name = "lbl_Patron";
            this.lbl_Patron.Size = new System.Drawing.Size(152, 17);
            this.lbl_Patron.TabIndex = 37;
            this.lbl_Patron.Text = "Ingrese el mes a filtrar:";
            // 
            // meses
            // 
            this.meses.FormattingEnabled = true;
            this.meses.Location = new System.Drawing.Point(191, 34);
            this.meses.Name = "meses";
            this.meses.Size = new System.Drawing.Size(201, 21);
            this.meses.TabIndex = 40;
            // 
            // ListadoProyectoMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.meses);
            this.Controls.Add(this.btn_SeleccPatron);
            this.Controls.Add(this.lbl_Patron);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoProyectoMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Proyectos por Mes";
            this.Load += new System.EventHandler(this.ListadoProyectoMes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_SeleccPatron;
        private System.Windows.Forms.Label lbl_Patron;
        private System.Windows.Forms.ComboBox meses;
    }
}