using NewWare_Soft.AccesoADatos;
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
    public partial class BajaFormaPago : Form
    {
        public BajaFormaPago()
        {
            InitializeComponent();
        }

        private void BajaFormaPago_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboFormaPago();
            CargarGrilla();
            btnEliminarFormaPago.Enabled = false;
        }
        private void LimpiarCampos()
        {
            txtNroFactura.Text = "";
            txtDescripcion.Text = "";
            txtMonto.Text = "";
        }
        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM formas_pago_factura";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                grillaFormaPago.DataSource = tabla;

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

        private void CargarComboFormaPago()
        {

            try
            {
                cmbFormaPago.DataSource = AD_FPago.ObtenerTiposPago();
                cmbFormaPago.DisplayMember = "NombreFormaPago";
                cmbFormaPago.ValueMember = "idFormaPago";
                cmbFormaPago.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipos de pago");
            }
        }

        private void grillaFormaPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnEliminarFormaPago.Enabled = true;
            DataGridViewRow filaSeleccionada = grillaFormaPago.Rows[indice];
            string nroFactura = filaSeleccionada.Cells["NroFactura"].Value.ToString();
            FormaPago fp = ObtenerFormaPago(nroFactura);
            LimpiarCampos();
            CargarCampos(fp);
        }
        private void CargarCampos(FormaPago fp)
        {
            txtNroFactura.Text = fp.NroFacturaPersona.ToString();
            txtDescripcion.Text = fp.DescripcionPersona;
            txtMonto.Text = fp.MontoPersona.ToString();
            cmbFormaPago.SelectedValue = fp.IdFormaPagoPersona;
        }
        private FormaPago ObtenerFormaPago(string nroFactura)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            FormaPago fp = new FormaPago();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM formas_pago_factura where NroFactura like @nroFactura";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroFactura", nroFactura);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    fp.NroFacturaPersona = int.Parse(dr["NroFactura"].ToString());
                    fp.IdFormaPagoPersona = int.Parse(dr["IdFormaPago"].ToString());
                    fp.DescripcionPersona = dr["Descripcion"].ToString();
                    fp.MontoPersona = int.Parse(dr["Monto"].ToString());

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


            return fp;
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private FormaPago ObtenerDatosFormaPago()
        {
            FormaPago fp = new FormaPago();
            fp.NroFacturaPersona = int.Parse(txtNroFactura.Text);
            fp.IdFormaPagoPersona = (int)cmbFormaPago.SelectedValue;
            fp.DescripcionPersona = txtDescripcion.Text.Trim();
            fp.MontoPersona = int.Parse(txtMonto.Text);
            return fp;
        }

        private void btnEliminarFormaPago_Click(object sender, EventArgs e)
        {
            FormaPago fp = ObtenerDatosFormaPago();
            bool resultado = EliminarFormaPago(fp);
            if (resultado)
            {
                MessageBox.Show("Forma de pago eliminada con exito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboFormaPago();

            }
            else
            {
                MessageBox.Show("Error al eliminar forma de pago");
            }

        }

        private bool EliminarFormaPago(FormaPago fp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM formas_pago_factura WHERE NroFactura like @nroFactura AND IdFormaPago like @idFormaPago";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroFactura", fp.NroFacturaPersona);
                cmd.Parameters.AddWithValue("@idFormaPago", fp.IdFormaPagoPersona);
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
    
