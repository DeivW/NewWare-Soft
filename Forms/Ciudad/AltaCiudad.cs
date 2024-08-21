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
    public partial class AltaCiudad : Form
    {
        public AltaCiudad()
        {
            InitializeComponent();
        }
        private void AltaCiudad_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void btnLimiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombreCiudad.Text = "";
           
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
        private bool AgregarCiudad(Ciudad ciudad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO ciudades (NombreCiudad) VALUES(@NombreCiudad)";
                cmd.Parameters.AddWithValue("@NombreCiudad", ciudad.NombreCiudad);
                

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

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.NombreCiudad = txtNombreCiudad.Text.Trim();

            bool resultado = AgregarCiudad(ciudad);
            if (resultado)
            {
                MessageBox.Show("CIUDAD AGREGADA CON EXITO");
                CargarGrilla();
                LimpiarCampos();
             
            }
            else
            {
                MessageBox.Show("ERROR AL AGREGAR CIUDAD");
            }
        }
       
       
    }
}
