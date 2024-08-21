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
    public partial class BajaCliente : Form
    {
        public BajaCliente()
        {
            InitializeComponent();
        }

        private void BajaCliente_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
        }
        private void LlenarGrilla()
        {
            try
            {
                dataGridView_Clientes.DataSource = AD_Cliente.ObtenerData_grid_Cliente();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! No se pudo obtener los clientes para modicarlos.");
            }
        }
        private void dataGrid_ClienteBorrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            button_Eliminar.Enabled = true;
            DataGridViewRow filaSeleccionada = dataGridView_Clientes.Rows[index];
            string email = filaSeleccionada.Cells["Email"].Value.ToString();
            Cliente dude = AD_Cliente.EncontrarCliente_DB(email);
            textBox_Email.Text = dude.Email;
            VariablesGlobales.var = dude.Email;
        }



        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            groupBox_confirmacion.Enabled = true;
            groupBox_confirmacion.Visible = true;
            button_NO.Enabled = true;
            button_NO.Visible = true;
            button_SI.Enabled = true;
            button_NO.Visible = true;
            
        }

        private void button_NO_Click(object sender, EventArgs e)
        {
            textBox_Email.Text = "";
            MessageBox.Show("Si quiere eliminar a otro cliente, puede seleccionarlo desde la tabla");
            groupBox_confirmacion.Enabled = false;
            groupBox_confirmacion.Visible = false;
            button_NO.Enabled = false;
            button_NO.Visible = false;
            button_SI.Enabled = false;
            button_NO.Visible = false;
            LlenarGrilla();
        }

        private void button_SI_Click(object sender, EventArgs e)
        {
            bool borrar = AD_Cliente.BorrarCliente_DB(VariablesGlobales.var);
            if (borrar)
            {
                LlenarGrilla();
                MessageBox.Show("Se borro el cliente con exito");
                groupBox_confirmacion.Enabled = false;
                groupBox_confirmacion.Visible = false;
                button_NO.Enabled = false;
                button_NO.Visible = false;
                button_SI.Enabled = false;
                button_NO.Visible = false;
                textBox_Email.Text = " ";
            }
            else
            {
                MessageBox.Show("ERROR! No se borro el cliente con exito. Por favor, intentelo otra vez");
                groupBox_confirmacion.Enabled = false;
                groupBox_confirmacion.Visible = false;
                button_NO.Enabled = false;
                button_NO.Visible = false;
                button_SI.Enabled = false;
                button_NO.Visible = false;
            }
        }
    }
}
