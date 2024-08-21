
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoBarrios
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
            this.reporte_barrios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_reportenormal = new System.Windows.Forms.RadioButton();
            this.rdb_ordenAlfabetico = new System.Windows.Forms.RadioButton();
            this.rdb_barriosxciudad = new System.Windows.Forms.RadioButton();
            this.lbl_Ciudad = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.txt_ciudad = new System.Windows.Forms.ComboBox();
            this.lblReporteNormal = new System.Windows.Forms.Label();
            this.btnGenerarReporte2 = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblOrdenAlfabetico = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_barrios
            // 
            this.reporte_barrios.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ReporteBarrios.rdlc";
            this.reporte_barrios.Location = new System.Drawing.Point(0, 178);
            this.reporte_barrios.Name = "reporte_barrios";
            this.reporte_barrios.ServerReport.BearerToken = null;
            this.reporte_barrios.Size = new System.Drawing.Size(800, 358);
            this.reporte_barrios.TabIndex = 0;
            this.reporte_barrios.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_reportenormal);
            this.groupBox1.Controls.Add(this.rdb_ordenAlfabetico);
            this.groupBox1.Controls.Add(this.rdb_barriosxciudad);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Reporte";
            // 
            // rdb_reportenormal
            // 
            this.rdb_reportenormal.AutoSize = true;
            this.rdb_reportenormal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdb_reportenormal.Location = new System.Drawing.Point(50, 82);
            this.rdb_reportenormal.Name = "rdb_reportenormal";
            this.rdb_reportenormal.Size = new System.Drawing.Size(199, 25);
            this.rdb_reportenormal.TabIndex = 2;
            this.rdb_reportenormal.TabStop = true;
            this.rdb_reportenormal.Text = "Mostrar Reporte Normal";
            this.rdb_reportenormal.UseVisualStyleBackColor = true;
            // 
            // rdb_ordenAlfabetico
            // 
            this.rdb_ordenAlfabetico.AutoSize = true;
            this.rdb_ordenAlfabetico.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdb_ordenAlfabetico.Location = new System.Drawing.Point(50, 54);
            this.rdb_ordenAlfabetico.Name = "rdb_ordenAlfabetico";
            this.rdb_ordenAlfabetico.Size = new System.Drawing.Size(273, 25);
            this.rdb_ordenAlfabetico.TabIndex = 1;
            this.rdb_ordenAlfabetico.TabStop = true;
            this.rdb_ordenAlfabetico.Text = "Mostrar barrios en orden alfabetico";
            this.rdb_ordenAlfabetico.UseVisualStyleBackColor = true;
            // 
            // rdb_barriosxciudad
            // 
            this.rdb_barriosxciudad.AutoSize = true;
            this.rdb_barriosxciudad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdb_barriosxciudad.Location = new System.Drawing.Point(50, 25);
            this.rdb_barriosxciudad.Name = "rdb_barriosxciudad";
            this.rdb_barriosxciudad.Size = new System.Drawing.Size(214, 25);
            this.rdb_barriosxciudad.TabIndex = 0;
            this.rdb_barriosxciudad.TabStop = true;
            this.rdb_barriosxciudad.Text = "Mostrar barrios por ciudad";
            this.rdb_barriosxciudad.UseVisualStyleBackColor = true;
            // 
            // lbl_Ciudad
            // 
            this.lbl_Ciudad.AutoSize = true;
            this.lbl_Ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ciudad.Location = new System.Drawing.Point(416, 36);
            this.lbl_Ciudad.Name = "lbl_Ciudad";
            this.lbl_Ciudad.Size = new System.Drawing.Size(82, 24);
            this.lbl_Ciudad.TabIndex = 2;
            this.lbl_Ciudad.Text = "Ciudad:";
            this.lbl_Ciudad.Visible = false;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Enabled = false;
            this.btnGenerarReporte.Location = new System.Drawing.Point(606, 86);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(106, 25);
            this.btnGenerarReporte.TabIndex = 4;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Visible = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Enabled = false;
            this.txt_ciudad.FormattingEnabled = true;
            this.txt_ciudad.Location = new System.Drawing.Point(504, 39);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(208, 21);
            this.txt_ciudad.TabIndex = 5;
            this.txt_ciudad.Visible = false;
            // 
            // lblReporteNormal
            // 
            this.lblReporteNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteNormal.Location = new System.Drawing.Point(416, 20);
            this.lblReporteNormal.Name = "lblReporteNormal";
            this.lblReporteNormal.Size = new System.Drawing.Size(348, 71);
            this.lblReporteNormal.TabIndex = 6;
            this.lblReporteNormal.Text = "SI DESEA GENERAR UN REPORTE COMPLETO GENERAL\r\n PRESIONE \"GENERAR REPORTE\"";
            this.lblReporteNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReporteNormal.Visible = false;
            // 
            // btnGenerarReporte2
            // 
            this.btnGenerarReporte2.Location = new System.Drawing.Point(538, 96);
            this.btnGenerarReporte2.Name = "btnGenerarReporte2";
            this.btnGenerarReporte2.Size = new System.Drawing.Size(106, 25);
            this.btnGenerarReporte2.TabIndex = 7;
            this.btnGenerarReporte2.Text = "Generar Reporte";
            this.btnGenerarReporte2.UseVisualStyleBackColor = true;
            this.btnGenerarReporte2.Visible = false;
            this.btnGenerarReporte2.Click += new System.EventHandler(this.btnGenerarReporte2_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(163, 131);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOrdenAlfabetico
            // 
            this.lblOrdenAlfabetico.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOrdenAlfabetico.Location = new System.Drawing.Point(416, 20);
            this.lblOrdenAlfabetico.Name = "lblOrdenAlfabetico";
            this.lblOrdenAlfabetico.Size = new System.Drawing.Size(348, 71);
            this.lblOrdenAlfabetico.TabIndex = 9;
            this.lblOrdenAlfabetico.Text = "SI DESEA GENERAR UN REPORTE EN ORDEN ALFABETICO, PRESIONE \"GENERAR REPORTE\"";
            this.lblOrdenAlfabetico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrdenAlfabetico.Visible = false;
            // 
            // ListadoBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.lblOrdenAlfabetico);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnGenerarReporte2);
            this.Controls.Add(this.lblReporteNormal);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.lbl_Ciudad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reporte_barrios);
            this.Name = "ListadoBarrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoBarrios";
            this.Load += new System.EventHandler(this.ListadoBarrios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_barrios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_ordenAlfabetico;
        private System.Windows.Forms.RadioButton rdb_barriosxciudad;
        private System.Windows.Forms.Label lbl_Ciudad;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.ComboBox txt_ciudad;
        private System.Windows.Forms.RadioButton rdb_reportenormal;
        private System.Windows.Forms.Label lblReporteNormal;
        private System.Windows.Forms.Button btnGenerarReporte2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblOrdenAlfabetico;
    }
}