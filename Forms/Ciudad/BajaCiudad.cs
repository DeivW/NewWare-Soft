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
    public partial class BajaCiudad : Form
    {
        public BajaCiudad()
        {
            InitializeComponent();
        }

        private void btnLimiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombreCiudad.Text = "";
            txtIdCiudad.Text = "";
        }
        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdCiudad, NombreCiudad FROM ciudades";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaCiudades.DataSource = tabla;

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

        private Ciudad ObtenerDatosCiudad()
        {
            Ciudad ciudad = new Ciudad();

            ciudad.NombreCiudad = txtNombreCiudad.Text.Trim();

            return ciudad;

        }

        private bool EliminarCiudad (string idCiudad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM ciudades WHERE IdCiudad LIKE @IdCiudad";
                cmd.Parameters.AddWithValue("@IdCiudad", idCiudad);


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
        private void btnBajaCiudad_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = ObtenerDatosCiudad();
            bool resultado = EliminarCiudad(txtIdCiudad.Text);
            if (resultado)
            {
                MessageBox.Show("CIUDAD ELIMINADA CON EXITO");
                CargarGrilla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("ERROR AL ELIMINAR CIUDAD");
            }
        }

        private void BajaCiudad_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();

        }

        private void grillaCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnBajaCiudad.Enabled = true;
            DataGridViewRow fila = grillaCiudades.Rows[indice];
            string nombreCiudad = fila.Cells["Nombre"].Value.ToString();
            string idCiudad = fila.Cells["Numero"].Value.ToString();
            Ciudad ciudad = ObtenerCiudad(nombreCiudad);
            LimpiarCampos();
            CargarCampos(ciudad, idCiudad);
        }
        private Ciudad ObtenerCiudad(string nombreCiudad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Ciudad ciudad = new Ciudad();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM ciudades WHERE NombreCiudad like @NombreCiudad";
                cmd.Parameters.AddWithValue("@NombreCiudad", nombreCiudad);


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
        private void CargarCampos(Ciudad ciudad, string idCiudad)
        {
            txtNombreCiudad.Text = ciudad.NombreCiudad;
            txtIdCiudad.Text = idCiudad;


        }
    }
}
