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
    public partial class Baja_Cargo : Form
    {
        public Baja_Cargo()
        {
            InitializeComponent();
        }

        private void Baja_Cargo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            
        }
        private void CargarGrilla()
        {

            try
            {
                grillaCargos.DataSource = AD_Cargo.ObtenerListadoCargos();
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo cargar tabla");
            }


        }
        private void LimpiarCampos()
        {
            
            txtCargo.Text = "";
            txtDescripcionCargo.Text = "";
            
        }

        private void grillaCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grillaCargos.Rows[indice];
            string nombre = filaseleccionada.Cells["Nombre"].Value.ToString();
            Cargos c = AD_Cargo.ObtenerCargo(nombre);
            LimpiarCampos();
            CargarCampos(c);
        }
      
        private void CargarCampos(Cargos c)
        {
            txtCargo.Text = c.NombreCargoEmpleado;
            txtDescripcionCargo.Text = c.DescripcionCargoEmpleado;
        }

       

        private Cargos ObtenerDatosCargo()
        {
            Cargos c = new Cargos();
            c.NombreCargoEmpleado = txtCargo.Text.Trim();
            c.DescripcionCargoEmpleado = txtDescripcionCargo.Text.Trim();

            return c;
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {


            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Esta seguro de eliminar el cargo seleccionado?", "Advertencia", botones, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                Cargos c = ObtenerDatosCargo();
                bool resultado = AD_Cargo.EliminarCargo(c);
                if (resultado)
                {
                    MessageBox.Show("Cargo Eliminado");
                    LimpiarCampos();
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("No se puede eliminar debido a que tiene empleados asignados a ese cargo");
                }
            }
            else
            {
                MessageBox.Show("Eliminar Cargo Cancelado");
            }
            
            
            
            

        }

        
    }


}
