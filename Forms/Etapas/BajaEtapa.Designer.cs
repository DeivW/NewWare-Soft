
namespace NewWare_Soft.Forms
{
    partial class BajaEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaEtapa));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvEtapas = new System.Windows.Forms.DataGridView();
            this.NroEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label_Empresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(117, 252);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(249, 23);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvEtapas
            // 
            this.dgvEtapas.AllowUserToAddRows = false;
            this.dgvEtapas.AllowUserToDeleteRows = false;
            this.dgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroEtapa,
            this.NombreEtapa});
            this.dgvEtapas.Location = new System.Drawing.Point(18, 84);
            this.dgvEtapas.Name = "dgvEtapas";
            this.dgvEtapas.ReadOnly = true;
            this.dgvEtapas.Size = new System.Drawing.Size(443, 150);
            this.dgvEtapas.TabIndex = 8;
            this.dgvEtapas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapas_CellClick);
            // 
            // NroEtapa
            // 
            this.NroEtapa.DataPropertyName = "IdEtapa";
            this.NroEtapa.HeaderText = "Nro Etapa";
            this.NroEtapa.Name = "NroEtapa";
            this.NroEtapa.ReadOnly = true;
            // 
            // NombreEtapa
            // 
            this.NombreEtapa.DataPropertyName = "NombreEtapa";
            this.NombreEtapa.HeaderText = "Nombre Etapa";
            this.NombreEtapa.Name = "NombreEtapa";
            this.NombreEtapa.ReadOnly = true;
            this.NombreEtapa.Width = 300;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 28);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Eliminar una Etapa";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // BajaEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 287);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvEtapas);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BajaEtapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Etapa";
            this.Load += new System.EventHandler(this.BajaEtapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dgvEtapas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEtapa;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label_Empresa;
    }
}