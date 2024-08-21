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
    public partial class ListadoDeProductos : Form
    {
        public ListadoDeProductos()
        {
            InitializeComponent();
        }
        private void ListadoDeProductos_Load(object sender, EventArgs e)
        {
            this.listadoProductos.RefreshReport();
        }
        private void listadoProductos_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = AD_Productos.obtenerListadoProductos();
                ReportDataSource ds = new ReportDataSource("DatosProductos", tabla);
                listadoProductos.LocalReport.DataSources.Clear();
                listadoProductos.LocalReport.DataSources.Add(ds);
                listadoProductos.RefreshReport();
            }
            catch (Exception)
            {
                MessageBox.Show("Error ak obtener listado de productos...");
            }
            
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (rdPrecio.Checked)
            {
                DataTable tabla = AD_Productos.obtenerProductosPrecioMayorA(int.Parse(txtPrecioMayor.Text));
                ReportDataSource ds = new ReportDataSource("DatosProductos", tabla);
                listadoProductos.Visible = false;
                listadoProductos.LocalReport.DataSources.Clear();
                listadoProductos.LocalReport.DataSources.Add(ds);
                listadoProductos.RefreshReport();
                listadoProductos.Visible = true;
            }
            else if (rdDenominacion.Checked)
            {
                DataTable tabla = AD_Productos.obtenerProductoConDenominacion(txtDenominacion.Text);
                ReportDataSource ds = new ReportDataSource("DatosProductos", tabla);
                listadoProductos.Visible = false;
                listadoProductos.LocalReport.DataSources.Clear();
                listadoProductos.LocalReport.DataSources.Add(ds);
                listadoProductos.RefreshReport();
                listadoProductos.Visible = true;
            }
            else if (rdFecha.Checked)
            {
                DataTable tabla = AD_Productos.obtenerProductoFechaMayor(txtFecha.Text);
                ReportDataSource ds = new ReportDataSource("DatosProductos", tabla);
                listadoProductos.Visible = false;
                listadoProductos.LocalReport.DataSources.Clear();
                listadoProductos.LocalReport.DataSources.Add(ds);
                listadoProductos.RefreshReport();
                listadoProductos.Visible = true;
            }
            else
            {
                DataTable tabla = AD_Productos.obtenerListadoProductos();
                ReportDataSource ds = new ReportDataSource("DatosProductos", tabla);
                listadoProductos.Visible = false;
                listadoProductos.LocalReport.DataSources.Clear();
                listadoProductos.LocalReport.DataSources.Add(ds);
                listadoProductos.RefreshReport();
                listadoProductos.Visible = true;
            }
        }
        private void rdPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPrecio.Checked)
            {
                txtPrecioMayor.Enabled = true;
            } else
            {
                txtPrecioMayor.Enabled = false;
                txtPrecioMayor.Text = "";
            }
            
        }
        private void rdDenominacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDenominacion.Checked)
            {
                txtDenominacion.Enabled = true;
            }
            else
            {
                txtDenominacion.Enabled = false;
                txtDenominacion.Text = "";
            }
        }
        private void rdFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFecha.Checked)
            {
                txtFecha.Enabled = true;
            }
            else
            {
                txtFecha.Enabled = false;
                txtFecha.Text = "";
            }
        }
    }
}
