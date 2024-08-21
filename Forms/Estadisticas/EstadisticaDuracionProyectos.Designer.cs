
namespace NewWare_Soft.Forms.Estadisticas
{
    partial class EstadisticaDuracionProyectos
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
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblProm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelecc = new System.Windows.Forms.Button();
            this.rbMayores = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.chk_barras = new System.Windows.Forms.CheckBox();
            this.rv1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(623, 27);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(149, 20);
            this.txtPromedio.TabIndex = 18;
            this.txtPromedio.Visible = false;
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Location = new System.Drawing.Point(395, 30);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(222, 13);
            this.lblProm.TabIndex = 17;
            this.lblProm.Text = "Promedio de Duracion de proyectos (en dias):";
            this.lblProm.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecc);
            this.groupBox1.Controls.Add(this.rbMayores);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 74);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de grafico estadistico:";
            // 
            // btnSelecc
            // 
            this.btnSelecc.Location = new System.Drawing.Point(213, 41);
            this.btnSelecc.Name = "btnSelecc";
            this.btnSelecc.Size = new System.Drawing.Size(146, 23);
            this.btnSelecc.TabIndex = 5;
            this.btnSelecc.Text = "Seleccionar";
            this.btnSelecc.UseVisualStyleBackColor = true;
            this.btnSelecc.Click += new System.EventHandler(this.btnSelecc_Click);
            // 
            // rbMayores
            // 
            this.rbMayores.AutoSize = true;
            this.rbMayores.Location = new System.Drawing.Point(18, 44);
            this.rbMayores.Name = "rbMayores";
            this.rbMayores.Size = new System.Drawing.Size(167, 17);
            this.rbMayores.TabIndex = 4;
            this.rbMayores.TabStop = true;
            this.rbMayores.Text = "Filtrar por mayores al promedio";
            this.rbMayores.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(18, 21);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(120, 17);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los proyectos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // chk_barras
            // 
            this.chk_barras.AutoSize = true;
            this.chk_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_barras.Location = new System.Drawing.Point(398, 67);
            this.chk_barras.Name = "chk_barras";
            this.chk_barras.Size = new System.Drawing.Size(197, 19);
            this.chk_barras.TabIndex = 15;
            this.chk_barras.Text = "Mostrar como grafico de barras";
            this.chk_barras.UseVisualStyleBackColor = true;
            // 
            // rv1
            // 
            this.rv1.Location = new System.Drawing.Point(-1, 104);
            this.rv1.Name = "rv1";
            this.rv1.ServerReport.BearerToken = null;
            this.rv1.Size = new System.Drawing.Size(804, 347);
            this.rv1.TabIndex = 19;
            this.rv1.Visible = false;
            // 
            // EstadisticaDuracionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rv1);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblProm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chk_barras);
            this.Name = "EstadisticaDuracionProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica de duracion de proyectos";
            this.Load += new System.EventHandler(this.EstadisticaDuracionProyectos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelecc;
        private System.Windows.Forms.RadioButton rbMayores;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.CheckBox chk_barras;
        private Microsoft.Reporting.WinForms.ReportViewer rv1;
    }
}