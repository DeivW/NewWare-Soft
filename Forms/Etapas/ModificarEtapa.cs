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
using NewWare_Soft.Entidades;

namespace NewWare_Soft.Forms
{
    public partial class ModificarEtapa : Form
    {
        int global;
        public ModificarEtapa()
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


        #region Modificar Etapa
        private bool updateEtapa(Etapas etapa, int global)
        {
            bool isValid = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {
                string query = "update etapas set NombreEtapa = @nombre where IdEtapa = @id";
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", etapa.Nombre);
                cmd.Parameters.AddWithValue("@id", global);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                canalConexion.Open();
                cmd.Connection = canalConexion;
                cmd.ExecuteNonQuery();
                isValid = true;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                canalConexion.Close();
            }
            return isValid;
        }
        #endregion

        #region Load
        private void ModificarEtapa_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            txtNombre.Focus();
            CargarGrilla();
        }
        #endregion


        #region Evento Cell click
        private void dgvEtapas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnModificar.Enabled = true;
            DataGridViewRow filaSeleccionada = dgvEtapas.Rows[indice];
            string nombre = filaSeleccionada.Cells["NombreEtapa"].Value.ToString();
            Etapas etapa = ObtenerEtapa(nombre);
            txtNombre.Text = " ";
            cargarCampo(etapa);
        }
        #endregion

        #region Boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Etapas etapa = ObtenerDatosEtapa();
                bool resultado = updateEtapa(etapa, global);
                if (resultado)
                {
                    CargarGrilla();
                    MessageBox.Show("Operacion exitosa");
                    txtNombre.Text = "";
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo ejecutar la operacion");
                    txtNombre.Text = "";
                    txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Obtener Datos Personas
        private Etapas ObtenerDatosEtapa()
        {
            Etapas etapa = new Etapas();
            etapa.Nombre = txtNombre.Text.Trim();
            return etapa;
        }
        #endregion

        #region Obtener Etapas
        private Etapas ObtenerEtapa(string nombre)
        {
            Etapas e = new Etapas();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string query = "select * from etapas where NombreEtapa like @nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);

                command.CommandType = CommandType.Text;
                command.CommandText = query;

                canalConexion.Open();
                command.Connection = canalConexion;

                SqlDataReader dr = command.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    global = int.Parse(dr["IdEtapa"].ToString());
                    e.Nombre = dr["NombreEtapa"].ToString();
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
            return e;

        }
    #endregion

        #region Cargar Campo
        private void cargarCampo(Etapas etapa)
        {
            txtNombre.Text = etapa.Nombre;
        }
        #endregion
    }
}
