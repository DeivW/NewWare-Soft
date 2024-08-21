using NewWare_Soft.AccesoADatos;
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
    public partial class Mod_Tarjeta : Form
    {
        int nroViejo = 0;
        public Mod_Tarjeta()
        {
            InitializeComponent();
        }

        private void Mod_Tarjeta_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrTarjetas.DataSource = AD_Tarjetas.ObtenerListaTarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tarjeta");
            }

        }

        private void gdrTarjetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrTarjetas.Rows[indice];
            int nroTarjeta = int.Parse(filaSeleccionada.Cells["NroTarjeta"].Value.ToString());
            nroViejo = int.Parse(filaSeleccionada.Cells["NroTarjeta"].Value.ToString());

            try
            {
                Tarjeta t = AD_Tarjetas.ObtenerTarjeta(nroTarjeta);
                LimpiarCampos();
                CargarCampos(t);
                btnModificarTarjeta.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener la tarjeta");
            }
        }
        private void LimpiarCampos()
        {
            txtCodSeguridad.Clear();
            txtNroTarjeta.Clear();
            txtFechaVencimiento.Clear();
            cmbBancos.SelectedIndex = -1;
            CargarComboBancos();
        }

        private void CargarComboBancos()
        {
            try
            {
                cmbBancos.DataSource = AD_FPagos.ObtenerListaBancos();
                cmbBancos.DisplayMember = "Nombre";
                cmbBancos.ValueMember = "IdBanco";
                cmbBancos.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo");
            }
        }

        private void CargarCampos(Tarjeta t)
        {
            txtNroTarjeta.Text = t.NroTarjeta.ToString();
            txtNroTarjeta.Enabled = true;
            cmbBancos.SelectedValue = t.ID_Banco;
            cmbBancos.Enabled = true;
            txtFechaVencimiento.Text = t.Fecha_vencimiento.Date.ToShortDateString();
            txtFechaVencimiento.Enabled = true;
            txtCodSeguridad.Text = t.Cod_seguridad.ToString();
            txtCodSeguridad.Enabled = true;
        }


        private Tarjeta ObtenerDatosTarjeta()
        {
            Tarjeta t = new Tarjeta();

            t.NroTarjeta = int.Parse(txtNroTarjeta.Text);
            t.Fecha_vencimiento = DateTime.Parse(txtFechaVencimiento.Text);
            t.Cod_seguridad = int.Parse(txtCodSeguridad.Text);
            t.ID_Banco = (int)cmbBancos.SelectedValue;

            return t;
        }
        private void btnModificarTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta t = ObtenerDatosTarjeta();
            try
            {
                bool resultado = AD_Tarjetas.ActualizarTarjeta(t, nroViejo);
                if (resultado)
                {
                    MessageBox.Show("Datos de la tarjeta actualizados con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                    CargarComboBancos();
                    txtNroTarjeta.Enabled = false;
                    txtCodSeguridad.Enabled = false;
                    txtFechaVencimiento.Enabled = false;
                    btnModificarTarjeta.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al actualizar tarjeta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar tarjeta");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int nroABuscar = int.Parse(txtBuscarNro.Text);
            try
            {
                if (txtBuscarNro.Text.Length != 0)
                {
                    Tarjeta t = AD_Tarjetas.ObtenerTarjeta(nroABuscar);

                    if (t.NroTarjeta == -1)
                    {
                        MessageBox.Show("Esa tarjeta no fue encontrada");
                    }
                    else
                    {
                        LimpiarCampos();
                        CargarCampos(t);
                        nroViejo = t.NroTarjeta;
                        btnModificarTarjeta.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero de tarjeta para buscar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la tarjeta");
            }
        }
    }
}
