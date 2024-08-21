namespace NewWare_Soft.Forms
{
    partial class AltaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaPersonal));
            this.lblTitleAdd = new System.Windows.Forms.Label();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbEgreso = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
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
            this.btLimpiarPersonal = new System.Windows.Forms.Button();
            this.btAddPersonal = new System.Windows.Forms.Button();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleAdd
            // 
            this.lblTitleAdd.AutoSize = true;
            this.lblTitleAdd.Cursor = System.Windows.Forms.Cursors.No;
            this.lblTitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAdd.Location = new System.Drawing.Point(106, 50);
            this.lblTitleAdd.Name = "lblTitleAdd";
            this.lblTitleAdd.Size = new System.Drawing.Size(213, 20);
            this.lblTitleAdd.TabIndex = 52;
            this.lblTitleAdd.Text = "Agregar Nuevo Empleado";
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(171, 509);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(217, 21);
            this.cmbBarrio.TabIndex = 43;
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(171, 397);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(217, 21);
            this.cmbCargo.TabIndex = 38;
            // 
            // cmbEgreso
            // 
            this.cmbEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEgreso.FormattingEnabled = true;
            this.cmbEgreso.Location = new System.Drawing.Point(171, 360);
            this.cmbEgreso.Name = "cmbEgreso";
            this.cmbEgreso.Size = new System.Drawing.Size(217, 21);
            this.cmbEgreso.TabIndex = 36;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.ItemHeight = 13;
            this.cmbUsuario.Location = new System.Drawing.Point(171, 200);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(217, 21);
            this.cmbUsuario.TabIndex = 31;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(171, 88);
            this.txtNroDoc.Mask = "99999999";
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(217, 20);
            this.txtNroDoc.TabIndex = 27;
            // 
            // txtFechaEgreso
            // 
            this.txtFechaEgreso.Location = new System.Drawing.Point(171, 318);
            this.txtFechaEgreso.Mask = "00/00/0000";
            this.txtFechaEgreso.Name = "txtFechaEgreso";
            this.txtFechaEgreso.Size = new System.Drawing.Size(217, 20);
            this.txtFechaEgreso.TabIndex = 35;
            this.txtFechaEgreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(171, 279);
            this.txtFechaIngreso.Mask = "00/00/0000";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(217, 20);
            this.txtFechaIngreso.TabIndex = 33;
            this.txtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(171, 240);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(217, 20);
            this.txtFechaNacimiento.TabIndex = 32;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(45, 243);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 51;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblIdBarrio
            // 
            this.lblIdBarrio.AutoSize = true;
            this.lblIdBarrio.Location = new System.Drawing.Point(110, 512);
            this.lblIdBarrio.Name = "lblIdBarrio";
            this.lblIdBarrio.Size = new System.Drawing.Size(46, 13);
            this.lblIdBarrio.TabIndex = 50;
            this.lblIdBarrio.Text = "IdBarrio:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(171, 471);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(217, 20);
            this.txtNroCalle.TabIndex = 41;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Location = new System.Drawing.Point(68, 474);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(88, 13);
            this.lblNroCalle.TabIndex = 49;
            this.lblNroCalle.Text = "Numero de Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(171, 434);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(217, 20);
            this.txtCalle.TabIndex = 40;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(123, 437);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 48;
            this.lblCalle.Text = "Calle:";
            // 
            // lblIdCargo
            // 
            this.lblIdCargo.AutoSize = true;
            this.lblIdCargo.Location = new System.Drawing.Point(109, 400);
            this.lblIdCargo.Name = "lblIdCargo";
            this.lblIdCargo.Size = new System.Drawing.Size(47, 13);
            this.lblIdCargo.TabIndex = 47;
            this.lblIdCargo.Text = "IdCargo:";
            // 
            // lblIdEgreso
            // 
            this.lblIdEgreso.AutoSize = true;
            this.lblIdEgreso.Location = new System.Drawing.Point(63, 363);
            this.lblIdEgreso.Name = "lblIdEgreso";
            this.lblIdEgreso.Size = new System.Drawing.Size(93, 13);
            this.lblIdEgreso.TabIndex = 45;
            this.lblIdEgreso.Text = "Motivo de Egreso:";
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Location = new System.Drawing.Point(65, 321);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(91, 13);
            this.lblFechaEgreso.TabIndex = 42;
            this.lblFechaEgreso.Text = "Fecha de Egreso:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(63, 282);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(93, 13);
            this.lblFechaIngreso.TabIndex = 39;
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(101, 203);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblIdUsuario.TabIndex = 37;
            this.lblIdUsuario.Text = "IdUsuario:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(171, 164);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(217, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(109, 167);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 34;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(171, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(109, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre:";
            // 
            // btLimpiarPersonal
            // 
            this.btLimpiarPersonal.Location = new System.Drawing.Point(228, 561);
            this.btLimpiarPersonal.Name = "btLimpiarPersonal";
            this.btLimpiarPersonal.Size = new System.Drawing.Size(185, 37);
            this.btLimpiarPersonal.TabIndex = 46;
            this.btLimpiarPersonal.Text = "Limpiar Datos";
            this.btLimpiarPersonal.UseVisualStyleBackColor = true;
            this.btLimpiarPersonal.Click += new System.EventHandler(this.btLimpiarPersonal_Click);
            // 
            // btAddPersonal
            // 
            this.btAddPersonal.Location = new System.Drawing.Point(14, 561);
            this.btAddPersonal.Name = "btAddPersonal";
            this.btAddPersonal.Size = new System.Drawing.Size(185, 37);
            this.btAddPersonal.TabIndex = 44;
            this.btAddPersonal.Text = "Guardar Datos";
            this.btAddPersonal.UseVisualStyleBackColor = true;
            this.btAddPersonal.Click += new System.EventHandler(this.btAddPersonal_Click);
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(33, 91);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(123, 13);
            this.lblNroDoc.TabIndex = 26;
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
            this.label_Empresa.TabIndex = 53;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // AltaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 617);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.lblTitleAdd);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.cmbEgreso);
            this.Controls.Add(this.cmbUsuario);
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
            this.Controls.Add(this.btLimpiarPersonal);
            this.Controls.Add(this.btAddPersonal);
            this.Controls.Add(this.lblNroDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Personal";
            this.Load += new System.EventHandler(this.AltaPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleAdd;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbEgreso;
        private System.Windows.Forms.ComboBox cmbUsuario;
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
        private System.Windows.Forms.Button btLimpiarPersonal;
        private System.Windows.Forms.Button btAddPersonal;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label label_Empresa;
    }
}