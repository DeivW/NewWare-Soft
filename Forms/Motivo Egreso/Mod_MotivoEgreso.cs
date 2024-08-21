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
    public partial class Mod_MotivoEgreso : Form
    {
        int IdMotivo = 0;
        public Mod_MotivoEgreso()
        {
            InitializeComponent();

        }

        private void Mod_MotivoEgreso_Load(object sender, EventArgs e)
        {

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrMotivosEgresos.DataSource = AD_MotivosEgreso.ObtenerListaMotivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuarios");
            }
        }

        private void gdrMotivosEgresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrMotivosEgresos.Rows[indice];
            string nombreMotivo = filaSeleccionada.Cells["NombreMotivo"].Value.ToString();
            IdMotivo = (int)filaSeleccionada.Cells["Id"].Value;
            try
            {
                txtNombreMotivo.Enabled = true;
                txtNombreMotivo.Text = nombreMotivo;
                btnGuardarMotivo.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener persona");
            }
        }

        private void btnGuardarMotivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (AD_MotivosEgreso.ActualizarNombreMotivo(IdMotivo, txtNombreMotivo.Text))
                {
                    MessageBox.Show("Motivo actualizado con éxito");
                    CargarGrilla();
                    txtNombreMotivo.Clear();
                    txtNombreMotivo.Enabled = false;
                    txtNombreBuscar.Clear();
                    btnGuardarMotivo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al actualizar el motivo");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar motivo");
            }
        }

        private void btnBuscarMotivo_Click(object sender, EventArgs e)
        {
            string nombreABuscar = txtNombreBuscar.Text;
            try
            {
                if (txtNombreBuscar.Text.Length != 0)
                {
                    MotivoEgreso m = AD_MotivosEgreso.ObtenerMotivo(nombreABuscar);

                    if (m.NombreMotivo == "")
                    {
                        MessageBox.Show("Ese motivo no fue encontrado");
                    }
                    else
                    {
                        IdMotivo = m.IdMotivo;
                        txtNombreMotivo.Enabled = true;
                        txtNombreMotivo.Text = m.NombreMotivo;
                        btnGuardarMotivo.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un motivo para buscar");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener motivo");
            }
        }
    }
}
