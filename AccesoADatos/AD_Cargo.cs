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
    public class AD_Cargo
    {
        public static bool ValidarCargo(string nombreCargo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM cargos WHERE Nombre like @nombre ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombreCargo);
                
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
                else
                {
                    resultado = false;
                }
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

        public static bool InsertarCargo(string nombreCargo, string descripcionCargo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertarCargo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreCargo", nombreCargo);
                cmd.Parameters.AddWithValue("@descripcion", descripcionCargo);
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
            return resultado;
        }

        public static DataTable ObtenerListadoCargos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerTablaCargo";
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static Cargos ObtenerCargo(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cargos c = new Cargos();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerDatosCargo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    c.IdCargoEmpleado = (int)dr["IdCargo"];
                    c.NombreCargoEmpleado = dr["Nombre"].ToString();
                    c.DescripcionCargoEmpleado = dr["Descripcion"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }

            return c;

        }
        public static bool ModificarCargo(Cargos car)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ModifCargo2";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", car.IdCargoEmpleado);
                cmd.Parameters.AddWithValue("@nombre", car.NombreCargoEmpleado);
                cmd.Parameters.AddWithValue("@descripcion", car.DescripcionCargoEmpleado);

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

            return resultado;

        }

        public static bool EliminarCargo(Cargos car)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarCargo";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombre", car.NombreCargoEmpleado);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                resultado = false;
            }

            return resultado;

        }


    }

}
