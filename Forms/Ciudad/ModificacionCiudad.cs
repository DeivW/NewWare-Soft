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
    public partial class ModificacionCiudad : Form
    {
        public ModificacionCiudad()
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

        private void grillaCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnModificarCiudad.Enabled = true;
            txtNombreCiudad.Enabled = true;
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

        private void ModificacionCiudad_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            btnModificarCiudad.Enabled = false;
        }

        private Ciudad ObtenerDatosCiudad()
        {
            Ciudad ciudad = new Ciudad();
            
            ciudad.NombreCiudad = txtNombreCiudad.Text.Trim();

            return ciudad;
          
        }
        private void btnModificarCiudad_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = ObtenerDatosCiudad();
            bool resultado = ActualizarCiudad(ciudad, txtIdCiudad.Text);
            if (resultado)
            {
                MessageBox.Show("CIUDAD ACTUALIZADA CON EXITO");
                CargarGrilla();
                LimpiarCampos();
                btnModificarCiudad.Enabled = false;
            }
            else
            {
                MessageBox.Show("ERROR AL MODIFICAR CIUDAD");
            }
        }
        private bool ActualizarCiudad(Ciudad ciudad, string idCiudad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE ciudades SET NombreCiudad = @NombreCiudad WHERE IdCiudad LIKE @IdCiudad";
                cmd.Parameters.AddWithValue("@NombreCiudad", ciudad.NombreCiudad);
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

        
    }
       
    
}
