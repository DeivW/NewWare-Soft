
namespace NewWare_Soft.Forms.Reportes
{
    partial class ListadoProductosXCliente
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
            this.ProdXClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Client = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.btn_Prod = new System.Windows.Forms.Button();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.lbl_Prod = new System.Windows.Forms.Label();
            this.btn_Lider = new System.Windows.Forms.Button();
            this.txtLider = new System.Windows.Forms.TextBox();
            this.lbl_Lider = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_FullListado = new System.Windows.Forms.RadioButton();
            this.btn_Next = new System.Windows.Forms.Button();
            this.rb_LiderInst = new System.Windows.Forms.RadioButton();
            this.rb_IdCliente = new System.Windows.Forms.RadioButton();
            this.rb_IdProducto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProdXClientes
            // 
            this.ProdXClientes.LocalReport.ReportEmbeddedResource = "NewWare_Soft.ReporteProductosXCliente.rdlc";
            this.ProdXClientes.Location = new System.Drawing.Point(0, 179);
            this.ProdXClientes.Name = "ProdXClientes";
            this.ProdXClientes.ServerReport.BearerToken = null;
            this.ProdXClientes.Size = new System.Drawing.Size(821, 271);
            this.ProdXClientes.TabIndex = 0;
            this.ProdXClientes.Visible = false;
            // 
            // btn_Client
            // 
            this.btn_Client.Enabled = false;
            this.btn_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Client.Location = new System.Drawing.Point(713, 58);
            this.btn_Client.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(96, 27);
            this.btn_Client.TabIndex = 78;
            this.btn_Client.Text = "Seleccionar";
            this.btn_Client.UseVisualStyleBackColor = true;
            this.btn_Client.Visible = false;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(618, 65);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(79, 20);
            this.txtCliente.TabIndex = 77;
            this.txtCliente.Visible = false;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(474, 68);
            this.lbl_Cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(127, 17);
            this.lbl_Cliente.TabIndex = 76;
            this.lbl_Cliente.Text = "ID Cliente a buscar";
            this.lbl_Cliente.Visible = false;
            // 
            // btn_Prod
            // 
            this.btn_Prod.Enabled = false;
            this.btn_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prod.Location = new System.Drawing.Point(713, 22);
            this.btn_Prod.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Prod.Name = "btn_Prod";
            this.btn_Prod.Size = new System.Drawing.Size(96, 27);
            this.btn_Prod.TabIndex = 75;
            this.btn_Prod.Text = "Seleccionar";
            this.btn_Prod.UseVisualStyleBackColor = true;
            this.btn_Prod.Visible = false;
            this.btn_Prod.Click += new System.EventHandler(this.btn_Prod_Click);
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(618, 29);
            this.txtProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(79, 20);
            this.txtProd.TabIndex = 74;
            this.txtProd.Visible = false;
            // 
            // lbl_Prod
            // 
            this.lbl_Prod.AutoSize = true;
            this.lbl_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prod.Location = new System.Drawing.Point(461, 29);
            this.lbl_Prod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Prod.Name = "lbl_Prod";
            this.lbl_Prod.Size = new System.Drawing.Size(140, 17);
            this.lbl_Prod.TabIndex = 73;
            this.lbl_Prod.Text = "ID producto a buscar";
            this.lbl_Prod.Visible = false;
            // 
            // btn_Lider
            // 
            this.btn_Lider.Enabled = false;
            this.btn_Lider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lider.Location = new System.Drawing.Point(713, 98);
            this.btn_Lider.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Lider.Name = "btn_Lider";
            this.btn_Lider.Size = new System.Drawing.Size(96, 27);
            this.btn_Lider.TabIndex = 72;
            this.btn_Lider.Text = "Seleccionar";
            this.btn_Lider.UseVisualStyleBackColor = true;
            this.btn_Lider.Visible = false;
            this.btn_Lider.Click += new System.EventHandler(this.btn_Lider_Click);
            // 
            // txtLider
            // 
            this.txtLider.Location = new System.Drawing.Point(618, 102);
            this.txtLider.Margin = new System.Windows.Forms.Padding(2);
            this.txtLider.Name = "txtLider";
            this.txtLider.Size = new System.Drawing.Size(79, 20);
            this.txtLider.TabIndex = 71;
            this.txtLider.Visible = false;
            // 
            // lbl_Lider
            // 
            this.lbl_Lider.AutoSize = true;
            this.lbl_Lider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lider.Location = new System.Drawing.Point(431, 103);
            this.lbl_Lider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Lider.Name = "lbl_Lider";
            this.lbl_Lider.Size = new System.Drawing.Size(170, 17);
            this.lbl_Lider.TabIndex = 70;
            this.lbl_Lider.Text = "Lider Instalacion a buscar";
            this.lbl_Lider.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_FullListado);
            this.groupBox1.Controls.Add(this.btn_Next);
            this.groupBox1.Controls.Add(this.rb_LiderInst);
            this.groupBox1.Controls.Add(this.rb_IdCliente);
            this.groupBox1.Controls.Add(this.rb_IdProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 161);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eleccion Reporte";
            // 
            // rb_FullListado
            // 
            this.rb_FullListado.AutoSize = true;
            this.rb_FullListado.Location = new System.Drawing.Point(136, 100);
            this.rb_FullListado.Name = "rb_FullListado";
            this.rb_FullListado.Size = new System.Drawing.Size(166, 21);
            this.rb_FullListado.TabIndex = 5;
            this.rb_FullListado.TabStop = true;
            this.rb_FullListado.Text = "Mostrar todo el listado";
            this.rb_FullListado.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(263, 123);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(86, 32);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Siguiente";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // rb_LiderInst
            // 
            this.rb_LiderInst.AutoSize = true;
            this.rb_LiderInst.Location = new System.Drawing.Point(136, 73);
            this.rb_LiderInst.Name = "rb_LiderInst";
            this.rb_LiderInst.Size = new System.Drawing.Size(202, 21);
            this.rb_LiderInst.TabIndex = 3;
            this.rb_LiderInst.TabStop = true;
            this.rb_LiderInst.Text = "Buscar por Lider Instalacion";
            this.rb_LiderInst.UseVisualStyleBackColor = true;
            // 
            // rb_IdCliente
            // 
            this.rb_IdCliente.AutoSize = true;
            this.rb_IdCliente.Location = new System.Drawing.Point(136, 46);
            this.rb_IdCliente.Name = "rb_IdCliente";
            this.rb_IdCliente.Size = new System.Drawing.Size(157, 21);
            this.rb_IdCliente.TabIndex = 2;
            this.rb_IdCliente.TabStop = true;
            this.rb_IdCliente.Text = "Buscar por ID cliente";
            this.rb_IdCliente.UseVisualStyleBackColor = true;
            // 
            // rb_IdProducto
            // 
            this.rb_IdProducto.AutoSize = true;
            this.rb_IdProducto.Location = new System.Drawing.Point(136, 19);
            this.rb_IdProducto.Name = "rb_IdProducto";
            this.rb_IdProducto.Size = new System.Drawing.Size(192, 21);
            this.rb_IdProducto.TabIndex = 1;
            this.rb_IdProducto.TabStop = true;
            this.rb_IdProducto.Text = "Buscar por ID de producto";
            this.rb_IdProducto.UseVisualStyleBackColor = true;
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
            // ListadoProductosXCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.btn_Client);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.btn_Prod);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.lbl_Prod);
            this.Controls.Add(this.btn_Lider);
            this.Controls.Add(this.txtLider);
            this.Controls.Add(this.lbl_Lider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProdXClientes);
            this.Name = "ListadoProductosXCliente";
            this.Text = "ListadoProductosXCliente";
            this.Load += new System.EventHandler(this.ListadoProductosXCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ProdXClientes;
        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Button btn_Prod;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label lbl_Prod;
        private System.Windows.Forms.Button btn_Lider;
        private System.Windows.Forms.TextBox txtLider;
        private System.Windows.Forms.Label lbl_Lider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_FullListado;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.RadioButton rb_LiderInst;
        private System.Windows.Forms.RadioButton rb_IdCliente;
        private System.Windows.Forms.RadioButton rb_IdProducto;
        private System.Windows.Forms.Label label1;
    }
}