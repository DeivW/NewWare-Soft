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
    public partial class ElimUser : Form
    {
        public ElimUser()
        {
            InitializeComponent();
        }

        private void CargarGrilla()
        {
            try
            {
                GrillaUsers2.DataSource = AD_Usuarios.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuarios");
            }
        }

        private void LimpiarCampos()
        {
            txtElimUser.Clear();
            txtElimPass.Clear();
        }

        private void ElimUser_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            btnEliminar.Enabled = false;
        }

        private void CargarCampos(Usuarios U)
        {
            txtElimUser.Text = U.NombreUsuario;
            txtElimPass.Text = U.Password;
        }

        private void GrillaUsers2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnEliminar.Enabled = true;
            DataGridViewRow filaselec = GrillaUsers2.Rows[indice];
            string user = filaselec.Cells["ID"].Value.ToString(); //
            Usuarios U = AD_Usuarios.ObtenerUsuario(user);
            LimpiarCampos();
            CargarCampos(U);

        }

        private Usuarios ObtenerDatosUsuario()
        {
            Usuarios U = new Usuarios();
            U.NombreUsuario = txtElimUser.Text.Trim();
            U.Password = txtElimPass.Text;
            return U;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas eliminar a " + txtElimUser.Text + "?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    Usuarios U = ObtenerDatosUsuario();
                    bool resultado = AD_Usuarios.EliminarUsuario(U);
                    if (resultado)
                    {
                        MessageBox.Show("Usuario eliminado con éxito");
                        LimpiarCampos();
                        CargarGrilla();
                        btnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar usuario");
                    txtElimUser.Focus();
                }
            }
            else
            {
                LimpiarCampos();
                btnEliminar.Enabled = false;
            }
        }

    }

}
