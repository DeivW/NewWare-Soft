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
    public partial class ListadoHerramientasXetapas : Form
    {
        public ListadoHerramientasXetapas()
        {
            InitializeComponent();
        }

        private void ListadoHerramientasXetapas_Load(object sender, EventArgs e)
        {
            CargarTipoReporte();
            this.reportViewerHerramientasXetapas.RefreshReport();
        }

        private void reportViewerHerramientasXetapas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Herramientas.ObtenerListadoHerramientaXetapa();

            ReportDataSource ds = new ReportDataSource("DatosHerramientasXetapa", tabla);
            reportViewerHerramientasXetapas.LocalReport.DataSources.Clear();
            reportViewerHerramientasXetapas.LocalReport.DataSources.Add(ds);
            reportViewerHerramientasXetapas.LocalReport.Refresh();
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
                //id cargo
                LimpiarIconos();
                lblId.Visible = true;
                cmbGeneral.Visible = true;
                cmbGeneral.DataSource = AD_Herramientas.ObtenerListadoHerramientas();
                cmbGeneral.DisplayMember = "IdHerramienta";
                cmbGeneral.ValueMember = "IdHerramienta";
                cmbGeneral.SelectedIndex = 0;
            }
            if (cmbTipoReporte.SelectedIndex.Equals(2))
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
            if (cmbTipoReporte.SelectedIndex.Equals(3))
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = GenerarTabla();

            ReportDataSource ds = new ReportDataSource("DatosHerramientasXetapa", tabla);
            reportViewerHerramientasXetapas.LocalReport.DataSources.Clear();
            reportViewerHerramientasXetapas.LocalReport.DataSources.Add(ds);
            reportViewerHerramientasXetapas.LocalReport.Refresh();

            this.reportViewerHerramientasXetapas.RefreshReport();
        }

        private void CargarTipoReporte()
        {
            DataTable tablaTipoReportes = new DataTable();
            tablaTipoReportes.Columns.Add("Tipo de reporte");
            tablaTipoReportes.Rows.Add("Todos los reportes");
            tablaTipoReportes.Rows.Add("Buscar por Id de Herramienta");
            tablaTipoReportes.Rows.Add("Buscar por Id de Etapa");
            tablaTipoReportes.Rows.Add("Buscar por Id de Proyecto");

            cmbTipoReporte.DataSource = tablaTipoReportes;
            cmbTipoReporte.DisplayMember = "Tipo de reporte";
            cmbTipoReporte.SelectedIndex = 0;
        }

        private DataTable GenerarTabla()
        {
            DataTable tabla = new DataTable();

            if (cmbTipoReporte.SelectedIndex.Equals(0))
            {
                //todo
                tabla = AD_Herramientas.ObtenerListadoHerramientaXetapa();
            }
            if (cmbTipoReporte.SelectedIndex.Equals(1))
            {
                //id Herramienta                                 
                try
                {
                    tabla = AD_Herramientas.BuscarHerrXetapaXproyecto_porID(int.Parse(cmbGeneral.Text), "IdHerramienta");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro ");
                }
            }
            if (cmbTipoReporte.SelectedIndex.Equals(2))
            {
                //id Etapa
                try
                {
                    tabla = AD_Herramientas.BuscarHerrXetapaXproyecto_porID(int.Parse(cmbGeneral.Text), "IdEtapa");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro ");
                }
            }
            if (cmbTipoReporte.SelectedIndex.Equals(3))
            {
                //id Proyecto
                try
                {
                    tabla = AD_Herramientas.BuscarHerrXetapaXproyecto_porID(int.Parse(cmbGeneral.Text), "CodigoProyecto");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro ");
                }
            }

            return tabla;
        }



        private void LimpiarIconos()
        {
            lblId.Visible = false;
            cmbGeneral.Visible = false;
        }
    }
}
