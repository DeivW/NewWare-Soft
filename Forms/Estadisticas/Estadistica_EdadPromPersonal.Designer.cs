
namespace NewWare_Soft.Forms.Estadisticas
{
    partial class Estadistica_EdadPromPersonal
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
            this.RvcEstadisticaEdadProm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grupBoxEstadisticaEdadProm = new System.Windows.Forms.GroupBox();
            this.lblFiltrarEstadisticaEdadProm = new System.Windows.Forms.Label();
            this.rdEstadisticaEdadPromFiltroPorCargo = new System.Windows.Forms.RadioButton();
            this.btnElegirEstadisticaEdadProm = new System.Windows.Forms.Button();
            this.rdMostrarEstadisticaEdadPromCompleta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdadPromEstadistica = new System.Windows.Forms.TextBox();
            this.txtCargoEstadisticaEdadProm = new System.Windows.Forms.TextBox();
            this.lblIngresarCargoEstadEdadProm = new System.Windows.Forms.Label();
            this.btnFiltrarEstadisticaEdadProm = new System.Windows.Forms.Button();
            this.grupBoxEstadisticaEdadProm.SuspendLayout();
            this.SuspendLayout();
            // 
            // RvcEstadisticaEdadProm
            // 
            this.RvcEstadisticaEdadProm.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaEdadPromPersonal.rdlc";
            this.RvcEstadisticaEdadProm.Location = new System.Drawing.Point(12, 123);
            this.RvcEstadisticaEdadProm.Name = "RvcEstadisticaEdadProm";
            this.RvcEstadisticaEdadProm.ServerReport.BearerToken = null;
            this.RvcEstadisticaEdadProm.Size = new System.Drawing.Size(920, 408);
            this.RvcEstadisticaEdadProm.TabIndex = 0;
            this.RvcEstadisticaEdadProm.Load += new System.EventHandler(this.RvcEstadisticaEdadProm_Load);
            // 
            // grupBoxEstadisticaEdadProm
            // 
            this.grupBoxEstadisticaEdadProm.Controls.Add(this.lblFiltrarEstadisticaEdadProm);
            this.grupBoxEstadisticaEdadProm.Controls.Add(this.rdEstadisticaEdadPromFiltroPorCargo);
            this.grupBoxEstadisticaEdadProm.Controls.Add(this.btnElegirEstadisticaEdadProm);
            this.grupBoxEstadisticaEdadProm.Controls.Add(this.rdMostrarEstadisticaEdadPromCompleta);
            this.grupBoxEstadisticaEdadProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupBoxEstadisticaEdadProm.Location = new System.Drawing.Point(67, 11);
            this.grupBoxEstadisticaEdadProm.Margin = new System.Windows.Forms.Padding(2);
            this.grupBoxEstadisticaEdadProm.Name = "grupBoxEstadisticaEdadProm";
            this.grupBoxEstadisticaEdadProm.Padding = new System.Windows.Forms.Padding(2);
            this.grupBoxEstadisticaEdadProm.Size = new System.Drawing.Size(358, 107);
            this.grupBoxEstadisticaEdadProm.TabIndex = 13;
            this.grupBoxEstadisticaEdadProm.TabStop = false;
            this.grupBoxEstadisticaEdadProm.Text = "Eleccion Reporte";
            // 
            // lblFiltrarEstadisticaEdadProm
            // 
            this.lblFiltrarEstadisticaEdadProm.AutoSize = true;
            this.lblFiltrarEstadisticaEdadProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarEstadisticaEdadProm.Location = new System.Drawing.Point(5, 17);
            this.lblFiltrarEstadisticaEdadProm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltrarEstadisticaEdadProm.Name = "lblFiltrarEstadisticaEdadProm";
            this.lblFiltrarEstadisticaEdadProm.Size = new System.Drawing.Size(111, 18);
            this.lblFiltrarEstadisticaEdadProm.TabIndex = 3;
            this.lblFiltrarEstadisticaEdadProm.Text = "Tipo estadistica";
            // 
            // rdEstadisticaEdadPromFiltroPorCargo
            // 
            this.rdEstadisticaEdadPromFiltroPorCargo.AutoSize = true;
            this.rdEstadisticaEdadPromFiltroPorCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEstadisticaEdadPromFiltroPorCargo.Location = new System.Drawing.Point(124, 46);
            this.rdEstadisticaEdadPromFiltroPorCargo.Margin = new System.Windows.Forms.Padding(2);
            this.rdEstadisticaEdadPromFiltroPorCargo.Name = "rdEstadisticaEdadPromFiltroPorCargo";
            this.rdEstadisticaEdadPromFiltroPorCargo.Size = new System.Drawing.Size(218, 21);
            this.rdEstadisticaEdadPromFiltroPorCargo.TabIndex = 2;
            this.rdEstadisticaEdadPromFiltroPorCargo.TabStop = true;
            this.rdEstadisticaEdadPromFiltroPorCargo.Text = "Filtrar estadistica por un cargo";
            this.rdEstadisticaEdadPromFiltroPorCargo.UseVisualStyleBackColor = true;
            // 
            // btnElegirEstadisticaEdadProm
            // 
            this.btnElegirEstadisticaEdadProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirEstadisticaEdadProm.Location = new System.Drawing.Point(124, 71);
            this.btnElegirEstadisticaEdadProm.Margin = new System.Windows.Forms.Padding(2);
            this.btnElegirEstadisticaEdadProm.Name = "btnElegirEstadisticaEdadProm";
            this.btnElegirEstadisticaEdadProm.Size = new System.Drawing.Size(99, 27);
            this.btnElegirEstadisticaEdadProm.TabIndex = 1;
            this.btnElegirEstadisticaEdadProm.Text = "Siguiente";
            this.btnElegirEstadisticaEdadProm.UseVisualStyleBackColor = true;
            this.btnElegirEstadisticaEdadProm.Click += new System.EventHandler(this.btnElegirEstadisticaEdadProm_Click);
            // 
            // rdMostrarEstadisticaEdadPromCompleta
            // 
            this.rdMostrarEstadisticaEdadPromCompleta.AutoSize = true;
            this.rdMostrarEstadisticaEdadPromCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMostrarEstadisticaEdadPromCompleta.Location = new System.Drawing.Point(124, 21);
            this.rdMostrarEstadisticaEdadPromCompleta.Margin = new System.Windows.Forms.Padding(2);
            this.rdMostrarEstadisticaEdadPromCompleta.Name = "rdMostrarEstadisticaEdadPromCompleta";
            this.rdMostrarEstadisticaEdadPromCompleta.Size = new System.Drawing.Size(206, 21);
            this.rdMostrarEstadisticaEdadPromCompleta.TabIndex = 1;
            this.rdMostrarEstadisticaEdadPromCompleta.TabStop = true;
            this.rdMostrarEstadisticaEdadPromCompleta.Text = "Mostrar estadistica completa";
            this.rdMostrarEstadisticaEdadPromCompleta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(503, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Edad promedio del personal: ";
            // 
            // txtEdadPromEstadistica
            // 
            this.txtEdadPromEstadistica.Enabled = false;
            this.txtEdadPromEstadistica.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtEdadPromEstadistica.Location = new System.Drawing.Point(778, 73);
            this.txtEdadPromEstadistica.Name = "txtEdadPromEstadistica";
            this.txtEdadPromEstadistica.Size = new System.Drawing.Size(38, 34);
            this.txtEdadPromEstadistica.TabIndex = 15;
            // 
            // txtCargoEstadisticaEdadProm
            // 
            this.txtCargoEstadisticaEdadProm.Enabled = false;
            this.txtCargoEstadisticaEdadProm.Location = new System.Drawing.Point(715, 35);
            this.txtCargoEstadisticaEdadProm.Name = "txtCargoEstadisticaEdadProm";
            this.txtCargoEstadisticaEdadProm.Size = new System.Drawing.Size(49, 20);
            this.txtCargoEstadisticaEdadProm.TabIndex = 17;
            // 
            // lblIngresarCargoEstadEdadProm
            // 
            this.lblIngresarCargoEstadEdadProm.AutoSize = true;
            this.lblIngresarCargoEstadEdadProm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIngresarCargoEstadEdadProm.Location = new System.Drawing.Point(513, 33);
            this.lblIngresarCargoEstadEdadProm.Name = "lblIngresarCargoEstadEdadProm";
            this.lblIngresarCargoEstadEdadProm.Size = new System.Drawing.Size(196, 20);
            this.lblIngresarCargoEstadEdadProm.TabIndex = 16;
            this.lblIngresarCargoEstadEdadProm.Text = "Ingrese un cargo para filtrar:";
            // 
            // btnFiltrarEstadisticaEdadProm
            // 
            this.btnFiltrarEstadisticaEdadProm.Enabled = false;
            this.btnFiltrarEstadisticaEdadProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFiltrarEstadisticaEdadProm.Location = new System.Drawing.Point(769, 34);
            this.btnFiltrarEstadisticaEdadProm.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrarEstadisticaEdadProm.Name = "btnFiltrarEstadisticaEdadProm";
            this.btnFiltrarEstadisticaEdadProm.Size = new System.Drawing.Size(81, 22);
            this.btnFiltrarEstadisticaEdadProm.TabIndex = 18;
            this.btnFiltrarEstadisticaEdadProm.Text = "Filtrar";
            this.btnFiltrarEstadisticaEdadProm.UseVisualStyleBackColor = true;
            this.btnFiltrarEstadisticaEdadProm.Click += new System.EventHandler(this.btnFiltrarEstadisticaEdadProm_Click);
            // 
            // Estadistica_EdadPromPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 543);
            this.Controls.Add(this.btnFiltrarEstadisticaEdadProm);
            this.Controls.Add(this.txtCargoEstadisticaEdadProm);
            this.Controls.Add(this.lblIngresarCargoEstadEdadProm);
            this.Controls.Add(this.txtEdadPromEstadistica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grupBoxEstadisticaEdadProm);
            this.Controls.Add(this.RvcEstadisticaEdadProm);
            this.Name = "Estadistica_EdadPromPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica de edad promedio del personal";
            this.Load += new System.EventHandler(this.Estadistica_EdadPromPersonal_Load);
            this.grupBoxEstadisticaEdadProm.ResumeLayout(false);
            this.grupBoxEstadisticaEdadProm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RvcEstadisticaEdadProm;
        private System.Windows.Forms.GroupBox grupBoxEstadisticaEdadProm;
        private System.Windows.Forms.Label lblFiltrarEstadisticaEdadProm;
        private System.Windows.Forms.RadioButton rdEstadisticaEdadPromFiltroPorCargo;
        private System.Windows.Forms.Button btnElegirEstadisticaEdadProm;
        private System.Windows.Forms.RadioButton rdMostrarEstadisticaEdadPromCompleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdadPromEstadistica;
        private System.Windows.Forms.TextBox txtCargoEstadisticaEdadProm;
        private System.Windows.Forms.Label lblIngresarCargoEstadEdadProm;
        private System.Windows.Forms.Button btnFiltrarEstadisticaEdadProm;
    }
}