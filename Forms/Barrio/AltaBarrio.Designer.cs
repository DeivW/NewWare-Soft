
namespace NewWare_Soft.Forms
{
    partial class AltaBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaBarrio));
            this.grillaBarrios = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarBarrio = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Empresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaBarrios
            // 
            this.grillaBarrios.AllowUserToAddRows = false;
            this.grillaBarrios.AllowUserToDeleteRows = false;
            this.grillaBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre});
            this.grillaBarrios.Location = new System.Drawing.Point(375, 77);
            this.grillaBarrios.Name = "grillaBarrios";
            this.grillaBarrios.ReadOnly = true;
            this.grillaBarrios.Size = new System.Drawing.Size(246, 243);
            this.grillaBarrios.TabIndex = 4;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "IdBarrio";
            this.Numero.HeaderText = "Nro";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreBarrio";
            this.Nombre.HeaderText = "NombreBarrio";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // btnAgregarBarrio
            // 
            this.btnAgregarBarrio.Location = new System.Drawing.Point(206, 219);
            this.btnAgregarBarrio.Name = "btnAgregarBarrio";
            this.btnAgregarBarrio.Size = new System.Drawing.Size(147, 36);
            this.btnAgregarBarrio.TabIndex = 5;
            this.btnAgregarBarrio.Text = "Agregar Barrio";
            this.btnAgregarBarrio.UseVisualStyleBackColor = true;
            this.btnAgregarBarrio.Click += new System.EventHandler(this.btnAgregarBarrio_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(18, 219);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(147, 36);
            this.btnLimpiarCampos.TabIndex = 6;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(90, 136);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(58, 18);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre barrio:";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Location = new System.Drawing.Point(154, 98);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(199, 20);
            this.txtNombreBarrio.TabIndex = 4;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownHeight = 100;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.DropDownWidth = 100;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.IntegralHeight = false;
            this.cmbCiudad.ItemHeight = 13;
            this.cmbCiudad.Location = new System.Drawing.Point(154, 137);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(199, 21);
            this.cmbCiudad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(220, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agregar Nuevo Barrio";
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
            this.label_Empresa.TabIndex = 13;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // AltaBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 332);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtNombreBarrio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregarBarrio);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.grillaBarrios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Barrio";
            this.Load += new System.EventHandler(this.AltaBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaBarrios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grillaBarrios;
        private System.Windows.Forms.Button btnAgregarBarrio;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Empresa;
    }
}