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

namespace NewWare_Soft.Forms.Estadisticas
{
    public partial class Estadistica_EdadPromPersonal : Form
    {
        public Estadistica_EdadPromPersonal()
        {
            InitializeComponent();
        }

        private void Estadistica_EdadPromPersonal_Load(object sender, EventArgs e)
        {
            this.RvcEstadisticaEdadProm.RefreshReport();
            txtEdadPromEstadistica.Text = ObtenerPromedioEdad().ToString();
        }

        private void RvcEstadisticaEdadProm_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = ObtenerEdades();

            ReportDataSource ds = new ReportDataSource("DatosEdadProm", tabla);
            RvcEstadisticaEdadProm.LocalReport.DataSources.Clear();
            RvcEstadisticaEdadProm.LocalReport.DataSources.Add(ds);
            RvcEstadisticaEdadProm.LocalReport.Refresh();
        }

        private void ArmarEstadisticaCompleta()
        {
            DataTable tabla = new DataTable();

            tabla = ObtenerEdades();

            ReportDataSource ds = new ReportDataSource("DatosEdadProm", tabla);
            RvcEstadisticaEdadProm.LocalReport.DataSources.Clear();
            RvcEstadisticaEdadProm.LocalReport.DataSources.Add(ds);
            RvcEstadisticaEdadProm.RefreshReport();

        }
        private void ArmarEstadisticaFiltrada(int idCargo)
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerEdadesFiltrado(idCargo);

            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
            }
            else
            {
                ReportDataSource ds = new ReportDataSource("DatosEdadProm", tabla);
                RvcEstadisticaEdadProm.LocalReport.DataSources.Clear();
                RvcEstadisticaEdadProm.LocalReport.DataSources.Add(ds);
                RvcEstadisticaEdadProm.RefreshReport();
                txtEdadPromEstadistica.Text = ObtenerPromedioEdadFiltrado(int.Parse(txtCargoEstadisticaEdadProm.Text)).ToString();
            }
        }
        public static int ObtenerPromedioEdad()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select avg(datediff(year, p.fechaNacimiento, getdate())) as 'Promedio' from personal p";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();

                return resultado;
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
        public static int ObtenerPromedioEdadFiltrado(int idCargo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select avg(datediff(year, p.fechaNacimiento, getdate())) as 'Promedio' from personal p where IdCargo = @idCargo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCargo", idCargo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();

                return resultado;
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
        public static DataTable ObtenerEdades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select datediff(year, p.fechaNacimiento, getdate()) as 'Edad', count(datediff(year, p.fechaNacimiento, getdate())) as 'Cantidad' from personal p group by datediff(year, p.fechaNacimiento, getdate()) order by datediff(year, p.fechaNacimiento, getdate())";

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
        public static DataTable ObtenerEdadesFiltrado(int idCargo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select datediff(year, p.fechaNacimiento, getdate()) as 'Edad', count(datediff(year, p.fechaNacimiento, getdate())) as 'Cantidad' from personal p where p.IdCargo = @idCargo group by datediff(year, p.fechaNacimiento, getdate()) order by datediff(year, p.fechaNacimiento, getdate())";

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
        private void btnElegirEstadisticaEdadProm_Click(object sender, EventArgs e)
        {
            if (rdMostrarEstadisticaEdadPromCompleta.Checked)
            {
                txtCargoEstadisticaEdadProm.Enabled = false;
                btnFiltrarEstadisticaEdadProm.Enabled = false;
                ArmarEstadisticaCompleta();
                txtEdadPromEstadistica.Text = ObtenerPromedioEdad().ToString();
            }
            if (rdEstadisticaEdadPromFiltroPorCargo.Checked)
            {
                txtCargoEstadisticaEdadProm.Enabled = true;
                btnFiltrarEstadisticaEdadProm.Enabled = true;

            }

        }

        private void btnFiltrarEstadisticaEdadProm_Click(object sender, EventArgs e)
        {
            if (txtCargoEstadisticaEdadProm.Text.Equals(""))
            {
                MessageBox.Show("ERROR! Debe ingresar un cargo para filtrar");
            }
            else
            {
                ArmarEstadisticaFiltrada(int.Parse(txtCargoEstadisticaEdadProm.Text));
            }


        }
    }
}
