
namespace NewWare_Soft.Forms
{
    partial class AltaCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCiudad));
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLimiarCampos = new System.Windows.Forms.Button();
            this.grillaCiudades = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarCiudad = new System.Windows.Forms.Button();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Location = new System.Drawing.Point(138, 110);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(199, 20);
            this.txtNombreCiudad.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 109);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre ciudad:";
            // 
            // btnLimiarCampos
            // 
            this.btnLimiarCampos.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimiarCampos.Location = new System.Drawing.Point(28, 198);
            this.btnLimiarCampos.Name = "btnLimiarCampos";
            this.btnLimiarCampos.Size = new System.Drawing.Size(147, 36);
            this.btnLimiarCampos.TabIndex = 1;
            this.btnLimiarCampos.Text = "Limpiar Campos";
            this.btnLimiarCampos.UseVisualStyleBackColor = false;
            this.btnLimiarCampos.Click += new System.EventHandler(this.btnLimiarCampos_Click);
            // 
            // grillaCiudades
            // 
            this.grillaCiudades.AllowUserToAddRows = false;
            this.grillaCiudades.AllowUserToDeleteRows = false;
            this.grillaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.Pais});
            this.grillaCiudades.Location = new System.Drawing.Point(366, 76);
            this.grillaCiudades.Name = "grillaCiudades";
            this.grillaCiudades.ReadOnly = true;
            this.grillaCiudades.Size = new System.Drawing.Size(246, 243);
            this.grillaCiudades.TabIndex = 2;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "IdCiudad";
            this.Numero.HeaderText = "Id";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreCiudad";
            this.Nombre.HeaderText = "Nombre Ciudad";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            this.Pais.Width = 200;
            // 
            // btnAgregarCiudad
            // 
            this.btnAgregarCiudad.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarCiudad.Location = new System.Drawing.Point(190, 198);
            this.btnAgregarCiudad.Name = "btnAgregarCiudad";
            this.btnAgregarCiudad.Size = new System.Drawing.Size(147, 36);
            this.btnAgregarCiudad.TabIndex = 3;
            this.btnAgregarCiudad.Text = "Agregar Ciudad";
            this.btnAgregarCiudad.UseVisualStyleBackColor = false;
            this.btnAgregarCiudad.Click += new System.EventHandler(this.btnAgregarCiudad_Click);
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
            this.label_Empresa.TabIndex = 15;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(212, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Agregar Nuevo Barrio";
            // 
            // AltaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 331);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCiudad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregarCiudad);
            this.Controls.Add(this.grillaCiudades);
            this.Controls.Add(this.btnLimiarCampos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Ciudad";
            this.Load += new System.EventHandler(this.AltaCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimiarCampos;
        private System.Windows.Forms.DataGridView grillaCiudades;
        private System.Windows.Forms.Button btnAgregarCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.Label label1;
    }
}