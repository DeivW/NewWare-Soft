﻿
namespace NewWare_Soft.Forms
{
    partial class Mod_Banco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mod_Banco));
            this.btnGuardarBanco = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarBanco = new System.Windows.Forms.Button();
            this.gdrBancos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarBanco = new System.Windows.Forms.Label();
            this.txtNombreBanco = new System.Windows.Forms.TextBox();
            this.lblNombreBanco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBancos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarBanco
            // 
            this.btnGuardarBanco.Enabled = false;
            this.btnGuardarBanco.Location = new System.Drawing.Point(194, 340);
            this.btnGuardarBanco.Name = "btnGuardarBanco";
            this.btnGuardarBanco.Size = new System.Drawing.Size(264, 33);
            this.btnGuardarBanco.TabIndex = 13;
            this.btnGuardarBanco.Text = "Guardar cambio";
            this.btnGuardarBanco.UseVisualStyleBackColor = true;
            this.btnGuardarBanco.Click += new System.EventHandler(this.btnGuardarBanco_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarBanco);
            this.groupBox1.Controls.Add(this.gdrBancos);
            this.groupBox1.Controls.Add(this.txtNombreBuscar);
            this.groupBox1.Controls.Add(this.lblBuscarBanco);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 205);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un banco de la lista o busque por nombre";
            // 
            // btnBuscarBanco
            // 
            this.btnBuscarBanco.Location = new System.Drawing.Point(360, 163);
            this.btnBuscarBanco.Name = "btnBuscarBanco";
            this.btnBuscarBanco.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBanco.TabIndex = 7;
            this.btnBuscarBanco.Text = "Buscar";
            this.btnBuscarBanco.UseVisualStyleBackColor = true;
            this.btnBuscarBanco.Click += new System.EventHandler(this.btnBuscarBanco_Click);
            // 
            // gdrBancos
            // 
            this.gdrBancos.AllowUserToAddRows = false;
            this.gdrBancos.AllowUserToDeleteRows = false;
            this.gdrBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrBancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreBanco});
            this.gdrBancos.Location = new System.Drawing.Point(51, 22);
            this.gdrBancos.Name = "gdrBancos";
            this.gdrBancos.ReadOnly = true;
            this.gdrBancos.Size = new System.Drawing.Size(399, 131);
            this.gdrBancos.TabIndex = 0;
            this.gdrBancos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrBancos_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdBanco";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // NombreBanco
            // 
            this.NombreBanco.DataPropertyName = "Nombre";
            this.NombreBanco.HeaderText = "Nombre del banco";
            this.NombreBanco.Name = "NombreBanco";
            this.NombreBanco.ReadOnly = true;
            this.NombreBanco.Width = 300;
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(162, 163);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(192, 23);
            this.txtNombreBuscar.TabIndex = 6;
            // 
            // lblBuscarBanco
            // 
            this.lblBuscarBanco.AutoSize = true;
            this.lblBuscarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarBanco.Location = new System.Drawing.Point(48, 164);
            this.lblBuscarBanco.Name = "lblBuscarBanco";
            this.lblBuscarBanco.Size = new System.Drawing.Size(104, 18);
            this.lblBuscarBanco.TabIndex = 5;
            this.lblBuscarBanco.Text = "Buscar banco:";
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.Enabled = false;
            this.txtNombreBanco.Location = new System.Drawing.Point(194, 88);
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(235, 20);
            this.txtNombreBanco.TabIndex = 11;
            // 
            // lblNombreBanco
            // 
            this.lblNombreBanco.AutoSize = true;
            this.lblNombreBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBanco.Location = new System.Drawing.Point(83, 87);
            this.lblNombreBanco.Name = "lblNombreBanco";
            this.lblNombreBanco.Size = new System.Drawing.Size(105, 18);
            this.lblNombreBanco.TabIndex = 10;
            this.lblNombreBanco.Text = "Editar nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modificar un Banco";
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
            this.label_Empresa.TabIndex = 28;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // Mod_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 385);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.btnGuardarBanco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombreBanco);
            this.Controls.Add(this.lblNombreBanco);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mod_Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Banco";
            this.Load += new System.EventHandler(this.Mod_Banco_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBancos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarBanco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarBanco;
        private System.Windows.Forms.DataGridView gdrBancos;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label lblBuscarBanco;
        private System.Windows.Forms.TextBox txtNombreBanco;
        private System.Windows.Forms.Label lblNombreBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBanco;
        private System.Windows.Forms.Label label_Empresa;
    }
}