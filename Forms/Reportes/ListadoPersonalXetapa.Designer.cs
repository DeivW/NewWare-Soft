
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoPersonalXetapa
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
            this.reportViewerPersonalXetapa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox_tipoReporte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFormato = new System.Windows.Forms.Label();
            this.maskedTextBox_Hasta = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Desde = new System.Windows.Forms.MaskedTextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.cmbGeneral = new System.Windows.Forms.ComboBox();
            this.groupBox_tipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerPersonalXetapa
            // 
            this.reportViewerPersonalXetapa.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_PersonalXetapa.rdlc";
            this.reportViewerPersonalXetapa.Location = new System.Drawing.Point(0, 109);
            this.reportViewerPersonalXetapa.Name = "reportViewerPersonalXetapa";
            this.reportViewerPersonalXetapa.ServerReport.BearerToken = null;
            this.reportViewerPersonalXetapa.Size = new System.Drawing.Size(630, 320);
            this.reportViewerPersonalXetapa.TabIndex = 6;
            this.reportViewerPersonalXetapa.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox_tipoReporte
            // 
            this.groupBox_tipoReporte.Controls.Add(this.label1);
            this.groupBox_tipoReporte.Controls.Add(this.cmbTipoReporte);
            this.groupBox_tipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoReporte.Location = new System.Drawing.Point(0, 2);
            this.groupBox_tipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Name = "groupBox_tipoReporte";
            this.groupBox_tipoReporte.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Size = new System.Drawing.Size(757, 51);
            this.groupBox_tipoReporte.TabIndex = 12;
            this.groupBox_tipoReporte.TabStop = false;
            this.groupBox_tipoReporte.Text = "Eleccion Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Reporte";
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.Location = new System.Drawing.Point(132, 17);
            this.cmbTipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(342, 24);
            this.cmbTipoReporte.TabIndex = 1;
            this.cmbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cmbTipoReporte_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(450, 77);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 27);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.Location = new System.Drawing.Point(249, 89);
            this.lblFormato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(154, 17);
            this.lblFormato.TabIndex = 30;
            this.lblFormato.Text = "Formato: DD/MM/AAAA";
            this.lblFormato.Visible = false;
            // 
            // maskedTextBox_Hasta
            // 
            this.maskedTextBox_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Hasta.Location = new System.Drawing.Point(356, 57);
            this.maskedTextBox_Hasta.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox_Hasta.Mask = "00/00/0000";
            this.maskedTextBox_Hasta.Name = "maskedTextBox_Hasta";
            this.maskedTextBox_Hasta.Size = new System.Drawing.Size(69, 23);
            this.maskedTextBox_Hasta.TabIndex = 3;
            this.maskedTextBox_Hasta.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_Hasta.Visible = false;
            // 
            // maskedTextBox_Desde
            // 
            this.maskedTextBox_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Desde.Location = new System.Drawing.Point(226, 57);
            this.maskedTextBox_Desde.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox_Desde.Mask = "00/00/0000";
            this.maskedTextBox_Desde.Name = "maskedTextBox_Desde";
            this.maskedTextBox_Desde.Size = new System.Drawing.Size(71, 23);
            this.maskedTextBox_Desde.TabIndex = 2;
            this.maskedTextBox_Desde.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_Desde.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(311, 60);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(45, 17);
            this.lblHasta.TabIndex = 27;
            this.lblHasta.Text = "Hasta";
            this.lblHasta.Visible = false;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(176, 60);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(49, 17);
            this.lblDesde.TabIndex = 25;
            this.lblDesde.Text = "Desde";
            this.lblDesde.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(317, 80);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(282, 80);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(51, 17);
            this.lblLegajo.TabIndex = 32;
            this.lblLegajo.Text = "Legajo";
            this.lblLegajo.Visible = false;
            // 
            // cmbGeneral
            // 
            this.cmbGeneral.Location = new System.Drawing.Point(340, 79);
            this.cmbGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGeneral.Name = "cmbGeneral";
            this.cmbGeneral.Size = new System.Drawing.Size(106, 21);
            this.cmbGeneral.TabIndex = 4;
            // 
            // ListadoPersonalXetapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 426);
            this.Controls.Add(this.cmbGeneral);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.maskedTextBox_Hasta);
            this.Controls.Add(this.maskedTextBox_Desde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox_tipoReporte);
            this.Controls.Add(this.reportViewerPersonalXetapa);
            this.Name = "ListadoPersonalXetapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoPersonalXetapa";
            this.Load += new System.EventHandler(this.ListadoPersonalXetapa_Load);
            this.groupBox_tipoReporte.ResumeLayout(false);
            this.groupBox_tipoReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPersonalXetapa;
        private System.Windows.Forms.GroupBox groupBox_tipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Hasta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Desde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.ComboBox cmbGeneral;
    }
}