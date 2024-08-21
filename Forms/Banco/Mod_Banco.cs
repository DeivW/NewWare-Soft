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
    public partial class Mod_Banco : Form
    {
        int IdBanco = 0;
        public Mod_Banco()
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
                gdrBancos.DataSource = AD_FPagos.ObtenerListaBancos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuarios");
            }
        }

        private void gdrBancos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrBancos.Rows[indice];
            string nombreBanco = filaSeleccionada.Cells["NombreBanco"].Value.ToString();
            IdBanco = (int)filaSeleccionada.Cells["Id"].Value;
            txtNombreBuscar.Clear();
            try
            {
                txtNombreBanco.Enabled = true;
                txtNombreBanco.Text = nombreBanco;
                btnGuardarBanco.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener persona");
            }
        }

        private void btnGuardarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                AD_FPagos.ActualizarNombreBanco(IdBanco, txtNombreBanco.Text);
                MessageBox.Show("Banco actualizado con éxito");
                CargarGrilla();
                txtNombreBanco.Clear();
                txtNombreBanco.Enabled = false;
                txtNombreBuscar.Clear();
                btnGuardarBanco.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Banco");
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
                        txtNombreBanco.Enabled = true;
                        txtNombreBanco.Text = b.NombreBanco;
                        btnGuardarBanco.Enabled = true;
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
    }
}
