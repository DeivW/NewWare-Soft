
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoProdXFactura
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
            this.rptProducto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListarPorFactura = new System.Windows.Forms.Button();
            this.lblFactura = new System.Windows.Forms.Label();
            this.cmbFacturas = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.lblUnProducto = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.groupBox_tipoReporte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbUnaFactura = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.rbUNProducto = new System.Windows.Forms.RadioButton();
            this.rbTodasFacturas = new System.Windows.Forms.RadioButton();
            this.groupBox_tipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptProducto
            // 
            this.rptProducto.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ReporteProdXFact.rdlc";
            this.rptProducto.Location = new System.Drawing.Point(-3, 262);
            this.rptProducto.Name = "rptProducto";
            this.rptProducto.ServerReport.BearerToken = null;
            this.rptProducto.Size = new System.Drawing.Size(803, 337);
            this.rptProducto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(223, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Reporte de Productos por Factura";
            // 
            // btnListarPorFactura
            // 
            this.btnListarPorFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPorFactura.Location = new System.Drawing.Point(664, 198);
            this.btnListarPorFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarPorFactura.Name = "btnListarPorFactura";
            this.btnListarPorFactura.Size = new System.Drawing.Size(96, 27);
            this.btnListarPorFactura.TabIndex = 25;
            this.btnListarPorFactura.Text = "Seleccionar";
            this.btnListarPorFactura.UseVisualStyleBackColor = true;
            this.btnListarPorFactura.Visible = false;
            this.btnListarPorFactura.Click += new System.EventHandler(this.btnListarPorFactura_Click);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(466, 203);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(67, 17);
            this.lblFactura.TabIndex = 24;
            this.lblFactura.Text = "Facturas:";
            this.lblFactura.Visible = false;
            // 
            // cmbFacturas
            // 
            this.cmbFacturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacturas.Enabled = false;
            this.cmbFacturas.FormattingEnabled = true;
            this.cmbFacturas.Location = new System.Drawing.Point(548, 202);
            this.cmbFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFacturas.Name = "cmbFacturas";
            this.cmbFacturas.Size = new System.Drawing.Size(85, 21);
            this.cmbFacturas.TabIndex = 23;
            this.cmbFacturas.Visible = false;
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(664, 143);
            this.btnSeleccionarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(96, 27);
            this.btnSeleccionarProducto.TabIndex = 22;
            this.btnSeleccionarProducto.Text = "Seleccionar";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.btnSeleccionarProducto.Visible = false;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // lblUnProducto
            // 
            this.lblUnProducto.AutoSize = true;
            this.lblUnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnProducto.Location = new System.Drawing.Point(457, 147);
            this.lblUnProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnProducto.Name = "lblUnProducto";
            this.lblUnProducto.Size = new System.Drawing.Size(76, 17);
            this.lblUnProducto.TabIndex = 21;
            this.lblUnProducto.Text = "Productos:";
            this.lblUnProducto.Visible = false;
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.Enabled = false;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(551, 147);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(85, 21);
            this.cmbProductos.TabIndex = 20;
            this.cmbProductos.Visible = false;
            // 
            // groupBox_tipoReporte
            // 
            this.groupBox_tipoReporte.Controls.Add(this.label1);
            this.groupBox_tipoReporte.Controls.Add(this.rbUnaFactura);
            this.groupBox_tipoReporte.Controls.Add(this.btnSiguiente);
            this.groupBox_tipoReporte.Controls.Add(this.rbUNProducto);
            this.groupBox_tipoReporte.Controls.Add(this.rbTodasFacturas);
            this.groupBox_tipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tipoReporte.Location = new System.Drawing.Point(44, 126);
            this.groupBox_tipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Name = "groupBox_tipoReporte";
            this.groupBox_tipoReporte.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_tipoReporte.Size = new System.Drawing.Size(409, 115);
            this.groupBox_tipoReporte.TabIndex = 19;
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
            // rbUnaFactura
            // 
            this.rbUnaFactura.AutoSize = true;
            this.rbUnaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnaFactura.Location = new System.Drawing.Point(124, 62);
            this.rbUnaFactura.Margin = new System.Windows.Forms.Padding(2);
            this.rbUnaFactura.Name = "rbUnaFactura";
            this.rbUnaFactura.Size = new System.Drawing.Size(138, 21);
            this.rbUnaFactura.TabIndex = 2;
            this.rbUnaFactura.TabStop = true;
            this.rbUnaFactura.Text = "Listar por Factura";
            this.rbUnaFactura.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(291, 88);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(99, 23);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // rbUNProducto
            // 
            this.rbUNProducto.AutoSize = true;
            this.rbUNProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUNProducto.Location = new System.Drawing.Point(124, 17);
            this.rbUNProducto.Margin = new System.Windows.Forms.Padding(2);
            this.rbUNProducto.Name = "rbUNProducto";
            this.rbUNProducto.Size = new System.Drawing.Size(280, 21);
            this.rbUNProducto.TabIndex = 1;
            this.rbUNProducto.TabStop = true;
            this.rbUNProducto.Text = "Listar facturas que incluyen un producto";
            this.rbUNProducto.UseVisualStyleBackColor = true;
            // 
            // rbTodasFacturas
            // 
            this.rbTodasFacturas.AutoSize = true;
            this.rbTodasFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodasFacturas.Location = new System.Drawing.Point(124, 40);
            this.rbTodasFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.rbTodasFacturas.Name = "rbTodasFacturas";
            this.rbTodasFacturas.Size = new System.Drawing.Size(147, 21);
            this.rbTodasFacturas.TabIndex = 0;
            this.rbTodasFacturas.TabStop = true;
            this.rbTodasFacturas.Text = "Todas las Facturas";
            this.rbTodasFacturas.UseVisualStyleBackColor = true;
            // 
            // ListadoProdXFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListarPorFactura);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.cmbFacturas);
            this.Controls.Add(this.btnSeleccionarProducto);
            this.Controls.Add(this.lblUnProducto);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.groupBox_tipoReporte);
            this.Controls.Add(this.rptProducto);
            this.Name = "ListadoProdXFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoProdXFactura";
            this.Load += new System.EventHandler(this.ListadoProdXFactura_Load);
            this.groupBox_tipoReporte.ResumeLayout(false);
            this.groupBox_tipoReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListarPorFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.ComboBox cmbFacturas;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Label lblUnProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.GroupBox groupBox_tipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbUnaFactura;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.RadioButton rbUNProducto;
        private System.Windows.Forms.RadioButton rbTodasFacturas;
    }
}