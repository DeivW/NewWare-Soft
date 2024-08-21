using NewWare_Soft.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.AccesoADatos
{
    public class AD_FPagos
    {
        public static bool VerificarExistencia(string nombreBanco)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "VerifyExistBanco";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBanco", nombreBanco);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public static bool InsertarBanco(string nombreBanco)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertBanco";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBanco", nombreBanco);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static bool ActualizarNombreBanco(int idBanco, string nomNuevo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateBanco";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBanco", nomNuevo);
                cmd.Parameters.AddWithValue("@idBanco", idBanco);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static Banco ObtenerBanco(string nomABuscar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            Banco b = new Banco();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "GetBanco";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBanco", nomABuscar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    b.IdBanco = int.Parse(dr["IdBanco"].ToString());
                    b.NombreBanco = dr["Nombre"].ToString();
                }
                else
                {
                    b.NombreBanco = "";
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
            return b;
        }
        public static bool EliminarBanco(string nomBanco)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteBanco";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBanco", nomBanco);
                cmd.CommandType = CommandType.StoredProcedure;
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
        //public static DataTable ObtenerBancos()
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand();


        //        string consulta = "SELECT * FROM bancos";

        //        cmd.Parameters.Clear();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;

        //        DataTable tabla = new DataTable();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(tabla);

        //        return tabla;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}
        public static DataTable ObtenerListaBancos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "GetListBancos";

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
    }
}
