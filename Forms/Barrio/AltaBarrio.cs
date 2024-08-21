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
    public partial class AltaBarrio : Form
    {
        public AltaBarrio()
        {
            InitializeComponent();
        }

        private void AltaBarrio_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboCiudad();
            CargarGrilla();
        }
        private void btnLimiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            CargarComboCiudad();
        }
        private void LimpiarCampos()
        {
            txtNombreBarrio.Text = "";
            cmbCiudad.Text = "";
        }
        private void CargarComboCiudad()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM ciudades";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbCiudad.DataSource = tabla;
                cmbCiudad.DisplayMember = "NombreCiudad";
                cmbCiudad.ValueMember = "IdCiudad";
                cmbCiudad.SelectedIndex = -1;

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
        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdBarrio, NombreBarrio, IdCiudad FROM barrios";
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
        
        private void btnAgregarBarrio_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO barrios (NombreBarrio, IdCiudad) VALUES (@NombreBarrio, @Ciudad)";
                cmd.Parameters.AddWithValue("@NombreBarrio", txtNombreBarrio.Text);
                cmd.Parameters.AddWithValue("@Ciudad", (int)cmbCiudad.SelectedValue);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                CargarGrilla();
                MessageBox.Show("BARRIO DADO DE ALTA CON EXITO");
                LimpiarCampos();
                    


               

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
    }
}
