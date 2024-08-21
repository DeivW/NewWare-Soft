using NewWare_Soft.AccesoADatos;
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
    public partial class Alta_FormPago : Form
    {
        public Alta_FormPago()
        {
            InitializeComponent();
        }

        private void Alta_Banco_Load(object sender, EventArgs e)
        {
            txtNombreBanco.Focus();
        }

        private void btnAgregarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = AD_FPago.VerificarExistencia(txtNombreBanco.Text);
                if (resultado)
                {
                    MessageBox.Show("Esa forma de pago ya fue dada de alta", "¡Error!");
                }
                else
                {
                    try
                    {
                        if (AD_FPago.InsertarBanco(txtNombreBanco.Text) == true)
                        {
                            MessageBox.Show("La forma de pago fue agregada éxitosamente", "Agregado");
                            txtNombreBanco.Clear();
                            txtNombreBanco.Focus();
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al insertar forma de pago", "¡Error!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al verificar existencia de forma de pago", "¡Error!");
            }
        }
    }
}
