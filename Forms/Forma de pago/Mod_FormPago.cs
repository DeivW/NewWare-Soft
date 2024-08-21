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
    public partial class Mod_FormPago : Form
    {
        int IdBanco = 0;
        public Mod_FormPago()
        {
            InitializeComponent();
        }

        private void Mod_Banco_Load(object sender, EventArgs e)
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
                MessageBox.Show("Error al obtener formas de pago!");
            }
        }

        private void gdrBancos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrBancos.Rows[indice];
            string nombreBanco = filaSeleccionada.Cells["NombreFormaPago"].Value.ToString();
            IdBanco = (int)filaSeleccionada.Cells["idFormaPago"].Value;
            txtNombreBuscar.Clear();
            try
            {
                txtNombreBanco.Enabled = true;
                txtNombreBanco.Text = nombreBanco;
                btnGuardarBanco.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener forma de pago!");
            }
        }

        private void btnGuardarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                AD_FPago.ActualizarNombreBanco(IdBanco, txtNombreBanco.Text);
                MessageBox.Show("forma de pago actualizada con éxito!");
                CargarGrilla();
                txtNombreBanco.Clear();
                txtNombreBanco.Enabled = false;
                txtNombreBuscar.Clear();
                btnGuardarBanco.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar forma de pago!");
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
                        MessageBox.Show("Esa forma de pago no fue encontrada");
                    }
                    else
                    {
                        IdBanco = b.IdFormaPagoPersona;
                        txtNombreBanco.Enabled = true;
                        txtNombreBanco.Text = b.NombreFormaPago;
                        btnGuardarBanco.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una forma de pago para buscar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener forma de pago");
            }
        }
    }
}
