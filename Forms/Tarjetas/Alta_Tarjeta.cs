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
    public partial class Alta_Tarjeta : Form
    {
        public Alta_Tarjeta()
        {
            InitializeComponent();
        }

        private void Alta_Tarjeta_Load(object sender, EventArgs e)
        {
            CargarComboBancos();
            LimpiarCampos();
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

        private Tarjeta ObtenerDatosTarjeta()
        {
            Tarjeta t = new Tarjeta();

            t.NroTarjeta = int.Parse(txtNroTarjeta.Text);
            t.Fecha_vencimiento = DateTime.Parse(txtFechaVencimiento.Text);
            t.Cod_seguridad = int.Parse(txtCodSeguridad.Text);
            t.ID_Banco = (int)cmbBancos.SelectedValue;

            return t;
        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta t = ObtenerDatosTarjeta();
            try
            {
                if (AD_Tarjetas.VerificarExistencia(t.NroTarjeta))
                {
                    MessageBox.Show("Esa tarjeta ya fue dada de alta anteriormente");
                    LimpiarCampos();
                }
                else
                {
                    if (AD_Tarjetas.InsertarTarjeta(t))
                    {
                        MessageBox.Show("Tarjeta agregada exitosamente");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la tarjeta");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la tarjeta");
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
    }
}
