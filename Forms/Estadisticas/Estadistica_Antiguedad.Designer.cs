
namespace NewWare_Soft
{
    partial class Estadistica_Antiguedad
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
            this.reportViewer_Ant = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox_tipoReporte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_viaje = new System.Windows.Forms.RadioButton();
            this.button_Siguiente = new System.Windows.Forms.Button();
            this.radioButton_TodosAño = new System.Windows.Forms.RadioButton();
            this.radioButton_Todos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_Años = new System.Windows.Forms.MaskedTextBox();
            this.button_Generar = new System.Windows.Forms.Button();
            this.groupBox_tipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer_Ant
            // 
            this.reportViewer_Ant.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Estadistica_Antiguedad_Personal.rdlc";
            this.reportViewer_Ant.Location = new System.Drawing.Point(1, 196);
            this.reportViewer_Ant.Name = "reportViewer_Ant";
            this.reportViewer_Ant.ServerReport.BearerToken = null;
            this.reportViewer_Ant.Size = new System.Drawing.Size(1077, 388);
            this.reportViewer_Ant.TabIndex = 0;
            this.reportViewer_Ant.Visible = false;
            // 
            // groupBox_tipoReporte
            // 
            this.groupBox_tipoReporte.Controls.Add(this.label1);
            this.groupBox_tipoReporte.Controls.Add(this.radioButton_viaje);
            this.groupBox_tipoReporte.Controls.Add(this.button_Siguiente);
            this.groupBox_tipoReporte.Controls.Add(this.radioButton_TodosAño);
            this.groupBox_tipoReporte.Controls.Add(this.radioButton_Todos);
            this.groupBox_tipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoReporte.Location = new System.Drawing.Point(12, 13);
            this.groupBox_tipoReporte.Name = "groupBox_tipoReporte";
            this.groupBox_tipoReporte.Size = new System.Drawing.Size(561, 177);
            this.groupBox_tipoReporte.TabIndex = 9;
            this.groupBox_tipoReporte.TabStop = false;
            this.groupBox_tipoReporte.Text = "Estadisticas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipos";
            // 
            // radioButton_viaje
            // 
            this.radioButton_viaje.AutoSize = true;
            this.radioButton_viaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_viaje.Location = new System.Drawing.Point(113, 96);
            this.radioButton_viaje.Name = "radioButton_viaje";
            this.radioButton_viaje.Size = new System.Drawing.Size(230, 29);
            this.radioButton_viaje.TabIndex = 2;
            this.radioButton_viaje.TabStop = true;
            this.radioButton_viaje.Text = "Trabajó x años o mas ";
            this.radioButton_viaje.UseVisualStyleBackColor = true;
            // 
            // button_Siguiente
            // 
            this.button_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Siguiente.Location = new System.Drawing.Point(113, 136);
            this.button_Siguiente.Name = "button_Siguiente";
            this.button_Siguiente.Size = new System.Drawing.Size(148, 35);
            this.button_Siguiente.TabIndex = 1;
            this.button_Siguiente.Text = "Siguiente";
            this.button_Siguiente.UseVisualStyleBackColor = true;
            this.button_Siguiente.Click += new System.EventHandler(this.button_Siguiente_Click);
            // 
            // radioButton_TodosAño
            // 
            this.radioButton_TodosAño.AutoSize = true;
            this.radioButton_TodosAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_TodosAño.Location = new System.Drawing.Point(113, 26);
            this.radioButton_TodosAño.Name = "radioButton_TodosAño";
            this.radioButton_TodosAño.Size = new System.Drawing.Size(366, 29);
            this.radioButton_TodosAño.TabIndex = 1;
            this.radioButton_TodosAño.TabStop = true;
            this.radioButton_TodosAño.Text = "Antiguedad de los que superan el año";
            this.radioButton_TodosAño.UseVisualStyleBackColor = true;
            // 
            // radioButton_Todos
            // 
            this.radioButton_Todos.AutoSize = true;
            this.radioButton_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Todos.Location = new System.Drawing.Point(113, 61);
            this.radioButton_Todos.Name = "radioButton_Todos";
            this.radioButton_Todos.Size = new System.Drawing.Size(227, 29);
            this.radioButton_Todos.TabIndex = 0;
            this.radioButton_Todos.TabStop = true;
            this.radioButton_Todos.Text = "Antiguedad en meses";
            this.radioButton_Todos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Años: ";
            this.label2.Visible = false;
            // 
            // maskedTextBox_Años
            // 
            this.maskedTextBox_Años.Enabled = false;
            this.maskedTextBox_Años.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Años.Location = new System.Drawing.Point(667, 110);
            this.maskedTextBox_Años.Mask = "##";
            this.maskedTextBox_Años.Name = "maskedTextBox_Años";
            this.maskedTextBox_Años.Size = new System.Drawing.Size(35, 30);
            this.maskedTextBox_Años.TabIndex = 11;
            this.maskedTextBox_Años.Visible = false;
            // 
            // button_Generar
            // 
            this.button_Generar.Enabled = false;
            this.button_Generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generar.Location = new System.Drawing.Point(733, 104);
            this.button_Generar.Name = "button_Generar";
            this.button_Generar.Size = new System.Drawing.Size(161, 39);
            this.button_Generar.TabIndex = 12;
            this.button_Generar.Text = "Generar grafico";
            this.button_Generar.UseVisualStyleBackColor = true;
            this.button_Generar.Visible = false;
            this.button_Generar.Click += new System.EventHandler(this.button_Generar_Click);
            // 
            // Estadistica_Antiguedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 596);
            this.Controls.Add(this.button_Generar);
            this.Controls.Add(this.maskedTextBox_Años);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox_tipoReporte);
            this.Controls.Add(this.reportViewer_Ant);
            this.Name = "Estadistica_Antiguedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antiguedad del Personal";
            this.Load += new System.EventHandler(this.Estadistica_Antiguedad_Load);
            this.groupBox_tipoReporte.ResumeLayout(false);
            this.groupBox_tipoReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Ant;
        private System.Windows.Forms.GroupBox groupBox_tipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_viaje;
        private System.Windows.Forms.Button button_Siguiente;
        private System.Windows.Forms.RadioButton radioButton_TodosAño;
        private System.Windows.Forms.RadioButton radioButton_Todos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Años;
        private System.Windows.Forms.Button button_Generar;
    }
}