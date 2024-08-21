
namespace NewWare_Soft.Forms
{
    partial class BajaCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaCiudad));
            this.txtIdCiudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grillaCiudades = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimiarCampos = new System.Windows.Forms.Button();
            this.btnBajaCiudad = new System.Windows.Forms.Button();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCiudad
            // 
            this.txtIdCiudad.Enabled = false;
            this.txtIdCiudad.Location = new System.Drawing.Point(143, 113);
            this.txtIdCiudad.Name = "txtIdCiudad";
            this.txtIdCiudad.Size = new System.Drawing.Size(44, 20);
            this.txtIdCiudad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Ciudad:";
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Enabled = false;
            this.txtNombreCiudad.Location = new System.Drawing.Point(143, 79);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(199, 20);
            this.txtNombreCiudad.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(116, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Ciudad:";
            // 
            // grillaCiudades
            // 
            this.grillaCiudades.AllowUserToAddRows = false;
            this.grillaCiudades.AllowUserToDeleteRows = false;
            this.grillaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre});
            this.grillaCiudades.Location = new System.Drawing.Point(370, 78);
            this.grillaCiudades.Name = "grillaCiudades";
            this.grillaCiudades.ReadOnly = true;
            this.grillaCiudades.Size = new System.Drawing.Size(246, 243);
            this.grillaCiudades.TabIndex = 4;
            this.grillaCiudades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaCiudades_CellClick);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "IdCiudad";
            this.Numero.HeaderText = "Nro";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreCiudad";
            this.Nombre.HeaderText = "NombreCiudad";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // btnLimiarCampos
            // 
            this.btnLimiarCampos.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimiarCampos.Location = new System.Drawing.Point(12, 161);
            this.btnLimiarCampos.Name = "btnLimiarCampos";
            this.btnLimiarCampos.Size = new System.Drawing.Size(160, 38);
            this.btnLimiarCampos.TabIndex = 5;
            this.btnLimiarCampos.Text = "Limpiar Campos";
            this.btnLimiarCampos.UseVisualStyleBackColor = false;
            this.btnLimiarCampos.Click += new System.EventHandler(this.btnLimiarCampos_Click);
            // 
            // btnBajaCiudad
            // 
            this.btnBajaCiudad.BackColor = System.Drawing.SystemColors.Control;
            this.btnBajaCiudad.Enabled = false;
            this.btnBajaCiudad.Location = new System.Drawing.Point(195, 161);
            this.btnBajaCiudad.Name = "btnBajaCiudad";
            this.btnBajaCiudad.Size = new System.Drawing.Size(160, 38);
            this.btnBajaCiudad.TabIndex = 6;
            this.btnBajaCiudad.TabStop = false;
            this.btnBajaCiudad.Text = "Borrar Ciudad";
            this.btnBajaCiudad.UseVisualStyleBackColor = false;
            this.btnBajaCiudad.Click += new System.EventHandler(this.btnBajaCiudad_Click);
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
            this.label_Empresa.TabIndex = 59;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Eliminar una Ciudad";
            // 
            // BajaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 333);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCiudad);
            this.Controls.Add(this.btnBajaCiudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimiarCampos);
            this.Controls.Add(this.txtNombreCiudad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.grillaCiudades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BajaCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Ciudad";
            this.Load += new System.EventHandler(this.BajaCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView grillaCiudades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnLimiarCampos;
        private System.Windows.Forms.Button btnBajaCiudad;
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.Label label2;
    }
}