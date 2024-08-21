
namespace NewWare_Soft.Forms.Reportes
{
    partial class ReporteListadoPersonal
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
            this.ReportListPersonal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblFiltrarReportePersonal = new System.Windows.Forms.Label();
            this.mskDniFiltroReportePersonal = new System.Windows.Forms.MaskedTextBox();
            this.btnFiltrarReportePersonal = new System.Windows.Forms.Button();
            this.grupBoxListadoPersonal = new System.Windows.Forms.GroupBox();
            this.rdListadoPersonalTodos = new System.Windows.Forms.RadioButton();
            this.lblReporteListadoPersonal = new System.Windows.Forms.Label();
            this.rdListadoPersonalxCargo = new System.Windows.Forms.RadioButton();
            this.btnElegirReportePersonal = new System.Windows.Forms.Button();
            this.rdReportePersonalxDni = new System.Windows.Forms.RadioButton();
            this.btnFiltrarReportePersonalCargo = new System.Windows.Forms.Button();
            this.mskCargoFiltroListadoPersonal = new System.Windows.Forms.MaskedTextBox();
            this.lblListarPorCargo = new System.Windows.Forms.Label();
            this.grupBoxListadoPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportListPersonal
            // 
            this.ReportListPersonal.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_Personal.rdlc";
            this.ReportListPersonal.Location = new System.Drawing.Point(5, 156);
            this.ReportListPersonal.Name = "ReportListPersonal";
            this.ReportListPersonal.ServerReport.BearerToken = null;
            this.ReportListPersonal.Size = new System.Drawing.Size(1107, 329);
            this.ReportListPersonal.TabIndex = 0;
            this.ReportListPersonal.Load += new System.EventHandler(this.ReportListPersonal_Load);
            // 
            // lblFiltrarReportePersonal
            // 
            this.lblFiltrarReportePersonal.AutoSize = true;
            this.lblFiltrarReportePersonal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarReportePersonal.Location = new System.Drawing.Point(472, 25);
            this.lblFiltrarReportePersonal.Name = "lblFiltrarReportePersonal";
            this.lblFiltrarReportePersonal.Size = new System.Drawing.Size(145, 20);
            this.lblFiltrarReportePersonal.TabIndex = 1;
            this.lblFiltrarReportePersonal.Text = "Ingresar documento:";
            // 
            // mskDniFiltroReportePersonal
            // 
            this.mskDniFiltroReportePersonal.Enabled = false;
            this.mskDniFiltroReportePersonal.Location = new System.Drawing.Point(629, 24);
            this.mskDniFiltroReportePersonal.Mask = "99999999";
            this.mskDniFiltroReportePersonal.Name = "mskDniFiltroReportePersonal";
            this.mskDniFiltroReportePersonal.Size = new System.Drawing.Size(91, 20);
            this.mskDniFiltroReportePersonal.TabIndex = 2;
            this.mskDniFiltroReportePersonal.ValidatingType = typeof(int);
            // 
            // btnFiltrarReportePersonal
            // 
            this.btnFiltrarReportePersonal.Enabled = false;
            this.btnFiltrarReportePersonal.Location = new System.Drawing.Point(736, 24);
            this.btnFiltrarReportePersonal.Name = "btnFiltrarReportePersonal";
            this.btnFiltrarReportePersonal.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarReportePersonal.TabIndex = 3;
            this.btnFiltrarReportePersonal.Text = "Filtrar";
            this.btnFiltrarReportePersonal.UseVisualStyleBackColor = true;
            this.btnFiltrarReportePersonal.Click += new System.EventHandler(this.btnFiltrarReportePersonal_Click);
            // 
            // grupBoxListadoPersonal
            // 
            this.grupBoxListadoPersonal.Controls.Add(this.rdListadoPersonalTodos);
            this.grupBoxListadoPersonal.Controls.Add(this.lblReporteListadoPersonal);
            this.grupBoxListadoPersonal.Controls.Add(this.rdListadoPersonalxCargo);
            this.grupBoxListadoPersonal.Controls.Add(this.btnElegirReportePersonal);
            this.grupBoxListadoPersonal.Controls.Add(this.rdReportePersonalxDni);
            this.grupBoxListadoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupBoxListadoPersonal.Location = new System.Drawing.Point(47, 10);
            this.grupBoxListadoPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.grupBoxListadoPersonal.Name = "grupBoxListadoPersonal";
            this.grupBoxListadoPersonal.Padding = new System.Windows.Forms.Padding(2);
            this.grupBoxListadoPersonal.Size = new System.Drawing.Size(393, 130);
            this.grupBoxListadoPersonal.TabIndex = 12;
            this.grupBoxListadoPersonal.TabStop = false;
            this.grupBoxListadoPersonal.Text = "Eleccion Reporte";
            // 
            // rdListadoPersonalTodos
            // 
            this.rdListadoPersonalTodos.AutoSize = true;
            this.rdListadoPersonalTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdListadoPersonalTodos.Location = new System.Drawing.Point(124, 71);
            this.rdListadoPersonalTodos.Margin = new System.Windows.Forms.Padding(2);
            this.rdListadoPersonalTodos.Name = "rdListadoPersonalTodos";
            this.rdListadoPersonalTodos.Size = new System.Drawing.Size(167, 21);
            this.rdListadoPersonalTodos.TabIndex = 4;
            this.rdListadoPersonalTodos.TabStop = true;
            this.rdListadoPersonalTodos.Text = "Listar todo el personal";
            this.rdListadoPersonalTodos.UseVisualStyleBackColor = true;
            // 
            // lblReporteListadoPersonal
            // 
            this.lblReporteListadoPersonal.AutoSize = true;
            this.lblReporteListadoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteListadoPersonal.Location = new System.Drawing.Point(5, 17);
            this.lblReporteListadoPersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReporteListadoPersonal.Name = "lblReporteListadoPersonal";
            this.lblReporteListadoPersonal.Size = new System.Drawing.Size(114, 18);
            this.lblReporteListadoPersonal.TabIndex = 3;
            this.lblReporteListadoPersonal.Text = "Tipo de Reporte";
            // 
            // rdListadoPersonalxCargo
            // 
            this.rdListadoPersonalxCargo.AutoSize = true;
            this.rdListadoPersonalxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdListadoPersonalxCargo.Location = new System.Drawing.Point(124, 46);
            this.rdListadoPersonalxCargo.Margin = new System.Windows.Forms.Padding(2);
            this.rdListadoPersonalxCargo.Name = "rdListadoPersonalxCargo";
            this.rdListadoPersonalxCargo.Size = new System.Drawing.Size(198, 21);
            this.rdListadoPersonalxCargo.TabIndex = 2;
            this.rdListadoPersonalxCargo.TabStop = true;
            this.rdListadoPersonalxCargo.Text = "Listar por numero de cargo";
            this.rdListadoPersonalxCargo.UseVisualStyleBackColor = true;
            // 
            // btnElegirReportePersonal
            // 
            this.btnElegirReportePersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirReportePersonal.Location = new System.Drawing.Point(124, 96);
            this.btnElegirReportePersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnElegirReportePersonal.Name = "btnElegirReportePersonal";
            this.btnElegirReportePersonal.Size = new System.Drawing.Size(99, 27);
            this.btnElegirReportePersonal.TabIndex = 1;
            this.btnElegirReportePersonal.Text = "Siguiente";
            this.btnElegirReportePersonal.UseVisualStyleBackColor = true;
            this.btnElegirReportePersonal.Click += new System.EventHandler(this.btnElegirReporte_Click);
            // 
            // rdReportePersonalxDni
            // 
            this.rdReportePersonalxDni.AutoSize = true;
            this.rdReportePersonalxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReportePersonalxDni.Location = new System.Drawing.Point(124, 21);
            this.rdReportePersonalxDni.Margin = new System.Windows.Forms.Padding(2);
            this.rdReportePersonalxDni.Name = "rdReportePersonalxDni";
            this.rdReportePersonalxDni.Size = new System.Drawing.Size(219, 21);
            this.rdReportePersonalxDni.TabIndex = 1;
            this.rdReportePersonalxDni.TabStop = true;
            this.rdReportePersonalxDni.Text = "Listar personal por documento";
            this.rdReportePersonalxDni.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarReportePersonalCargo
            // 
            this.btnFiltrarReportePersonalCargo.Enabled = false;
            this.btnFiltrarReportePersonalCargo.Location = new System.Drawing.Point(736, 56);
            this.btnFiltrarReportePersonalCargo.Name = "btnFiltrarReportePersonalCargo";
            this.btnFiltrarReportePersonalCargo.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarReportePersonalCargo.TabIndex = 15;
            this.btnFiltrarReportePersonalCargo.Text = "Filtrar";
            this.btnFiltrarReportePersonalCargo.UseVisualStyleBackColor = true;
            this.btnFiltrarReportePersonalCargo.Click += new System.EventHandler(this.btnFiltrarReportePersonalCargo_Click);
            // 
            // mskCargoFiltroListadoPersonal
            // 
            this.mskCargoFiltroListadoPersonal.Enabled = false;
            this.mskCargoFiltroListadoPersonal.Location = new System.Drawing.Point(629, 56);
            this.mskCargoFiltroListadoPersonal.Mask = "99999999";
            this.mskCargoFiltroListadoPersonal.Name = "mskCargoFiltroListadoPersonal";
            this.mskCargoFiltroListadoPersonal.Size = new System.Drawing.Size(91, 20);
            this.mskCargoFiltroListadoPersonal.TabIndex = 14;
            this.mskCargoFiltroListadoPersonal.ValidatingType = typeof(int);
            // 
            // lblListarPorCargo
            // 
            this.lblListarPorCargo.AutoSize = true;
            this.lblListarPorCargo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarPorCargo.Location = new System.Drawing.Point(472, 57);
            this.lblListarPorCargo.Name = "lblListarPorCargo";
            this.lblListarPorCargo.Size = new System.Drawing.Size(151, 20);
            this.lblListarPorCargo.TabIndex = 13;
            this.lblListarPorCargo.Text = "Ingresar ID del cargo:";
            // 
            // ReporteListadoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 488);
            this.Controls.Add(this.btnFiltrarReportePersonalCargo);
            this.Controls.Add(this.mskCargoFiltroListadoPersonal);
            this.Controls.Add(this.lblListarPorCargo);
            this.Controls.Add(this.grupBoxListadoPersonal);
            this.Controls.Add(this.btnFiltrarReportePersonal);
            this.Controls.Add(this.mskDniFiltroReportePersonal);
            this.Controls.Add(this.lblFiltrarReportePersonal);
            this.Controls.Add(this.ReportListPersonal);
            this.Name = "ReporteListadoPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de personal";
            this.Load += new System.EventHandler(this.ReporteListadoPersonal_Load);
            this.grupBoxListadoPersonal.ResumeLayout(false);
            this.grupBoxListadoPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportListPersonal;
        private System.Windows.Forms.Label lblFiltrarReportePersonal;
        private System.Windows.Forms.MaskedTextBox mskDniFiltroReportePersonal;
        private System.Windows.Forms.Button btnFiltrarReportePersonal;
        private System.Windows.Forms.GroupBox grupBoxListadoPersonal;
        private System.Windows.Forms.Label lblReporteListadoPersonal;
        private System.Windows.Forms.RadioButton rdListadoPersonalxCargo;
        private System.Windows.Forms.Button btnElegirReportePersonal;
        private System.Windows.Forms.RadioButton rdReportePersonalxDni;
        private System.Windows.Forms.Button btnFiltrarReportePersonalCargo;
        private System.Windows.Forms.MaskedTextBox mskCargoFiltroListadoPersonal;
        private System.Windows.Forms.Label lblListarPorCargo;
        private System.Windows.Forms.RadioButton rdListadoPersonalTodos;
    }
}