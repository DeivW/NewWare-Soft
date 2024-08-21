
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoEmpleadoXproyecto
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
            this.btnSeleccionarProyecto = new System.Windows.Forms.Button();
            this.lblProyectos = new System.Windows.Forms.Label();
            this.cmbProyectos = new System.Windows.Forms.ComboBox();
            this.groupBox_tipoReporte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbUnPersonal = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.rbUNProyecto = new System.Windows.Forms.RadioButton();
            this.rbTodosProyectos = new System.Windows.Forms.RadioButton();
            this.btnListarPorPersonal = new System.Windows.Forms.Button();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_tipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerPersonalXetapa
            // 
            this.reportViewerPersonalXetapa.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_PersonalXetapa.rdlc";
            this.reportViewerPersonalXetapa.Location = new System.Drawing.Point(0, 250);
            this.reportViewerPersonalXetapa.Name = "reportViewerPersonalXetapa";
            this.reportViewerPersonalXetapa.ServerReport.BearerToken = null;
            this.reportViewerPersonalXetapa.Size = new System.Drawing.Size(734, 293);
            this.reportViewerPersonalXetapa.TabIndex = 0;
            // 
            // btnSeleccionarProyecto
            // 
            this.btnSeleccionarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProyecto.Location = new System.Drawing.Point(604, 130);
            this.btnSeleccionarProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarProyecto.Name = "btnSeleccionarProyecto";
            this.btnSeleccionarProyecto.Size = new System.Drawing.Size(96, 27);
            this.btnSeleccionarProyecto.TabIndex = 14;
            this.btnSeleccionarProyecto.Text = "Seleccionar";
            this.btnSeleccionarProyecto.UseVisualStyleBackColor = true;
            this.btnSeleccionarProyecto.Visible = false;
            this.btnSeleccionarProyecto.Click += new System.EventHandler(this.btnSeleccionarProyecto_Click);
            // 
            // lblProyectos
            // 
            this.lblProyectos.AutoSize = true;
            this.lblProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectos.Location = new System.Drawing.Point(358, 135);
            this.lblProyectos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(75, 17);
            this.lblProyectos.TabIndex = 13;
            this.lblProyectos.Text = "Proyectos:";
            this.lblProyectos.Visible = false;
            // 
            // cmbProyectos
            // 
            this.cmbProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyectos.Enabled = false;
            this.cmbProyectos.FormattingEnabled = true;
            this.cmbProyectos.Location = new System.Drawing.Point(437, 134);
            this.cmbProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProyectos.Name = "cmbProyectos";
            this.cmbProyectos.Size = new System.Drawing.Size(144, 21);
            this.cmbProyectos.TabIndex = 12;
            this.cmbProyectos.Visible = false;
            // 
            // groupBox_tipoReporte
            // 
            this.groupBox_tipoReporte.Controls.Add(this.label1);
            this.groupBox_tipoReporte.Controls.Add(this.rbUnPersonal);
            this.groupBox_tipoReporte.Controls.Add(this.btnSiguiente);
            this.groupBox_tipoReporte.Controls.Add(this.rbUNProyecto);
            this.groupBox_tipoReporte.Controls.Add(this.rbTodosProyectos);
            this.groupBox_tipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoReporte.Location = new System.Drawing.Point(11, 115);
            this.groupBox_tipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Name = "groupBox_tipoReporte";
            this.groupBox_tipoReporte.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Size = new System.Drawing.Size(343, 115);
            this.groupBox_tipoReporte.TabIndex = 11;
            this.groupBox_tipoReporte.TabStop = false;
            this.groupBox_tipoReporte.Text = "Eleccion Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Reporte";
            // 
            // rbUnPersonal
            // 
            this.rbUnPersonal.AutoSize = true;
            this.rbUnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnPersonal.Location = new System.Drawing.Point(124, 62);
            this.rbUnPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.rbUnPersonal.Name = "rbUnPersonal";
            this.rbUnPersonal.Size = new System.Drawing.Size(153, 21);
            this.rbUnPersonal.TabIndex = 2;
            this.rbUnPersonal.TabStop = true;
            this.rbUnPersonal.Text = "Listar por Empleado";
            this.rbUnPersonal.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(124, 88);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(99, 23);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // rbUNProyecto
            // 
            this.rbUNProyecto.AutoSize = true;
            this.rbUNProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUNProyecto.Location = new System.Drawing.Point(124, 17);
            this.rbUNProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.rbUNProyecto.Name = "rbUNProyecto";
            this.rbUNProyecto.Size = new System.Drawing.Size(146, 21);
            this.rbUNProyecto.TabIndex = 1;
            this.rbUNProyecto.TabStop = true;
            this.rbUNProyecto.Text = "Listar por Proyecto";
            this.rbUNProyecto.UseVisualStyleBackColor = true;
            // 
            // rbTodosProyectos
            // 
            this.rbTodosProyectos.AutoSize = true;
            this.rbTodosProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodosProyectos.Location = new System.Drawing.Point(124, 40);
            this.rbTodosProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.rbTodosProyectos.Name = "rbTodosProyectos";
            this.rbTodosProyectos.Size = new System.Drawing.Size(155, 21);
            this.rbTodosProyectos.TabIndex = 0;
            this.rbTodosProyectos.TabStop = true;
            this.rbTodosProyectos.Text = "Todos los Proyectos";
            this.rbTodosProyectos.UseVisualStyleBackColor = true;
            // 
            // btnListarPorPersonal
            // 
            this.btnListarPorPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPorPersonal.Location = new System.Drawing.Point(604, 184);
            this.btnListarPorPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarPorPersonal.Name = "btnListarPorPersonal";
            this.btnListarPorPersonal.Size = new System.Drawing.Size(96, 27);
            this.btnListarPorPersonal.TabIndex = 17;
            this.btnListarPorPersonal.Text = "Seleccionar";
            this.btnListarPorPersonal.UseVisualStyleBackColor = true;
            this.btnListarPorPersonal.Visible = false;
            this.btnListarPorPersonal.Click += new System.EventHandler(this.btnListarPorPersonal_Click);
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.Location = new System.Drawing.Point(358, 189);
            this.lblPersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(68, 17);
            this.lblPersonal.TabIndex = 16;
            this.lblPersonal.Text = "Personal:";
            this.lblPersonal.Visible = false;
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonal.Enabled = false;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Location = new System.Drawing.Point(437, 188);
            this.cmbPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(144, 21);
            this.cmbPersonal.TabIndex = 15;
            this.cmbPersonal.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(130, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Reporte de Personal por Etapa de Proyectos";
            // 
            // ListadoPersonalXetapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListarPorPersonal);
            this.Controls.Add(this.lblPersonal);
            this.Controls.Add(this.cmbPersonal);
            this.Controls.Add(this.btnSeleccionarProyecto);
            this.Controls.Add(this.lblProyectos);
            this.Controls.Add(this.cmbProyectos);
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
        private System.Windows.Forms.Button btnSeleccionarProyecto;
        private System.Windows.Forms.Label lblProyectos;
        private System.Windows.Forms.ComboBox cmbProyectos;
        private System.Windows.Forms.GroupBox groupBox_tipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbUnPersonal;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.RadioButton rbUNProyecto;
        private System.Windows.Forms.RadioButton rbTodosProyectos;
        private System.Windows.Forms.Button btnListarPorPersonal;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.Label label2;
    }
}