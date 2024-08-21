using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewWare_Soft.Entidades;

namespace NewWare_Soft.AccesoADatos
{
    public class AD_PersonalXEtapa
    {
       
        public static DataTable ObtenerPersonalXLegajo(int legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personal WHERE Legajo LIKE @legajo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
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


        public static DataTable BuscarPersonalEnTablaPXE(int legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personal_X_etapas WHERE Legajo LIKE @legajo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
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
        public static DataTable ConfirmarEtapaxProyecto(int idProyecto, int idEtapa)
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM etapas_x_proyecto where idProyecto = @idProyect and idEtapa = @idEtapa";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProyect", idProyecto);
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

        public static bool TransaccionPersonalXEtapa(int idEtapa, int idProyecto, List<Personal>listaPersonal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlTransaction objTransac = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
               
                

                cn.Open();
                objTransac = cn.BeginTransaction("AltaPersonasXEtapa");
                cmd.Transaction = objTransac;
                cmd.Connection = cn;
                




                foreach (Personal item in listaPersonal)
                {
                    
                    string consulta = "Insert into personal_x_etapas values(@idEtapa, @idProyecto, @legajo, @fechaIngreso, @fechaEgreso, @idCargo, @cantHoras)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idEtapa", idEtapa);
                    cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
                    cmd.Parameters.AddWithValue("@legajo", item.LegajoPersonal);
                    cmd.Parameters.AddWithValue("@fechaIngreso", item.FechaIngresoPersonal);
                    cmd.Parameters.AddWithValue("@FechaEgreso", item.FechaEgresoPersonal);
                    cmd.Parameters.AddWithValue("@idCargo", item.IdCargoPersonal);
                    cmd.Parameters.AddWithValue("@cantHoras", item.CantidadHoras);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cmd.ExecuteNonQuery();
                }

                objTransac.Commit();

                return true;
            }
            catch (Exception ex)
            {
                objTransac.Rollback();
                throw;
                
            }

            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerEtapas()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
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

        public static DataTable ObtenerProyectos()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM proyectos";

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

        public static DataTable ObtenerListadoPersonalXetapa()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM personal_x_etapas";
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

        public static DataTable ObtenerProyectosTabPXE()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT distinct IdProyecto FROM personal_X_etapas";

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

        public static DataTable ObtenerPersonalTabPXE()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "select * from personal_X_etapas";

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

        public static DataTable ObtenerProyectoPersonalXetapa(int IdProyecto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM personal_x_etapas where IdProyecto=@idProy";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProy", IdProyecto);
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

        public static DataTable ObtenerEmpleadoPersonalXetapa(int Legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM personal_x_etapas where Legajo=@legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", Legajo);
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

        public static DataTable BuscarPxPEntreFechas(string desde, string hasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "select * from personal_x_etapas where FechaInicioParticipacion >= convert(datetime,'" + desde + "' ,103) and FechaFinParticipacion <= CONVERT(datetime,'" + hasta + "', 103)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaDesde", desde);
                cmd.Parameters.AddWithValue("@fechaHasta", hasta);
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

        public static DataTable BuscarPersonalXetapa_porInt(int id, string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personal_X_etapas WHERE " + nombre + " LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
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

        public static DataTable ObtenerEstadisticasporProyectos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select pe.IdProyecto as 'Proyecto', count(pe.Legajo) as 'Empleados' from personal_x_etapas pe group by pe.IdProyecto";

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

        public static DataTable ObtenerEstadisticasProyectosporFecha(DateTime fechaIni)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select pe.IdProyecto as 'Proyecto', count(pe.Legajo) as 'Empleados' from personal_x_etapas pe, proyectos p where p.FechaInicial >= @fechaIni  and pe.IdProyecto =p.CodigoProyecto group by pe.IdProyecto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("fechaIni", fechaIni);
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
    }
}
