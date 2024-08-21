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
    public class DAOpersonal
    {
        public static DataTable ObtenerTiposUsuarios()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM usuarios";

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

        public static DataTable ObtenerTiposBarrio()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM barrios";

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

        public static DataTable ObtenerTiposCargo()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM cargos";

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

        public static DataTable ObtenerTiposEgreso()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
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

        public static bool ActualizarPersonal(Personal per)
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE personal SET NroDni = @nroDni, Apellido = @apellido, Nombre = @nombre, IdUsuario = @idUsuario, FechaIngreso = @fechaIngreso, FechaEgreso = @fechaEgreso," +
                    "IdMotivoEgreso = @idMotivoEgreso, IdCargo = @idCargo, NroCalle = @nroCalle, Calle = @calle, IdBarrio = @idBarrio, FechaNacimiento = @fechaNacimiento WHERE Legajo like @legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", per.LegajoPersonal);
                cmd.Parameters.AddWithValue("@nroDni", per.NroDniPersonal);
                cmd.Parameters.AddWithValue("@apellido", per.ApellidoPersonal);
                cmd.Parameters.AddWithValue("@nombre", per.NombrePersonal);
                cmd.Parameters.AddWithValue("@idUsuario", per.IdUsuarioPersonal);
                cmd.Parameters.AddWithValue("@fechaIngreso", per.FechaIngresoPersonal);
                cmd.Parameters.AddWithValue("@fechaEgreso", per.FechaEgresoPersonal);
                cmd.Parameters.AddWithValue("@idMotivoEgreso", per.IdMotivoEgresoPersonal);
                cmd.Parameters.AddWithValue("@idCargo", per.IdCargoPersonal);
                cmd.Parameters.AddWithValue("@nroCalle", per.NroCallePersonal);
                cmd.Parameters.AddWithValue("@calle", per.CallePersonal);
                cmd.Parameters.AddWithValue("@idBarrio", per.IdBarrioPersonal);
                cmd.Parameters.AddWithValue("@fechaNacimiento", per.FechaNacimientoPersonal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return res;
        }

        public static Personal ObtenerPersonal(string leg)
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);
            Personal p = new Personal();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personal where Legajo like @legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", leg);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.NombrePersonal = dr["Nombre"].ToString();
                    p.NroDniPersonal = dr["NroDni"].ToString();
                    p.ApellidoPersonal = dr["Apellido"].ToString();
                    p.CallePersonal = dr["Calle"].ToString();
                    p.NroCallePersonal = dr["NroCalle"].ToString();
                    p.FechaIngresoPersonal = DateTime.Parse(dr["FechaIngreso"].ToString());
                    p.FechaEgresoPersonal = DateTime.Parse(dr["FechaEgreso"].ToString());
                    p.FechaNacimientoPersonal = DateTime.Parse(dr["FechaNacimiento"].ToString());
                    p.IdUsuarioPersonal = int.Parse(dr["IdUsuario"].ToString());
                    p.IdCargoPersonal = int.Parse(dr["IdCargo"].ToString());
                    p.IdMotivoEgresoPersonal = int.Parse(dr["IdMotivoEgreso"].ToString());
                    p.IdBarrioPersonal = int.Parse(dr["IdBarrio"].ToString());
                    p.LegajoPersonal = int.Parse(dr["Legajo"].ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return p;
        }


        public static DataTable ObtenerListadoPersonalGrilla()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT Legajo, NroDni, Apellido, Nombre, FechaNacimiento FROM personal";
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

        public static DataTable ObtenerListadoPersonalGrillaBaja()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT Legajo, NroDni, Apellido, Nombre, IdCargo, FechaIngreso, IdBarrio FROM personal";
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

        public static bool InsertarPersonal(Personal per)
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO personal (NroDni, Apellido, Nombre, IdUsuario, FechaIngreso, FechaEgreso, IdMotivoEgreso, IdCargo, NroCalle, Calle, IdBarrio, FechaNacimiento)" +
                    " VALUES (@nroDni, @apellido, @nombre, @idUsuario, @fechaIngreso, @fechaEgreso, @idMotivoEgreso, @idCargo, @nroCalle, @calle, @idBarrio, @fechaNacimiento)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDni", per.NroDniPersonal);
                cmd.Parameters.AddWithValue("@apellido", per.ApellidoPersonal);
                cmd.Parameters.AddWithValue("@nombre", per.NombrePersonal);
                cmd.Parameters.AddWithValue("@idUsuario", per.IdUsuarioPersonal);
                cmd.Parameters.AddWithValue("@fechaIngreso", per.FechaIngresoPersonal);
                cmd.Parameters.AddWithValue("@fechaEgreso", per.FechaEgresoPersonal);
                cmd.Parameters.AddWithValue("@idMotivoEgreso", per.IdMotivoEgresoPersonal);
                cmd.Parameters.AddWithValue("@idCargo", per.IdCargoPersonal);
                cmd.Parameters.AddWithValue("@nroCalle", per.NroCallePersonal);
                cmd.Parameters.AddWithValue("@calle", per.CallePersonal);
                cmd.Parameters.AddWithValue("@idBarrio", per.IdBarrioPersonal);
                cmd.Parameters.AddWithValue("@fechaNacimiento", per.FechaNacimientoPersonal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return res;
        }

        public static bool EliminarPersonal(Personal per)
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM personal WHERE Legajo like @legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", per.LegajoPersonal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return res;
        }

        public static DataTable ObtenerListadoPersonal()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personal_x_etapas";

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
        public static DataTable ObtenerListadoPersonalpReporte()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personal";

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
    }
}
