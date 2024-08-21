using NewWare_Soft.AccesoADatos;
using NewWare_Soft.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms
{
    public partial class Modificacion_Cargo : Form
    {
        public Modificacion_Cargo()
        {
            InitializeComponent();
        }

        private void Modificacion_Cargo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {

            try
            {
                grillaListaCargos.DataSource = AD_Cargo.ObtenerListadoCargos();
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo cargar tabla");
            }


        }
        private void LimpiarCampos()
        {
            txtIdCargo.Text = "";
            txtCargo.Text = "";
            txtDescripcionCargo.Text = "";
            txtCargo.Focus();
        }

        private void grillaListaCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grillaListaCargos.Rows[indice];
            string nombre = filaseleccionada.Cells["Nombre"].Value.ToString();
            Cargos c = AD_Cargo.ObtenerCargo(nombre);
            LimpiarCampos();
            CargarCampos(c);
        }

        private void CargarCampos(Cargos c)
        {
            txtIdCargo.Text = c.IdCargoEmpleado.ToString();
            txtCargo.Text = c.NombreCargoEmpleado;
            txtDescripcionCargo.Text = c.DescripcionCargoEmpleado;
        }

        

        

        private Cargos ObtenerDatosCargo()
        {
            Cargos c = new Cargos();
            c.IdCargoEmpleado = int.Parse(txtIdCargo.Text.Trim());
            c.NombreCargoEmpleado = txtCargo.Text.Trim();
            c.DescripcionCargoEmpleado = txtDescripcionCargo.Text.Trim();

            return c;
        }

        private void btnModCargo_Click(object sender, EventArgs e)
        {
            Cargos c = ObtenerDatosCargo();
            bool resultado = AD_Cargo.ModificarCargo(c);
            if (resultado)
            {
                MessageBox.Show("Cargo Actualizado");
                LimpiarCampos();
                CargarGrilla();

            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
