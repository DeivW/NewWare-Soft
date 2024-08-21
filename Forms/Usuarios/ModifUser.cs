using NewWare_Soft.AccesoADatos_Usuarios;
using NewWare_Soft.Entidades;
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
    public partial class ModifUser : Form
    {
        public ModifUser()
        {
            InitializeComponent();
        }

        private void ModifUser_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            btnModificar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtModifUser.Clear();
            txtModifPass.Clear();
            txtConfirm2Pass.Clear();
        }

        private void CargarGrilla()
        {
            try
            {
                GrillaUsers.DataSource = AD_Usuarios.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuarios");
            }
        }



        private Usuarios ObtenerDatosUsuario()
        {
            Usuarios U = new Usuarios();
            U.id = txtIdUser.Text.Trim();
            U.NombreUsuario = txtModifUser.Text.Trim();
            U.Password = txtModifPass.Text;
            return U;
        }

        private void GrillaUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnModificar.Enabled = true;
            DataGridViewRow filaselec = GrillaUsers.Rows[indice];
            string user = filaselec.Cells["ID"].Value.ToString(); //
            Usuarios U = AD_Usuarios.ObtenerUsuario(user);
            LimpiarCampos();
            CargarCampos(U);

        }

        private void CargarCampos(Usuarios U)
        {
            txtIdUser.Text = U.id;
            txtModifUser.Text = U.NombreUsuario;
            txtModifPass.Text = U.Password;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtModifUser.Text.Equals("") || AD_Usuarios.ValidarNombreUsuario(txtModifUser.Text))
            {
                MessageBox.Show("No rellenó el nombre de usuario o escogió uno ya utilizado previamente");
                LimpiarCampos();
                txtModifUser.Focus();
            }
            else
            {
                if (txtModifPass.Text.Equals(txtConfirm2Pass.Text))
                {
                    if (MessageBox.Show("Vas a modificar a  " + txtModifUser.Text + ", estas seguro?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            Usuarios U = ObtenerDatosUsuario();
                            bool resultado = AD_Usuarios.ModificarUsuario(U);
                            if (resultado)
                            {
                                MessageBox.Show("Usuario modificado con éxito");
                                LimpiarCampos();
                                CargarGrilla();
                                btnModificar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar el usuario");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al modificar usuario");
                            txtModifUser.Focus();
                        }
                    }
                    else
                    {
                        LimpiarCampos();
                        btnModificar.Enabled = false;
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
