using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.AccesoADatos
{
    public class AD_Etapas
    {
        public static DataTable duracionEtapa()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT et.NombreEtapa as 'Codigo' , DATEDIFF(day, e.fechaInicio, e.fechaFin) as 'Duracion' FROM etapas_X_proyecto e JOIN etapas et ON e.idEtapa = et.IdEtapa WHERE DATEDIFF(day, e.fechaInicio, e.fechaFin) >= ALL(select DATEDIFF(day, e1.fechaInicio, e1.fechaFin) from etapas_X_proyecto e1 where e.idEtapa = e1.idEtapa)";
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
        public static DataTable duracionEtapasPorProyectos(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT et.NombreEtapa as 'Codigo' , DATEDIFF(day, e.fechaInicio, e.fechaFin) as 'Duracion' FROM etapas_X_proyecto e JOIN etapas et ON e.idEtapa = et.IdEtapa JOIN proyectos p ON e.idProyecto = p.CodigoProyecto WHERE DATEDIFF(day, e.fechaInicio, e.fechaFin) >= ALL(select DATEDIFF(day, e1.fechaInicio, e1.fechaFin) from etapas_X_proyecto e1 JOIN proyectos p1 ON e1.idProyecto = p1.CodigoProyecto  where e.idEtapa = e1.idEtapa AND p.CodigoProyecto = p1.CodigoProyecto) AND p.Descripcion = @Nombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", nombre);
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
        public static DataTable duracionMayoRA(string duracion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT et.NombreEtapa as 'Codigo' , DATEDIFF(day, e.fechaInicio, e.fechaFin) as 'Duracion' FROM etapas_X_proyecto e JOIN etapas et ON e.idEtapa = et.IdEtapa JOIN proyectos p ON e.idProyecto = p.CodigoProyecto WHERE DATEDIFF(day, e.fechaInicio, e.fechaFin) >= @duracion ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@duracion", duracion);
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

