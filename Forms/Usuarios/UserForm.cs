using NewWare_Soft.AccesoADatos_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNewUser.Clear();
            txtNewPass.Clear();
            txtConfirmNewPass.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Text.Equals("") || txtNewPass.Text.Equals("") || AD_Usuarios.ValidarNombreUsuario(txtNewUser.Text.Trim()))
            {
                MessageBox.Show("No rellenó los campos o por el contrario escogió un usuario ya utilizado previamente");
                LimpiarCampos();
                txtNewUser.Focus();
            }
            else
            {
                if (txtNewPass.Text.Equals(txtConfirmNewPass.Text))
                {
                    try
                    {
                        bool resultado = AD_Usuarios.InsertarNuevoUsuario(txtNewUser.Text, txtNewPass.Text);
                        if (resultado)
                        {
                            MessageBox.Show("Usuario dado de alta con éxito");
                            LimpiarCampos();
                            txtNewUser.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error al añadir nuevo usuario");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al añadir nuevo usuario");
                        txtNewUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }
    }

}
