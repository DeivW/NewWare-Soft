
namespace NewWare_Soft.Forms
{
    partial class ModifUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifUser));
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.txtConfirm2Pass = new System.Windows.Forms.TextBox();
            this.lblConfirm2Pass = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblModifUser = new System.Windows.Forms.Label();
            this.txtModifUser = new System.Windows.Forms.TextBox();
            this.txtModifPass = new System.Windows.Forms.TextBox();
            this.lblModifPass = new System.Windows.Forms.Label();
            this.GrillaUsers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdUser
            // 
            this.txtIdUser.Enabled = false;
            this.txtIdUser.Location = new System.Drawing.Point(92, 184);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(42, 20);
            this.txtIdUser.TabIndex = 10;
            // 
            // txtConfirm2Pass
            // 
            this.txtConfirm2Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm2Pass.Location = new System.Drawing.Point(203, 141);
            this.txtConfirm2Pass.Name = "txtConfirm2Pass";
            this.txtConfirm2Pass.PasswordChar = '*';
            this.txtConfirm2Pass.Size = new System.Drawing.Size(132, 23);
            this.txtConfirm2Pass.TabIndex = 9;
            // 
            // lblConfirm2Pass
            // 
            this.lblConfirm2Pass.AutoSize = true;
            this.lblConfirm2Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm2Pass.Location = new System.Drawing.Point(14, 147);
            this.lblConfirm2Pass.Name = "lblConfirm2Pass";
            this.lblConfirm2Pass.Size = new System.Drawing.Size(159, 18);
            this.lblConfirm2Pass.TabIndex = 8;
            this.lblConfirm2Pass.Text = "Confirmar Contraseña:";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(190, 170);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(145, 46);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar Usuario";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblModifUser
            // 
            this.lblModifUser.AutoSize = true;
            this.lblModifUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifUser.Location = new System.Drawing.Point(34, 72);
            this.lblModifUser.Name = "lblModifUser";
            this.lblModifUser.Size = new System.Drawing.Size(139, 18);
            this.lblModifUser.TabIndex = 0;
            this.lblModifUser.Text = "Nombre de usuario:";
            // 
            // txtModifUser
            // 
            this.txtModifUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifUser.Location = new System.Drawing.Point(203, 66);
            this.txtModifUser.Name = "txtModifUser";
            this.txtModifUser.Size = new System.Drawing.Size(132, 23);
            this.txtModifUser.TabIndex = 3;
            // 
            // txtModifPass
            // 
            this.txtModifPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifPass.Location = new System.Drawing.Point(203, 104);
            this.txtModifPass.Name = "txtModifPass";
            this.txtModifPass.PasswordChar = '*';
            this.txtModifPass.Size = new System.Drawing.Size(132, 23);
            this.txtModifPass.TabIndex = 4;
            // 
            // lblModifPass
            // 
            this.lblModifPass.AutoSize = true;
            this.lblModifPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifPass.Location = new System.Drawing.Point(89, 110);
            this.lblModifPass.Name = "lblModifPass";
            this.lblModifPass.Size = new System.Drawing.Size(89, 18);
            this.lblModifPass.TabIndex = 1;
            this.lblModifPass.Text = "Contraseña:";
            // 
            // GrillaUsers
            // 
            this.GrillaUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.User,
            this.Password});
            this.GrillaUsers.Location = new System.Drawing.Point(360, 66);
            this.GrillaUsers.Name = "GrillaUsers";
            this.GrillaUsers.Size = new System.Drawing.Size(444, 211);
            this.GrillaUsers.TabIndex = 9;
            this.GrillaUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaUsers_CellClick);
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
            // label_Empresa
            // 
            this.label_Empresa.AutoSize = true;
            this.label_Empresa.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold);
            this.label_Empresa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Empresa.Location = new System.Drawing.Point(14, 9);
            this.label_Empresa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Empresa.Name = "label_Empresa";
            this.label_Empresa.Size = new System.Drawing.Size(190, 24);
            this.label_Empresa.TabIndex = 65;
            this.label_Empresa.Text = "NewWare-Soft";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(291, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 37);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "Modificar un Usuario";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 289);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.GrillaUsers);
            this.Controls.Add(this.txtConfirm2Pass);
            this.Controls.Add(this.lblConfirm2Pass);
            this.Controls.Add(this.txtModifUser);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblModifPass);
            this.Controls.Add(this.lblModifUser);
            this.Controls.Add(this.txtModifPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Usuario";
            this.Load += new System.EventHandler(this.ModifUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtConfirm2Pass;
        private System.Windows.Forms.Label lblConfirm2Pass;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblModifUser;
        private System.Windows.Forms.TextBox txtModifUser;
        private System.Windows.Forms.TextBox txtModifPass;
        private System.Windows.Forms.Label lblModifPass;
        private System.Windows.Forms.DataGridView GrillaUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.Label lblTitle;
    }
}