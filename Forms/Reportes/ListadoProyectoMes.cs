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
    public partial class ListadoProyectoMes : Form
    {
        public ListadoProyectoMes()
        {
            InitializeComponent();
            cargarCombo();
        }

        private void ListadoProyectoMes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void cargarCombo()
        {
            meses.Items.Insert(0,"Enero");
            meses.Items.Insert(1,"Febrero");
            meses.Items.Insert(2,"Marzo");
            meses.Items.Insert(3,"Abril");
            meses.Items.Insert(4,"Mayo");
            meses.Items.Insert(5,"Junio");
            meses.Items.Insert(6,"Julio");
            meses.Items.Insert(7,"Agosto");
            meses.Items.Insert(8,"Septiembre");
            meses.Items.Insert(9,"Octubre");
            meses.Items.Insert(10,"Noviembre");
            meses.Items.Insert(11,"Diciembre");
        }        

        private void btn_SeleccPatron_Click(object sender, EventArgs e)
        {
            int mes = (int)meses.SelectedIndex + 1;
            DataTable tabla = new DataTable();
            tabla = AD_Proyectos.ObtenerProyectosXMes(mes);
            generarReporte(tabla);
        }

        private void generarReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("DataProyectoMes", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
            reportViewer1.Visible = true;
        }

    }
}
