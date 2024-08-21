using NewWare_Soft.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NewWare_Soft.AccesoADatos
{
    class AD_Proyectos
    {
        public static int obtenerUltimoProyectoId()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(CodigoProyecto) FROM proyectos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                connect.Close();
            }
        }

        public static DataTable ObtenerProyectos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
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

        public static DataTable ObtenerEtapa()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetEtapa";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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
        public static DataTable obtenerTablaClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM clientes";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        public static int ObtenerIDEtapa(string nomEtapa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT IdEtapa FROM etapas WHERE NombreEtapa like '" + nomEtapa + "'";

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
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool agregarProyectoABD(Proyecto pro, List<int> listaEtapas, int idProyecto)
        {
            bool resultado = false;
            try
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlTransaction objTransaccion = null;
                SqlConnection connect = new SqlConnection(cadenaConexion);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "INSERT INTO proyectos (IdCliente, Descripcion, FechaInicial, FechaFinProbable, FechaFinReal) VALUES (@idCliente, @descripcion, @fechaInicio, @fechaFin, @fechaFinReal)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idCliente", pro.IdCliente);
                    cmd.Parameters.AddWithValue("@descripcion", pro.Descripcion);
                    cmd.Parameters.AddWithValue("@fechaInicio", pro.FechaDeInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", pro.FechaDeFinProbable);
                    cmd.Parameters.AddWithValue("@fechaFinReal", pro.FechaDeFinReal);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    connect.Open();
                    objTransaccion = connect.BeginTransaction("AltaDeProyecto");
                    cmd.Transaction = objTransaccion;
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();
                    foreach (var etapa in listaEtapas)
                    {
                        string consulta2 = "INSERT INTO etapas_X_proyecto VALUES (@IdEtapa, @IdProyecto, @fechaIni, @fechaFinal)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@IdEtapa", etapa);
                        cmd.Parameters.AddWithValue("@IdProyecto", idProyecto);
                        cmd.Parameters.AddWithValue("@fechaIni", pro.FechaDeInicio);
                        cmd.Parameters.AddWithValue("@fechaFinal", pro.FechaDeFinReal);
                        cmd.CommandText = consulta2;
                        cmd.ExecuteNonQuery();
                    }
                    objTransaccion.Commit();
                    resultado = true;
                }
                catch (Exception ex)
                {
                    objTransaccion.Rollback();
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public static DataTable ObtenerProyectoPorID(int codProyecto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM proyectos WHERE CodigoProyecto = @codProyecto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codProyecto", codProyecto);
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
        public static bool HerramientasPorEtapa(int codProyecto, int idEtapa, List<int> listaIDsHerramientas)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlTransaction objTransaccion = null;
            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.Text;
                cmd.Transaction = objTransaccion;

                cn.Open();
                objTransaccion = cn.BeginTransaction("AltaHerramientoXEtapa");

                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                foreach (var idHerramienta in listaIDsHerramientas)
                {
                    string consulta1 = "INSERT INTO herramientas_x_etapas_x_proyectos values(@idHerramienta,@idEtapa,@codProyecto)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idHerramienta", idHerramienta);
                    cmd.Parameters.AddWithValue("@idEtapa", idEtapa);
                    cmd.Parameters.AddWithValue("@codProyecto", codProyecto);
                    cmd.CommandText = consulta1;

                    cmd.CommandText = consulta1;
                    cmd.ExecuteNonQuery();

                }

                objTransaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {

                objTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerProyectosXEtapa(int etapa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM etapas_X_proyecto WHERE idEtapa = @etapa";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@etapa", etapa);
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
        public static DataTable ObtenerProyectosActivos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM proyectos WHERE GETDATE() BETWEEN FechaInicial AND FechaFinReal";

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

        public static DataTable ObtenerProyectoPorFechaInicio(DateTime fechaInicio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "Select * from proyectos WHERE FechaInicial >= Convert(datetime, '" + fechaInicio + "', 103)";

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

        public static DataTable ObtenerProyectosPorPatrón(string patron)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM proyectos WHERE Descripcion LIKE '%" + patron + "%' ";

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

        public static DataTable ObtenerProyectosXMes(int mes)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM proyectos WHERE MONTH(FechaInicial) = @mes";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mes", mes);
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
        public static DataTable ObtenerProyectoActivoXFecha(DateTime fechaInicio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM proyectos WHERE GETDATE() BETWEEN FechaInicial AND FechaFinReal AND FechaInicial >= Convert(datetime, '" + fechaInicio + "', 103)";

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

        public static DataTable ObtenerProyectosXID(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM proyectos WHERE IdCliente = @id AND GETDATE() BETWEEN FechaInicial AND FechaFinReal";

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

        public static DataTable getEstadistica()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MONTH(p.FechaInicial) as Mes, COUNT(*) as Cantidad FROM proyectos p GROUP BY MONTH(p.FechaInicial)";

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

        public static DataTable getEstadisticaCli(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MONTH(p.FechaInicial) as Mes, COUNT(*) as Cantidad FROM proyectos p WHERE IdCliente = @id GROUP BY MONTH(p.FechaInicial)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id" , id);
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

        public static DataTable getDuracion1()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT CodigoProyecto as Proyecto, DATEDIFF(day, FechaInicial, FechaFinReal) as Duracion FROM proyectos";

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

        public static DataTable getDuracion2()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT CodigoProyecto as Proyecto, DATEDIFF(day, FechaInicial, FechaFinReal) as Duracion FROM proyectos WHERE DATEDIFF(day, FechaInicial, FechaFinReal) > (SELECT AVG(DATEDIFF(day, FechaInicial, FechaFinReal)) FROM proyectos)";

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

        public static int getPromDuracion()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT  AVG(DATEDIFF(day, FechaInicial, FechaFinReal)) FROM proyectos";

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
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }
            #region Proyectos Finalizados
            public static DataTable proyectoFinalizados()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {
                string query = "Select p.CodigoProyecto, p.IdCliente, p.Descripcion, p.FechaInicial, p.FechaFinProbable, p.FechaFinReal " +
                               "from proyectos p " +
                               "where p.FechaFinReal is not null " +
                               "group by p.CodigoProyecto, p.IdCliente, p.Descripcion, p.FechaInicial, p.FechaFinProbable, p.FechaFinReal";

                SqlCommand command = new SqlCommand();
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                canalConexion.Open();
                command.Connection = canalConexion;

                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(table);

                return table;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                canalConexion.Close();
            }
        }
        #endregion
    }

}
