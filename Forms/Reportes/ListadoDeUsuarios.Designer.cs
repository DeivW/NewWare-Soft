
namespace NewWare_Soft.Forms
{
    partial class ListadoDeUsuarios
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
            this.reportUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_SeleccPatron = new System.Windows.Forms.Button();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.lbl_Patron = new System.Windows.Forms.Label();
            this.groupBox_ListUsuarios = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.rb_Patron = new System.Windows.Forms.RadioButton();
            this.rb_TodosUsu = new System.Windows.Forms.RadioButton();
            this.groupBox_ListUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportUsuarios
            // 
            this.reportUsuarios.LocalReport.ReportEmbeddedResource = "NewWare_Soft.Reporte_Usuarios.rdlc";
            this.reportUsuarios.Location = new System.Drawing.Point(0, 116);
            this.reportUsuarios.Name = "reportUsuarios";
            this.reportUsuarios.ServerReport.BearerToken = null;
            this.reportUsuarios.Size = new System.Drawing.Size(654, 405);
            this.reportUsuarios.TabIndex = 0;
            this.reportUsuarios.Visible = false;
            // 
            // btn_SeleccPatron
            // 
            this.btn_SeleccPatron.Enabled = false;
            this.btn_SeleccPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeleccPatron.Location = new System.Drawing.Point(558, 62);
            this.btn_SeleccPatron.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SeleccPatron.Name = "btn_SeleccPatron";
            this.btn_SeleccPatron.Size = new System.Drawing.Size(96, 27);
            this.btn_SeleccPatron.TabIndex = 36;
            this.btn_SeleccPatron.Text = "Seleccionar";
            this.btn_SeleccPatron.UseVisualStyleBackColor = true;
            this.btn_SeleccPatron.Visible = false;
            this.btn_SeleccPatron.Click += new System.EventHandler(this.btn_SeleccPatron_Click);
            // 
            // txtPatron
            // 
            this.txtPatron.Location = new System.Drawing.Point(575, 28);
            this.txtPatron.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.Size = new System.Drawing.Size(79, 20);
            this.txtPatron.TabIndex = 35;
            this.txtPatron.Visible = false;
            // 
            // lbl_Patron
            // 
            this.lbl_Patron.AutoSize = true;
            this.lbl_Patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patron.Location = new System.Drawing.Point(397, 32);
            this.lbl_Patron.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Patron.Name = "lbl_Patron";
            this.lbl_Patron.Size = new System.Drawing.Size(161, 17);
            this.lbl_Patron.TabIndex = 34;
            this.lbl_Patron.Text = "Letra o patron a buscar:";
            this.lbl_Patron.Visible = false;
            // 
            // groupBox_ListUsuarios
            // 
            this.groupBox_ListUsuarios.Controls.Add(this.label1);
            this.groupBox_ListUsuarios.Controls.Add(this.btnSiguiente);
            this.groupBox_ListUsuarios.Controls.Add(this.rb_Patron);
            this.groupBox_ListUsuarios.Controls.Add(this.rb_TodosUsu);
            this.groupBox_ListUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ListUsuarios.Location = new System.Drawing.Point(11, 11);
            this.groupBox_ListUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_ListUsuarios.Name = "groupBox_ListUsuarios";
            this.groupBox_ListUsuarios.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_ListUsuarios.Size = new System.Drawing.Size(364, 100);
            this.groupBox_ListUsuarios.TabIndex = 31;
            this.groupBox_ListUsuarios.TabStop = false;
            this.groupBox_ListUsuarios.Text = "Eleccion Reporte";
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
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(124, 65);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(103, 27);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // rb_Patron
            // 
            this.rb_Patron.AutoSize = true;
            this.rb_Patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Patron.Location = new System.Drawing.Point(124, 17);
            this.rb_Patron.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Patron.Name = "rb_Patron";
            this.rb_Patron.Size = new System.Drawing.Size(140, 21);
            this.rb_Patron.TabIndex = 1;
            this.rb_Patron.TabStop = true;
            this.rb_Patron.Text = "Buscar por patrón";
            this.rb_Patron.UseVisualStyleBackColor = true;
            // 
            // rb_TodosUsu
            // 
            this.rb_TodosUsu.AutoSize = true;
            this.rb_TodosUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TodosUsu.Location = new System.Drawing.Point(124, 40);
            this.rb_TodosUsu.Margin = new System.Windows.Forms.Padding(2);
            this.rb_TodosUsu.Name = "rb_TodosUsu";
            this.rb_TodosUsu.Size = new System.Drawing.Size(146, 21);
            this.rb_TodosUsu.TabIndex = 0;
            this.rb_TodosUsu.TabStop = true;
            this.rb_TodosUsu.Text = "Todos los usuarios";
            this.rb_TodosUsu.UseVisualStyleBackColor = true;
            // 
            // ListadoDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 521);
            this.Controls.Add(this.btn_SeleccPatron);
            this.Controls.Add(this.txtPatron);
            this.Controls.Add(this.lbl_Patron);
            this.Controls.Add(this.groupBox_ListUsuarios);
            this.Controls.Add(this.reportUsuarios);
            this.Name = "ListadoDeUsuarios";
            this.Text = "ListadoDeUsuarios";
            this.Load += new System.EventHandler(this.ListadoDeUsuarios_Load);
            this.groupBox_ListUsuarios.ResumeLayout(false);
            this.groupBox_ListUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportUsuarios;
        private System.Windows.Forms.Button btn_SeleccPatron;
        private System.Windows.Forms.TextBox txtPatron;
        private System.Windows.Forms.Label lbl_Patron;
        private System.Windows.Forms.GroupBox groupBox_ListUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.RadioButton rb_Patron;
        private System.Windows.Forms.RadioButton rb_TodosUsu;
    }
}