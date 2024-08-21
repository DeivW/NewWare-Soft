
namespace NewWare_Soft.Forms
{
    partial class ElimUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElimUser));
            this.GrillaUsers2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblElimUser = new System.Windows.Forms.Label();
            this.txtElimUser = new System.Windows.Forms.TextBox();
            this.txtElimPass = new System.Windows.Forms.TextBox();
            this.lblElimPass = new System.Windows.Forms.Label();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsers2)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaUsers2
            // 
            this.GrillaUsers2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsers2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.User,
            this.Password});
            this.GrillaUsers2.Location = new System.Drawing.Point(305, 80);
            this.GrillaUsers2.Name = "GrillaUsers2";
            this.GrillaUsers2.Size = new System.Drawing.Size(444, 264);
            this.GrillaUsers2.TabIndex = 11;
            this.GrillaUsers2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaUsers2_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdUsuario";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // User
            // 
            this.User.DataPropertyName = "NombreUsuario";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.Width = 200;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(59, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblElimUser
            // 
            this.lblElimUser.AutoSize = true;
            this.lblElimUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimUser.Location = new System.Drawing.Point(18, 81);
            this.lblElimUser.Name = "lblElimUser";
            this.lblElimUser.Size = new System.Drawing.Size(139, 18);
            this.lblElimUser.TabIndex = 0;
            this.lblElimUser.Text = "Nombre de usuario:";
            // 
            // txtElimUser
            // 
            this.txtElimUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElimUser.Location = new System.Drawing.Point(163, 80);
            this.txtElimUser.Name = "txtElimUser";
            this.txtElimUser.Size = new System.Drawing.Size(119, 23);
            this.txtElimUser.TabIndex = 3;
            // 
            // txtElimPass
            // 
            this.txtElimPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElimPass.Location = new System.Drawing.Point(163, 118);
            this.txtElimPass.Name = "txtElimPass";
            this.txtElimPass.PasswordChar = '*';
            this.txtElimPass.Size = new System.Drawing.Size(119, 23);
            this.txtElimPass.TabIndex = 4;
            // 
            // lblElimPass
            // 
            this.lblElimPass.AutoSize = true;
            this.lblElimPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimPass.Location = new System.Drawing.Point(68, 121);
            this.lblElimPass.Name = "lblElimPass";
            this.lblElimPass.Size = new System.Drawing.Size(89, 18);
            this.lblElimPass.TabIndex = 1;
            this.lblElimPass.Text = "Contraseña:";
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
            this.label_Empresa.TabIndex = 27;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(272, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Eliminar un Usuario";
            // 
            // ElimUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 350);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.GrillaUsers2);
            this.Controls.Add(this.lblElimUser);
            this.Controls.Add(this.txtElimUser);
            this.Controls.Add(this.txtElimPass);
            this.Controls.Add(this.lblElimPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElimUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Usuario";
            this.Load += new System.EventHandler(this.ElimUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsers2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaUsers2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblElimUser;
        private System.Windows.Forms.TextBox txtElimUser;
        private System.Windows.Forms.TextBox txtElimPass;
        private System.Windows.Forms.Label lblElimPass;
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.Label label5;
    }
}