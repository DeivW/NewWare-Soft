
namespace NewWare_Soft.Forms
{
    partial class PersonalXEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalXEtapa));
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEtapa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProyecto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnTransaccion = new System.Windows.Forms.Button();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gdrPersonal = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarPersonaGrilla = new System.Windows.Forms.Button();
            this.txtFechaFinal = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdCargo = new System.Windows.Forms.TextBox();
            this.txtNombrePersonal = new System.Windows.Forms.TextBox();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmarEtapaxProyecto = new System.Windows.Forms.Button();
            this.chkEtapa = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Etapa:";
            // 
            // cmbEtapa
            // 
            this.cmbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtapa.FormattingEnabled = true;
            this.cmbEtapa.Location = new System.Drawing.Point(270, 123);
            this.cmbEtapa.Name = "cmbEtapa";
            this.cmbEtapa.Size = new System.Drawing.Size(121, 21);
            this.cmbEtapa.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(222, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Personal por Etapa de Proyecto";
            // 
            // cmbProyecto
            // 
            this.cmbProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyecto.FormattingEnabled = true;
            this.cmbProyecto.Location = new System.Drawing.Point(128, 124);
            this.cmbProyecto.Name = "cmbProyecto";
            this.cmbProyecto.Size = new System.Drawing.Size(76, 21);
            this.cmbProyecto.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Proyecto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtFechaInicio);
            this.groupBox3.Controls.Add(this.btnLimpiarCampos);
            this.groupBox3.Controls.Add(this.btnTransaccion);
            this.groupBox3.Controls.Add(this.txtHoras);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.gdrPersonal);
            this.groupBox3.Controls.Add(this.btnAgregarPersonaGrilla);
            this.groupBox3.Controls.Add(this.txtFechaFinal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtIdCargo);
            this.groupBox3.Controls.Add(this.txtNombrePersonal);
            this.groupBox3.Controls.Add(this.btnBuscarPersonal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtLegajo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(44, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 451);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(281, 63);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 20);
            this.txtApellido.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellido:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Location = new System.Drawing.Point(145, 101);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(54, 20);
            this.txtFechaInicio.TabIndex = 30;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(145, 131);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(81, 34);
            this.btnLimpiarCampos.TabIndex = 16;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaccion.Location = new System.Drawing.Point(472, 384);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(81, 52);
            this.btnTransaccion.TabIndex = 29;
            this.btnTransaccion.Text = "Agregar Personal a Etapa";
            this.btnTransaccion.UseVisualStyleBackColor = true;
            this.btnTransaccion.Click += new System.EventHandler(this.btnTransaccion_Click);
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(574, 101);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(55, 20);
            this.txtHoras.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(429, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ingresar Cant. Horas:";
            // 
            // gdrPersonal
            // 
            this.gdrPersonal.AllowUserToAddRows = false;
            this.gdrPersonal.AllowUserToDeleteRows = false;
            this.gdrPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.FechaIni,
            this.FechaFin,
            this.IdCargo,
            this.CantHoras});
            this.gdrPersonal.Location = new System.Drawing.Point(18, 184);
            this.gdrPersonal.Name = "gdrPersonal";
            this.gdrPersonal.ReadOnly = true;
            this.gdrPersonal.Size = new System.Drawing.Size(436, 252);
            this.gdrPersonal.TabIndex = 26;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // FechaIni
            // 
            this.FechaIni.HeaderText = "Fecha Ini. Part.";
            this.FechaIni.Name = "FechaIni";
            this.FechaIni.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha Fin Part.";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // IdCargo
            // 
            this.IdCargo.HeaderText = "Id Cargo";
            this.IdCargo.Name = "IdCargo";
            this.IdCargo.ReadOnly = true;
            this.IdCargo.Width = 40;
            // 
            // CantHoras
            // 
            this.CantHoras.HeaderText = "Horas";
            this.CantHoras.Name = "CantHoras";
            this.CantHoras.ReadOnly = true;
            this.CantHoras.Width = 50;
            // 
            // btnAgregarPersonaGrilla
            // 
            this.btnAgregarPersonaGrilla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarPersonaGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPersonaGrilla.Location = new System.Drawing.Point(18, 131);
            this.btnAgregarPersonaGrilla.Name = "btnAgregarPersonaGrilla";
            this.btnAgregarPersonaGrilla.Size = new System.Drawing.Size(107, 34);
            this.btnAgregarPersonaGrilla.TabIndex = 25;
            this.btnAgregarPersonaGrilla.Text = "Agregar Personal a grilla";
            this.btnAgregarPersonaGrilla.UseVisualStyleBackColor = true;
            this.btnAgregarPersonaGrilla.Click += new System.EventHandler(this.btnAgregarPersonaGrilla_Click);
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.Location = new System.Drawing.Point(355, 101);
            this.txtFechaFinal.Mask = "00/00/0000";
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(68, 20);
            this.txtFechaFinal.TabIndex = 24;
            this.txtFechaFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(209, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ingrese Fecha Final:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ingrese Fecha Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Id Cargo:";
            // 
            // txtIdCargo
            // 
            this.txtIdCargo.Enabled = false;
            this.txtIdCargo.Location = new System.Drawing.Point(503, 61);
            this.txtIdCargo.Name = "txtIdCargo";
            this.txtIdCargo.Size = new System.Drawing.Size(26, 20);
            this.txtIdCargo.TabIndex = 16;
            // 
            // txtNombrePersonal
            // 
            this.txtNombrePersonal.Enabled = false;
            this.txtNombrePersonal.Location = new System.Drawing.Point(78, 61);
            this.txtNombrePersonal.Name = "txtNombrePersonal";
            this.txtNombrePersonal.Size = new System.Drawing.Size(125, 20);
            this.txtNombrePersonal.TabIndex = 19;
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPersonal.Location = new System.Drawing.Point(192, 15);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(81, 37);
            this.btnBuscarPersonal.TabIndex = 17;
            this.btnBuscarPersonal.Text = "Buscar Personal";
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ingresar Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(131, 24);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(55, 20);
            this.txtLegajo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nombre:";
            // 
            // btnConfirmarEtapaxProyecto
            // 
            this.btnConfirmarEtapaxProyecto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConfirmarEtapaxProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnConfirmarEtapaxProyecto.Location = new System.Drawing.Point(417, 120);
            this.btnConfirmarEtapaxProyecto.Name = "btnConfirmarEtapaxProyecto";
            this.btnConfirmarEtapaxProyecto.Size = new System.Drawing.Size(68, 26);
            this.btnConfirmarEtapaxProyecto.TabIndex = 33;
            this.btnConfirmarEtapaxProyecto.Text = "Confirmar ";
            this.btnConfirmarEtapaxProyecto.UseVisualStyleBackColor = true;
            this.btnConfirmarEtapaxProyecto.Click += new System.EventHandler(this.btnConfirmarEtapaxProyecto_Click);
            // 
            // chkEtapa
            // 
            this.chkEtapa.AutoSize = true;
            this.chkEtapa.Enabled = false;
            this.chkEtapa.Location = new System.Drawing.Point(501, 125);
            this.chkEtapa.Name = "chkEtapa";
            this.chkEtapa.Size = new System.Drawing.Size(158, 17);
            this.chkEtapa.TabIndex = 34;
            this.chkEtapa.Text = "Etapa pertenece a proyecto";
            this.chkEtapa.UseVisualStyleBackColor = true;
            // 
            // PersonalXEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 610);
            this.Controls.Add(this.chkEtapa);
            this.Controls.Add(this.btnConfirmarEtapaxProyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProyecto);
            this.Controls.Add(this.cmbEtapa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalXEtapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPersonalXEtapa";
            this.Load += new System.EventHandler(this.PersonalXEtapa_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombrePersonal;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView gdrPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantHoras;
        private System.Windows.Forms.Button btnAgregarPersonaGrilla;
        private System.Windows.Forms.MaskedTextBox txtFechaFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdCargo;
        private System.Windows.Forms.Button btnTransaccion;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEtapa;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.Button btnConfirmarEtapaxProyecto;
        private System.Windows.Forms.CheckBox chkEtapa;
    }
}