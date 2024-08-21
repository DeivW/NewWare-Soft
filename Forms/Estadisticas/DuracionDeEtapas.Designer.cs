
namespace NewWare_Soft.Forms.Estadisticas
{
    partial class DuracionDeEtapas
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
            this.reporte_Etapas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDuracionMayor = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.btnSelecc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_Etapas
            // 
            this.reporte_Etapas.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Estadistica_DuracionEtapas.rdlc";
            this.reporte_Etapas.Location = new System.Drawing.Point(0, 157);
            this.reporte_Etapas.Name = "reporte_Etapas";
            this.reporte_Etapas.ServerReport.BearerToken = null;
            this.reporte_Etapas.Size = new System.Drawing.Size(800, 359);
            this.reporte_Etapas.TabIndex = 0;
            this.reporte_Etapas.Visible = false;
            this.reporte_Etapas.Load += new System.EventHandler(this.Estadistica_EtapasQueMasTardaron_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDuracionMayor);
            this.groupBox1.Controls.Add(this.rdbNombre);
            this.groupBox1.Controls.Add(this.rbTodas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 98);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES PARA VISUALIZAR GRAFICO";
            // 
            // rdbDuracionMayor
            // 
            this.rdbDuracionMayor.AutoSize = true;
            this.rdbDuracionMayor.Location = new System.Drawing.Point(18, 70);
            this.rdbDuracionMayor.Name = "rdbDuracionMayor";
            this.rdbDuracionMayor.Size = new System.Drawing.Size(175, 17);
            this.rdbDuracionMayor.TabIndex = 6;
            this.rdbDuracionMayor.TabStop = true;
            this.rdbDuracionMayor.Text = "Etapas con duracion mayor a ...";
            this.rdbDuracionMayor.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(18, 47);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(113, 17);
            this.rdbNombre.TabIndex = 4;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Filtrar por Proyecto";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(18, 24);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(106, 17);
            this.rbTodas.TabIndex = 3;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas las etapas";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // btnSelecc
            // 
            this.btnSelecc.Location = new System.Drawing.Point(106, 116);
            this.btnSelecc.Name = "btnSelecc";
            this.btnSelecc.Size = new System.Drawing.Size(146, 23);
            this.btnSelecc.TabIndex = 5;
            this.btnSelecc.Text = "Seleccionar";
            this.btnSelecc.UseVisualStyleBackColor = true;
            this.btnSelecc.Click += new System.EventHandler(this.btnSelecc_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 72);
            this.label1.TabIndex = 18;
            this.label1.Text = "SI DESEA VISUALIZAR UN GRAFICO  MOSTRANDO LA DURACION DE CADA ETAPA, PRESIONE CON" +
    "FIRMAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(442, 87);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(146, 23);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ingrese Nombre del Proyecto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(497, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 20);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ingrese un Numero:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(529, 56);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(70, 20);
            this.txtNumero.TabIndex = 24;
            this.txtNumero.Visible = false;
            // 
            // DuracionDeEtapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelecc);
            this.Controls.Add(this.reporte_Etapas);
            this.Name = "DuracionDeEtapas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duracion de las Etapas";
            this.Load += new System.EventHandler(this.Estadistica_EtapasQueMasTardaron_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_Etapas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDuracionMayor;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.Button btnSelecc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
    }
}