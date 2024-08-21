
namespace NewWare_Soft
{
    partial class EstadisticasEmpleados
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
            this.rptEstadisticasProyectos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbPorFecha = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFechaPrDesde = new System.Windows.Forms.Label();
            this.txtFechaIni = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptEstadisticasProyectos
            // 
            this.rptEstadisticasProyectos.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticasEmpleadoProyecto.rdlc";
            this.rptEstadisticasProyectos.Location = new System.Drawing.Point(1, 202);
            this.rptEstadisticasProyectos.Name = "rptEstadisticasProyectos";
            this.rptEstadisticasProyectos.ServerReport.BearerToken = null;
            this.rptEstadisticasProyectos.Size = new System.Drawing.Size(798, 454);
            this.rptEstadisticasProyectos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPorFecha);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de grafico estadistico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un tipo:";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(146, 27);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(123, 17);
            this.rbTodos.TabIndex = 1;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los proyectos.";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbPorFecha
            // 
            this.rbPorFecha.AutoSize = true;
            this.rbPorFecha.Location = new System.Drawing.Point(146, 59);
            this.rbPorFecha.Name = "rbPorFecha";
            this.rbPorFecha.Size = new System.Drawing.Size(141, 17);
            this.rbPorFecha.TabIndex = 2;
            this.rbPorFecha.TabStop = true;
            this.rbPorFecha.Text = "Filtrar por fecha de Inicio";
            this.rbPorFecha.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(335, 109);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFechaPrDesde
            // 
            this.lblFechaPrDesde.AutoSize = true;
            this.lblFechaPrDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrDesde.Location = new System.Drawing.Point(454, 109);
            this.lblFechaPrDesde.Name = "lblFechaPrDesde";
            this.lblFechaPrDesde.Size = new System.Drawing.Size(149, 18);
            this.lblFechaPrDesde.TabIndex = 3;
            this.lblFechaPrDesde.Text = "Fecha Inicio mayor a:";
            this.lblFechaPrDesde.Visible = false;
            // 
            // txtFechaIni
            // 
            this.txtFechaIni.Enabled = false;
            this.txtFechaIni.Location = new System.Drawing.Point(610, 106);
            this.txtFechaIni.Mask = "00/00/0000";
            this.txtFechaIni.Name = "txtFechaIni";
            this.txtFechaIni.Size = new System.Drawing.Size(68, 20);
            this.txtFechaIni.TabIndex = 4;
            this.txtFechaIni.ValidatingType = typeof(System.DateTime);
            this.txtFechaIni.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(693, 102);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 42);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar por Fecha";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(195, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estadisticas de Personal por Proyectos";
            // 
            // EstadisticasEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFechaIni);
            this.Controls.Add(this.lblFechaPrDesde);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptEstadisticasProyectos);
            this.Name = "EstadisticasEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticasEmpleados";
            this.Load += new System.EventHandler(this.EstadisticasEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptEstadisticasProyectos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPorFecha;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFechaPrDesde;
        private System.Windows.Forms.MaskedTextBox txtFechaIni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
    }
}