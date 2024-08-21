using NewWare_Soft.Entidades;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.AccesoADatos
{
    class AD_Productos
    {
        public static bool agregarProductoABd(Producto prod)
        {
            bool resultado = false;
            try
            {
                Producto existe = obtenerProducto(prod.Denominacion);
                if (existe == null)
                {
                    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                    SqlConnection connect = new SqlConnection(cadenaConexion);
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        string consulta = "INSERT INTO productos (Denominacion, Descripcion, FechaFinalizacion, PrecioVenta) VALUES (@denominacion, @descripcion, @fechaFinalizacion, @precioVenta)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@denominacion", prod.Denominacion);
                        cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                        cmd.Parameters.AddWithValue("@fechaFinalizacion", prod.FechaDeFinalizacion);
                        cmd.Parameters.AddWithValue("@precioVenta", prod.Precio);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = consulta;
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.ExecuteNonQuery();
                        resultado = true;
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
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        public static DataTable obtenerProductosPrecioMayorA(int precio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM productos WHERE PrecioVenta >= @precio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@precio", precio);
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
        internal static DataTable obtenerProductoFechaMayor(string fecha)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM productos WHERE FechaFinalizacion >= @fecha";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", fecha);
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

        public static Producto obtenerProducto(string denominacion)
        {
            Producto prod = new Producto();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM productos WHERE Denominacion LIKE @denominacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", denominacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    prod.Denominacion = dr["Denominacion"].ToString();
                    prod.Descripcion = dr["Descripcion"].ToString();
                    prod.FechaDeFinalizacion = DateTime.Parse(dr["FechaFinalizacion"].ToString());
                    prod.Precio = int.Parse(dr["PrecioVenta"].ToString());
                }
                else
                {
                    prod = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
            return prod;
        }
        public static DataTable obtenerProductoConDenominacion(string denominacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM productos WHERE Denominacion LIKE '%" + (denominacion) + "%'";
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
        public static DataTable cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Denominacion, Descripcion, FechaFinalizacion, PrecioVenta FROM productos";
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
        public static DataTable obtenerListadoProductos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM productos";
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
        public static bool actualizarProducto(Producto prod)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE productos SET Denominacion = @denominacion, Descripcion = @descripcion, FechaFinalizacion = @fechaFinalizacion, PrecioVenta = @precio WHERE Denominacion LIKE @denominacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", prod.Denominacion);
                cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                cmd.Parameters.AddWithValue("@fechaFinalizacion", prod.FechaDeFinalizacion);
                cmd.Parameters.AddWithValue("@precio", prod.Precio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
            return resultado;
        }
        public static bool eliminarProducto(Producto prod)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM productos WHERE Denominacion LIKE @denominacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", prod.Denominacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
            return resultado;
        }

        public static Producto obtenerDatosProductoSeleccionado(string denominacion)
        {
            Producto prod = new Producto();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT p.IdProducto, p.Denominacion, p.PrecioVenta FROM productos p WHERE Denominacion LIKE @denominacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", denominacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    prod.IdProducto = int.Parse(dr["IdProducto"].ToString());
                    prod.Denominacion = dr["Denominacion"].ToString();
                    prod.Precio = int.Parse(dr["PrecioVenta"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
            return prod;
        }

        public static DataTable GetEstadisticaPreciosProduc()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select IdProducto AS 'Producto', PrecioVenta AS 'Precio' from productos";

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

        public static DataTable GetEstadisticaPromPrecios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select concat(year(FechaFinalizacion), '-', month(FechaFinalizacion)) as 'Mes', AVG(PrecioVenta) AS 'Promedio' from productos GROUP BY year(FechaFinalizacion), month(FechaFinalizacion) ";

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

        public static int GetPromedio()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select AVG(PrecioVenta) from productos";

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
        public static DataTable getProductosMasVendidos()
        {
            string connection_network = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection_duct = new SqlConnection(connection_network);

            try
            {
                SqlCommand command = new SqlCommand();
                string query = "select p.Denominacion, count(*) as 'Cantidad' " +
                                "from detalle_factura d inner join productos p on d.IdProducto = p.IdProducto " +
                                "group by p.Denominacion";
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                connection_duct.Open();
                command.Connection = connection_duct;

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection_duct.Close();
            }
        }
    }
}