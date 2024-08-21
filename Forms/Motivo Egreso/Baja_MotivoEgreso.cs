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

    public partial class Baja_MotivoEgreso : Form
    {
        public Baja_MotivoEgreso()
        {
            InitializeComponent();
        }

        private void Baja_MotivoEgreso_Load(object sender, EventArgs e)
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
                MessageBox.Show("Error al obtener motivos de egreso para la grilla");
            }
        }

        private void btnEliminarMotivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (AD_MotivosEgreso.EliminarMotivo(txtNombreMotivo.Text))
                {
                    MessageBox.Show("Motivo de egreso eliminado con éxito");
                    CargarGrilla();
                    txtNombreMotivo.Clear();
                    txtNombreBuscar.Clear();
                    btnEliminarMotivo.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el motivo");
            }
        }

        private void btnBuscarMotivo_Click_1(object sender, EventArgs e)
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
                        txtNombreMotivo.Text = m.NombreMotivo;
                        btnEliminarMotivo.Enabled = true;
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

        private void gdrMotivosEgresos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrMotivosEgresos.Rows[indice];
            string nombreMotivo = filaSeleccionada.Cells["NombreMotivo"].Value.ToString();
            try
            {
                txtNombreMotivo.Text = nombreMotivo;
                btnEliminarMotivo.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener persona");
            }
        }
    }
}
