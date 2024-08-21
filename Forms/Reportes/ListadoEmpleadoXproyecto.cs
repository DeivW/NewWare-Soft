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
    public partial class ListadoEmpleadoXproyecto : Form
    {
        public ListadoEmpleadoXproyecto()
        {
            InitializeComponent();
        }

        private void ListadoPersonalXetapa_Load(object sender, EventArgs e)
        {
            btnListarPorPersonal.Enabled = false;
            btnSeleccionarProyecto.Enabled = false;
            this.reportViewerPersonalXetapa.RefreshReport();
        }

        //private void reportViewer1_Load(object sender, EventArgs e)
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = AD_PersonalXEtapa.ObtenerListadoPersonalXetapa();

        //    ReportDataSource ds = new ReportDataSource("DataSet_PersonalXetapa", tabla);
        //    reportViewerPersonalXetapa.LocalReport.DataSources.Clear();
        //    reportViewerPersonalXetapa.LocalReport.DataSources.Add(ds);
        //    reportViewerPersonalXetapa.LocalReport.Refresh();
        //}

        private void InabilitarRB()
        {
            rbTodosProyectos.Enabled = false;
            rbUnPersonal.Enabled = false;
            rbUNProyecto.Enabled = false;
            btnSiguiente.Enabled = false;
        }

        private void HabilitarRB()
        {
            rbTodosProyectos.Enabled = true;
            rbUnPersonal.Enabled = true;
            rbUNProyecto.Enabled = true;
            btnSiguiente.Enabled = true;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (rbTodosProyectos.Checked)
            {

                DataTable tabla = new DataTable();
                tabla = AD_PersonalXEtapa.ObtenerListadoPersonalXetapa();
                CrearReporte(tabla);
                rbTodosProyectos.Checked = false;
            }
            if (rbUNProyecto.Checked)
            {
                InabilitarRB();
                lblProyectos.Visible = true;
                cmbProyectos.Enabled = true;
                cmbProyectos.Visible = true;
                btnSeleccionarProyecto.Enabled = true;
                CargarCombosProyectos();
                btnSeleccionarProyecto.Visible = true;
            }
            if (rbUnPersonal.Checked)
            {
                InabilitarRB();
                lblPersonal.Visible = true;
                cmbPersonal.Enabled = true;
                cmbPersonal.Visible = true;
                btnListarPorPersonal.Enabled = true;
                CargarComboPersonal();
                btnListarPorPersonal.Visible = true;

            }
        }

        private void CrearReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("DataSet_PersonalXetapa", tabla);
            reportViewerPersonalXetapa.LocalReport.DataSources.Clear();
            reportViewerPersonalXetapa.LocalReport.DataSources.Add(ds);
            reportViewerPersonalXetapa.RefreshReport();

        }

        private void CargarCombosProyectos()
        {
            try
            {
                cmbProyectos.DataSource = AD_PersonalXEtapa.ObtenerProyectosTabPXE();
                cmbProyectos.DisplayMember = "IdProyecto";
                cmbProyectos.ValueMember = "IdProyecto";
                cmbProyectos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box proyectos");
            }
        }

        private void CargarComboPersonal()
        {
            try
            {
                cmbPersonal.DataSource = AD_PersonalXEtapa.ObtenerPersonalTabPXE();
                cmbPersonal.DisplayMember = "Legajo";
                cmbPersonal.ValueMember = "Legajo";
                cmbPersonal.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box personal");
            }
        }

        private DataTable buscarTabla()
        {
            if (rbTodosProyectos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_PersonalXEtapa.ObtenerListadoPersonalXetapa();
                return tabla;
            }
            if (rbUNProyecto.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_PersonalXEtapa.ObtenerProyectoPersonalXetapa((int)cmbProyectos.SelectedValue);
                return tabla;
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_PersonalXEtapa.ObtenerEmpleadoPersonalXetapa((int)cmbPersonal.SelectedValue);
                return tabla;
            }
        }

        private void btnSeleccionarProyecto_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = buscarTabla();
            CrearReporte(tabla);
            lblProyectos.Visible = false;
            cmbProyectos.Enabled = false;
            cmbProyectos.Visible = false;
            btnSeleccionarProyecto.Enabled = false;
            btnSeleccionarProyecto.Visible = false;
            rbUNProyecto.Checked = false;

            HabilitarRB();
        }

        private void btnListarPorPersonal_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = buscarTabla();
            CrearReporte(tabla);
            lblPersonal.Visible = false;
            cmbPersonal.Enabled = false;
            cmbPersonal.Visible = false;
            btnListarPorPersonal.Enabled = false;
            btnListarPorPersonal.Visible = false;
            rbUnPersonal.Checked = false;

            HabilitarRB();
        }
    }
}
