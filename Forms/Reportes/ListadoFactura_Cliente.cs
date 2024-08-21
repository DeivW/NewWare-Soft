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
    public partial class Listado_Factura_Cliente : Form
    {
        public Listado_Factura_Cliente()
        {
            InitializeComponent();
        }

        private void Listado_Factura_Cliente_Load(object sender, EventArgs e)
        {
            this.reportViewer_Factura_Cliente.RefreshReport();
        }
        private void button_Siguiente_Click(object sender, EventArgs e)
        {
            if (radioButton_Todos.Checked)
            {
                DataTable tablaa = new DataTable();
                tablaa = buscarTablas();
                if (tablaa == null || tablaa.Rows.Count == 0)
                {
                    MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
                }
                else
                {
                    armarReporte(tablaa);
                }
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
            if (radioButton_Fechas.Checked)
            {
                label_Desde.Visible = true;
                label_Hasta.Visible = true;
                maskedTextBox_Desde.Visible = true;
                maskedTextBox_Desde.Enabled = true;
                maskedTextBox_Hasta.Visible = true;
                maskedTextBox_Hasta.Enabled = true;
                button_SeleccionarFechas.Enabled = true;
                button_SeleccionarFechas.Visible = true;
                label2.Visible = true;
            }

        }
        private DataTable buscarTablas()
        {
            if (radioButton_Todos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Cliente.ObtenerFacturas_Cliente();
                return tabla;
            }
            if (radioButton_ClienteParticular.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Cliente.EncontrarFacturasDeCliente__DB(comboBox_Clientes.SelectedValue.ToString());
                return tabla;
            }
            else
            {
                try
                {
                    DataTable tabla = new DataTable();
                    tabla = AD_Cliente.getData_Facturas_Fechas(maskedTextBox_Desde.Text.ToString(), maskedTextBox_Hasta.Text.ToString());
                    return tabla;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingreso la fecha con el formato equivocado. Recuerde DD/MM/AAAA. Intentelo de nuevo");
                    maskedTextBox_Desde.Text = "";
                    maskedTextBox_Hasta.Text = "";
                    DataTable tabla = new DataTable();
                    return tabla;
                }
            }
        }
        private void armarReporte(DataTable tablaa)
        {
            ReportDataSource ds = new ReportDataSource("DataSet_Fac_Cli", tablaa);
            reportViewer_Factura_Cliente.LocalReport.DataSources.Clear();
            reportViewer_Factura_Cliente.LocalReport.DataSources.Add(ds);
            reportViewer_Factura_Cliente.RefreshReport();
            reportViewer_Factura_Cliente.Visible = true;
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
            try
            {
                object seleccionCombo = new object();
                seleccionCombo = (int)comboBox_Clientes.SelectedValue;
                DataTable tablaa = new DataTable();
                tablaa = buscarTablas();
                if (tablaa == null || tablaa.Rows.Count == 0)
                {
                    MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
                }
                else
                {
                    armarReporte(tablaa);
                    label_ClientesSelecccion.Visible = false;
                    button_SeleccionCliente.Enabled = false;
                    button_SeleccionCliente.Visible = false;
                    comboBox_Clientes.Enabled = false;
                    comboBox_Clientes.Visible = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un ERROR inesperado. Intentelo de nuevo");
            }
        }

        private void button_SeleccionarFechas_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaa = new DataTable();
                tablaa = buscarTablas();
                if (tablaa == null || tablaa.Rows.Count == 0)
                {
                    MessageBox.Show("El reporte esta vacio o es incorrecto, intentelo de nuevo");
                }
                else
                {
                    armarReporte(tablaa);
                    label_Desde.Visible = false;
                    label_Hasta.Visible = false;
                    maskedTextBox_Desde.Visible = false;
                    maskedTextBox_Desde.Enabled = false;
                    maskedTextBox_Hasta.Visible = false;
                    maskedTextBox_Hasta.Enabled = false;
                    button_SeleccionarFechas.Enabled = false;
                    button_SeleccionarFechas.Visible = false;
                    label2.Visible = false;
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un ERROR inesperado. Intentelo de nuevo");
            }
        }
        
    }
}
