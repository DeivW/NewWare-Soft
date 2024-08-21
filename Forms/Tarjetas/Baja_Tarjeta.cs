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
    public partial class Baja_Tarjeta : Form
    {
        int nroViejo = 0;
        public Baja_Tarjeta()
        {
            InitializeComponent();
        }

        private void Baja_Tarjeta_Load(object sender, EventArgs e)
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
                CargarCampos(t);
                btnEliminarTarjeta.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener persona");
            }
        }
        private void CargarCampos(Tarjeta t)
        {
            txtNroTarjeta.Text = t.NroTarjeta.ToString();
            cmbBancos.SelectedValue = t.ID_Banco;
            txtFechaVencimiento.Text = t.Fecha_vencimiento.Date.ToShortDateString();
            txtCodSeguridad.Text = t.Cod_seguridad.ToString();
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            int nroABuscar = int.Parse(txtBuscarNroEliminar.Text);
            try
            {
                if (txtBuscarNroEliminar.Text.Length != 0)
                {
                    Tarjeta t = AD_Tarjetas.ObtenerTarjeta(nroABuscar);

                    if (t.NroTarjeta == -1)
                    {
                        MessageBox.Show("Esa tarjeta no fue encontrada");
                    }
                    else
                    {
                        CargarCampos(t);
                        nroViejo = t.NroTarjeta;
                        btnEliminarTarjeta.Enabled = true;
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

        private void btnEliminarTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (AD_Tarjetas.EliminarTarjeta(int.Parse(txtNroTarjeta.Text))) ;
                {
                    MessageBox.Show("Tarjeta eliminada con éxito");
                    btnEliminarTarjeta.Enabled = false;
                    CargarGrilla();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la tarjeta");
            }


        }
    }
}
