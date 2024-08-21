
namespace NewWare_Soft.Forms
{
    partial class Alta_Cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Cargo));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCargo = new System.Windows.Forms.Label();
            this.lblDescripcionCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtDescripcionCargo = new System.Windows.Forms.TextBox();
            this.btnAltaPersona = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grillaListaCargos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaListaCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(317, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Nuevo Usuario";
            // 
            // lblNombreCargo
            // 
            this.lblNombreCargo.AutoSize = true;
            this.lblNombreCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCargo.Location = new System.Drawing.Point(37, 80);
            this.lblNombreCargo.Name = "lblNombreCargo";
            this.lblNombreCargo.Size = new System.Drawing.Size(131, 18);
            this.lblNombreCargo.TabIndex = 1;
            this.lblNombreCargo.Text = "Nombre de Cargo:";
            // 
            // lblDescripcionCargo
            // 
            this.lblDescripcionCargo.AutoSize = true;
            this.lblDescripcionCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCargo.Location = new System.Drawing.Point(9, 108);
            this.lblDescripcionCargo.Name = "lblDescripcionCargo";
            this.lblDescripcionCargo.Size = new System.Drawing.Size(159, 18);
            this.lblDescripcionCargo.TabIndex = 3;
            this.lblDescripcionCargo.Text = "Descripcion del Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(174, 81);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(219, 20);
            this.txtCargo.TabIndex = 4;
            // 
            // txtDescripcionCargo
            // 
            this.txtDescripcionCargo.Location = new System.Drawing.Point(174, 109);
            this.txtDescripcionCargo.Multiline = true;
            this.txtDescripcionCargo.Name = "txtDescripcionCargo";
            this.txtDescripcionCargo.Size = new System.Drawing.Size(219, 134);
            this.txtDescripcionCargo.TabIndex = 5;
            // 
            // btnAltaPersona
            // 
            this.btnAltaPersona.Location = new System.Drawing.Point(221, 315);
            this.btnAltaPersona.Name = "btnAltaPersona";
            this.btnAltaPersona.Size = new System.Drawing.Size(160, 38);
            this.btnAltaPersona.TabIndex = 6;
            this.btnAltaPersona.Text = "Alta Persona";
            this.btnAltaPersona.UseVisualStyleBackColor = true;
            this.btnAltaPersona.Click += new System.EventHandler(this.btnAltaPersona_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(18, 315);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(160, 38);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grillaListaCargos);
            this.groupBox1.Location = new System.Drawing.Point(399, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 356);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Cargos";
            // 
            // grillaListaCargos
            // 
            this.grillaListaCargos.AllowUserToAddRows = false;
            this.grillaListaCargos.AllowUserToDeleteRows = false;
            this.grillaListaCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaListaCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion});
            this.grillaListaCargos.Location = new System.Drawing.Point(7, 19);
            this.grillaListaCargos.Name = "grillaListaCargos";
            this.grillaListaCargos.ReadOnly = true;
            this.grillaListaCargos.Size = new System.Drawing.Size(492, 330);
            this.grillaListaCargos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdCargo";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
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
            this.label_Empresa.TabIndex = 9;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // Alta_Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 442);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAltaPersona);
            this.Controls.Add(this.txtDescripcionCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblDescripcionCargo);
            this.Controls.Add(this.lblNombreCargo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alta_Cargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Nuevo Usuario";
            this.Load += new System.EventHandler(this.Alta_Cargo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaListaCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCargo;
        private System.Windows.Forms.Label lblDescripcionCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtDescripcionCargo;
        private System.Windows.Forms.Button btnAltaPersona;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grillaListaCargos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label label_Empresa;
    }
}