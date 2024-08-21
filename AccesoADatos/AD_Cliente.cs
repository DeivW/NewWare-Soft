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
    class AD_Cliente
    {
        public static bool AgregarCliente_DB(Cliente client)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                bool result = false;
                string query = "InsertarNuevoCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", client.Nombre);
                cmd.Parameters.AddWithValue("@apellido", client.Apellido);
                cmd.Parameters.AddWithValue("@telefono", client.Telefono);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.Parameters.AddWithValue("@nroCalle", client.NroCalle);
                cmd.Parameters.AddWithValue("@calle", client.Calle);
                cmd.Parameters.AddWithValue("@idBarrio", client.Barrio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
                return result;
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

        public static DataTable ObtenerData_grid_Cliente()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT Email, Apellido, Nombre FROM clientes";
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

        public static Boolean BorrarCliente_DB(string var)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "BorrarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", var);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }

        }

        public static Cliente EncontrarCliente_DB(string email)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente dude = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "EncontrarCliente_Email";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", email);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    dude.IdCliente = int.Parse(dr["IdCliente"].ToString());
                    dude.Nombre = dr["Nombre"].ToString();
                    dude.Apellido = dr["Apellido"].ToString();
                    dude.Telefono = dr["Telefono"].ToString();
                    dude.Email = dr["Email"].ToString();
                    dude.NroCalle = int.Parse(dr["NroCalle"].ToString());
                    dude.Calle = dr["Calle"].ToString();
                    dude.Barrio = int.Parse(dr["IdBarrio"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return dude;
        }
        public static Boolean EncontrarCliente_Bool_DB(string email)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente dude = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "EncontrarCliente_Email";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", email);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
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


        public static bool UpdateCliente_DB(Cliente mod_cliente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                result = false;
                string query = "UPDATE clientes SET Nombre = @nombre, Apellido = @apellido, Email = @email, Telefono = @telefono, NroCalle = @nroCalle, Calle = @nombreCalle, IdBarrio = @idBarrio WHERE Email like @email";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", mod_cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", mod_cliente.Apellido);
                cmd.Parameters.AddWithValue("@email", mod_cliente.Email);
                cmd.Parameters.AddWithValue("@telefono", mod_cliente.Telefono);
                cmd.Parameters.AddWithValue("@nroCalle", mod_cliente.NroCalle);
                cmd.Parameters.AddWithValue("@nombreCalle", mod_cliente.Calle);
                cmd.Parameters.AddWithValue("@idBarrio", mod_cliente.Barrio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
                return result;
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

        public static object getData_Barrio_Combos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "GetComboBarrios";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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
        public static object getData_Producto_Combo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "GetComboProducto";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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

        #region Metodo Clientes mas de 5 productos
        public static DataTable Productos_x_Clientes()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {
                string query = "select CP.IdProducto, CP.IdCliente, CP.FechaVendido, CP.FechaInicioInstalacion, CP.LiderInstalacion " +
                               "from productos_x_clientes CP " +
                               "where CP.IdCliente in (select p.IdCliente from productos_x_clientes p group by p.IdCliente having count(*) > 5) " +
                               "group by CP.IdProducto, CP.IdCliente, CP.FechaVendido, CP.FechaInicioInstalacion, CP.LiderInstalacion";
                SqlCommand command = new SqlCommand();
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                canalConexion.Open();
                command.Connection = canalConexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(tabla);
                return tabla;


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

        #region ultimo nro factura
        public static int ultimoNroFactura()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string query = "SELECT MAX(NroFactura) FROM facturas";

                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                canalConexion.Open();
                command.Connection = canalConexion;
                try
                {
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
                catch (Exception)
                {
                    return -1;
                }
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

        #region ReporteListadoClientes
        public static DataTable ObtenerDataGrid_Cliente()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM clientes";
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
        #endregion

        #region ListadoFacturaClientes
        public static DataTable ObtenerFacturas_Cliente()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM facturas Order BY facturas.IdCliente";
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
        public static DataTable ObtenerDataGrid_tablaEmailCliente()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT c.Email AS 'Email' FROM facturas f JOIN clientes c ON(f.IdCliente = c.IdCliente) ORDER BY f.IdCliente";
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
        #endregion

        #region

        public static DataTable getData_Cliente_Combos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM clientes";
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
        #endregion

        #region
        public static DataTable EncontrarClienteTabla__DB(string email)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "EncontrarCliente_Email";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", email);
                cmd.CommandType = CommandType.StoredProcedure;
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
        #endregion
        #region
        public static DataTable getData_Clientes_Patron(string patron)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM clientes WHERE Apellido LIKE '%" + (patron) + "%'";
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
        #endregion
        #region
        public static DataTable EncontrarFacturasDeCliente__DB(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM facturas f WHERE f.IdCliente = " + id + " ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdCliente", id);
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

        #endregion
        #region
        public static DataTable getData_Facturas_Fechas(string desde, string hasta)
        { 
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT * FROM facturas f WHERE f.FechaFactura BETWEEN CONVERT(DATETIME, '" + desde + "', 103) AND CONVERT(DATETIME,'" + hasta + "',103)";
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



        #endregion
    }
}




