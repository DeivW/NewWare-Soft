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
    public partial class Baja_Banco : Form
    {
        int IdBanco = 0;
        public Baja_Banco()
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
                gdrBancos.DataSource = AD_FPagos.ObtenerListaBancos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener bancos para la grilla");
            }
        }

        private void btnEliminarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                if (AD_FPagos.EliminarBanco(txtNombreBanco.Text))
                {
                    MessageBox.Show("El banco fue eliminado con éxito");
                    CargarGrilla();
                    txtNombreBanco.Clear();
                    txtNombreBuscar.Clear();
                    btnEliminarBanco.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el banco");
            }
        }

        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            string nombreABuscar = txtNombreBuscar.Text;
            try
            {
                if (txtNombreBuscar.Text.Length != 0)
                {
                    Banco b = AD_FPagos.ObtenerBanco(nombreABuscar);

                    if (b.NombreBanco == "")
                    {
                        MessageBox.Show("Ese banco no fue encontrado");
                    }
                    else
                    {
                        IdBanco = b.IdBanco;
                        txtNombreBanco.Text = b.NombreBanco;
                        btnEliminarBanco.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un banco para buscar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el banco");
            }
        }

        private void gdrBancos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrBancos.Rows[indice];
            string nombreMotivo = filaSeleccionada.Cells["NombreBanco"].Value.ToString();
            try
            {
                txtNombreBanco.Text = nombreMotivo;
                btnEliminarBanco.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener persona");
            }
        }
    }
}
