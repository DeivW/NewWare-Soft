
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoProyectosActivos
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
            this.reportProyActivos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.btn_SelecID = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_SelecFecha = new System.Windows.Forms.Button();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.rb_ProyectosActivos = new System.Windows.Forms.RadioButton();
            this.rb_IDCliente = new System.Windows.Forms.RadioButton();
            this.rb_FechaInicio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportProyActivos
            // 
            this.reportProyActivos.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ReporteProyectoActivo.rdlc";
            this.reportProyActivos.Location = new System.Drawing.Point(0, 156);
            this.reportProyActivos.Name = "reportProyActivos";
            this.reportProyActivos.ServerReport.BearerToken = null;
            this.reportProyActivos.Size = new System.Drawing.Size(836, 294);
            this.reportProyActivos.TabIndex = 0;
            this.reportProyActivos.Visible = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(618, 32);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(79, 20);
            this.txtFecha.TabIndex = 50;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            this.txtFecha.Visible = false;
            // 
            // btn_SelecID
            // 
            this.btn_SelecID.Enabled = false;
            this.btn_SelecID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelecID.Location = new System.Drawing.Point(713, 73);
            this.btn_SelecID.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SelecID.Name = "btn_SelecID";
            this.btn_SelecID.Size = new System.Drawing.Size(96, 27);
            this.btn_SelecID.TabIndex = 49;
            this.btn_SelecID.Text = "Seleccionar";
            this.btn_SelecID.UseVisualStyleBackColor = true;
            this.btn_SelecID.Visible = false;
            this.btn_SelecID.Click += new System.EventHandler(this.btn_SelecID_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(618, 80);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(79, 20);
            this.txtID.TabIndex = 48;
            this.txtID.Visible = false;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(461, 80);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(127, 17);
            this.lbl_ID.TabIndex = 47;
            this.lbl_ID.Text = "ID Cliente a buscar";
            this.lbl_ID.Visible = false;
            // 
            // btn_SelecFecha
            // 
            this.btn_SelecFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelecFecha.Location = new System.Drawing.Point(713, 25);
            this.btn_SelecFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SelecFecha.Name = "btn_SelecFecha";
            this.btn_SelecFecha.Size = new System.Drawing.Size(96, 27);
            this.btn_SelecFecha.TabIndex = 46;
            this.btn_SelecFecha.Text = "Seleccionar";
            this.btn_SelecFecha.UseVisualStyleBackColor = true;
            this.btn_SelecFecha.Visible = false;
            this.btn_SelecFecha.Click += new System.EventHandler(this.btn_SelecFecha_Click);
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaInicio.Location = new System.Drawing.Point(458, 35);
            this.lbl_FechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(130, 17);
            this.lbl_FechaInicio.TabIndex = 45;
            this.lbl_FechaInicio.Text = "Fecha inicio desde:";
            this.lbl_FechaInicio.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Next);
            this.groupBox1.Controls.Add(this.rb_ProyectosActivos);
            this.groupBox1.Controls.Add(this.rb_IDCliente);
            this.groupBox1.Controls.Add(this.rb_FechaInicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 138);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eleccion Reporte";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(263, 100);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(86, 32);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Siguiente";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // rb_ProyectosActivos
            // 
            this.rb_ProyectosActivos.AutoSize = true;
            this.rb_ProyectosActivos.Location = new System.Drawing.Point(136, 73);
            this.rb_ProyectosActivos.Name = "rb_ProyectosActivos";
            this.rb_ProyectosActivos.Size = new System.Drawing.Size(202, 21);
            this.rb_ProyectosActivos.TabIndex = 3;
            this.rb_ProyectosActivos.TabStop = true;
            this.rb_ProyectosActivos.Text = "Todos los proyectos activos";
            this.rb_ProyectosActivos.UseVisualStyleBackColor = true;
            // 
            // rb_IDCliente
            // 
            this.rb_IDCliente.AutoSize = true;
            this.rb_IDCliente.Location = new System.Drawing.Point(136, 46);
            this.rb_IDCliente.Name = "rb_IDCliente";
            this.rb_IDCliente.Size = new System.Drawing.Size(157, 21);
            this.rb_IDCliente.TabIndex = 2;
            this.rb_IDCliente.TabStop = true;
            this.rb_IDCliente.Text = "Buscar por ID cliente";
            this.rb_IDCliente.UseVisualStyleBackColor = true;
            // 
            // rb_FechaInicio
            // 
            this.rb_FechaInicio.AutoSize = true;
            this.rb_FechaInicio.Location = new System.Drawing.Point(136, 19);
            this.rb_FechaInicio.Name = "rb_FechaInicio";
            this.rb_FechaInicio.Size = new System.Drawing.Size(213, 21);
            this.rb_FechaInicio.TabIndex = 1;
            this.rb_FechaInicio.TabStop = true;
            this.rb_FechaInicio.Text = "Buscar por fecha inicio desde";
            this.rb_FechaInicio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de reporte";
            // 
            // ListadoProyectosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btn_SelecID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_SelecFecha);
            this.Controls.Add(this.lbl_FechaInicio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportProyActivos);
            this.Name = "ListadoProyectosActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de proyectos activos";
            this.Load += new System.EventHandler(this.ListadoProyectosActivos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportProyActivos;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Button btn_SelecID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_SelecFecha;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.RadioButton rb_ProyectosActivos;
        private System.Windows.Forms.RadioButton rb_IDCliente;
        private System.Windows.Forms.RadioButton rb_FechaInicio;
        private System.Windows.Forms.Label label1;
    }
}