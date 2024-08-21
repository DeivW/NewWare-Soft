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
    public partial class Alta_MotivoEgreso : Form
    {
        public Alta_MotivoEgreso()
        {
            InitializeComponent();
        }

        private void Alta_MotivoEgreso_Load(object sender, EventArgs e)
        {
            txtNombreMotivo.Focus();
        }

        private void btnAgregarMotivo_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = AD_MotivosEgreso.VerificarExistencia(txtNombreMotivo.Text);
                if (resultado)
                {
                    MessageBox.Show("Ese motivo de egreso ya existe", "¡Error!");
                }
                else
                {
                    try
                    {
                        if (AD_MotivosEgreso.InsertarMotivoEgreso(txtNombreMotivo.Text) == true)
                        {
                            MessageBox.Show("El motivo de egreso fue agregado éxitosamente", "Motivo agregado");
                            txtNombreMotivo.Clear();
                            txtNombreMotivo.Focus();
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al insertar motivo de egreso", "¡Error!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al verificar existencia del motivo de egreso", "¡Error!");
            }
        }
    }
}
