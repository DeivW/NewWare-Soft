
namespace NewWare_Soft.Forms
{
    partial class Baja_Tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baja_Tarjeta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdrTarjetas = new System.Windows.Forms.DataGridView();
            this.NroTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodSeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarEliminar = new System.Windows.Forms.Button();
            this.txtBuscarNroEliminar = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarTarjeta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodSeguridad = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdrTarjetas);
            this.groupBox1.Controls.Add(this.btnBuscarEliminar);
            this.groupBox1.Controls.Add(this.txtBuscarNroEliminar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(355, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 329);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una tarjeta o busque por número";
            // 
            // gdrTarjetas
            // 
            this.gdrTarjetas.AllowUserToAddRows = false;
            this.gdrTarjetas.AllowUserToDeleteRows = false;
            this.gdrTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroTarjeta,
            this.CodSeg,
            this.FechaVencimiento,
            this.Banco});
            this.gdrTarjetas.Location = new System.Drawing.Point(12, 91);
            this.gdrTarjetas.Name = "gdrTarjetas";
            this.gdrTarjetas.ReadOnly = true;
            this.gdrTarjetas.Size = new System.Drawing.Size(395, 226);
            this.gdrTarjetas.TabIndex = 25;
            this.gdrTarjetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrTarjetas_CellClick);
            // 
            // NroTarjeta
            // 
            this.NroTarjeta.DataPropertyName = "NroTarjeta";
            this.NroTarjeta.HeaderText = "Nro. Tarjeta";
            this.NroTarjeta.Name = "NroTarjeta";
            this.NroTarjeta.ReadOnly = true;
            this.NroTarjeta.Width = 150;
            // 
            // CodSeg
            // 
            this.CodSeg.DataPropertyName = "CodigoSeguridad";
            this.CodSeg.HeaderText = "Cod. Seg.";
            this.CodSeg.Name = "CodSeg";
            this.CodSeg.ReadOnly = true;
            this.CodSeg.Width = 50;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.DataPropertyName = "FechaVencimiento";
            this.FechaVencimiento.HeaderText = "Fecha de Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            // 
            // Banco
            // 
            this.Banco.DataPropertyName = "IdBanco";
            this.Banco.HeaderText = "Id Banco";
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            this.Banco.Width = 50;
            // 
            // btnBuscarEliminar
            // 
            this.btnBuscarEliminar.Location = new System.Drawing.Point(273, 34);
            this.btnBuscarEliminar.Name = "btnBuscarEliminar";
            this.btnBuscarEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEliminar.TabIndex = 24;
            this.btnBuscarEliminar.Text = "Buscar";
            this.btnBuscarEliminar.UseVisualStyleBackColor = true;
            this.btnBuscarEliminar.Click += new System.EventHandler(this.btnBuscarEliminar_Click);
            // 
            // txtBuscarNroEliminar
            // 
            this.txtBuscarNroEliminar.Location = new System.Drawing.Point(182, 34);
            this.txtBuscarNroEliminar.Mask = "99999999";
            this.txtBuscarNroEliminar.Name = "txtBuscarNroEliminar";
            this.txtBuscarNroEliminar.Size = new System.Drawing.Size(73, 23);
            this.txtBuscarNroEliminar.TabIndex = 22;
            this.txtBuscarNroEliminar.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Buscar por numero:";
            // 
            // btnEliminarTarjeta
            // 
            this.btnEliminarTarjeta.Enabled = false;
            this.btnEliminarTarjeta.Location = new System.Drawing.Point(45, 227);
            this.btnEliminarTarjeta.Name = "btnEliminarTarjeta";
            this.btnEliminarTarjeta.Size = new System.Drawing.Size(256, 31);
            this.btnEliminarTarjeta.TabIndex = 36;
            this.btnEliminarTarjeta.Text = "Eliminar tarjeta";
            this.btnEliminarTarjeta.UseVisualStyleBackColor = true;
            this.btnEliminarTarjeta.Click += new System.EventHandler(this.btnEliminarTarjeta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cod. Seguridad:";
            // 
            // txtCodSeguridad
            // 
            this.txtCodSeguridad.Enabled = false;
            this.txtCodSeguridad.Location = new System.Drawing.Point(168, 169);
            this.txtCodSeguridad.Mask = "999";
            this.txtCodSeguridad.Name = "txtCodSeguridad";
            this.txtCodSeguridad.Size = new System.Drawing.Size(32, 20);
            this.txtCodSeguridad.TabIndex = 34;
            this.txtCodSeguridad.ValidatingType = typeof(int);
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Enabled = false;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(168, 143);
            this.txtFechaVencimiento.Mask = "00/00/0000";
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(156, 20);
            this.txtFechaVencimiento.TabIndex = 33;
            this.txtFechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha de vencimiento:";
            // 
            // cmbBancos
            // 
            this.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancos.Enabled = false;
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(168, 116);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(156, 21);
            this.cmbBancos.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Banco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nro de tarjeta:";
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Enabled = false;
            this.txtNroTarjeta.Location = new System.Drawing.Point(168, 86);
            this.txtNroTarjeta.Mask = "99999999";
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(156, 20);
            this.txtNroTarjeta.TabIndex = 28;
            this.txtNroTarjeta.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Eliminar una Tarjeta";
            // 
            // label_Empresa
            // 
            this.label_Empresa.AutoSize = true;
            this.label_Empresa.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold);
            this.label_Empresa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Empresa.Location = new System.Drawing.Point(14, 9);
            this.label_Empresa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Empresa.Name = "label_Empresa";
            this.label_Empresa.Size = new System.Drawing.Size(190, 24);
            this.label_Empresa.TabIndex = 57;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // Baja_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 412);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarTarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodSeguridad);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBancos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNroTarjeta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baja_Tarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Tarjeta";
            this.Load += new System.EventHandler(this.Baja_Tarjeta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdrTarjetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.Button btnBuscarEliminar;
        private System.Windows.Forms.MaskedTextBox txtBuscarNroEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCodSeguridad;
        private System.Windows.Forms.MaskedTextBox txtFechaVencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBancos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNroTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Empresa;
    }
}