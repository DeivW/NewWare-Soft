
namespace NewWare_Soft
{
    partial class EstadisticaPromProductos
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.rbPorMes = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.BD3K7G07_2021DataSet = new NewWare_Soft.BD3K7G07_2021DataSet();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosTableAdapter = new NewWare_Soft.BD3K7G07_2021DataSetTableAdapters.proyectosTableAdapter();
            this.reportProm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G07_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.rbPorMes);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de grafico estadistico:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(146, 41);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(146, 23);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // rbPorMes
            // 
            this.rbPorMes.AutoSize = true;
            this.rbPorMes.Location = new System.Drawing.Point(18, 44);
            this.rbPorMes.Name = "rbPorMes";
            this.rbPorMes.Size = new System.Drawing.Size(90, 17);
            this.rbPorMes.TabIndex = 4;
            this.rbPorMes.TabStop = true;
            this.rbPorMes.Text = "Filtrar por mes";
            this.rbPorMes.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(18, 21);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(121, 17);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los productos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(393, 33);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(139, 13);
            this.lblPromedio.TabIndex = 7;
            this.lblPromedio.Text = "Promedio de precio general:";
            this.lblPromedio.Visible = false;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(562, 25);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 8;
            this.txtPromedio.Visible = false;
            // 
            // BD3K7G07_2021DataSet
            // 
            this.BD3K7G07_2021DataSet.DataSetName = "BD3K7G07_2021DataSet";
            this.BD3K7G07_2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "proyectos";
            this.proyectosBindingSource.DataSource = this.BD3K7G07_2021DataSet;
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // reportProm
            // 
            this.reportProm.Location = new System.Drawing.Point(0, 92);
            this.reportProm.Name = "reportProm";
            this.reportProm.ServerReport.BearerToken = null;
            this.reportProm.Size = new System.Drawing.Size(831, 427);
            this.reportProm.TabIndex = 9;
            this.reportProm.Visible = false;
            // 
            // EstadisticaPromProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 519);
            this.Controls.Add(this.reportProm);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.groupBox1);
            this.Name = "EstadisticaPromProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precio promedio de productos";
            this.Load += new System.EventHandler(this.EstadisticaPromProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G07_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.RadioButton rbPorMes;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private BD3K7G07_2021DataSet BD3K7G07_2021DataSet;
        private BD3K7G07_2021DataSetTableAdapters.proyectosTableAdapter proyectosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportProm;
    }
}