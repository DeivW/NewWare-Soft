namespace NewWare_Soft
{
    partial class EstadisticaProyectoMes
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
            this.rp1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bt_Buscar = new System.Windows.Forms.Button();
            this.chk_barras = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_clie = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Seleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rp1
            // 
            this.rp1.Location = new System.Drawing.Point(0, 96);
            this.rp1.Name = "rp1";
            this.rp1.ServerReport.BearerToken = null;
            this.rp1.Size = new System.Drawing.Size(801, 433);
            this.rp1.TabIndex = 0;
            // 
            // bt_Buscar
            // 
            this.bt_Buscar.Enabled = false;
            this.bt_Buscar.Location = new System.Drawing.Point(601, 25);
            this.bt_Buscar.Name = "bt_Buscar";
            this.bt_Buscar.Size = new System.Drawing.Size(177, 23);
            this.bt_Buscar.TabIndex = 1;
            this.bt_Buscar.Text = "Buscar";
            this.bt_Buscar.UseVisualStyleBackColor = true;
            this.bt_Buscar.Click += new System.EventHandler(this.bt_Buscar_Click);
            // 
            // chk_barras
            // 
            this.chk_barras.AutoSize = true;
            this.chk_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_barras.Location = new System.Drawing.Point(592, 58);
            this.chk_barras.Name = "chk_barras";
            this.chk_barras.Size = new System.Drawing.Size(197, 19);
            this.chk_barras.TabIndex = 2;
            this.chk_barras.Text = "Mostrar como grafico de barras";
            this.chk_barras.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos los proyectos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rb_clie
            // 
            this.rb_clie.AutoSize = true;
            this.rb_clie.Location = new System.Drawing.Point(18, 44);
            this.rb_clie.Name = "rb_clie";
            this.rb_clie.Size = new System.Drawing.Size(102, 17);
            this.rb_clie.TabIndex = 4;
            this.rb_clie.TabStop = true;
            this.rb_clie.Text = "Filtrar por cliente";
            this.rb_clie.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Seleccionar);
            this.groupBox1.Controls.Add(this.rb_clie);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de grafico estadistico:";
            // 
            // bt_Seleccionar
            // 
            this.bt_Seleccionar.Location = new System.Drawing.Point(146, 41);
            this.bt_Seleccionar.Name = "bt_Seleccionar";
            this.bt_Seleccionar.Size = new System.Drawing.Size(146, 23);
            this.bt_Seleccionar.TabIndex = 5;
            this.bt_Seleccionar.Text = "Seleccionar";
            this.bt_Seleccionar.UseVisualStyleBackColor = true;
            this.bt_Seleccionar.Click += new System.EventHandler(this.bt_Seleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nro. Cliente:";
            this.label1.Visible = false;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(404, 27);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(149, 20);
            this.txt.TabIndex = 8;
            this.txt.Visible = false;
            // 
            // EstadisticaProyectoMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chk_barras);
            this.Controls.Add(this.bt_Buscar);
            this.Controls.Add(this.rp1);
            this.Name = "EstadisticaProyectoMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio de Proyectos por Mes";
            this.Load += new System.EventHandler(this.EstadisticaProyectoMes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp1;
        private System.Windows.Forms.Button bt_Buscar;
        private System.Windows.Forms.CheckBox chk_barras;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rb_clie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Seleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt;
    }
}