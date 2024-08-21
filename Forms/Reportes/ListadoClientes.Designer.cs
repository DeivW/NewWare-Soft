
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoClientes
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
            this.reportViewer_Clientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button_Siguiente = new System.Windows.Forms.Button();
            this.groupBox_tipoReporte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_ClienteLetra = new System.Windows.Forms.RadioButton();
            this.radioButton_ClienteParticular = new System.Windows.Forms.RadioButton();
            this.radioButton_Todos = new System.Windows.Forms.RadioButton();
            this.comboBox_Clientes = new System.Windows.Forms.ComboBox();
            this.label_ClientesSelecccion = new System.Windows.Forms.Label();
            this.button_SeleccionCliente = new System.Windows.Forms.Button();
            this.label_Patron = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.button_SeleccionarPatron = new System.Windows.Forms.Button();
            this.groupBox_tipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer_Clientes
            // 
            this.reportViewer_Clientes.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Report_Clientes.rdlc";
            this.reportViewer_Clientes.Location = new System.Drawing.Point(0, 185);
            this.reportViewer_Clientes.Name = "reportViewer_Clientes";
            this.reportViewer_Clientes.ServerReport.BearerToken = null;
            this.reportViewer_Clientes.Size = new System.Drawing.Size(1169, 547);
            this.reportViewer_Clientes.TabIndex = 0;
            this.reportViewer_Clientes.Visible = false;
            // 
            // button_Siguiente
            // 
            this.button_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Siguiente.Location = new System.Drawing.Point(186, 136);
            this.button_Siguiente.Name = "button_Siguiente";
            this.button_Siguiente.Size = new System.Drawing.Size(148, 35);
            this.button_Siguiente.TabIndex = 1;
            this.button_Siguiente.Text = "Siguiente";
            this.button_Siguiente.UseVisualStyleBackColor = true;
            this.button_Siguiente.Click += new System.EventHandler(this.button_Siguiente_Click);
            // 
            // groupBox_tipoReporte
            // 
            this.groupBox_tipoReporte.Controls.Add(this.label1);
            this.groupBox_tipoReporte.Controls.Add(this.radioButton_ClienteLetra);
            this.groupBox_tipoReporte.Controls.Add(this.button_Siguiente);
            this.groupBox_tipoReporte.Controls.Add(this.radioButton_ClienteParticular);
            this.groupBox_tipoReporte.Controls.Add(this.radioButton_Todos);
            this.groupBox_tipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoReporte.Location = new System.Drawing.Point(12, 2);
            this.groupBox_tipoReporte.Name = "groupBox_tipoReporte";
            this.groupBox_tipoReporte.Size = new System.Drawing.Size(514, 177);
            this.groupBox_tipoReporte.TabIndex = 4;
            this.groupBox_tipoReporte.TabStop = false;
            this.groupBox_tipoReporte.Text = "Eleccion Reporte";
            this.groupBox_tipoReporte.Enter += new System.EventHandler(this.groupBox_tipoReporte_Enter);
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
            // radioButton_ClienteLetra
            // 
            this.radioButton_ClienteLetra.AutoSize = true;
            this.radioButton_ClienteLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ClienteLetra.Location = new System.Drawing.Point(186, 96);
            this.radioButton_ClienteLetra.Name = "radioButton_ClienteLetra";
            this.radioButton_ClienteLetra.Size = new System.Drawing.Size(290, 29);
            this.radioButton_ClienteLetra.TabIndex = 2;
            this.radioButton_ClienteLetra.TabStop = true;
            this.radioButton_ClienteLetra.Text = "Buscar por patron de apellido";
            this.radioButton_ClienteLetra.UseVisualStyleBackColor = true;
            // 
            // radioButton_ClienteParticular
            // 
            this.radioButton_ClienteParticular.AutoSize = true;
            this.radioButton_ClienteParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ClienteParticular.Location = new System.Drawing.Point(186, 26);
            this.radioButton_ClienteParticular.Name = "radioButton_ClienteParticular";
            this.radioButton_ClienteParticular.Size = new System.Drawing.Size(243, 29);
            this.radioButton_ClienteParticular.TabIndex = 1;
            this.radioButton_ClienteParticular.TabStop = true;
            this.radioButton_ClienteParticular.Text = "Buscar cliente particular";
            this.radioButton_ClienteParticular.UseVisualStyleBackColor = true;
            // 
            // radioButton_Todos
            // 
            this.radioButton_Todos.AutoSize = true;
            this.radioButton_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Todos.Location = new System.Drawing.Point(186, 61);
            this.radioButton_Todos.Name = "radioButton_Todos";
            this.radioButton_Todos.Size = new System.Drawing.Size(194, 29);
            this.radioButton_Todos.TabIndex = 0;
            this.radioButton_Todos.TabStop = true;
            this.radioButton_Todos.Text = "Todos los clientes";
            this.radioButton_Todos.UseVisualStyleBackColor = true;
            // 
            // comboBox_Clientes
            // 
            this.comboBox_Clientes.Enabled = false;
            this.comboBox_Clientes.FormattingEnabled = true;
            this.comboBox_Clientes.Location = new System.Drawing.Point(621, 31);
            this.comboBox_Clientes.Name = "comboBox_Clientes";
            this.comboBox_Clientes.Size = new System.Drawing.Size(315, 28);
            this.comboBox_Clientes.TabIndex = 5;
            this.comboBox_Clientes.Visible = false;
            this.comboBox_Clientes.SelectedIndexChanged += new System.EventHandler(this.comboBox_Clientes_SelectedIndexChanged);
            // 
            // label_ClientesSelecccion
            // 
            this.label_ClientesSelecccion.AutoSize = true;
            this.label_ClientesSelecccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientesSelecccion.Location = new System.Drawing.Point(532, 32);
            this.label_ClientesSelecccion.Name = "label_ClientesSelecccion";
            this.label_ClientesSelecccion.Size = new System.Drawing.Size(83, 25);
            this.label_ClientesSelecccion.TabIndex = 6;
            this.label_ClientesSelecccion.Text = "Clientes";
            this.label_ClientesSelecccion.Visible = false;
            this.label_ClientesSelecccion.Click += new System.EventHandler(this.label_ClientesSelecccion_Click);
            // 
            // button_SeleccionCliente
            // 
            this.button_SeleccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SeleccionCliente.Location = new System.Drawing.Point(961, 21);
            this.button_SeleccionCliente.Name = "button_SeleccionCliente";
            this.button_SeleccionCliente.Size = new System.Drawing.Size(144, 42);
            this.button_SeleccionCliente.TabIndex = 7;
            this.button_SeleccionCliente.Text = "Seleccionar";
            this.button_SeleccionCliente.UseVisualStyleBackColor = true;
            this.button_SeleccionCliente.Visible = false;
            this.button_SeleccionCliente.Click += new System.EventHandler(this.button_SeleccionCliente_Click);
            // 
            // label_Patron
            // 
            this.label_Patron.AutoSize = true;
            this.label_Patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Patron.Location = new System.Drawing.Point(533, 104);
            this.label_Patron.Name = "label_Patron";
            this.label_Patron.Size = new System.Drawing.Size(212, 25);
            this.label_Patron.TabIndex = 8;
            this.label_Patron.Text = "Letra o patron a buscar";
            this.label_Patron.Visible = false;
            this.label_Patron.Click += new System.EventHandler(this.label_Patron_Click);
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Enabled = false;
            this.textBox_Apellido.Location = new System.Drawing.Point(819, 100);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(117, 26);
            this.textBox_Apellido.TabIndex = 9;
            this.textBox_Apellido.Visible = false;
            this.textBox_Apellido.TextChanged += new System.EventHandler(this.textBox_Apellido_TextChanged);
            // 
            // button_SeleccionarPatron
            // 
            this.button_SeleccionarPatron.Enabled = false;
            this.button_SeleccionarPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SeleccionarPatron.Location = new System.Drawing.Point(961, 95);
            this.button_SeleccionarPatron.Name = "button_SeleccionarPatron";
            this.button_SeleccionarPatron.Size = new System.Drawing.Size(144, 42);
            this.button_SeleccionarPatron.TabIndex = 10;
            this.button_SeleccionarPatron.Text = "Seleccionar";
            this.button_SeleccionarPatron.UseVisualStyleBackColor = true;
            this.button_SeleccionarPatron.Visible = false;
            this.button_SeleccionarPatron.Click += new System.EventHandler(this.button_SeleccionarPatron_Click);
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 732);
            this.Controls.Add(this.button_SeleccionarPatron);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.label_Patron);
            this.Controls.Add(this.button_SeleccionCliente);
            this.Controls.Add(this.label_ClientesSelecccion);
            this.Controls.Add(this.comboBox_Clientes);
            this.Controls.Add(this.groupBox_tipoReporte);
            this.Controls.Add(this.reportViewer_Clientes);
            this.Name = "ListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.ListadoClientes_Load);
            this.groupBox_tipoReporte.ResumeLayout(false);
            this.groupBox_tipoReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Clientes;
        private System.Windows.Forms.Button button_Siguiente;
        private System.Windows.Forms.GroupBox groupBox_tipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_ClienteLetra;
        private System.Windows.Forms.RadioButton radioButton_ClienteParticular;
        private System.Windows.Forms.RadioButton radioButton_Todos;
        private System.Windows.Forms.ComboBox comboBox_Clientes;
        private System.Windows.Forms.Label label_ClientesSelecccion;
        private System.Windows.Forms.Button button_SeleccionCliente;
        private System.Windows.Forms.Label label_Patron;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Button button_SeleccionarPatron;
    }
}