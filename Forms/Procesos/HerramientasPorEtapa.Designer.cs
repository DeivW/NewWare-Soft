
namespace NewWare_Soft.Forms
{
    partial class HerramientasPorEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HerramientasPorEtapa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodProyecto = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEtapas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHerramientas = new System.Windows.Forms.ComboBox();
            this.btnAgregarHerramienta = new System.Windows.Forms.Button();
            this.gdrHerramientas = new System.Windows.Forms.DataGridView();
            this.idHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarHxE = new System.Windows.Forms.Button();
            this.txtDescProyecto = new System.Windows.Forms.TextBox();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Herramientas por etapa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de proyecto:";
            // 
            // txtCodProyecto
            // 
            this.txtCodProyecto.Location = new System.Drawing.Point(154, 66);
            this.txtCodProyecto.Mask = "9999";
            this.txtCodProyecto.Name = "txtCodProyecto";
            this.txtCodProyecto.Size = new System.Drawing.Size(35, 20);
            this.txtCodProyecto.TabIndex = 2;
            this.txtCodProyecto.ValidatingType = typeof(int);
            this.txtCodProyecto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCodProyecto_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Etapas del proyecto:";
            // 
            // cmbEtapas
            // 
            this.cmbEtapas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtapas.Enabled = false;
            this.cmbEtapas.FormattingEnabled = true;
            this.cmbEtapas.Location = new System.Drawing.Point(153, 130);
            this.cmbEtapas.Name = "cmbEtapas";
            this.cmbEtapas.Size = new System.Drawing.Size(121, 21);
            this.cmbEtapas.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHerramientas);
            this.groupBox1.Controls.Add(this.btnAgregarHerramienta);
            this.groupBox1.Controls.Add(this.gdrHerramientas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 219);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione las herramientas a agregar";
            // 
            // cmbHerramientas
            // 
            this.cmbHerramientas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHerramientas.Enabled = false;
            this.cmbHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHerramientas.FormattingEnabled = true;
            this.cmbHerramientas.Location = new System.Drawing.Point(198, 26);
            this.cmbHerramientas.Name = "cmbHerramientas";
            this.cmbHerramientas.Size = new System.Drawing.Size(148, 23);
            this.cmbHerramientas.TabIndex = 7;
            // 
            // btnAgregarHerramienta
            // 
            this.btnAgregarHerramienta.Enabled = false;
            this.btnAgregarHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHerramienta.Location = new System.Drawing.Point(352, 25);
            this.btnAgregarHerramienta.Name = "btnAgregarHerramienta";
            this.btnAgregarHerramienta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHerramienta.TabIndex = 6;
            this.btnAgregarHerramienta.Text = "Agregar";
            this.btnAgregarHerramienta.UseVisualStyleBackColor = true;
            this.btnAgregarHerramienta.Click += new System.EventHandler(this.btnAgregarHerramienta_Click);
            // 
            // gdrHerramientas
            // 
            this.gdrHerramientas.AllowUserToAddRows = false;
            this.gdrHerramientas.AllowUserToDeleteRows = false;
            this.gdrHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrHerramientas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHerramienta,
            this.nombreHerramienta,
            this.descHerramienta});
            this.gdrHerramientas.Location = new System.Drawing.Point(31, 56);
            this.gdrHerramientas.Name = "gdrHerramientas";
            this.gdrHerramientas.ReadOnly = true;
            this.gdrHerramientas.Size = new System.Drawing.Size(395, 145);
            this.gdrHerramientas.TabIndex = 5;
            // 
            // idHerramienta
            // 
            this.idHerramienta.HeaderText = "ID";
            this.idHerramienta.Name = "idHerramienta";
            this.idHerramienta.ReadOnly = true;
            this.idHerramienta.Width = 50;
            // 
            // nombreHerramienta
            // 
            this.nombreHerramienta.HeaderText = "Nombre";
            this.nombreHerramienta.Name = "nombreHerramienta";
            this.nombreHerramienta.ReadOnly = true;
            // 
            // descHerramienta
            // 
            this.descHerramienta.HeaderText = "Descripción";
            this.descHerramienta.Name = "descHerramienta";
            this.descHerramienta.ReadOnly = true;
            this.descHerramienta.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccionar herramienta:";
            // 
            // btnGuardarHxE
            // 
            this.btnGuardarHxE.Enabled = false;
            this.btnGuardarHxE.Location = new System.Drawing.Point(355, 389);
            this.btnGuardarHxE.Name = "btnGuardarHxE";
            this.btnGuardarHxE.Size = new System.Drawing.Size(92, 36);
            this.btnGuardarHxE.TabIndex = 6;
            this.btnGuardarHxE.Text = "Guardar";
            this.btnGuardarHxE.UseVisualStyleBackColor = true;
            this.btnGuardarHxE.Click += new System.EventHandler(this.btnGuardarHxE_Click);
            // 
            // txtDescProyecto
            // 
            this.txtDescProyecto.Enabled = false;
            this.txtDescProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProyecto.Location = new System.Drawing.Point(104, 95);
            this.txtDescProyecto.Name = "txtDescProyecto";
            this.txtDescProyecto.Size = new System.Drawing.Size(376, 21);
            this.txtDescProyecto.TabIndex = 10;
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProyecto.Location = new System.Drawing.Point(199, 63);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProyecto.TabIndex = 9;
            this.btnBuscarProyecto.Text = "Buscar";
            this.btnBuscarProyecto.UseVisualStyleBackColor = true;
            this.btnBuscarProyecto.Click += new System.EventHandler(this.btnBuscarProyecto_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descripción:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(52, 389);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 36);
            this.btnLimpiarCampos.TabIndex = 12;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // HerramientasPorEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 437);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescProyecto);
            this.Controls.Add(this.btnBuscarProyecto);
            this.Controls.Add(this.btnGuardarHxE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbEtapas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodProyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HerramientasPorEtapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar herramientas a etapa de proyecto";
            this.Load += new System.EventHandler(this.HerramientasPorEtapa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCodProyecto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEtapas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarHerramienta;
        private System.Windows.Forms.DataGridView gdrHerramientas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHerramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreHerramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descHerramienta;
        private System.Windows.Forms.Button btnGuardarHxE;
        private System.Windows.Forms.TextBox txtDescProyecto;
        private System.Windows.Forms.Button btnBuscarProyecto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHerramientas;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}