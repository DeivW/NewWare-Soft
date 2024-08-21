
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoDeTodosLosProyectos
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
            this.reportProyectos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_SeleccPatron = new System.Windows.Forms.Button();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.lbl_Patron = new System.Windows.Forms.Label();
            this.btn_SeleccFecha = new System.Windows.Forms.Button();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.groupBox_Proyec = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_PatrónDescrip = new System.Windows.Forms.RadioButton();
            this.button_Siguiente = new System.Windows.Forms.Button();
            this.rb_FechaInicioDesde = new System.Windows.Forms.RadioButton();
            this.rb_Todos = new System.Windows.Forms.RadioButton();
            this.txtInicioABuscar = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_Proyec.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportProyectos
            // 
            this.reportProyectos.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_Todos_Proyectos.rdlc";
            this.reportProyectos.Location = new System.Drawing.Point(0, 136);
            this.reportProyectos.Name = "reportProyectos";
            this.reportProyectos.ServerReport.BearerToken = null;
            this.reportProyectos.Size = new System.Drawing.Size(800, 387);
            this.reportProyectos.TabIndex = 0;
            this.reportProyectos.Visible = false;
            // 
            // btn_SeleccPatron
            // 
            this.btn_SeleccPatron.Enabled = false;
            this.btn_SeleccPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeleccPatron.Location = new System.Drawing.Point(683, 73);
            this.btn_SeleccPatron.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SeleccPatron.Name = "btn_SeleccPatron";
            this.btn_SeleccPatron.Size = new System.Drawing.Size(96, 27);
            this.btn_SeleccPatron.TabIndex = 17;
            this.btn_SeleccPatron.Text = "Seleccionar";
            this.btn_SeleccPatron.UseVisualStyleBackColor = true;
            this.btn_SeleccPatron.Visible = false;
            this.btn_SeleccPatron.Click += new System.EventHandler(this.btn_SeleccPatron_Click);
            // 
            // txtPatron
            // 
            this.txtPatron.Location = new System.Drawing.Point(588, 80);
            this.txtPatron.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.Size = new System.Drawing.Size(79, 20);
            this.txtPatron.TabIndex = 16;
            this.txtPatron.Visible = false;
            // 
            // lbl_Patron
            // 
            this.lbl_Patron.AutoSize = true;
            this.lbl_Patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patron.Location = new System.Drawing.Point(397, 83);
            this.lbl_Patron.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Patron.Name = "lbl_Patron";
            this.lbl_Patron.Size = new System.Drawing.Size(161, 17);
            this.lbl_Patron.TabIndex = 15;
            this.lbl_Patron.Text = "Letra o patron a buscar:";
            this.lbl_Patron.Visible = false;
            // 
            // btn_SeleccFecha
            // 
            this.btn_SeleccFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeleccFecha.Location = new System.Drawing.Point(683, 25);
            this.btn_SeleccFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SeleccFecha.Name = "btn_SeleccFecha";
            this.btn_SeleccFecha.Size = new System.Drawing.Size(96, 27);
            this.btn_SeleccFecha.TabIndex = 14;
            this.btn_SeleccFecha.Text = "Seleccionar";
            this.btn_SeleccFecha.UseVisualStyleBackColor = true;
            this.btn_SeleccFecha.Visible = false;
            this.btn_SeleccFecha.Click += new System.EventHandler(this.btn_SeleccFecha_Click);
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaInicio.Location = new System.Drawing.Point(428, 35);
            this.lbl_FechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(130, 17);
            this.lbl_FechaInicio.TabIndex = 13;
            this.lbl_FechaInicio.Text = "Fecha inicio desde:";
            this.lbl_FechaInicio.Visible = false;
            // 
            // groupBox_Proyec
            // 
            this.groupBox_Proyec.Controls.Add(this.label1);
            this.groupBox_Proyec.Controls.Add(this.rb_PatrónDescrip);
            this.groupBox_Proyec.Controls.Add(this.button_Siguiente);
            this.groupBox_Proyec.Controls.Add(this.rb_FechaInicioDesde);
            this.groupBox_Proyec.Controls.Add(this.rb_Todos);
            this.groupBox_Proyec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Proyec.Location = new System.Drawing.Point(11, 11);
            this.groupBox_Proyec.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Proyec.Name = "groupBox_Proyec";
            this.groupBox_Proyec.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Proyec.Size = new System.Drawing.Size(364, 115);
            this.groupBox_Proyec.TabIndex = 11;
            this.groupBox_Proyec.TabStop = false;
            this.groupBox_Proyec.Text = "Eleccion Reporte";
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
            // rb_PatrónDescrip
            // 
            this.rb_PatrónDescrip.AutoSize = true;
            this.rb_PatrónDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_PatrónDescrip.Location = new System.Drawing.Point(124, 62);
            this.rb_PatrónDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.rb_PatrónDescrip.Name = "rb_PatrónDescrip";
            this.rb_PatrónDescrip.Size = new System.Drawing.Size(236, 21);
            this.rb_PatrónDescrip.TabIndex = 2;
            this.rb_PatrónDescrip.TabStop = true;
            this.rb_PatrónDescrip.Text = "Buscar por patrón de descripción";
            this.rb_PatrónDescrip.UseVisualStyleBackColor = true;
            // 
            // button_Siguiente
            // 
            this.button_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Siguiente.Location = new System.Drawing.Point(124, 88);
            this.button_Siguiente.Margin = new System.Windows.Forms.Padding(2);
            this.button_Siguiente.Name = "button_Siguiente";
            this.button_Siguiente.Size = new System.Drawing.Size(99, 23);
            this.button_Siguiente.TabIndex = 1;
            this.button_Siguiente.Text = "Siguiente";
            this.button_Siguiente.UseVisualStyleBackColor = true;
            this.button_Siguiente.Click += new System.EventHandler(this.button_Siguiente_Click);
            // 
            // rb_FechaInicioDesde
            // 
            this.rb_FechaInicioDesde.AutoSize = true;
            this.rb_FechaInicioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_FechaInicioDesde.Location = new System.Drawing.Point(124, 17);
            this.rb_FechaInicioDesde.Margin = new System.Windows.Forms.Padding(2);
            this.rb_FechaInicioDesde.Name = "rb_FechaInicioDesde";
            this.rb_FechaInicioDesde.Size = new System.Drawing.Size(213, 21);
            this.rb_FechaInicioDesde.TabIndex = 1;
            this.rb_FechaInicioDesde.TabStop = true;
            this.rb_FechaInicioDesde.Text = "Buscar por fecha inicio desde";
            this.rb_FechaInicioDesde.UseVisualStyleBackColor = true;
            // 
            // rb_Todos
            // 
            this.rb_Todos.AutoSize = true;
            this.rb_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Todos.Location = new System.Drawing.Point(124, 40);
            this.rb_Todos.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Todos.Name = "rb_Todos";
            this.rb_Todos.Size = new System.Drawing.Size(154, 21);
            this.rb_Todos.TabIndex = 0;
            this.rb_Todos.TabStop = true;
            this.rb_Todos.Text = "Todos los proyectos";
            this.rb_Todos.UseVisualStyleBackColor = true;
            // 
            // txtInicioABuscar
            // 
            this.txtInicioABuscar.Location = new System.Drawing.Point(588, 32);
            this.txtInicioABuscar.Mask = "00/00/0000";
            this.txtInicioABuscar.Name = "txtInicioABuscar";
            this.txtInicioABuscar.Size = new System.Drawing.Size(66, 20);
            this.txtInicioABuscar.TabIndex = 30;
            this.txtInicioABuscar.ValidatingType = typeof(System.DateTime);
            this.txtInicioABuscar.Visible = false;
            // 
            // ListadoDeTodosLosProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 521);
            this.Controls.Add(this.txtInicioABuscar);
            this.Controls.Add(this.btn_SeleccPatron);
            this.Controls.Add(this.txtPatron);
            this.Controls.Add(this.lbl_Patron);
            this.Controls.Add(this.btn_SeleccFecha);
            this.Controls.Add(this.lbl_FechaInicio);
            this.Controls.Add(this.groupBox_Proyec);
            this.Controls.Add(this.reportProyectos);
            this.Name = "ListadoDeTodosLosProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoDeTodosLosProyectos";
            this.Load += new System.EventHandler(this.ListadoDeTodosLosProyectos_Load);
            this.groupBox_Proyec.ResumeLayout(false);
            this.groupBox_Proyec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportProyectos;
        private System.Windows.Forms.Button btn_SeleccPatron;
        private System.Windows.Forms.TextBox txtPatron;
        private System.Windows.Forms.Label lbl_Patron;
        private System.Windows.Forms.Button btn_SeleccFecha;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.GroupBox groupBox_Proyec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_PatrónDescrip;
        private System.Windows.Forms.Button button_Siguiente;
        private System.Windows.Forms.RadioButton rb_FechaInicioDesde;
        private System.Windows.Forms.RadioButton rb_Todos;
        private System.Windows.Forms.MaskedTextBox txtInicioABuscar;
    }
}