namespace NewWare_Soft.Forms
{
    partial class ModificarPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPersonal));
            this.lblTitleMod = new System.Windows.Forms.Label();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbEgreso = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.gdrPersonal = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaEgreso = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblIdBarrio = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblIdCargo = new System.Windows.Forms.Label();
            this.lblIdEgreso = new System.Windows.Forms.Label();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleMod
            // 
            this.lblTitleMod.AutoSize = true;
            this.lblTitleMod.Location = new System.Drawing.Point(446, 80);
            this.lblTitleMod.Name = "lblTitleMod";
            this.lblTitleMod.Size = new System.Drawing.Size(289, 13);
            this.lblTitleMod.TabIndex = 93;
            this.lblTitleMod.Text = "Seleccione un empleado existente para modificar sus datos:";
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(190, 568);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(217, 21);
            this.cmbBarrio.TabIndex = 75;
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(190, 456);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(217, 21);
            this.cmbCargo.TabIndex = 72;
            // 
            // cmbEgreso
            // 
            this.cmbEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEgreso.FormattingEnabled = true;
            this.cmbEgreso.Location = new System.Drawing.Point(190, 419);
            this.cmbEgreso.Name = "cmbEgreso";
            this.cmbEgreso.Size = new System.Drawing.Size(217, 21);
            this.cmbEgreso.TabIndex = 71;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(190, 259);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(217, 21);
            this.cmbUsuario.TabIndex = 67;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(769, 560);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(250, 28);
            this.btLimpiar.TabIndex = 77;
            this.btLimpiar.Text = "Limpiar Campos";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(446, 560);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(250, 28);
            this.btActualizar.TabIndex = 76;
            this.btActualizar.Text = "Actualizar Datos";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // gdrPersonal
            // 
            this.gdrPersonal.AllowUserToAddRows = false;
            this.gdrPersonal.AllowUserToDeleteRows = false;
            this.gdrPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.NroDocumento,
            this.Apellido,
            this.Nombre,
            this.FechaNacimiento});
            this.gdrPersonal.Location = new System.Drawing.Point(446, 109);
            this.gdrPersonal.Name = "gdrPersonal";
            this.gdrPersonal.ReadOnly = true;
            this.gdrPersonal.Size = new System.Drawing.Size(573, 437);
            this.gdrPersonal.TabIndex = 92;
            this.gdrPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrPersonal_CellClick);
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 80;
            // 
            // NroDocumento
            // 
            this.NroDocumento.DataPropertyName = "NroDni";
            this.NroDocumento.HeaderText = "NroDocumento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 115;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 115;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 120;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(190, 109);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(217, 20);
            this.txtLegajo.TabIndex = 91;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(120, 111);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(56, 18);
            this.lblLegajo.TabIndex = 90;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(190, 147);
            this.txtNroDoc.Mask = "99999999";
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(217, 20);
            this.txtNroDoc.TabIndex = 64;
            // 
            // txtFechaEgreso
            // 
            this.txtFechaEgreso.Location = new System.Drawing.Point(190, 377);
            this.txtFechaEgreso.Mask = "00/00/0000";
            this.txtFechaEgreso.Name = "txtFechaEgreso";
            this.txtFechaEgreso.Size = new System.Drawing.Size(217, 20);
            this.txtFechaEgreso.TabIndex = 70;
            this.txtFechaEgreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(190, 338);
            this.txtFechaIngreso.Mask = "00/00/0000";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(217, 20);
            this.txtFechaIngreso.TabIndex = 69;
            this.txtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(190, 299);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(217, 20);
            this.txtFechaNacimiento.TabIndex = 68;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(24, 301);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(152, 18);
            this.lblFechaNacimiento.TabIndex = 89;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblIdBarrio
            // 
            this.lblIdBarrio.AutoSize = true;
            this.lblIdBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBarrio.Location = new System.Drawing.Point(113, 571);
            this.lblIdBarrio.Name = "lblIdBarrio";
            this.lblIdBarrio.Size = new System.Drawing.Size(63, 18);
            this.lblIdBarrio.TabIndex = 88;
            this.lblIdBarrio.Text = "IdBarrio:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(190, 530);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(217, 20);
            this.txtNroCalle.TabIndex = 74;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCalle.Location = new System.Drawing.Point(53, 532);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(123, 18);
            this.lblNroCalle.TabIndex = 87;
            this.lblNroCalle.Text = "Numero de Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(190, 493);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(217, 20);
            this.txtCalle.TabIndex = 73;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(131, 495);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(45, 18);
            this.lblCalle.TabIndex = 86;
            this.lblCalle.Text = "Calle:";
            // 
            // lblIdCargo
            // 
            this.lblIdCargo.AutoSize = true;
            this.lblIdCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCargo.Location = new System.Drawing.Point(112, 459);
            this.lblIdCargo.Name = "lblIdCargo";
            this.lblIdCargo.Size = new System.Drawing.Size(64, 18);
            this.lblIdCargo.TabIndex = 85;
            this.lblIdCargo.Text = "IdCargo:";
            // 
            // lblIdEgreso
            // 
            this.lblIdEgreso.AutoSize = true;
            this.lblIdEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEgreso.Location = new System.Drawing.Point(47, 422);
            this.lblIdEgreso.Name = "lblIdEgreso";
            this.lblIdEgreso.Size = new System.Drawing.Size(129, 18);
            this.lblIdEgreso.TabIndex = 84;
            this.lblIdEgreso.Text = "Motivo de Egreso:";
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEgreso.Location = new System.Drawing.Point(51, 379);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(125, 18);
            this.lblFechaEgreso.TabIndex = 83;
            this.lblFechaEgreso.Text = "Fecha de Egreso:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(50, 340);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(126, 18);
            this.lblFechaIngreso.TabIndex = 82;
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.Location = new System.Drawing.Point(101, 262);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(75, 18);
            this.lblIdUsuario.TabIndex = 81;
            this.lblIdUsuario.Text = "IdUsuario:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(190, 223);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(217, 20);
            this.txtApellido.TabIndex = 66;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(113, 225);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 18);
            this.lblApellido.TabIndex = 80;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 186);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 65;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(110, 188);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 79;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(12, 149);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(172, 18);
            this.lblNroDoc.TabIndex = 78;
            this.lblNroDoc.Text = "Numero de Documento: ";
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
            this.label_Empresa.TabIndex = 95;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(375, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 37);
            this.lblTitle.TabIndex = 94;
            this.lblTitle.Text = "Modificar Personal";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModificarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 612);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTitleMod);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.cmbEgreso);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.gdrPersonal);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.txtFechaEgreso);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblIdBarrio);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.lblNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblIdCargo);
            this.Controls.Add(this.lblIdEgreso);
            this.Controls.Add(this.lblFechaEgreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNroDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Personal";
            this.Load += new System.EventHandler(this.ModificarPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMod;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbEgreso;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.DataGridView gdrPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.MaskedTextBox txtNroDoc;
        private System.Windows.Forms.MaskedTextBox txtFechaEgreso;
        private System.Windows.Forms.MaskedTextBox txtFechaIngreso;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblIdBarrio;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblIdCargo;
        private System.Windows.Forms.Label lblIdEgreso;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.Label lblTitle;
    }
}