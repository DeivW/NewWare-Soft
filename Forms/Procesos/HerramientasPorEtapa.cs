using NewWare_Soft.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NewWare_Soft.Forms
{
    public partial class HerramientasPorEtapa : Form
    {
        public HerramientasPorEtapa()
        {
            InitializeComponent();
        }

        private void HerramientasPorEtapa_Load(object sender, EventArgs e)
        {
            CargarComboHerramientas();
            cmbHerramientas.SelectedIndex = 0;
        }

        private void btnBuscarProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Proyectos.ObtenerProyectoPorID(int.Parse(txtCodProyecto.Text));
                if (tablaResultado.Rows.Count > 0)
                {
                    txtDescProyecto.Text = tablaResultado.Rows[0][2].ToString();
                    CargarComboEtapas(int.Parse(txtCodProyecto.Text));
                    cmbEtapas.Enabled = true;
                    cmbEtapas.SelectedIndex = 0;
                    btnAgregarHerramienta.Enabled = true;
                    cmbHerramientas.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El proyecto no fue encontrado");
                    txtCodProyecto.Focus();
                    txtDescProyecto.Clear();
                    cmbEtapas.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
        }

        private void CargarComboEtapas(int idProyecto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT e.* FROM etapas e " +
                                  "JOIN etapas_X_proyecto x ON(e.idEtapa = x.IdEtapa) " +
                                  "WHERE x.idProyecto = @idProyecto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;


                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                cmbEtapas.DataSource = tabla;
                cmbEtapas.DisplayMember = "NombreEtapa";
                cmbEtapas.ValueMember = "IdEtapa";
                cmbEtapas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo");
            }
            finally
            {
                cn.Close();
            }
        }

        private void txtCodProyecto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cmbEtapas.Enabled = false;
        }

        private void CargarComboHerramientas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM herramientas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;


                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                cmbHerramientas.DataSource = tabla;
                cmbHerramientas.DisplayMember = "Nombre";
                cmbHerramientas.ValueMember = "IdHerramienta";
                cmbHerramientas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo");
            }
            finally
            {
                cn.Close();
            }
        }
        private DataTable ConsultarDescripcion(int idHerramienta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM herramientas WHERE IdHerramienta like @idHerramienta";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idHerramienta", idHerramienta);
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
                MessageBox.Show("Error al cargar combo");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private bool HerramientaCargadaPreviamente()
        {
            for (int i = 0; i < gdrHerramientas.Rows.Count; i++)
            {
                if (gdrHerramientas.Rows[i].Cells[0].Value.Equals(cmbHerramientas.SelectedValue))
                {
                    return false;
                }              
            }

            return true;
        }

        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {
            if (HerramientaCargadaPreviamente() == true)
            {
                try
                {
                    DataTable tabla = ConsultarDescripcion((int)cmbHerramientas.SelectedValue);
                    string descripcion = tabla.Rows[0][2].ToString();
                    gdrHerramientas.Rows.Add(cmbHerramientas.SelectedValue, cmbHerramientas.Text, descripcion);
                    btnGuardarHxE.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Seleccione una herramienta para poder agregarla");
                    throw;
                }

            }
            else
            {
                MessageBox.Show("Herramienta agregada previamente");
            }

        }


        private void btnGuardarHxE_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> listaHerramientas = new List<int>();
                for (int i = 0; i < gdrHerramientas.Rows.Count; i++)
                {
                    listaHerramientas.Add(int.Parse(gdrHerramientas.Rows[i].Cells[0].Value.ToString()));
                }
                AD_Proyectos.HerramientasPorEtapa(int.Parse(txtCodProyecto.Text.Trim()), (int)cmbEtapas.SelectedValue, listaHerramientas);
                LimpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la o las herramientas");
                throw;
            }
        }

        private void LimpiarCampos()
        {
            txtCodProyecto.Text = "";
            txtDescProyecto.Text = "";
            cmbEtapas.SelectedIndex = -1;
            btnAgregarHerramienta.Enabled = false;
            btnGuardarHxE.Enabled = false;
            cmbHerramientas.Enabled = false;
            gdrHerramientas.Rows.Clear();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
