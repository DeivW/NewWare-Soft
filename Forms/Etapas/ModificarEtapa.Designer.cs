
namespace NewWare_Soft.Forms
{
    partial class ModificarEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEtapa));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvEtapas = new System.Windows.Forms.DataGridView();
            this.NroEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label_Empresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(166, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 37);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Modificar una Etapa";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEtapas
            // 
            this.dgvEtapas.AllowUserToAddRows = false;
            this.dgvEtapas.AllowUserToDeleteRows = false;
            this.dgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroEtapa,
            this.NombreEtapa});
            this.dgvEtapas.Location = new System.Drawing.Point(45, 106);
            this.dgvEtapas.Name = "dgvEtapas";
            this.dgvEtapas.ReadOnly = true;
            this.dgvEtapas.Size = new System.Drawing.Size(443, 150);
            this.dgvEtapas.TabIndex = 9;
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
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(125, 262);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(275, 29);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(102, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 12;
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
            this.label_Empresa.TabIndex = 63;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // ModificarEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 303);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvEtapas);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarEtapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Etapa";
            this.Load += new System.EventHandler(this.ModificarEtapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEtapas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEtapa;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label_Empresa;
    }
}