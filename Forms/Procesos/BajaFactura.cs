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
    public partial class BajaFactura : Form
    {
        Factura facturaGlobal = new Factura();

        public BajaFactura()
        {
            InitializeComponent();
            button_Borrar.Enabled = false;
            llenarGrilla();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Para dar de baja a una factura, debe primero seleccionarla" +
                " y se le activará el botón BORRAR", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llenarGrilla()
        {
            try
            {
                dgvFacturas.DataSource = extraerDatosFacturasDB();

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! No se pudo obtener datos...");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            button_Borrar.Enabled = true;
            DataGridViewRow filaSeleccionada = dgvFacturas.Rows[index];
            int nroFactura = int.Parse(filaSeleccionada.Cells["NroFactura"].Value.ToString());
            facturaGlobal = obtenerFactura(nroFactura);                     
        }

        #region Cargar Grilla Factura
        private DataTable extraerDatosFacturasDB()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {
                string query = "select * from facturas";
                SqlCommand command = new SqlCommand();

                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                canalConexion.Open();
                command.Connection = canalConexion;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(tabla);
                return tabla;
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

        #region Obtener instancia Factura
        private Factura obtenerFactura(int id)
        {
            Factura factura = new Factura();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);
            try
            {
                string query = "select * from facturas where NroFactura like @id";
                SqlCommand command = new SqlCommand();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", id);
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                canalConexion.Open();
                command.Connection = canalConexion;

                SqlDataReader dr = command.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    factura.NroFactura = int.Parse(dr["NroFactura"].ToString());
                    factura.IdCliente = int.Parse(dr["IdCliente"].ToString());
                    factura.FechaFacturacion = DateTime.Parse(dr["FechaFactura"].ToString());
                }
                return factura;
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

        #region Metodo Borrar Factura
        private bool borrarFactura(int idFactura)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {
                string query = "delete from facturas where NroFactura like @idFactura";
                SqlCommand command = new SqlCommand();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@idFactura", idFactura);
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                canalConexion.Open();
                command.Connection = canalConexion;

                command.ExecuteNonQuery();
                result = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                canalConexion.Close();
            }
            return result;
        }
        #endregion

        #region Metodo Borrar Factura en Forma Pago
        private bool borrarFormaPago(int idFactura)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM formas_pago_factura WHERE NroFactura like @nroFactura";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroFactura", idFactura);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                canalConexion.Open();
                cmd.Connection = canalConexion;
                cmd.ExecuteNonQuery();
                result = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                canalConexion.Close();
            }
            return result;
        }
        #endregion

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                borrarFactura(facturaGlobal.NroFactura);
                borrarFormaPago(facturaGlobal.NroFactura);
                MessageBox.Show("Operacion exitosa");
                llenarGrilla();
                button_Borrar.Enabled = false;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                button_Borrar.Enabled = false;
            }                     
        }
    }
}
