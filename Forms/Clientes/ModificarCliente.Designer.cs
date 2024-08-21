
namespace NewWare_Soft.Forms
{
    partial class ModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCliente));
            this.button_LimpiarCampos = new System.Windows.Forms.Button();
            this.button_actualizarCliente = new System.Windows.Forms.Button();
            this.label_barrio = new System.Windows.Forms.Label();
            this.textBox_nroCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_calle = new System.Windows.Forms.Label();
            this.textBox_nombreCalle = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Barrio = new System.Windows.Forms.ComboBox();
            this.label_Empresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LimpiarCampos
            // 
            this.button_LimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_LimpiarCampos.Location = new System.Drawing.Point(22, 316);
            this.button_LimpiarCampos.Margin = new System.Windows.Forms.Padding(2);
            this.button_LimpiarCampos.Name = "button_LimpiarCampos";
            this.button_LimpiarCampos.Size = new System.Drawing.Size(144, 39);
            this.button_LimpiarCampos.TabIndex = 60;
            this.button_LimpiarCampos.Text = "Limpiar campos";
            this.button_LimpiarCampos.UseVisualStyleBackColor = true;
            this.button_LimpiarCampos.Click += new System.EventHandler(this.button_LimpiarCampos_Click);
            // 
            // button_actualizarCliente
            // 
            this.button_actualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_actualizarCliente.Location = new System.Drawing.Point(195, 316);
            this.button_actualizarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.button_actualizarCliente.Name = "button_actualizarCliente";
            this.button_actualizarCliente.Size = new System.Drawing.Size(144, 39);
            this.button_actualizarCliente.TabIndex = 59;
            this.button_actualizarCliente.Text = "Actualizar";
            this.button_actualizarCliente.UseVisualStyleBackColor = true;
            this.button_actualizarCliente.Click += new System.EventHandler(this.button_actualizarCliente_Click);
            // 
            // label_barrio
            // 
            this.label_barrio.AutoSize = true;
            this.label_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_barrio.Location = new System.Drawing.Point(43, 269);
            this.label_barrio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_barrio.Name = "label_barrio";
            this.label_barrio.Size = new System.Drawing.Size(48, 18);
            this.label_barrio.TabIndex = 58;
            this.label_barrio.Text = "Barrio";
            // 
            // textBox_nroCalle
            // 
            this.textBox_nroCalle.Enabled = false;
            this.textBox_nroCalle.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nroCalle.Location = new System.Drawing.Point(95, 238);
            this.textBox_nroCalle.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nroCalle.Name = "textBox_nroCalle";
            this.textBox_nroCalle.Size = new System.Drawing.Size(244, 23);
            this.textBox_nroCalle.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(4, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nro de calle";
            // 
            // label_calle
            // 
            this.label_calle.AutoSize = true;
            this.label_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_calle.Location = new System.Drawing.Point(50, 209);
            this.label_calle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_calle.Name = "label_calle";
            this.label_calle.Size = new System.Drawing.Size(41, 18);
            this.label_calle.TabIndex = 54;
            this.label_calle.Text = "Calle";
            // 
            // textBox_nombreCalle
            // 
            this.textBox_nombreCalle.Enabled = false;
            this.textBox_nombreCalle.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombreCalle.Location = new System.Drawing.Point(95, 208);
            this.textBox_nombreCalle.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nombreCalle.Name = "textBox_nombreCalle";
            this.textBox_nombreCalle.Size = new System.Drawing.Size(244, 23);
            this.textBox_nombreCalle.TabIndex = 53;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(95, 174);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(244, 23);
            this.textBox_Email.TabIndex = 48;
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_telefono.Location = new System.Drawing.Point(25, 144);
            this.label_telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(66, 18);
            this.label_telefono.TabIndex = 52;
            this.label_telefono.Text = "Telefono";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Email.Location = new System.Drawing.Point(46, 175);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(45, 18);
            this.label_Email.TabIndex = 51;
            this.label_Email.Text = "Email";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Enabled = false;
            this.textBox_telefono.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_telefono.Location = new System.Drawing.Point(95, 143);
            this.textBox_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(244, 23);
            this.textBox_telefono.TabIndex = 47;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Enabled = false;
            this.textBox_apellido.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_apellido.Location = new System.Drawing.Point(95, 110);
            this.textBox_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(244, 23);
            this.textBox_apellido.TabIndex = 46;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_nombre.Location = new System.Drawing.Point(29, 76);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(62, 18);
            this.label_nombre.TabIndex = 50;
            this.label_nombre.Text = "Nombre";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_apellido.Location = new System.Drawing.Point(32, 111);
            this.label_apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(59, 18);
            this.label_apellido.TabIndex = 49;
            this.label_apellido.Text = "Apellido";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Enabled = false;
            this.textBox_nombre.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(95, 78);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(244, 23);
            this.textBox_nombre.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 44;
            // 
            // dataGridView_Clientes
            // 
            this.dataGridView_Clientes.AllowUserToAddRows = false;
            this.dataGridView_Clientes.AllowUserToDeleteRows = false;
            this.dataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.nombre_cliente,
            this.apellido_cliente});
            this.dataGridView_Clientes.Location = new System.Drawing.Point(366, 78);
            this.dataGridView_Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Clientes.Name = "dataGridView_Clientes";
            this.dataGridView_Clientes.ReadOnly = true;
            this.dataGridView_Clientes.RowHeadersWidth = 62;
            this.dataGridView_Clientes.RowTemplate.Height = 28;
            this.dataGridView_Clientes.Size = new System.Drawing.Size(429, 277);
            this.dataGridView_Clientes.TabIndex = 43;
            this.dataGridView_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Cliente_CellClick);
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 120;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.DataPropertyName = "Nombre";
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.MinimumWidth = 8;
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            this.nombre_cliente.Width = 120;
            // 
            // apellido_cliente
            // 
            this.apellido_cliente.DataPropertyName = "Apellido";
            this.apellido_cliente.HeaderText = "Apellido";
            this.apellido_cliente.MinimumWidth = 8;
            this.apellido_cliente.Name = "apellido_cliente";
            this.apellido_cliente.ReadOnly = true;
            this.apellido_cliente.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(272, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Modificar un Cliente";
            // 
            // comboBox_Barrio
            // 
            this.comboBox_Barrio.FormattingEnabled = true;
            this.comboBox_Barrio.Location = new System.Drawing.Point(95, 270);
            this.comboBox_Barrio.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Barrio.Name = "comboBox_Barrio";
            this.comboBox_Barrio.Size = new System.Drawing.Size(244, 21);
            this.comboBox_Barrio.TabIndex = 61;
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
            this.label_Empresa.TabIndex = 62;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 368);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.comboBox_Barrio);
            this.Controls.Add(this.button_LimpiarCampos);
            this.Controls.Add(this.button_actualizarCliente);
            this.Controls.Add(this.label_barrio);
            this.Controls.Add(this.textBox_nroCalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_calle);
            this.Controls.Add(this.textBox_nombreCalle);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Clientes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Cliente";
            this.Load += new System.EventHandler(this.ModificarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LimpiarCampos;
        private System.Windows.Forms.Button button_actualizarCliente;
        private System.Windows.Forms.Label label_barrio;
        private System.Windows.Forms.TextBox textBox_nroCalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_calle;
        private System.Windows.Forms.TextBox textBox_nombreCalle;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_cliente;
        private System.Windows.Forms.Label label_Empresa;
    }
}