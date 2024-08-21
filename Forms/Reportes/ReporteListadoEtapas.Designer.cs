
namespace NewWare_Soft.Forms.Reportes
{
    partial class ReporteListadoEtapas
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
            this.ReportListEtapas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFiltrarEtapasxNombre = new System.Windows.Forms.Button();
            this.lblFiltrarEtapasxNombre = new System.Windows.Forms.Label();
            this.grupBoxListadoEtapas = new System.Windows.Forms.GroupBox();
            this.rdReporteEtapasTodos = new System.Windows.Forms.RadioButton();
            this.lblReporteListadoEtapas = new System.Windows.Forms.Label();
            this.rdReporteEtapasxNombre = new System.Windows.Forms.RadioButton();
            this.btnElegirReporteEtapas = new System.Windows.Forms.Button();
            this.rdReporteEtapasxID = new System.Windows.Forms.RadioButton();
            this.btnFiltrarEtapasxID = new System.Windows.Forms.Button();
            this.mskIDFiltrarEtapas = new System.Windows.Forms.MaskedTextBox();
            this.lblFiltrarEtapasxID = new System.Windows.Forms.Label();
            this.txtNombreFiltrarEtapas = new System.Windows.Forms.TextBox();
            this.grupBoxListadoEtapas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportListEtapas
            // 
            this.ReportListEtapas.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_Etapas.rdlc";
            this.ReportListEtapas.Location = new System.Drawing.Point(67, 142);
            this.ReportListEtapas.Name = "ReportListEtapas";
            this.ReportListEtapas.ServerReport.BearerToken = null;
            this.ReportListEtapas.Size = new System.Drawing.Size(606, 256);
            this.ReportListEtapas.TabIndex = 0;
            this.ReportListEtapas.Load += new System.EventHandler(this.ReportListEtapas_Load);
            // 
            // btnFiltrarEtapasxNombre
            // 
            this.btnFiltrarEtapasxNombre.Enabled = false;
            this.btnFiltrarEtapasxNombre.Location = new System.Drawing.Point(589, 57);
            this.btnFiltrarEtapasxNombre.Name = "btnFiltrarEtapasxNombre";
            this.btnFiltrarEtapasxNombre.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarEtapasxNombre.TabIndex = 22;
            this.btnFiltrarEtapasxNombre.Text = "Filtrar";
            this.btnFiltrarEtapasxNombre.UseVisualStyleBackColor = true;
            this.btnFiltrarEtapasxNombre.Click += new System.EventHandler(this.btnFiltrarEtapasxNombre_Click);
            // 
            // lblFiltrarEtapasxNombre
            // 
            this.lblFiltrarEtapasxNombre.AutoSize = true;
            this.lblFiltrarEtapasxNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarEtapasxNombre.Location = new System.Drawing.Point(356, 57);
            this.lblFiltrarEtapasxNombre.Name = "lblFiltrarEtapasxNombre";
            this.lblFiltrarEtapasxNombre.Size = new System.Drawing.Size(121, 20);
            this.lblFiltrarEtapasxNombre.TabIndex = 20;
            this.lblFiltrarEtapasxNombre.Text = "Ingresar nombre:";
            // 
            // grupBoxListadoEtapas
            // 
            this.grupBoxListadoEtapas.Controls.Add(this.rdReporteEtapasTodos);
            this.grupBoxListadoEtapas.Controls.Add(this.lblReporteListadoEtapas);
            this.grupBoxListadoEtapas.Controls.Add(this.rdReporteEtapasxNombre);
            this.grupBoxListadoEtapas.Controls.Add(this.btnElegirReporteEtapas);
            this.grupBoxListadoEtapas.Controls.Add(this.rdReporteEtapasxID);
            this.grupBoxListadoEtapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupBoxListadoEtapas.Location = new System.Drawing.Point(5, 7);
            this.grupBoxListadoEtapas.Margin = new System.Windows.Forms.Padding(2);
            this.grupBoxListadoEtapas.Name = "grupBoxListadoEtapas";
            this.grupBoxListadoEtapas.Padding = new System.Windows.Forms.Padding(2);
            this.grupBoxListadoEtapas.Size = new System.Drawing.Size(329, 130);
            this.grupBoxListadoEtapas.TabIndex = 19;
            this.grupBoxListadoEtapas.TabStop = false;
            this.grupBoxListadoEtapas.Text = "Eleccion Reporte";
            // 
            // rdReporteEtapasTodos
            // 
            this.rdReporteEtapasTodos.AutoSize = true;
            this.rdReporteEtapasTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReporteEtapasTodos.Location = new System.Drawing.Point(124, 71);
            this.rdReporteEtapasTodos.Margin = new System.Windows.Forms.Padding(2);
            this.rdReporteEtapasTodos.Name = "rdReporteEtapasTodos";
            this.rdReporteEtapasTodos.Size = new System.Drawing.Size(169, 21);
            this.rdReporteEtapasTodos.TabIndex = 4;
            this.rdReporteEtapasTodos.TabStop = true;
            this.rdReporteEtapasTodos.Text = "Listar todas las etapas";
            this.rdReporteEtapasTodos.UseVisualStyleBackColor = true;
            // 
            // lblReporteListadoEtapas
            // 
            this.lblReporteListadoEtapas.AutoSize = true;
            this.lblReporteListadoEtapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteListadoEtapas.Location = new System.Drawing.Point(5, 17);
            this.lblReporteListadoEtapas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReporteListadoEtapas.Name = "lblReporteListadoEtapas";
            this.lblReporteListadoEtapas.Size = new System.Drawing.Size(114, 18);
            this.lblReporteListadoEtapas.TabIndex = 3;
            this.lblReporteListadoEtapas.Text = "Tipo de Reporte";
            // 
            // rdReporteEtapasxNombre
            // 
            this.rdReporteEtapasxNombre.AutoSize = true;
            this.rdReporteEtapasxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReporteEtapasxNombre.Location = new System.Drawing.Point(124, 46);
            this.rdReporteEtapasxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.rdReporteEtapasxNombre.Name = "rdReporteEtapasxNombre";
            this.rdReporteEtapasxNombre.Size = new System.Drawing.Size(185, 21);
            this.rdReporteEtapasxNombre.TabIndex = 2;
            this.rdReporteEtapasxNombre.TabStop = true;
            this.rdReporteEtapasxNombre.Text = "Listar etapas por nombre";
            this.rdReporteEtapasxNombre.UseVisualStyleBackColor = true;
            // 
            // btnElegirReporteEtapas
            // 
            this.btnElegirReporteEtapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirReporteEtapas.Location = new System.Drawing.Point(124, 96);
            this.btnElegirReporteEtapas.Margin = new System.Windows.Forms.Padding(2);
            this.btnElegirReporteEtapas.Name = "btnElegirReporteEtapas";
            this.btnElegirReporteEtapas.Size = new System.Drawing.Size(99, 27);
            this.btnElegirReporteEtapas.TabIndex = 1;
            this.btnElegirReporteEtapas.Text = "Siguiente";
            this.btnElegirReporteEtapas.UseVisualStyleBackColor = true;
            this.btnElegirReporteEtapas.Click += new System.EventHandler(this.btnElegirReporteEtapas_Click);
            // 
            // rdReporteEtapasxID
            // 
            this.rdReporteEtapasxID.AutoSize = true;
            this.rdReporteEtapasxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReporteEtapasxID.Location = new System.Drawing.Point(124, 21);
            this.rdReporteEtapasxID.Margin = new System.Windows.Forms.Padding(2);
            this.rdReporteEtapasxID.Name = "rdReporteEtapasxID";
            this.rdReporteEtapasxID.Size = new System.Drawing.Size(150, 21);
            this.rdReporteEtapasxID.TabIndex = 1;
            this.rdReporteEtapasxID.TabStop = true;
            this.rdReporteEtapasxID.Text = "Listar etapas por ID";
            this.rdReporteEtapasxID.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarEtapasxID
            // 
            this.btnFiltrarEtapasxID.Enabled = false;
            this.btnFiltrarEtapasxID.Location = new System.Drawing.Point(589, 25);
            this.btnFiltrarEtapasxID.Name = "btnFiltrarEtapasxID";
            this.btnFiltrarEtapasxID.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarEtapasxID.TabIndex = 18;
            this.btnFiltrarEtapasxID.Text = "Filtrar";
            this.btnFiltrarEtapasxID.UseVisualStyleBackColor = true;
            this.btnFiltrarEtapasxID.Click += new System.EventHandler(this.btnFiltrarEtapasxID_Click);
            // 
            // mskIDFiltrarEtapas
            // 
            this.mskIDFiltrarEtapas.Enabled = false;
            this.mskIDFiltrarEtapas.Location = new System.Drawing.Point(482, 25);
            this.mskIDFiltrarEtapas.Mask = "99999999";
            this.mskIDFiltrarEtapas.Name = "mskIDFiltrarEtapas";
            this.mskIDFiltrarEtapas.Size = new System.Drawing.Size(91, 20);
            this.mskIDFiltrarEtapas.TabIndex = 17;
            this.mskIDFiltrarEtapas.ValidatingType = typeof(int);
            // 
            // lblFiltrarEtapasxID
            // 
            this.lblFiltrarEtapasxID.AutoSize = true;
            this.lblFiltrarEtapasxID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarEtapasxID.Location = new System.Drawing.Point(356, 25);
            this.lblFiltrarEtapasxID.Name = "lblFiltrarEtapasxID";
            this.lblFiltrarEtapasxID.Size = new System.Drawing.Size(84, 20);
            this.lblFiltrarEtapasxID.TabIndex = 16;
            this.lblFiltrarEtapasxID.Text = "Ingresar ID:";
            // 
            // txtNombreFiltrarEtapas
            // 
            this.txtNombreFiltrarEtapas.Enabled = false;
            this.txtNombreFiltrarEtapas.Location = new System.Drawing.Point(483, 59);
            this.txtNombreFiltrarEtapas.Name = "txtNombreFiltrarEtapas";
            this.txtNombreFiltrarEtapas.Size = new System.Drawing.Size(90, 20);
            this.txtNombreFiltrarEtapas.TabIndex = 23;
            // 
            // ReporteListadoEtapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 410);
            this.Controls.Add(this.txtNombreFiltrarEtapas);
            this.Controls.Add(this.btnFiltrarEtapasxNombre);
            this.Controls.Add(this.lblFiltrarEtapasxNombre);
            this.Controls.Add(this.grupBoxListadoEtapas);
            this.Controls.Add(this.btnFiltrarEtapasxID);
            this.Controls.Add(this.mskIDFiltrarEtapas);
            this.Controls.Add(this.lblFiltrarEtapasxID);
            this.Controls.Add(this.ReportListEtapas);
            this.Name = "ReporteListadoEtapas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de etapas";
            this.Load += new System.EventHandler(this.ReporteListadoEtapas_Load);
            this.grupBoxListadoEtapas.ResumeLayout(false);
            this.grupBoxListadoEtapas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportListEtapas;
        private System.Windows.Forms.Button btnFiltrarEtapasxNombre;
        private System.Windows.Forms.Label lblFiltrarEtapasxNombre;
        private System.Windows.Forms.GroupBox grupBoxListadoEtapas;
        private System.Windows.Forms.RadioButton rdReporteEtapasTodos;
        private System.Windows.Forms.Label lblReporteListadoEtapas;
        private System.Windows.Forms.RadioButton rdReporteEtapasxNombre;
        private System.Windows.Forms.Button btnElegirReporteEtapas;
        private System.Windows.Forms.RadioButton rdReporteEtapasxID;
        private System.Windows.Forms.Button btnFiltrarEtapasxID;
        private System.Windows.Forms.MaskedTextBox mskIDFiltrarEtapas;
        private System.Windows.Forms.Label lblFiltrarEtapasxID;
        private System.Windows.Forms.TextBox txtNombreFiltrarEtapas;
    }
}