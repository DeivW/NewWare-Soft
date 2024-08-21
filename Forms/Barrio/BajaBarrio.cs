using NewWare_Soft.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms
{
    public partial class BajaBarrio : Form
    {
        public BajaBarrio()
        {
            InitializeComponent();
        }

        private void CargarCampos(Barrio barrio)
        {
            Ciudad ciudad = ObtenerCiudad(barrio.CiudadBarrio);
            txtNombreBarrio.Text = barrio.NombreBarrio;
            cmbCiudad.Items.Add(ciudad.NombreCiudad);
            cmbCiudad.SelectedIndex = 0;
            txtIdBarrio.Text = barrio.Id;

        }
        private void grillaBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnBorrarBarrio.Enabled = true;
            DataGridViewRow fila = grillaBarrios.Rows[indice];
            string nombreBarrio = fila.Cells["Nombre"].Value.ToString();
            Barrio barrio = ObtenerBarrio(nombreBarrio);
            LimpiarCampos();
            CargarCampos(barrio);
        }
        private Barrio ObtenerBarrio(string nombreBarrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Barrio barrio = new Barrio();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM barrios WHERE NombreBarrio like @NombreBarrio";
                cmd.Parameters.AddWithValue("@NombreBarrio", nombreBarrio);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    barrio.NombreBarrio = dr["NombreBarrio"].ToString();
                    barrio.CiudadBarrio = dr["IdCiudad"].ToString();
                    barrio.Id = dr["IdBarrio"].ToString();
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

            return barrio;
        }
        private void btnLimiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombreBarrio.Text = "";
            cmbCiudad.SelectedIndex = -1;
        }
        private Ciudad ObtenerCiudad(string idCiudad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Ciudad ciudad = new Ciudad();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM ciudades WHERE IdCiudad like @IdCiudad";
                cmd.Parameters.AddWithValue("@IdCiudad", idCiudad);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    ciudad.NombreCiudad = dr["NombreCiudad"].ToString();
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

            return ciudad;
        }
        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdBarrio, NombreBarrio FROM barrios";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaBarrios.DataSource = tabla;

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
        private void BajaBarrio_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarCampos();
        }
        private bool EliminarBarrio(string IdBarrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM barrios WHERE IdBarrio LIKE @IdBarrio";
                cmd.Parameters.AddWithValue("@IdBarrio", IdBarrio);


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
        private void btnBorrarBarrio_Click(object sender, EventArgs e)
        {
            Barrio barrio = ObtenerBarrio(txtNombreBarrio.Text);
            bool resultado = EliminarBarrio(txtIdBarrio.Text);
            if (resultado)
            {
                MessageBox.Show("BARRIO ELIMINADO CON EXITO");
                CargarGrilla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("ERROR AL ELIMINAR BARRIO");
            }
        }
    }
}
