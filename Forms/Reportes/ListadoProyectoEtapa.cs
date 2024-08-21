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
    public partial class ListadoProyectoEtapa : Form
    {
        public ListadoProyectoEtapa()
        {
            InitializeComponent();
        }

        private void ListadoProyectoEtapa_Load(object sender, EventArgs e)
        {
            CargarComboËtapas();
            this.reportViewer1.RefreshReport();
        }

        private void CargarComboËtapas()
        {
            try
            {
                cmbEtapas.DataSource = ObtenerEtapas();
                cmbEtapas.DisplayMember = "NombreEtapa";
                cmbEtapas.ValueMember = "IdEtapa";
                cmbEtapas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box Etapas");
            }
        }

        public DataTable ObtenerEtapas()
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

                return table;

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

        private void generarReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("DataProyectoEtapa", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
            reportViewer1.Visible = true;
        }

        private void btn_SeleccPatron_Click(object sender, EventArgs e)
        {
            int etapa = (int)cmbEtapas.SelectedValue;
            DataTable tabla = new DataTable();
            tabla = AD_Proyectos.ObtenerProyectosXEtapa(etapa);
            generarReporte(tabla);
            btn_SeleccPatron.Enabled = false;
        }

        private void cmbEtapas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_SeleccPatron.Enabled = true;
        }
    }
}
