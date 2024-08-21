using NewWare_Soft.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms.Herramientas
{
    public partial class HerramientasModificacionesForm : Form
    {
        public HerramientasModificacionesForm()
        {
            InitializeComponent();
        }
        private void HerramientasModificacionesForm_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }
        private void CargarGrilla()
        {
            try
            {
                gdrHerramientas.DataSource = AD_Herramientas.ObtenerListadoHerramientas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener herramientas");
            }
            
        }

        private void gdrHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrHerramientas.Rows[indice];
            string nombre = filaSeleccionada.Cells["NombreHerramienta"].Value.ToString();
            Entidades.Herramientas h = AD_Herramientas.ObtenerHerramienta(nombre);
            LimpiarCampos();
            CargarCampos(h);
        }
        private void CargarCampos(Entidades.Herramientas herramienta)
        {
            txtNombre.Text = herramienta.NombreHerramienta;
            txtDescripcion.Text = herramienta.Descripcion;
        }

        private void btnModificarHerramienta_Click(object sender, EventArgs e)
        {           
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre para la herramienta");
            }
            else
            {
                try
                {
                    bool resultado = AD_Herramientas.ModificarHerramienta(txtNombre.Text, txtDescripcion.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Herramienta modificada con exito");
                        LimpiarCampos();
                        CargarGrilla();
                        txtNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la herramienta");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la herramienta");
                }
            }
        }
    }
}

