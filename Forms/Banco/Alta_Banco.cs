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
    public partial class Alta_Banco : Form
    {
        public Alta_Banco()
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
                bool resultado = AD_FPagos.VerificarExistencia(txtNombreBanco.Text);
                if (resultado)
                {
                    MessageBox.Show("Ese banco ya fue dado de alta", "¡Error!");
                }
                else
                {
                    try
                    {
                        if (AD_FPagos.InsertarBanco(txtNombreBanco.Text) == true)
                        {
                            MessageBox.Show("El banco fue agregado éxitosamente", "Banco agregado");
                            txtNombreBanco.Clear();
                            txtNombreBanco.Focus();
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al insertar el banco", "¡Error!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al verificar existencia del banco", "¡Error!");
            }
        }
    }
}
