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
    public class AD_Tarjetas
    {
        public static bool VerificarExistencia(int nroTarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM tarjetas WHERE NroTarjeta = @nroTarjeta";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", nroTarjeta);
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
        public static bool InsertarTarjeta(Tarjeta t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO tarjetas (NroTarjeta, CodigoSeguridad, FechaVencimiento, IdBanco) VALUES (@nroTarjeta, @codSeg, @fechaVen, @idBanco)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", t.NroTarjeta);
                cmd.Parameters.AddWithValue("@codSeg", t.Cod_seguridad);
                cmd.Parameters.AddWithValue("@fechaVen", t.Fecha_vencimiento);
                cmd.Parameters.AddWithValue("@idBanco", t.ID_Banco);
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

        public static DataTable ObtenerListaTarjetas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM tarjetas";

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
        public static Tarjeta ObtenerTarjeta(int nroTarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Tarjeta t = new Tarjeta();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM tarjetas where NroTarjeta = @nroTarjeta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", nroTarjeta);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    t.NroTarjeta = int.Parse(dr["NroTarjeta"].ToString());
                    t.Cod_seguridad = int.Parse(dr["CodigoSeguridad"].ToString());
                    t.Fecha_vencimiento = DateTime.Parse(dr["FechaVencimiento"].ToString());
                    t.ID_Banco = int.Parse(dr["IdBanco"].ToString());
                }
                else
                {
                    t.NroTarjeta = -1;
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
            return t;
        }
        public static bool ActualizarTarjeta(Tarjeta t, int nroViejo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE tarjetas SET NroTarjeta = @nroTarjeta, CodigoSeguridad = @codSeg, FechaVencimiento = @fechaVen, IdBanco = @idBanco WHERE NroTarjeta = @nroViejo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", t.NroTarjeta);
                cmd.Parameters.AddWithValue("@codSeg", t.Cod_seguridad);
                cmd.Parameters.AddWithValue("@fechaVen", t.Fecha_vencimiento);
                cmd.Parameters.AddWithValue("@idBanco", t.ID_Banco);
                cmd.Parameters.AddWithValue("@nroViejo", nroViejo);
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

        public static bool EliminarTarjeta(int nroTarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM tarjetas WHERE NroTarjeta like @nroTarjeta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTarjeta", nroTarjeta);
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

        //private Tarjeta ObtenerDatosTarjeta()
        //{
        //    Tarjeta t = new Tarjeta();

        //    t.NroTarjeta = int.Parse(txtNroTarjeta.Text);
        //    t.Fecha_vencimiento = DateTime.Parse(txtFechaVencimiento.Text);
        //    t.Cod_seguridad = int.Parse(txtCodSeguridad.Text);
        //    t.ID_Banco = (int)cmbBancos.SelectedValue;

        //    return t;
        //}
    }
}
