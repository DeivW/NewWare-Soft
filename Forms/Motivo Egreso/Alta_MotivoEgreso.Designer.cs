
namespace NewWare_Soft.Forms
{
    partial class Alta_MotivoEgreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_MotivoEgreso));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreMotivo = new System.Windows.Forms.Label();
            this.txtNombreMotivo = new System.Windows.Forms.TextBox();
            this.btnAgregarMotivo = new System.Windows.Forms.Button();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Nuevo Motivo de Egreso";
            // 
            // lblNombreMotivo
            // 
            this.lblNombreMotivo.AutoSize = true;
            this.lblNombreMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMotivo.Location = new System.Drawing.Point(31, 105);
            this.lblNombreMotivo.Name = "lblNombreMotivo";
            this.lblNombreMotivo.Size = new System.Drawing.Size(138, 18);
            this.lblNombreMotivo.TabIndex = 1;
            this.lblNombreMotivo.Text = "Nombre del motivo:";
            // 
            // txtNombreMotivo
            // 
            this.txtNombreMotivo.Location = new System.Drawing.Point(175, 105);
            this.txtNombreMotivo.Name = "txtNombreMotivo";
            this.txtNombreMotivo.Size = new System.Drawing.Size(235, 20);
            this.txtNombreMotivo.TabIndex = 2;
            // 
            // btnAgregarMotivo
            // 
            this.btnAgregarMotivo.Location = new System.Drawing.Point(99, 150);
            this.btnAgregarMotivo.Name = "btnAgregarMotivo";
            this.btnAgregarMotivo.Size = new System.Drawing.Size(246, 23);
            this.btnAgregarMotivo.TabIndex = 3;
            this.btnAgregarMotivo.Text = "Agregar motivo";
            this.btnAgregarMotivo.UseVisualStyleBackColor = true;
            this.btnAgregarMotivo.Click += new System.EventHandler(this.btnAgregarMotivo_Click);
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
            this.label_Empresa.TabIndex = 10;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // Alta_MotivoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 185);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.btnAgregarMotivo);
            this.Controls.Add(this.txtNombreMotivo);
            this.Controls.Add(this.lblNombreMotivo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alta_MotivoEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Motivo de Egreso";
            this.Load += new System.EventHandler(this.Alta_MotivoEgreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreMotivo;
        private System.Windows.Forms.TextBox txtNombreMotivo;
        private System.Windows.Forms.Button btnAgregarMotivo;
        private System.Windows.Forms.Label label_Empresa;
    }
}