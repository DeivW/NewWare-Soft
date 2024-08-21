
namespace NewWare_Soft.Forms
{
    partial class Mod_Tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mod_Tarjeta));
            this.btnModificarTarjeta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodSeguridad = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarNro = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gdrTarjetas = new System.Windows.Forms.DataGridView();
            this.NroTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodSeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Empresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrTarjetas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificarTarjeta
            // 
            this.btnModificarTarjeta.Enabled = false;
            this.btnModificarTarjeta.Location = new System.Drawing.Point(38, 214);
            this.btnModificarTarjeta.Name = "btnModificarTarjeta";
            this.btnModificarTarjeta.Size = new System.Drawing.Size(275, 31);
            this.btnModificarTarjeta.TabIndex = 21;
            this.btnModificarTarjeta.Text = "Guardar cambios";
            this.btnModificarTarjeta.UseVisualStyleBackColor = true;
            this.btnModificarTarjeta.Click += new System.EventHandler(this.btnModificarTarjeta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cod. Seguridad:";
            // 
            // txtCodSeguridad
            // 
            this.txtCodSeguridad.Enabled = false;
            this.txtCodSeguridad.Location = new System.Drawing.Point(172, 178);
            this.txtCodSeguridad.Mask = "999";
            this.txtCodSeguridad.Name = "txtCodSeguridad";
            this.txtCodSeguridad.Size = new System.Drawing.Size(32, 20);
            this.txtCodSeguridad.TabIndex = 19;
            this.txtCodSeguridad.ValidatingType = typeof(int);
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Enabled = false;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(172, 152);
            this.txtFechaVencimiento.Mask = "00/00/0000";
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(141, 20);
            this.txtFechaVencimiento.TabIndex = 18;
            this.txtFechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de vencimiento:";
            // 
            // cmbBancos
            // 
            this.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancos.Enabled = false;
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(172, 125);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(141, 21);
            this.cmbBancos.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Banco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nro de tarjeta:";
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Enabled = false;
            this.txtNroTarjeta.Location = new System.Drawing.Point(172, 95);
            this.txtNroTarjeta.Mask = "99999999";
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(141, 20);
            this.txtNroTarjeta.TabIndex = 13;
            this.txtNroTarjeta.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modificar una Tarjeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Buscar por numero:";
            // 
            // txtBuscarNro
            // 
            this.txtBuscarNro.Location = new System.Drawing.Point(185, 33);
            this.txtBuscarNro.Mask = "99999999";
            this.txtBuscarNro.Name = "txtBuscarNro";
            this.txtBuscarNro.Size = new System.Drawing.Size(73, 23);
            this.txtBuscarNro.TabIndex = 22;
            this.txtBuscarNro.ValidatingType = typeof(int);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(276, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.gdrTarjetas.Location = new System.Drawing.Point(15, 90);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdrTarjetas);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarNro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(342, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 329);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una tarjeta o busque por número";
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
            this.label_Empresa.TabIndex = 31;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // Mod_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 430);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModificarTarjeta);
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
            this.Name = "Mod_Tarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Tarjeta";
            this.Load += new System.EventHandler(this.Mod_Tarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrTarjetas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCodSeguridad;
        private System.Windows.Forms.MaskedTextBox txtFechaVencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBancos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNroTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtBuscarNro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gdrTarjetas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.Label label_Empresa;
    }
}