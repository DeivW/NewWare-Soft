using Microsoft.Reporting.WinForms;
using NewWare_Soft.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft
{
    public partial class EstadisticasEmpleados : Form
    {
        public EstadisticasEmpleados()
        {
            InitializeComponent();
        }

        private void EstadisticasEmpleados_Load(object sender, EventArgs e)
        {

            this.rptEstadisticasProyectos.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                DeshabilitarElementos();
                DataTable tabla = new DataTable();
                tabla = AD_PersonalXEtapa.ObtenerEstadisticasporProyectos();
                ReportDataSource ds = new ReportDataSource("DataSetEmp2", tabla);
                

                rptEstadisticasProyectos.LocalReport.DataSources.Clear();
                rptEstadisticasProyectos.LocalReport.DataSources.Add(ds);
                rptEstadisticasProyectos.RefreshReport();
                rptEstadisticasProyectos.Visible = true;
            }
            else
            {
                HabilitarElementos();
            }
        }

        private void HabilitarElementos()
        {
            lblFechaPrDesde.Visible = true;
            txtFechaIni.Enabled = true;
            txtFechaIni.Visible = true;
            btnBuscar.Visible = true;
            btnBuscar.Enabled = true;
        }

        private void DeshabilitarElementos()
        {
            lblFechaPrDesde.Visible = false;
            txtFechaIni.Enabled = false;
            txtFechaIni.Visible = false;
            btnBuscar.Visible = false;
            btnBuscar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtFechaIni.Equals(""))
            {
                MessageBox.Show("Por Favor cargue una fecha de inicio");
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_PersonalXEtapa.ObtenerEstadisticasProyectosporFecha(DateTime.Parse(txtFechaIni.Text));
                ReportDataSource ds = new ReportDataSource("DataSetEmp2", tabla);


                rptEstadisticasProyectos.LocalReport.DataSources.Clear();
                rptEstadisticasProyectos.LocalReport.DataSources.Add(ds);
                rptEstadisticasProyectos.RefreshReport();
                rptEstadisticasProyectos.Visible = true;
                DeshabilitarElementos();
                rbPorFecha.Checked = false;
                rbTodos.Checked = false;
                txtFechaIni.Text = "";
            }
        }
    }
}
