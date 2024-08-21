using System;
using NewWare_Soft.AccesoADatos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace NewWare_Soft.Forms.Reportes
{
    public partial class ListadoPersonalXetapa : Form
    {
        public ListadoPersonalXetapa()
        {
            InitializeComponent();
        }

        private void ListadoPersonalXetapa_Load(object sender, EventArgs e)
        {
            CargarTipoReporte();

            DataTable tabla = GenerarTabla();

            ReportDataSource ds = new ReportDataSource("DataSet_PersonalXetapa", tabla);
            reportViewerPersonalXetapa.LocalReport.DataSources.Clear();
            reportViewerPersonalXetapa.LocalReport.DataSources.Add(ds);
            reportViewerPersonalXetapa.LocalReport.Refresh();

            this.reportViewerPersonalXetapa.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = GenerarTabla();

            ReportDataSource ds = new ReportDataSource("DataSet_PersonalXetapa", tabla);
            reportViewerPersonalXetapa.LocalReport.DataSources.Clear();
            reportViewerPersonalXetapa.LocalReport.DataSources.Add(ds);
            reportViewerPersonalXetapa.LocalReport.Refresh();

            this.reportViewerPersonalXetapa.RefreshReport();


        }

        private DataTable GenerarTabla()
        {
            DataTable tabla = new DataTable();

            if (cmbTipoReporte.SelectedIndex.Equals(0))
            {
                //todo
                tabla = AD_PersonalXEtapa.ObtenerListadoPersonalXetapa();
            }
            if (cmbTipoReporte.SelectedIndex.Equals(1))
            {
                //id Etapa                                       
                try
                {
                    tabla = AD_PersonalXEtapa.BuscarPersonalXetapa_porInt(int.Parse(cmbGeneral.Text), "idEtapa");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro ");
                }
            }
            if (cmbTipoReporte.SelectedIndex.Equals(2))
            {
                //id Proyecto
                try
                {
                    tabla = AD_PersonalXEtapa.BuscarPersonalXetapa_porInt(int.Parse(cmbGeneral.Text), "idProyecto");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro ");
                }
            }
            if (cmbTipoReporte.SelectedIndex.Equals(3))
            {
                //id Cargo
                try
                {
                    tabla = AD_PersonalXEtapa.BuscarPersonalXetapa_porInt(int.Parse(cmbGeneral.Text), "idCargoDesempeño");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro ");
                }
            }
            if (cmbTipoReporte.SelectedIndex.Equals(4))
            {
                //rango
                try
                {
                    tabla = AD_PersonalXEtapa.BuscarPxPEntreFechas(maskedTextBox_Desde.Text, maskedTextBox_Hasta.Text);
                    return tabla;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingreso la fecha con el formato equivocado. Recuerde DD/MM/AAAA. Intentelo de nuevo");
                    maskedTextBox_Desde.Text = "";
                    maskedTextBox_Hasta.Text = "";
                   
                    return tabla;
                }
            }
            if (cmbTipoReporte.SelectedIndex.Equals(5))
            {
                //legajo
                try
                {
                    tabla = AD_PersonalXEtapa.BuscarPersonalEnTablaPXE(int.Parse(cmbGeneral.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro ");
                }
            }

            return tabla;
        }

        private void CargarTipoReporte()
        {
            DataTable tablaTipoReportes = new DataTable();
            tablaTipoReportes.Columns.Add("Tipo de reporte");
            tablaTipoReportes.Rows.Add("Todos los reportes");
            tablaTipoReportes.Rows.Add("Buscar por Id de Etapa");
            tablaTipoReportes.Rows.Add("Buscar por Id de Proyecto");
            tablaTipoReportes.Rows.Add("Buscar por Id de Cargo");
            tablaTipoReportes.Rows.Add("Buscar por rango de fecha");
            tablaTipoReportes.Rows.Add("Buscar por Legajo");

            cmbTipoReporte.DataSource = tablaTipoReportes;
            cmbTipoReporte.DisplayMember = "Tipo de reporte";
            cmbTipoReporte.SelectedIndex = 0;
        }

        private void LimpiarIconos()
        {
            lblId.Visible = false;
            lblLegajo.Visible = false;
            lblDesde.Visible = false;
            lblHasta.Visible = false;
            lblFormato.Visible = false;
            cmbGeneral.Visible = false;
            maskedTextBox_Desde.Visible = false;
            maskedTextBox_Hasta.Visible = false;
        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoReporte.SelectedIndex.Equals(0))
            {
                //Todos
                LimpiarIconos();
            }
            if (cmbTipoReporte.SelectedIndex.Equals(1))
            {
                //Id etapa
                LimpiarIconos();
                lblId.Visible = true;
                cmbGeneral.Visible = true;
                cmbGeneral.DataSource = AD_PersonalXEtapa.ObtenerEtapas();
                cmbGeneral.DisplayMember = "IdEtapa";
                cmbGeneral.ValueMember = "IdEtapa";
                cmbGeneral.SelectedIndex = 0;
            }
            if (cmbTipoReporte.SelectedIndex.Equals(2))
            {
                //id proyecto
                LimpiarIconos();
                lblId.Visible = true;
                cmbGeneral.Visible = true;
                cmbGeneral.DataSource = AD_Proyectos.ObtenerProyectos();
                cmbGeneral.DisplayMember = "CodigoProyecto";
                cmbGeneral.ValueMember = "CodigoProyecto";
                cmbGeneral.SelectedIndex = 0;
            }
            if (cmbTipoReporte.SelectedIndex.Equals(3))
            {
                //id cargo
                LimpiarIconos();
                lblId.Visible = true;
                cmbGeneral.Visible = true;
                cmbGeneral.DataSource = AD_Cargo.ObtenerListadoCargos();
                cmbGeneral.DisplayMember = "IdCargo";
                cmbGeneral.ValueMember = "IdCargo";
                cmbGeneral.SelectedIndex = 0;
            }
            if (cmbTipoReporte.SelectedIndex.Equals(4))
            {
                //rango
                LimpiarIconos();
                lblDesde.Visible = true;
                lblHasta.Visible = true;
                lblFormato.Visible = true;
                maskedTextBox_Desde.Visible = true;
                maskedTextBox_Hasta.Visible = true;
            }
            if (cmbTipoReporte.SelectedIndex.Equals(5))
            {
                //legajo
                LimpiarIconos();
                lblLegajo.Visible = true;
                cmbGeneral.Visible = true;
                cmbGeneral.DataSource = DAOpersonal.ObtenerListadoPersonalpReporte();
                cmbGeneral.DisplayMember = "Legajo";
                cmbGeneral.ValueMember = "Legajo";
                cmbGeneral.SelectedIndex = 0;


            }
        }
    }
}
