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

namespace NewWare_Soft.Forms.Reportes
{
    public partial class ListadoPersonal : Form
    {
        public ListadoPersonal()
        {
            InitializeComponent();
        }

        private void ListadoPersonal_Load(object sender, EventArgs e)
        {

            this.rptPersonal.RefreshReport();
        }

        private void rptPersonal_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DAOpersonal.ObtenerListadoPersonal();

            ReportDataSource ds = new ReportDataSource("DataSetPersonalXProyecto", tabla);

            rptPersonal.LocalReport.DataSources.Clear();
            rptPersonal.LocalReport.DataSources.Add(ds);
            rptPersonal.LocalReport.Refresh();
        }
    }
}
