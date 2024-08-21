
namespace NewWare_Soft.Forms
{
    partial class Mod_MotivoEgreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mod_MotivoEgreso));
            this.gdrMotivosEgresos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreMotivo = new System.Windows.Forms.TextBox();
            this.lblNombreMotivo = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarMotivo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarMotivo = new System.Windows.Forms.Button();
            this.btnGuardarMotivo = new System.Windows.Forms.Button();
            this.label_Empresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMotivosEgresos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdrMotivosEgresos
            // 
            this.gdrMotivosEgresos.AllowUserToAddRows = false;
            this.gdrMotivosEgresos.AllowUserToDeleteRows = false;
            this.gdrMotivosEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrMotivosEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreMotivo});
            this.gdrMotivosEgresos.Location = new System.Drawing.Point(51, 22);
            this.gdrMotivosEgresos.Name = "gdrMotivosEgresos";
            this.gdrMotivosEgresos.ReadOnly = true;
            this.gdrMotivosEgresos.Size = new System.Drawing.Size(394, 131);
            this.gdrMotivosEgresos.TabIndex = 0;
            this.gdrMotivosEgresos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrMotivosEgresos_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdMotivoEgreso";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // NombreMotivo
            // 
            this.NombreMotivo.DataPropertyName = "NombreMotivoEgreso";
            this.NombreMotivo.HeaderText = "Nombre del motivo";
            this.NombreMotivo.Name = "NombreMotivo";
            this.NombreMotivo.ReadOnly = true;
            this.NombreMotivo.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificar un Motivo de Egreso";
            // 
            // txtNombreMotivo
            // 
            this.txtNombreMotivo.Enabled = false;
            this.txtNombreMotivo.Location = new System.Drawing.Point(177, 94);
            this.txtNombreMotivo.Name = "txtNombreMotivo";
            this.txtNombreMotivo.Size = new System.Drawing.Size(392, 20);
            this.txtNombreMotivo.TabIndex = 4;
            // 
            // lblNombreMotivo
            // 
            this.lblNombreMotivo.AutoSize = true;
            this.lblNombreMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMotivo.Location = new System.Drawing.Point(66, 93);
            this.lblNombreMotivo.Name = "lblNombreMotivo";
            this.lblNombreMotivo.Size = new System.Drawing.Size(105, 18);
            this.lblNombreMotivo.TabIndex = 3;
            this.lblNombreMotivo.Text = "Editar nombre:";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(162, 163);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(192, 23);
            this.txtNombreBuscar.TabIndex = 6;
            // 
            // lblBuscarMotivo
            // 
            this.lblBuscarMotivo.AutoSize = true;
            this.lblBuscarMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMotivo.Location = new System.Drawing.Point(48, 164);
            this.lblBuscarMotivo.Name = "lblBuscarMotivo";
            this.lblBuscarMotivo.Size = new System.Drawing.Size(108, 18);
            this.lblBuscarMotivo.TabIndex = 5;
            this.lblBuscarMotivo.Text = "Buscar motivo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarMotivo);
            this.groupBox1.Controls.Add(this.gdrMotivosEgresos);
            this.groupBox1.Controls.Add(this.txtNombreBuscar);
            this.groupBox1.Controls.Add(this.lblBuscarMotivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 205);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un motivo de la lista o busque por nombre";
            // 
            // btnBuscarMotivo
            // 
            this.btnBuscarMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMotivo.Location = new System.Drawing.Point(360, 163);
            this.btnBuscarMotivo.Name = "btnBuscarMotivo";
            this.btnBuscarMotivo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMotivo.TabIndex = 7;
            this.btnBuscarMotivo.Text = "Buscar";
            this.btnBuscarMotivo.UseVisualStyleBackColor = true;
            this.btnBuscarMotivo.Click += new System.EventHandler(this.btnBuscarMotivo_Click);
            // 
            // btnGuardarMotivo
            // 
            this.btnGuardarMotivo.Enabled = false;
            this.btnGuardarMotivo.Location = new System.Drawing.Point(177, 345);
            this.btnGuardarMotivo.Name = "btnGuardarMotivo";
            this.btnGuardarMotivo.Size = new System.Drawing.Size(268, 33);
            this.btnGuardarMotivo.TabIndex = 8;
            this.btnGuardarMotivo.Text = "Guardar cambio";
            this.btnGuardarMotivo.UseVisualStyleBackColor = true;
            this.btnGuardarMotivo.Click += new System.EventHandler(this.btnGuardarMotivo_Click);
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
            this.label_Empresa.TabIndex = 30;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // Mod_MotivoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 390);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.btnGuardarMotivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombreMotivo);
            this.Controls.Add(this.lblNombreMotivo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mod_MotivoEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Motivo de Egreso";
            this.Load += new System.EventHandler(this.Mod_MotivoEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrMotivosEgresos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdrMotivosEgresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreMotivo;
        private System.Windows.Forms.Label lblNombreMotivo;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label lblBuscarMotivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarMotivo;
        private System.Windows.Forms.Button btnGuardarMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMotivo;
        private System.Windows.Forms.Label label_Empresa;
    }
}