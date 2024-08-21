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
    public partial class ModificacionBarrio : Form
    {
        public ModificacionBarrio()
        {
            InitializeComponent();
        }

        private void ModificacionBarrio_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            btnModificarBarrio.Enabled = false;
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
        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM barrios";
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
        private void grillaBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnModificarBarrio.Enabled = true;
            DataGridViewRow fila = grillaBarrios.Rows[indice];
            string nombreBarrio = fila.Cells["Nombre"].Value.ToString();
            string nombreCiudad = fila.Cells["Ciudad"].Value.ToString();
            string idBarrio = fila.Cells["Numero"].Value.ToString();
            Barrio barrio = ObtenerBarrio(nombreBarrio);
            LimpiarCampos();
            CargarCampos(barrio, nombreCiudad, idBarrio);
            txtNombreBarrio.Enabled = true;
            cmbCiudad.Enabled = true;

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
        private void CargarCampos(Barrio barrio, string NombreCiudad, string idBarrio)
        {
            txtNombreBarrio.Text = barrio.NombreBarrio;
            txtIdBarrio.Text = idBarrio;
            CargarComboCiudad();
            cmbCiudad.SelectedIndex = int.Parse(NombreCiudad);

        }
        private bool ActualizarBarrio()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE barrios SET NombreBarrio = @NombreBarrio, IdCiudad = @IdCiudad WHERE IdBarrio LIKE @IdBarrio";
                cmd.Parameters.AddWithValue("@NombreBarrio", txtNombreBarrio.Text);
                cmd.Parameters.AddWithValue("@IdBarrio", txtIdBarrio.Text);
                cmd.Parameters.AddWithValue("@IdCiudad", cmbCiudad.SelectedValue);
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
        private void btnModificarBarrio_Click(object sender, EventArgs e)
        {
            Barrio barrio = ObtenerBarrio(txtNombreBarrio.Text);
            bool resultado = ActualizarBarrio();
            if (resultado)
            {
                MessageBox.Show("BARRIO ACTUALIZADO CON EXITO");
                CargarGrilla();
                LimpiarCampos();
                btnModificarBarrio.Enabled = false;
            }
            else
            {
                MessageBox.Show("ERROR AL MODIFICAR BARRIO");
            }
        }
    }
}
