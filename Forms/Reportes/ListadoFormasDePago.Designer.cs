
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoFormasDePago
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
            this.report_FormasdePago = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_reportenormal = new System.Windows.Forms.RadioButton();
            this.rdb_ordenAlfabetico = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblOrdenAlfabetico = new System.Windows.Forms.Label();
            this.btnGenerarReporte2 = new System.Windows.Forms.Button();
            this.lblNormal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // report_FormasdePago
            // 
            this.report_FormasdePago.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ListadoFormasDePago.rdlc";
            this.report_FormasdePago.Location = new System.Drawing.Point(0, 171);
            this.report_FormasdePago.Name = "report_FormasdePago";
            this.report_FormasdePago.ServerReport.BearerToken = null;
            this.report_FormasdePago.Size = new System.Drawing.Size(800, 340);
            this.report_FormasdePago.TabIndex = 0;
            this.report_FormasdePago.Visible = false;
            this.report_FormasdePago.Load += new System.EventHandler(this.ListadoFormasDePago_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_reportenormal);
            this.groupBox1.Controls.Add(this.rdb_ordenAlfabetico);
            this.groupBox1.Controls.Add(this.rdbNombre);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 113);
            this.groupBox1.TabIndex = 2;
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
            this.rdb_ordenAlfabetico.Size = new System.Drawing.Size(333, 25);
            this.rdb_ordenAlfabetico.TabIndex = 1;
            this.rdb_ordenAlfabetico.TabStop = true;
            this.rdb_ordenAlfabetico.Text = "Mostrar formas de pago en orden alfabetico";
            this.rdb_ordenAlfabetico.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNombre.Location = new System.Drawing.Point(50, 25);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(262, 25);
            this.rdbNombre.TabIndex = 0;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Filtrar forma de pago por nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(193, 131);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(447, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(529, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 20);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Visible = false;
            // 
            // lblOrdenAlfabetico
            // 
            this.lblOrdenAlfabetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenAlfabetico.Location = new System.Drawing.Point(440, 20);
            this.lblOrdenAlfabetico.Name = "lblOrdenAlfabetico";
            this.lblOrdenAlfabetico.Size = new System.Drawing.Size(348, 71);
            this.lblOrdenAlfabetico.TabIndex = 12;
            this.lblOrdenAlfabetico.Text = "SI DESEA GENERAR UN REPORTE EN ORDEN ALFABETICO, PRESIONE \"GENERAR REPORTE\"";
            this.lblOrdenAlfabetico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrdenAlfabetico.Visible = false;
            // 
            // btnGenerarReporte2
            // 
            this.btnGenerarReporte2.Location = new System.Drawing.Point(564, 98);
            this.btnGenerarReporte2.Name = "btnGenerarReporte2";
            this.btnGenerarReporte2.Size = new System.Drawing.Size(106, 25);
            this.btnGenerarReporte2.TabIndex = 13;
            this.btnGenerarReporte2.Text = "Generar Reporte";
            this.btnGenerarReporte2.UseVisualStyleBackColor = true;
            this.btnGenerarReporte2.Visible = false;
            this.btnGenerarReporte2.Click += new System.EventHandler(this.btnGenerarReporte2_Click);
            // 
            // lblNormal
            // 
            this.lblNormal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.Location = new System.Drawing.Point(429, 20);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(348, 71);
            this.lblNormal.TabIndex = 14;
            this.lblNormal.Text = "SI DESEA GENERAR UN REPORTE NORMAL, PRESIONE \"GENERAR REPORTE\"";
            this.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNormal.Visible = false;
            // 
            // ListadoFormasDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.btnGenerarReporte2);
            this.Controls.Add(this.lblOrdenAlfabetico);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.report_FormasdePago);
            this.Name = "ListadoFormasDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoFormasDePago";
            this.Load += new System.EventHandler(this.ListadoFormasDePago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_FormasdePago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_reportenormal;
        private System.Windows.Forms.RadioButton rdb_ordenAlfabetico;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblOrdenAlfabetico;
        private System.Windows.Forms.Button btnGenerarReporte2;
        private System.Windows.Forms.Label lblNormal;
    }
}