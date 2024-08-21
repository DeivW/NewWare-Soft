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
    public partial class ListadoProdXFactura : Form
    {
        public ListadoProdXFactura()
        {
            InitializeComponent();
        }

        private void ListadoProdXFactura_Load(object sender, EventArgs e)
        {

            this.rptProducto.RefreshReport();
            btnListarPorFactura.Enabled = false;
            btnSeleccionarProducto.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (rbTodasFacturas.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Facturas.ObtenerListadoProductoXFactura();
                CrearReporte(tabla);
                rbTodasFacturas.Checked = false;
            }
            if (rbUNProducto.Checked)
            {
                InabilitarRB();
                lblUnProducto.Visible = true;
                cmbProductos.Enabled = true;
                cmbProductos.Visible = true;
                btnSeleccionarProducto.Enabled = true;
                CargarCombosProductos();
                btnSeleccionarProducto.Visible = true;
            }
            if (rbUnaFactura.Checked)
            {
                InabilitarRB();
                lblFactura.Visible = true;
                cmbFacturas.Enabled = true;
                cmbFacturas.Visible = true;
                btnListarPorFactura.Enabled = true;
                CargarComboFacturas();
                btnListarPorFactura.Visible = true;

            }
        }

        //private void reportViewer1_Load(object sender, EventArgs e)
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = AD_Facturas.ObtenerListadoProductoXFactura();

        //    ReportDataSource ds = new ReportDataSource("DataSetProductoXFactura", tabla);
        //    rptProducto.LocalReport.DataSources.Clear();
        //    rptProducto.LocalReport.DataSources.Add(ds);
        //    rptProducto.LocalReport.Refresh();

        //}

        private void CrearReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("DataSetProductoXFactura", tabla);
            rptProducto.LocalReport.DataSources.Clear();
            rptProducto.LocalReport.DataSources.Add(ds);
            rptProducto.RefreshReport();

        }

        private void InabilitarRB()
        {
            rbUNProducto.Enabled = false;
            rbTodasFacturas.Enabled = false;
            rbUnaFactura.Enabled = false;
            btnSiguiente.Enabled = false;
        }

        private void HabilitarRB()
        {
            rbUNProducto.Enabled = true;
            rbTodasFacturas.Enabled = true;
            rbUnaFactura.Enabled = true;
            btnSiguiente.Enabled = true;
        }

        private void CargarCombosProductos()
        {
            try
            {
                cmbProductos.DataSource = AD_ProdXFAC.obtenerProdPXF();
                cmbProductos.DisplayMember = "IdProducto";
                cmbProductos.ValueMember = "IdProducto";
                cmbProductos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box productos");
            }
        }

        private void CargarComboFacturas()
        {
            try
            {
                cmbFacturas.DataSource = AD_ProdXFAC.obtenerFactPXF();
                cmbFacturas.DisplayMember = "NroFactura";
                cmbFacturas.ValueMember = "NroFactura";
                cmbFacturas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box facturas");
            }
        }


        private DataTable buscarTabla()
        {
            if (rbTodasFacturas.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Facturas.ObtenerListadoProductoXFactura();
                return tabla;
            }
            if (rbUNProducto.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_ProdXFAC.ObtenerListadoProductosPXF((int)cmbProductos.SelectedValue);
                return tabla;
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_ProdXFAC.ObtenerListadoFacturaPXF((int)cmbFacturas.SelectedValue);
                return tabla;
            }
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = buscarTabla();
            CrearReporte(tabla);
            lblUnProducto.Visible = false;
            cmbProductos.Enabled = false;
            cmbProductos.Visible = false;
            btnSeleccionarProducto.Enabled = false;
            btnSeleccionarProducto.Visible = false;
            rbUNProducto.Checked = false;

            HabilitarRB();
        }

        private void btnListarPorFactura_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = buscarTabla();
            CrearReporte(tabla);
            lblFactura.Visible = false;
            cmbFacturas.Enabled = false;
            cmbFacturas.Visible = false;
            btnListarPorFactura.Enabled = false;
            btnListarPorFactura.Visible = false;
            rbUnaFactura.Checked = false;

            HabilitarRB();
        }
    }
}
