
namespace NewWare_Soft.Forms.Estadisticas
{
    partial class Estadistica_HerramientasMasUtilizadas
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
            this.button_Generar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox_tipoReporte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Siguiente = new System.Windows.Forms.Button();
            this.rbnHerrMasUtili = new System.Windows.Forms.RadioButton();
            this.rbnHerrMasUtili_codigo = new System.Windows.Forms.RadioButton();
            this.rpv_HerrMasUtilizadas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbEtapa = new System.Windows.Forms.ComboBox();
            this.groupBox_tipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Generar
            // 
            this.button_Generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generar.Location = new System.Drawing.Point(558, 71);
            this.button_Generar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Generar.Name = "button_Generar";
            this.button_Generar.Size = new System.Drawing.Size(107, 25);
            this.button_Generar.TabIndex = 17;
            this.button_Generar.Text = "Generar grafico";
            this.button_Generar.UseVisualStyleBackColor = true;
            this.button_Generar.Visible = false;
            this.button_Generar.Click += new System.EventHandler(this.button_Generar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(396, 74);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 17);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Codigo: ";
            this.lblCodigo.Visible = false;
            // 
            // groupBox_tipoReporte
            // 
            this.groupBox_tipoReporte.Controls.Add(this.label1);
            this.groupBox_tipoReporte.Controls.Add(this.button_Siguiente);
            this.groupBox_tipoReporte.Controls.Add(this.rbnHerrMasUtili);
            this.groupBox_tipoReporte.Controls.Add(this.rbnHerrMasUtili_codigo);
            this.groupBox_tipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoReporte.Location = new System.Drawing.Point(11, 11);
            this.groupBox_tipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Name = "groupBox_tipoReporte";
            this.groupBox_tipoReporte.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Size = new System.Drawing.Size(374, 115);
            this.groupBox_tipoReporte.TabIndex = 14;
            this.groupBox_tipoReporte.TabStop = false;
            this.groupBox_tipoReporte.Text = "Estadisticas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipos";
            // 
            // button_Siguiente
            // 
            this.button_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Siguiente.Location = new System.Drawing.Point(75, 88);
            this.button_Siguiente.Margin = new System.Windows.Forms.Padding(2);
            this.button_Siguiente.Name = "button_Siguiente";
            this.button_Siguiente.Size = new System.Drawing.Size(99, 23);
            this.button_Siguiente.TabIndex = 1;
            this.button_Siguiente.Text = "Siguiente";
            this.button_Siguiente.UseVisualStyleBackColor = true;
            this.button_Siguiente.Click += new System.EventHandler(this.button_Siguiente_Click);
            // 
            // rbnHerrMasUtili
            // 
            this.rbnHerrMasUtili.AutoSize = true;
            this.rbnHerrMasUtili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHerrMasUtili.Location = new System.Drawing.Point(75, 17);
            this.rbnHerrMasUtili.Margin = new System.Windows.Forms.Padding(2);
            this.rbnHerrMasUtili.Name = "rbnHerrMasUtili";
            this.rbnHerrMasUtili.Size = new System.Drawing.Size(204, 21);
            this.rbnHerrMasUtili.TabIndex = 1;
            this.rbnHerrMasUtili.TabStop = true;
            this.rbnHerrMasUtili.Text = "Herramientas mas utilizadas";
            this.rbnHerrMasUtili.UseVisualStyleBackColor = true;
            // 
            // rbnHerrMasUtili_codigo
            // 
            this.rbnHerrMasUtili_codigo.AutoSize = true;
            this.rbnHerrMasUtili_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHerrMasUtili_codigo.Location = new System.Drawing.Point(75, 40);
            this.rbnHerrMasUtili_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.rbnHerrMasUtili_codigo.Name = "rbnHerrMasUtili_codigo";
            this.rbnHerrMasUtili_codigo.Size = new System.Drawing.Size(269, 21);
            this.rbnHerrMasUtili_codigo.TabIndex = 0;
            this.rbnHerrMasUtili_codigo.TabStop = true;
            this.rbnHerrMasUtili_codigo.Text = "Herramientas mas utilizadas por etapa";
            this.rbnHerrMasUtili_codigo.UseVisualStyleBackColor = true;
            // 
            // rpv_HerrMasUtilizadas
            // 
            this.rpv_HerrMasUtilizadas.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaHerrMasUtilizadas.rdlc";
            this.rpv_HerrMasUtilizadas.Location = new System.Drawing.Point(4, 130);
            this.rpv_HerrMasUtilizadas.Margin = new System.Windows.Forms.Padding(2);
            this.rpv_HerrMasUtilizadas.Name = "rpv_HerrMasUtilizadas";
            this.rpv_HerrMasUtilizadas.ServerReport.BearerToken = null;
            this.rpv_HerrMasUtilizadas.Size = new System.Drawing.Size(719, 253);
            this.rpv_HerrMasUtilizadas.TabIndex = 13;
            // 
            // cmbEtapa
            // 
            this.cmbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtapa.FormattingEnabled = true;
            this.cmbEtapa.Location = new System.Drawing.Point(460, 74);
            this.cmbEtapa.Name = "cmbEtapa";
            this.cmbEtapa.Size = new System.Drawing.Size(85, 21);
            this.cmbEtapa.TabIndex = 18;
            // 
            // Estadistica_HerramientasMasUtilizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 392);
            this.Controls.Add(this.cmbEtapa);
            this.Controls.Add(this.button_Generar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.groupBox_tipoReporte);
            this.Controls.Add(this.rpv_HerrMasUtilizadas);
            this.Name = "Estadistica_HerramientasMasUtilizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica_HerramientasMasUtilizadas";
            this.Load += new System.EventHandler(this.Estadistica_HerramientasMasUtilizadas_Load);
            this.groupBox_tipoReporte.ResumeLayout(false);
            this.groupBox_tipoReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox_tipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Siguiente;
        private System.Windows.Forms.RadioButton rbnHerrMasUtili;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_HerrMasUtilizadas;
        private System.Windows.Forms.RadioButton rbnHerrMasUtili_codigo;
        private System.Windows.Forms.ComboBox cmbEtapa;
    }
}