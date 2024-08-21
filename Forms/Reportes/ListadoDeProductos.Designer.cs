
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoDeProductos
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
            this.listadoProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioMayor = new System.Windows.Forms.MaskedTextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.grpOpcion = new System.Windows.Forms.GroupBox();
            this.rdFecha = new System.Windows.Forms.RadioButton();
            this.rdDenominacion = new System.Windows.Forms.RadioButton();
            this.rdPrecio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.grpOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoProductos
            // 
            this.listadoProductos.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ListadoDeProductos.rdlc";
            this.listadoProductos.Location = new System.Drawing.Point(0, 168);
            this.listadoProductos.Name = "listadoProductos";
            this.listadoProductos.ServerReport.BearerToken = null;
            this.listadoProductos.Size = new System.Drawing.Size(800, 432);
            this.listadoProductos.TabIndex = 0;
            this.listadoProductos.Load += new System.EventHandler(this.listadoProductos_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio mayor a: ";
            // 
            // txtPrecioMayor
            // 
            this.txtPrecioMayor.Enabled = false;
            this.txtPrecioMayor.Location = new System.Drawing.Point(139, 11);
            this.txtPrecioMayor.Mask = "999999999";
            this.txtPrecioMayor.Name = "txtPrecioMayor";
            this.txtPrecioMayor.Size = new System.Drawing.Size(66, 20);
            this.txtPrecioMayor.TabIndex = 3;
            this.txtPrecioMayor.ValidatingType = typeof(int);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(628, 131);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 31);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar Lista";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Denominación:";
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Enabled = false;
            this.txtDenominacion.Location = new System.Drawing.Point(139, 49);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(159, 20);
            this.txtDenominacion.TabIndex = 6;
            // 
            // grpOpcion
            // 
            this.grpOpcion.Controls.Add(this.rdFecha);
            this.grpOpcion.Controls.Add(this.rdDenominacion);
            this.grpOpcion.Controls.Add(this.rdPrecio);
            this.grpOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpcion.Location = new System.Drawing.Point(588, 9);
            this.grpOpcion.Name = "grpOpcion";
            this.grpOpcion.Size = new System.Drawing.Size(200, 116);
            this.grpOpcion.TabIndex = 7;
            this.grpOpcion.TabStop = false;
            this.grpOpcion.Text = "Buscar por:";
            // 
            // rdFecha
            // 
            this.rdFecha.AutoSize = true;
            this.rdFecha.Location = new System.Drawing.Point(7, 80);
            this.rdFecha.Name = "rdFecha";
            this.rdFecha.Size = new System.Drawing.Size(159, 24);
            this.rdFecha.TabIndex = 2;
            this.rdFecha.TabStop = true;
            this.rdFecha.Text = "Fecha Finalización";
            this.rdFecha.UseVisualStyleBackColor = true;
            this.rdFecha.CheckedChanged += new System.EventHandler(this.rdFecha_CheckedChanged);
            // 
            // rdDenominacion
            // 
            this.rdDenominacion.AutoSize = true;
            this.rdDenominacion.Location = new System.Drawing.Point(7, 50);
            this.rdDenominacion.Name = "rdDenominacion";
            this.rdDenominacion.Size = new System.Drawing.Size(129, 24);
            this.rdDenominacion.TabIndex = 1;
            this.rdDenominacion.TabStop = true;
            this.rdDenominacion.Text = "Denominacion";
            this.rdDenominacion.UseVisualStyleBackColor = true;
            this.rdDenominacion.CheckedChanged += new System.EventHandler(this.rdDenominacion_CheckedChanged);
            // 
            // rdPrecio
            // 
            this.rdPrecio.AutoSize = true;
            this.rdPrecio.Location = new System.Drawing.Point(7, 20);
            this.rdPrecio.Name = "rdPrecio";
            this.rdPrecio.Size = new System.Drawing.Size(71, 24);
            this.rdPrecio.TabIndex = 0;
            this.rdPrecio.TabStop = true;
            this.rdPrecio.Text = "Precio";
            this.rdPrecio.UseVisualStyleBackColor = true;
            this.rdPrecio.CheckedChanged += new System.EventHandler(this.rdPrecio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha mayor que:";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(154, 91);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(68, 20);
            this.txtFecha.TabIndex = 9;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // ListadoDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpOpcion);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtPrecioMayor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoProductos);
            this.Name = "ListadoDeProductos";
            this.Text = "ListadoDeProductos";
            this.Load += new System.EventHandler(this.ListadoDeProductos_Load);
            this.grpOpcion.ResumeLayout(false);
            this.grpOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer listadoProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPrecioMayor;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.GroupBox grpOpcion;
        private System.Windows.Forms.RadioButton rdFecha;
        private System.Windows.Forms.RadioButton rdDenominacion;
        private System.Windows.Forms.RadioButton rdPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtFecha;
    }
}