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
    public partial class ReporteListadoPersonal : Form
    {
        public ReporteListadoPersonal()
        {
            InitializeComponent();
        }

        private void ReporteListadoPersonal_Load(object sender, EventArgs e)
        {

            this.ReportListPersonal.RefreshReport();
        }

        private void ReportListPersonal_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = DAOpersonal.ObtenerListadoPersonalpReporte();

            ReportDataSource ds = new ReportDataSource("Datos_Personal", tabla);
            ReportListPersonal.LocalReport.DataSources.Clear();
            ReportListPersonal.LocalReport.DataSources.Add(ds);
            ReportListPersonal.LocalReport.Refresh();
        }

        private void GenerarReporteFiltrado(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("Datos_Personal", tabla);
            ReportListPersonal.LocalReport.DataSources.Clear();
            ReportListPersonal.LocalReport.DataSources.Add(ds);
            ReportListPersonal.RefreshReport();
        }

        private void btnFiltrarReportePersonal_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerTablaPersonalPorDNI(int.Parse(mskDniFiltroReportePersonal.Text));
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
            }
            else
            {
                GenerarReporteFiltrado(tabla);
            }
        }

        private void btnElegirReporte_Click(object sender, EventArgs e)
        {
            if (rdReportePersonalxDni.Checked)
            {
                //lblListarPorCargo.Visible = false;
                mskCargoFiltroListadoPersonal.Enabled = false;
                btnFiltrarReportePersonalCargo.Enabled = false;
                //lblFiltrarReportePersonal.Visible = true;
                mskDniFiltroReportePersonal.Enabled = true;
                btnFiltrarReportePersonal.Enabled = true;
            }
            if (rdListadoPersonalxCargo.Checked)
            {
                //lblFiltrarReportePersonal.Enabled = false;
                mskDniFiltroReportePersonal.Enabled = false;
                btnFiltrarReportePersonal.Enabled = false;
                //lblListarPorCargo.Enabled = true;
                mskCargoFiltroListadoPersonal.Enabled = true;
                btnFiltrarReportePersonalCargo.Enabled = true;
            }
            if (rdListadoPersonalTodos.Checked)
            {
                mskDniFiltroReportePersonal.Enabled = false;
                btnFiltrarReportePersonal.Enabled = false;
                mskCargoFiltroListadoPersonal.Enabled = false;
                btnFiltrarReportePersonalCargo.Enabled = false;
                DataTable tabla = new DataTable();
                tabla = DAOpersonal.ObtenerListadoPersonalpReporte();
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
        private DataTable ObtenerTablaPersonalPorDNI(int nroDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personal where NroDni like @nroDoc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc", nroDoc);
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
        private DataTable ObtenerTablaPersonalPorCargo(int idCargo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personal where IdCargo like @idCargo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCargo", idCargo);
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

        private void btnFiltrarReportePersonalCargo_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerTablaPersonalPorCargo(int.Parse(mskCargoFiltroListadoPersonal.Text));
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
