using NewWare_Soft.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.AccesoADatos
{
    public class AD_MotivosEgreso
    {
        public static bool VerificarExistencia(string nombreMotivo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM motivos_egresos WHERE NombreMotivoEgreso like @nombreMotivo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreMotivo", nombreMotivo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                return resultado;
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

        public static bool InsertarMotivoEgreso(string nombreMotivo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO motivos_egresos(NombreMotivoEgreso) VALUES(@nombreMotivo)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreMotivo", nombreMotivo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static DataTable ObtenerListaMotivos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM motivos_egresos";

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
        public static bool ActualizarNombreMotivo(int idMotivo, string nomNuevo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE motivos_egresos SET NombreMotivoEgreso = @nombreMotivo WHERE IdMotivoEgreso = @idMotivo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreMotivo", nomNuevo);
                cmd.Parameters.AddWithValue("@idMotivo", idMotivo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static MotivoEgreso ObtenerMotivo(string nomABuscar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            MotivoEgreso m = new MotivoEgreso();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM motivos_egresos WHERE NombreMotivoEgreso like @nombreMotivo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreMotivo", nomABuscar);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    m.IdMotivo = int.Parse(dr["IdMotivoEgreso"].ToString());
                    m.NombreMotivo = dr["NombreMotivoEgreso"].ToString();
                }
                else
                {
                    m.NombreMotivo = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return m;
        }
        public static bool EliminarMotivo(string nomMotivo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM motivos_egresos WHERE NombreMotivoEgreso like @nombreMotivo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreMotivo", nomMotivo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
    }
}
