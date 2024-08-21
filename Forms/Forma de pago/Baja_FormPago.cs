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
    public partial class Baja_FormPago : Form
    {
        int IdBanco = 0;
        public Baja_FormPago()
        {
            InitializeComponent();
        }

        private void Baja_Banco_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                gdrBancos.DataSource = AD_FPago.ObtenerListaBancos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener formas de pago para la grilla");
            }
        }

        private void btnEliminarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                if (AD_FPago.EliminarBanco(txtNombreBanco.Text))
                {
                    MessageBox.Show("La forma de pago fue eliminada con éxito");
                    CargarGrilla();
                    txtNombreBanco.Clear();
                    txtNombreBuscar.Clear();
                    btnEliminarBanco.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar!");
            }
        }

        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            string nombreABuscar = txtNombreBuscar.Text;
            try
            {
                if (txtNombreBuscar.Text.Length != 0)
                {
                    FormasPago b = AD_FPago.ObtenerBanco(nombreABuscar);

                    if (b.NombreFormaPago == "")
                    {
                        MessageBox.Show("Esa forma de pago no fue encontrada!");
                    }
                    else
                    {
                        IdBanco = b.IdFormaPagoPersona;
                        txtNombreBanco.Text = b.NombreFormaPago;
                        btnEliminarBanco.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una forma de pago para buscar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la forma de pago");
            }
        }

        private void gdrBancos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrBancos.Rows[indice];
            string nombreMotivo = filaSeleccionada.Cells["NombreFormaPago"].Value.ToString();
            try
            {
                txtNombreBanco.Text = nombreMotivo;
                btnEliminarBanco.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener forma de pago!");
            }
        }
    }
}
