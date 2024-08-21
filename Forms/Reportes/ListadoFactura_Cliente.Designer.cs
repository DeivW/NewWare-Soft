
namespace NewWare_Soft.Forms.Reportes
{
    partial class Listado_Factura_Cliente
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
            this.reportViewer_Factura_Cliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button_SeleccionarFechas = new System.Windows.Forms.Button();
            this.label_Desde = new System.Windows.Forms.Label();
            this.button_SeleccionCliente = new System.Windows.Forms.Button();
            this.label_ClientesSelecccion = new System.Windows.Forms.Label();
            this.comboBox_Clientes = new System.Windows.Forms.ComboBox();
            this.groupBox_tipoReporte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Fechas = new System.Windows.Forms.RadioButton();
            this.button_Siguiente = new System.Windows.Forms.Button();
            this.radioButton_ClienteParticular = new System.Windows.Forms.RadioButton();
            this.radioButton_Todos = new System.Windows.Forms.RadioButton();
            this.label_Hasta = new System.Windows.Forms.Label();
            this.maskedTextBox_Desde = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Hasta = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_tipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer_Factura_Cliente
            // 
            this.reportViewer_Factura_Cliente.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Report_Facturas_Por_Cliente.rdlc";
            this.reportViewer_Factura_Cliente.Location = new System.Drawing.Point(0, 200);
            this.reportViewer_Factura_Cliente.Name = "reportViewer_Factura_Cliente";
            this.reportViewer_Factura_Cliente.ServerReport.BearerToken = null;
            this.reportViewer_Factura_Cliente.Size = new System.Drawing.Size(1314, 448);
            this.reportViewer_Factura_Cliente.TabIndex = 0;
            this.reportViewer_Factura_Cliente.Visible = false;
            // 
            // button_SeleccionarFechas
            // 
            this.button_SeleccionarFechas.Enabled = false;
            this.button_SeleccionarFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SeleccionarFechas.Location = new System.Drawing.Point(1040, 98);
            this.button_SeleccionarFechas.Name = "button_SeleccionarFechas";
            this.button_SeleccionarFechas.Size = new System.Drawing.Size(144, 42);
            this.button_SeleccionarFechas.TabIndex = 17;
            this.button_SeleccionarFechas.Text = "Seleccionar";
            this.button_SeleccionarFechas.UseVisualStyleBackColor = true;
            this.button_SeleccionarFechas.Visible = false;
            this.button_SeleccionarFechas.Click += new System.EventHandler(this.button_SeleccionarFechas_Click);
            // 
            // label_Desde
            // 
            this.label_Desde.AutoSize = true;
            this.label_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Desde.Location = new System.Drawing.Point(625, 102);
            this.label_Desde.Name = "label_Desde";
            this.label_Desde.Size = new System.Drawing.Size(69, 25);
            this.label_Desde.TabIndex = 15;
            this.label_Desde.Text = "Desde";
            this.label_Desde.Visible = false;
            // 
            // button_SeleccionCliente
            // 
            this.button_SeleccionCliente.Enabled = false;
            this.button_SeleccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SeleccionCliente.Location = new System.Drawing.Point(1040, 34);
            this.button_SeleccionCliente.Name = "button_SeleccionCliente";
            this.button_SeleccionCliente.Size = new System.Drawing.Size(144, 42);
            this.button_SeleccionCliente.TabIndex = 14;
            this.button_SeleccionCliente.Text = "Seleccionar";
            this.button_SeleccionCliente.UseVisualStyleBackColor = true;
            this.button_SeleccionCliente.Visible = false;
            this.button_SeleccionCliente.Click += new System.EventHandler(this.button_SeleccionCliente_Click);
            // 
            // label_ClientesSelecccion
            // 
            this.label_ClientesSelecccion.AutoSize = true;
            this.label_ClientesSelecccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientesSelecccion.Location = new System.Drawing.Point(611, 38);
            this.label_ClientesSelecccion.Name = "label_ClientesSelecccion";
            this.label_ClientesSelecccion.Size = new System.Drawing.Size(83, 25);
            this.label_ClientesSelecccion.TabIndex = 13;
            this.label_ClientesSelecccion.Text = "Clientes";
            this.label_ClientesSelecccion.Visible = false;
            // 
            // comboBox_Clientes
            // 
            this.comboBox_Clientes.Enabled = false;
            this.comboBox_Clientes.FormattingEnabled = true;
            this.comboBox_Clientes.Location = new System.Drawing.Point(700, 39);
            this.comboBox_Clientes.Name = "comboBox_Clientes";
            this.comboBox_Clientes.Size = new System.Drawing.Size(315, 28);
            this.comboBox_Clientes.TabIndex = 12;
            this.comboBox_Clientes.Visible = false;
            // 
            // groupBox_tipoReporte
            // 
            this.groupBox_tipoReporte.Controls.Add(this.label1);
            this.groupBox_tipoReporte.Controls.Add(this.radioButton_Fechas);
            this.groupBox_tipoReporte.Controls.Add(this.button_Siguiente);
            this.groupBox_tipoReporte.Controls.Add(this.radioButton_ClienteParticular);
            this.groupBox_tipoReporte.Controls.Add(this.radioButton_Todos);
            this.groupBox_tipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoReporte.Location = new System.Drawing.Point(0, 2);
            this.groupBox_tipoReporte.Name = "groupBox_tipoReporte";
            this.groupBox_tipoReporte.Size = new System.Drawing.Size(590, 192);
            this.groupBox_tipoReporte.TabIndex = 11;
            this.groupBox_tipoReporte.TabStop = false;
            this.groupBox_tipoReporte.Text = "Eleccion Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Reporte";
            // 
            // radioButton_Fechas
            // 
            this.radioButton_Fechas.AutoSize = true;
            this.radioButton_Fechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Fechas.Location = new System.Drawing.Point(186, 96);
            this.radioButton_Fechas.Name = "radioButton_Fechas";
            this.radioButton_Fechas.Size = new System.Drawing.Size(228, 29);
            this.radioButton_Fechas.TabIndex = 2;
            this.radioButton_Fechas.TabStop = true;
            this.radioButton_Fechas.Text = "Entre rango de fechas";
            this.radioButton_Fechas.UseVisualStyleBackColor = true;
            // 
            // button_Siguiente
            // 
            this.button_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Siguiente.Location = new System.Drawing.Point(186, 136);
            this.button_Siguiente.Name = "button_Siguiente";
            this.button_Siguiente.Size = new System.Drawing.Size(148, 41);
            this.button_Siguiente.TabIndex = 1;
            this.button_Siguiente.Text = "Siguiente";
            this.button_Siguiente.UseVisualStyleBackColor = true;
            this.button_Siguiente.Click += new System.EventHandler(this.button_Siguiente_Click);
            // 
            // radioButton_ClienteParticular
            // 
            this.radioButton_ClienteParticular.AutoSize = true;
            this.radioButton_ClienteParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ClienteParticular.Location = new System.Drawing.Point(186, 32);
            this.radioButton_ClienteParticular.Name = "radioButton_ClienteParticular";
            this.radioButton_ClienteParticular.Size = new System.Drawing.Size(371, 29);
            this.radioButton_ClienteParticular.TabIndex = 1;
            this.radioButton_ClienteParticular.TabStop = true;
            this.radioButton_ClienteParticular.Text = "Buscar facturas de un cliente particular";
            this.radioButton_ClienteParticular.UseVisualStyleBackColor = true;
            // 
            // radioButton_Todos
            // 
            this.radioButton_Todos.AutoSize = true;
            this.radioButton_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Todos.Location = new System.Drawing.Point(186, 61);
            this.radioButton_Todos.Name = "radioButton_Todos";
            this.radioButton_Todos.Size = new System.Drawing.Size(197, 29);
            this.radioButton_Todos.TabIndex = 0;
            this.radioButton_Todos.TabStop = true;
            this.radioButton_Todos.Text = "Todas las facturas";
            this.radioButton_Todos.UseVisualStyleBackColor = true;
            // 
            // label_Hasta
            // 
            this.label_Hasta.AutoSize = true;
            this.label_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hasta.Location = new System.Drawing.Point(826, 101);
            this.label_Hasta.Name = "label_Hasta";
            this.label_Hasta.Size = new System.Drawing.Size(63, 25);
            this.label_Hasta.TabIndex = 18;
            this.label_Hasta.Text = "Hasta";
            this.label_Hasta.Visible = false;
            // 
            // maskedTextBox_Desde
            // 
            this.maskedTextBox_Desde.Culture = new System.Globalization.CultureInfo("es-AR");
            this.maskedTextBox_Desde.Enabled = false;
            this.maskedTextBox_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Desde.Location = new System.Drawing.Point(701, 102);
            this.maskedTextBox_Desde.Mask = "00/00/0000";
            this.maskedTextBox_Desde.Name = "maskedTextBox_Desde";
            this.maskedTextBox_Desde.Size = new System.Drawing.Size(104, 30);
            this.maskedTextBox_Desde.TabIndex = 19;
            this.maskedTextBox_Desde.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_Desde.Visible = false;
            // 
            // maskedTextBox_Hasta
            // 
            this.maskedTextBox_Hasta.Culture = new System.Globalization.CultureInfo("es-AR");
            this.maskedTextBox_Hasta.Enabled = false;
            this.maskedTextBox_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Hasta.Location = new System.Drawing.Point(895, 101);
            this.maskedTextBox_Hasta.Mask = "00/00/0000";
            this.maskedTextBox_Hasta.Name = "maskedTextBox_Hasta";
            this.maskedTextBox_Hasta.Size = new System.Drawing.Size(102, 30);
            this.maskedTextBox_Hasta.TabIndex = 20;
            this.maskedTextBox_Hasta.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_Hasta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Formato: DD/MM/AAAA";
            this.label2.Visible = false;
            // 
            // Listado_Factura_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 648);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox_Hasta);
            this.Controls.Add(this.maskedTextBox_Desde);
            this.Controls.Add(this.label_Hasta);
            this.Controls.Add(this.button_SeleccionarFechas);
            this.Controls.Add(this.label_Desde);
            this.Controls.Add(this.button_SeleccionCliente);
            this.Controls.Add(this.label_ClientesSelecccion);
            this.Controls.Add(this.comboBox_Clientes);
            this.Controls.Add(this.groupBox_tipoReporte);
            this.Controls.Add(this.reportViewer_Factura_Cliente);
            this.Name = "Listado_Factura_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de facturas por cliente";
            this.Load += new System.EventHandler(this.Listado_Factura_Cliente_Load);
            this.groupBox_tipoReporte.ResumeLayout(false);
            this.groupBox_tipoReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Factura_Cliente;
        private System.Windows.Forms.Button button_SeleccionarFechas;
        private System.Windows.Forms.Label label_Desde;
        private System.Windows.Forms.Button button_SeleccionCliente;
        private System.Windows.Forms.Label label_ClientesSelecccion;
        private System.Windows.Forms.ComboBox comboBox_Clientes;
        private System.Windows.Forms.GroupBox groupBox_tipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Fechas;
        private System.Windows.Forms.Button button_Siguiente;
        private System.Windows.Forms.RadioButton radioButton_ClienteParticular;
        private System.Windows.Forms.RadioButton radioButton_Todos;
        private System.Windows.Forms.Label label_Hasta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Desde;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Hasta;
        private System.Windows.Forms.Label label2;
    }
}