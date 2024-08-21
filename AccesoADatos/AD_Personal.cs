using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.AccesoADatos
{
    class AD_Personal
    {
        public static DataTable ObtenerDataGrid_Antiguedad_Todos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT p.Apellido, DATEDIFF (m, p.FechaIngreso, p.FechaEgreso) AS 'Antiguedad' FROM personal p ORDER BY 2";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerDataGrid_Antiguedad_Todos_Año()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT p.Apellido, DATEDIFF (m, p.FechaIngreso, p.FechaEgreso) AS 'Antiguedad' FROM personal p WHERE DATEDIFF (m, p.FechaIngreso, p.FechaEgreso) >= 12 ORDER BY 2";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable obtenerDataGrid_Antiguedad_Viaje(int año)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string query = "SELECT p.Apellido, DATEDIFF (YYYY, p.FechaIngreso, p.FechaEgreso) AS 'Antiguedad' FROM personal p WHERE DATEDIFF (YYYY, p.FechaIngreso, p.FechaEgreso) >= " + año.ToString() + " ORDER BY 2";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
