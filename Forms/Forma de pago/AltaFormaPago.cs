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
    public partial class AltaFormaPago : Form
    {
        public AltaFormaPago()
        {
            InitializeComponent();
        }

        private void AltaFormaPago_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboFormaPago();
            CargarGrilla();
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

        private void LimpiarCampos()
        {
            txtNroFactura.Text = "";
            txtDescripcion.Text = "";
            txtMonto.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaPago fp = new FormaPago();
            fp.NroFacturaPersona = int.Parse(txtNroFactura.Text);
            fp.IdFormaPagoPersona = (int)cmbFormaPago.SelectedValue;
            fp.DescripcionPersona = txtDescripcion.Text.Trim();
            fp.MontoPersona = int.Parse(txtMonto.Text);

            bool resultado = AgregarFormaPagoABD(fp);
            if (resultado)
            {
                MessageBox.Show("Forma de pago agregada");
                LimpiarCampos();
                CargarComboFormaPago();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar forma de pago");
            }
        }
        private bool AgregarFormaPagoABD(FormaPago fp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT into formas_pago_factura (NroFactura,IdFormaPago,Descripcion,Monto) VALUES(@nroFactura,@idFormaPago,@descripcion,@monto)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroFactura", fp.NroFacturaPersona);
                cmd.Parameters.AddWithValue("@idFormaPago", fp.IdFormaPagoPersona);
                cmd.Parameters.AddWithValue("@descripcion", fp.DescripcionPersona);
                cmd.Parameters.AddWithValue("@monto", fp.MontoPersona);
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
