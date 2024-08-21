using Microsoft.Reporting.WinForms;
using NewWare_Soft.AccesoADatos;
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

namespace NewWare_Soft.Forms.Reportes
{
    public partial class ListadoBarrios : Form
    {
        public ListadoBarrios()
        {
            InitializeComponent();
        }

        private void ListadoBarrios_Load(object sender, EventArgs e)
        {

            this.reporte_barrios.RefreshReport();
        }
                                 
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb_barriosxciudad.Checked)
            {
                lbl_Ciudad.Visible = true;
                txt_ciudad.Enabled = true;
                btnGenerarReporte.Visible = true;
                btnGenerarReporte.Enabled = true;
                CargarComboCiudad();
                txt_ciudad.Visible = true;
            }

            if (rdb_ordenAlfabetico.Checked)
            {
                lblOrdenAlfabetico.Visible = true;
                btnGenerarReporte2.Visible = true;
                btnGenerarReporte2.Enabled = true;
            }

            if (rdb_reportenormal.Checked)
            {
                lblReporteNormal.Visible = true;
                btnGenerarReporte2.Visible = true;
                btnGenerarReporte2.Enabled = true;

            }
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

                txt_ciudad.DataSource = tabla;
                txt_ciudad.DisplayMember = "NombreCiudad";
                txt_ciudad.ValueMember = "IdCiudad";
                txt_ciudad.SelectedIndex = -1;

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

        private DataTable buscarTablas()
        {
            if (rdb_barriosxciudad.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Barrios.barriosXciudad(txt_ciudad.SelectedValue.ToString());
                return tabla;
            }
            if (rdb_ordenAlfabetico.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Barrios.ordenAlfabetico();
                return tabla;
            }

            if (rdb_reportenormal.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Barrios.obtenerDatosBarrios();
                return tabla;
            }

            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_Barrios.obtenerDatosBarrios();
                return tabla;
            }
           
        }
        private void armarReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("DatosBarrios", tabla);
            reporte_barrios.LocalReport.DataSources.Clear();
            reporte_barrios.LocalReport.DataSources.Add(ds);
            reporte_barrios.RefreshReport();
            reporte_barrios.Visible = true;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ciudad.Text.Equals(""))
                { 
                    MessageBox.Show("Debe seleccionar al menos una ciudad");
                    txt_ciudad.Focus();
                }
                else
                {
                    object seleccionCombo = new object();
                    seleccionCombo = (int)txt_ciudad.SelectedValue;
                    DataTable tabla = new DataTable();
                    tabla = buscarTablas();
                    if (tabla == null || tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
                    }
                    else
                    {
                        armarReporte(tabla);
                        lbl_Ciudad.Visible = false;
                        txt_ciudad.Visible = false;
                        btnGenerarReporte.Visible = false;
                        txt_ciudad.Enabled = false;
                        txt_ciudad.Visible = false;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un ERROR inesperado. Intentelo de nuevo");
            }
        }

        private void btnGenerarReporte2_Click(object sender, EventArgs e)
        {
            if (rdb_reportenormal.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = buscarTablas();
                if (tabla == null || tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
                }
                else
                {
                    armarReporte(tabla);
                    lblReporteNormal.Visible = false;
                    btnGenerarReporte2.Enabled = false;
                    btnGenerarReporte2.Visible = false;
                }
            }

            if (rdb_ordenAlfabetico.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = buscarTablas();
                if (tabla == null || tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El reporte esta vacio, intentelo de nuevo");
                }
                else
                {
                    armarReporte(tabla);
                    lblOrdenAlfabetico.Visible = false;
                    btnGenerarReporte2.Enabled = false;
                    btnGenerarReporte2.Visible = false;
                }
            }

        }
    }
}
