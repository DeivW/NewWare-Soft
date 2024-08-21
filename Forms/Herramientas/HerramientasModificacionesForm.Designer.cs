
namespace NewWare_Soft.Forms.Herramientas
{
    partial class HerramientasModificacionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HerramientasModificacionesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarHerramienta = new System.Windows.Forms.Button();
            this.gdrHerramientas = new System.Windows.Forms.DataGridView();
            this.IdHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionHerramienta = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNomHerramienta = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.label_Empresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Modificar una Herramienta";
            // 
            // btnModificarHerramienta
            // 
            this.btnModificarHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHerramienta.Location = new System.Drawing.Point(317, 183);
            this.btnModificarHerramienta.Name = "btnModificarHerramienta";
            this.btnModificarHerramienta.Size = new System.Drawing.Size(180, 35);
            this.btnModificarHerramienta.TabIndex = 20;
            this.btnModificarHerramienta.Text = "Modificar Herramienta";
            this.btnModificarHerramienta.UseVisualStyleBackColor = true;
            this.btnModificarHerramienta.Click += new System.EventHandler(this.btnModificarHerramienta_Click);
            // 
            // gdrHerramientas
            // 
            this.gdrHerramientas.AllowUserToAddRows = false;
            this.gdrHerramientas.AllowUserToDeleteRows = false;
            this.gdrHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrHerramientas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHerramienta,
            this.NombreHerramienta,
            this.DescripcionHerramienta});
            this.gdrHerramientas.Location = new System.Drawing.Point(12, 224);
            this.gdrHerramientas.Name = "gdrHerramientas";
            this.gdrHerramientas.ReadOnly = true;
            this.gdrHerramientas.Size = new System.Drawing.Size(542, 150);
            this.gdrHerramientas.TabIndex = 19;
            this.gdrHerramientas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrHerramientas_CellClick);
            // 
            // IdHerramienta
            // 
            this.IdHerramienta.DataPropertyName = "IdHerramienta";
            this.IdHerramienta.HeaderText = "Id";
            this.IdHerramienta.Name = "IdHerramienta";
            this.IdHerramienta.ReadOnly = true;
            this.IdHerramienta.Width = 30;
            // 
            // NombreHerramienta
            // 
            this.NombreHerramienta.DataPropertyName = "Nombre";
            this.NombreHerramienta.HeaderText = "Nombre";
            this.NombreHerramienta.Name = "NombreHerramienta";
            this.NombreHerramienta.ReadOnly = true;
            this.NombreHerramienta.Width = 150;
            // 
            // DescripcionHerramienta
            // 
            this.DescripcionHerramienta.DataPropertyName = "Descripcion";
            this.DescripcionHerramienta.HeaderText = "Descripción";
            this.DescripcionHerramienta.Name = "DescripcionHerramienta";
            this.DescripcionHerramienta.ReadOnly = true;
            this.DescripcionHerramienta.Width = 300;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(213, 111);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(316, 54);
            this.txtDescripcion.TabIndex = 15;
            // 
            // lblDescripcionHerramienta
            // 
            this.lblDescripcionHerramienta.AutoSize = true;
            this.lblDescripcionHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionHerramienta.Location = new System.Drawing.Point(14, 111);
            this.lblDescripcionHerramienta.Name = "lblDescripcionHerramienta";
            this.lblDescripcionHerramienta.Size = new System.Drawing.Size(191, 18);
            this.lblDescripcionHerramienta.TabIndex = 18;
            this.lblDescripcionHerramienta.Text = "Descripcion de Heramienta:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(213, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(316, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNomHerramienta
            // 
            this.lblNomHerramienta.AutoSize = true;
            this.lblNomHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomHerramienta.Location = new System.Drawing.Point(21, 77);
            this.lblNomHerramienta.Name = "lblNomHerramienta";
            this.lblNomHerramienta.Size = new System.Drawing.Size(186, 18);
            this.lblNomHerramienta.TabIndex = 17;
            this.lblNomHerramienta.Text = "Nombre de la Herramienta:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(69, 183);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(180, 35);
            this.btnLimpiarCampos.TabIndex = 22;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
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
            // HerramientasModificacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 383);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificarHerramienta);
            this.Controls.Add(this.gdrHerramientas);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcionHerramienta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNomHerramienta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HerramientasModificacionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificaciones Herramientas ";
            this.Load += new System.EventHandler(this.HerramientasModificacionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarHerramienta;
        private System.Windows.Forms.DataGridView gdrHerramientas;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcionHerramienta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNomHerramienta;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHerramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHerramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionHerramienta;
        private System.Windows.Forms.Label label_Empresa;
    }
}