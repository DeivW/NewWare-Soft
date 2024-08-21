using Microsoft.Reporting.WinForms;
using NewWare_Soft.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms.Reportes
{
    public partial class ReporteListadoEtapas : Form
    {
        public ReporteListadoEtapas()
        {
            InitializeComponent();
        }

        private void ReporteListadoEtapas_Load(object sender, EventArgs e)
        {

            this.ReportListEtapas.RefreshReport();
        }

        private void ReportListEtapas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerListadoEtapas();

            ReportDataSource ds = new ReportDataSource("Datos_Etapas", tabla);
            ReportListEtapas.LocalReport.DataSources.Clear();
            ReportListEtapas.LocalReport.DataSources.Add(ds);
            ReportListEtapas.LocalReport.Refresh();

        }

        public static DataTable ObtenerListadoEtapas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM etapas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnElegirReporteEtapas_Click(object sender, EventArgs e)
        {
            if (rdReporteEtapasxID.Checked)
            {
                //lblListarPorCargo.Visible = false;
                txtNombreFiltrarEtapas.Enabled = false;
                btnFiltrarEtapasxNombre.Enabled = false;
                //lblFiltrarReportePersonal.Visible = true;
                mskIDFiltrarEtapas.Enabled = true;
                btnFiltrarEtapasxID.Enabled = true;
            }
            if (rdReporteEtapasxNombre.Checked)
            {
                //lblFiltrarReportePersonal.Enabled = false;
                mskIDFiltrarEtapas.Enabled = false;
                btnFiltrarEtapasxID.Enabled = false;
                //lblListarPorCargo.Enabled = true;
                txtNombreFiltrarEtapas.Enabled = true;
                btnFiltrarEtapasxNombre.Enabled = true;
            }
            if (rdReporteEtapasTodos.Checked)
            {
                mskIDFiltrarEtapas.Enabled = false;
                btnFiltrarEtapasxID.Enabled = false;
                txtNombreFiltrarEtapas.Enabled = false;
                btnFiltrarEtapasxNombre.Enabled = false;
                DataTable tabla = new DataTable();
                tabla = ObtenerListadoEtapas();
                if (tabla == null || tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
                }
                else
                {
                    GenerarReporteFiltrado(tabla);
                }
            }

        }
        private void GenerarReporteFiltrado(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("Datos_Etapas", tabla);
            ReportListEtapas.LocalReport.DataSources.Clear();
            ReportListEtapas.LocalReport.DataSources.Add(ds);
            ReportListEtapas.RefreshReport();
        }

        public static DataTable ObtenerListadoEtapasxID(int idEtapa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM etapas where IdEtapa = @idEtapa";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEtapa", idEtapa);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerListadoEtapasxNombre(string nomEtapa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM etapas where NombreEtapa like @nomEtapa";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomEtapa", nomEtapa);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnFiltrarEtapasxID_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerListadoEtapasxID(int.Parse(mskIDFiltrarEtapas.Text));
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
            }
            else
            {
                GenerarReporteFiltrado(tabla);
            }
        }

        private void btnFiltrarEtapasxNombre_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerListadoEtapasxNombre(txtNombreFiltrarEtapas.Text);
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
            }
            else
            {
                GenerarReporteFiltrado(tabla);
            }
        }
    }
}
