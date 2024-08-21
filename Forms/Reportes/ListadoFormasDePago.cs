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
    public partial class ListadoFormasDePago : Form
    {
        public ListadoFormasDePago()
        {
            InitializeComponent();
        }

        private void ListadoFormasDePago_Load(object sender, EventArgs e)
        {
            this.report_FormasdePago.RefreshReport();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (rdbNombre.Checked)
            {
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                txtNombre.Enabled = true;
                btnGenerarReporte2.Visible = true;
                btnGenerarReporte2.Enabled = true;
            }
            if (rdb_ordenAlfabetico.Checked)
            {
                lblOrdenAlfabetico.Visible = true;
                btnGenerarReporte2.Visible = true;
                btnGenerarReporte2.Enabled = true;
            }

            if (rdb_reportenormal.Checked)
            {
                lblNormal.Visible = true;
                btnGenerarReporte2.Visible = true;
                btnGenerarReporte2.Enabled = true;
            }
        }
        private DataTable buscarTablas()
        {
            if (rdbNombre.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_FPago.nombreFormadePago(txtNombre.Text);
                return tabla;
            }
            if (rdb_ordenAlfabetico.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_FPago.ordenAlfabetico();
                return tabla;
            }

            if (rdb_reportenormal.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_FPago.ObtenerTiposPago();
                return tabla;
            }

            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_FPago.ObtenerTiposPago();
                return tabla;
            }

        }
        private void armarReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("DatosFormaDePago", tabla);
            report_FormasdePago.LocalReport.DataSources.Clear();
            report_FormasdePago.LocalReport.DataSources.Add(ds);
            report_FormasdePago.RefreshReport();
            report_FormasdePago.Visible = true;
        }

        private void btnGenerarReporte2_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbNombre.Checked)
                {
                    DataTable tabla = new DataTable();
                    tabla = buscarTablas();
                    if (tabla == null || tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("Esa forma de pago no existe, ingrese otra");
                        txtNombre.Focus();

                    }
                    else
                    {
                        armarReporte(tabla);
                        lblNombre.Visible = false;
                        txtNombre.Text = " ";
                        txtNombre.Visible = false;
                        txtNombre.Enabled = false;
                        btnGenerarReporte2.Enabled = false;
                        btnGenerarReporte2.Visible = false;
                    }
                }

                if (rdb_reportenormal.Checked)
                {
                    DataTable tabla = new DataTable();
                    tabla = buscarTablas();
                    if (tabla == null || tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
                    }
                    else
                    {
                        armarReporte(tabla);
                        lblNormal.Visible = false;
                        btnGenerarReporte2.Enabled = false;
                        btnGenerarReporte2.Visible = false;
                    }
                }

                if (rdb_ordenAlfabetico.Checked)
                {
                    DataTable tabla = new DataTable();
                    tabla = buscarTablas();
                    if (tabla == null || tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
                    }
                    else
                    {
                        armarReporte(tabla);
                        lblOrdenAlfabetico.Visible = false;
                        btnGenerarReporte2.Enabled = false;
                        btnGenerarReporte2.Visible = false;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un ERROR inesperado. Intentelo de nuevo");
            }
           
        }

    }
}