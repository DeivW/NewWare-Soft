using NewWare_Soft.AccesoADatos_Usuarios;
using NewWare_Soft.Entidades;
using NewWare_Soft.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los valores correctos");
            }
            else
            {
                string nombreUsu = txtUser.Text;
                string password = txtPassword.Text;
                bool resultado = false;

                try
                {
                    resultado = AD_Usuarios.ValidarUsuario(nombreUsu, password);
                    if (resultado == true)
                    {
                        Usuarios usu = new Usuarios(nombreUsu, password);
                        PrincipalForm ventana = new PrincipalForm(usu);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al consultar el usuario");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblUser.Focus();
        }
    }
}
