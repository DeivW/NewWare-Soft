using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using NewWare_Soft.AccesoADatos;
using NewWare_Soft.Entidades;

namespace NewWare_Soft.Forms
{
    public partial class AltaEtapa : Form
    {
        public AltaEtapa()
        {
            InitializeComponent();
        }

        #region Cargar Grilla
        public void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion)
;
            try
            {
                string query = "select * from etapas";
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                canalConexion.Open();
                cmd.Connection = canalConexion;

                DataTable table = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(table);

                dgvEtapas.DataSource = table;

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


        #region Agregar Etapas
        private bool AddEtapa(Etapas etapa)
        {
            bool isValid = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {
                string query = "insert into etapas (NombreEtapa) values (@nombre)";
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", etapa.Nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                canalConexion.Open();
                cmd.Connection = canalConexion;

                cmd.ExecuteNonQuery();
                isValid = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                canalConexion.Close();
            }
            return isValid;
        }
        #endregion

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Etapas etapa = new Etapas();
                etapa.Nombre = txtNombre.Text;

                if (AddEtapa(etapa))
                {
                    CargarGrilla();
                    txtNombre.Text = "";
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("Error al cargar etapa");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AltaEtapa_Load_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}