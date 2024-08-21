using Microsoft.Reporting.WinForms;
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

namespace NewWare_Soft.Forms.Reportes
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            this.reportViewer_Clientes.RefreshReport();
            button_SeleccionCliente.Enabled = false;
        }

        private void button_Siguiente_Click(object sender, EventArgs e)
        {
            if (radioButton_Todos.Checked)
            {
                DataTable tablaa = new DataTable();
                tablaa = buscarTablas();
                armarReporte(tablaa);
            }
            if (radioButton_ClienteParticular.Checked)
            {
                label_ClientesSelecccion.Visible = true;
                button_SeleccionCliente.Enabled = true;
                button_SeleccionCliente.Visible = true;
                comboBox_Clientes.Enabled = true;
                CargarComboClientes();
                comboBox_Clientes.Visible = true;
            }
            if(radioButton_ClienteLetra.Checked)
            {
                label_Patron.Visible = true;
                button_SeleccionarPatron.Enabled = true;
                button_SeleccionarPatron.Visible = true;
                textBox_Apellido.Enabled = true;
                textBox_Apellido.Visible = true;
            }

        }

        private void armarReporte(DataTable tablaa)
        {
            ReportDataSource ds = new ReportDataSource("DataSet_Cliente", tablaa);
            reportViewer_Clientes.LocalReport.DataSources.Clear();
            reportViewer_Clientes.LocalReport.DataSources.Add(ds);
            //reportViewer_Clientes.LocalReport.Refresh();
            reportViewer_Clientes.RefreshReport();
            reportViewer_Clientes.Visible = true;

        }

        private DataTable buscarTablas()
        {
            if (radioButton_Todos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Cliente.ObtenerDataGrid_Cliente();
                return tabla;
            }
            if (radioButton_ClienteParticular.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Cliente.EncontrarClienteTabla__DB(comboBox_Clientes.Text);
                return tabla;
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_Cliente.getData_Clientes_Patron(textBox_Apellido.Text);
                return tabla;
            }
        }
        private void CargarComboClientes()
        {
            try
            {
                comboBox_Clientes.DataSource = AD_Cliente.getData_Cliente_Combos();
                comboBox_Clientes.DisplayMember = "Email";
                comboBox_Clientes.ValueMember = "IdCliente";
                comboBox_Clientes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de todos los clientes");
            }
        }

        private void button_SeleccionCliente_Click(object sender, EventArgs e)
        {
            object seleccionCombo = new object();
            seleccionCombo = (int)comboBox_Clientes.SelectedValue;
            DataTable tablaa = new DataTable();
            tablaa = buscarTablas();
            armarReporte(tablaa);
            label_ClientesSelecccion.Visible = false;
            button_SeleccionCliente.Enabled = false;
            button_SeleccionCliente.Visible = false;
            comboBox_Clientes.Enabled = false;
            comboBox_Clientes.Visible = false;
        }

        private void button_SeleccionarPatron_Click(object sender, EventArgs e)
        {
            DataTable tablaa = new DataTable();
            tablaa = buscarTablas();
            armarReporte(tablaa);
            label_Patron.Visible = false;
            button_SeleccionarPatron.Enabled = false;
            button_SeleccionarPatron.Visible = false;
            textBox_Apellido.Enabled = false;
            textBox_Apellido.Visible = false;

        }

        private void textBox_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Patron_Click(object sender, EventArgs e)
        {

        }

        private void label_ClientesSelecccion_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_tipoReporte_Enter(object sender, EventArgs e)
        {

        }
    }
}
