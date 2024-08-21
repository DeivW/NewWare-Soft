using NewWare_Soft.AccesoADatos;
using System;
using System.Windows.Forms;

namespace NewWare_Soft.Forms
{
    public partial class HerramientasAltasForm : Form
    {
        public HerramientasAltasForm()
        {
            InitializeComponent();
        }

        private void HerramientasForm_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
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
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }
        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el nombre de la herramienta");
            }
            else
            {
                try
                {
                    bool resultado = AD_Herramientas.InsertarHerramienta(txtNombre.Text, txtDescripcion.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Herramienta dada de alta con exito");
                        LimpiarCampos();
                        CargarGrilla();
                        txtNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar nueva herramienta");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar nueva herramienta");
                }
            }
        }
    }


}
