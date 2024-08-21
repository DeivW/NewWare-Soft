
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoHerramientasXetapas
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
            this.reportViewerHerramientasXetapas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbGeneral = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox_tipoReporte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox_tipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerHerramientasXetapas
            // 
            this.reportViewerHerramientasXetapas.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_HerramientasXetapas.rdlc";
            this.reportViewerHerramientasXetapas.Location = new System.Drawing.Point(0, 106);
            this.reportViewerHerramientasXetapas.Name = "reportViewerHerramientasXetapas";
            this.reportViewerHerramientasXetapas.ServerReport.BearerToken = null;
            this.reportViewerHerramientasXetapas.Size = new System.Drawing.Size(630, 320);
            this.reportViewerHerramientasXetapas.TabIndex = 4;
            this.reportViewerHerramientasXetapas.Load += new System.EventHandler(this.reportViewerHerramientasXetapas_Load);
            // 
            // cmbGeneral
            // 
            this.cmbGeneral.Location = new System.Drawing.Point(351, 74);
            this.cmbGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGeneral.Name = "cmbGeneral";
            this.cmbGeneral.Size = new System.Drawing.Size(106, 21);
            this.cmbGeneral.TabIndex = 1;
            this.cmbGeneral.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(461, 72);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox_tipoReporte
            // 
            this.groupBox_tipoReporte.Controls.Add(this.label1);
            this.groupBox_tipoReporte.Controls.Add(this.cmbTipoReporte);
            this.groupBox_tipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoReporte.Location = new System.Drawing.Point(11, 11);
            this.groupBox_tipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Name = "groupBox_tipoReporte";
            this.groupBox_tipoReporte.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Size = new System.Drawing.Size(582, 51);
            this.groupBox_tipoReporte.TabIndex = 15;
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
            this.cmbTipoReporte.TabIndex = 0;
            this.cmbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cmbTipoReporte_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(328, 75);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // ListadoHerramientasXetapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 426);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbGeneral);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox_tipoReporte);
            this.Controls.Add(this.reportViewerHerramientasXetapas);
            this.Name = "ListadoHerramientasXetapas";
            this.Text = "ListadoHerramientasXetapas";
            this.Load += new System.EventHandler(this.ListadoHerramientasXetapas_Load);
            this.groupBox_tipoReporte.ResumeLayout(false);
            this.groupBox_tipoReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHerramientasXetapas;
        private System.Windows.Forms.ComboBox cmbGeneral;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox_tipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Label lblId;
    }
}