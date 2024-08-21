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
    public partial class HerramientasBajasForm : Form
    {
        public HerramientasBajasForm()
        {
            InitializeComponent();
        }

        private void HerramientasBajasForm_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            btnEliminarHerramienta.Enabled = false;
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
            btnEliminarHerramienta.Enabled = true;
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

        private void btnEliminarHerramienta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas eliminar la herramienta " + txtNombre.Text + "?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    Entidades.Herramientas H = AD_Herramientas.ObtenerHerramienta(txtNombre.Text);
                    bool resultado = AD_Herramientas.EliminarHerramienta(H);
                    if (resultado)
                    {
                        MessageBox.Show("Herramienta eliminada con éxito");
                        LimpiarCampos();
                        CargarGrilla();

                        btnEliminarHerramienta.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar herramienta");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar herramienta");
                    txtNombre.Focus();
                }
            }
            else
            {
                LimpiarCampos();
                btnEliminarHerramienta.Enabled = false;
            }
        }
     
    }
}
