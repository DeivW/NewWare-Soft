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
    public partial class ListadoDeTodosLosProyectos : Form
    {
        public ListadoDeTodosLosProyectos()
        {
            InitializeComponent();
        }

        private void ListadoDeTodosLosProyectos_Load(object sender, EventArgs e)
        {
            this.reportProyectos.RefreshReport();
        }

        private void button_Siguiente_Click(object sender, EventArgs e)
        {
            if (rb_Todos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = buscarTablas();
                generarReporte(tabla);
                lbl_FechaInicio.Visible = false;
                btn_SeleccFecha.Enabled = false;
                btn_SeleccFecha.Visible = false;
                txtInicioABuscar.Visible = false;
                lbl_Patron.Visible = false;
                txtPatron.Visible = false;
                btn_SeleccPatron.Visible = false;
                btn_SeleccPatron.Enabled = false;
            }

            if (rb_FechaInicioDesde.Checked)
            {
                lbl_FechaInicio.Visible = true;
                btn_SeleccFecha.Enabled = true;
                btn_SeleccFecha.Visible = true;
                txtInicioABuscar.Visible = true;
                lbl_Patron.Visible = false;
                txtPatron.Visible = false;
                btn_SeleccPatron.Visible = false;
                btn_SeleccPatron.Enabled = false;
            }

            if (rb_PatrónDescrip.Checked)
            {
                lbl_FechaInicio.Visible = false;
                btn_SeleccFecha.Enabled = false;
                btn_SeleccFecha.Visible = false;
                txtInicioABuscar.Visible = false;
                lbl_Patron.Visible = true;
                txtPatron.Visible = true;
                btn_SeleccPatron.Visible = true;
                btn_SeleccPatron.Enabled = true;
            }

        }

        private void generarReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("DatosProyectos", tabla);
            reportProyectos.LocalReport.DataSources.Clear();
            reportProyectos.LocalReport.DataSources.Add(ds);
            reportProyectos.RefreshReport();
            reportProyectos.Visible = true;

        }

        private DataTable buscarTablas()
        {
            if (rb_Todos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Proyectos.ObtenerProyectos();
                return tabla;
            }
            if (rb_FechaInicioDesde.Checked)
            {
                DateTime fecha = DateTime.Parse(txtInicioABuscar.Text);
                DataTable tabla = new DataTable();
                tabla = AD_Proyectos.ObtenerProyectoPorFechaInicio(fecha);
                return tabla;
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_Proyectos.ObtenerProyectosPorPatrón(txtPatron.Text);
                return tabla;
            }
        }

        private void btn_SeleccFecha_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = buscarTablas();
            generarReporte(tabla);
            lbl_FechaInicio.Visible = false;
            btn_SeleccFecha.Enabled = false;
            btn_SeleccFecha.Visible = false;
            txtInicioABuscar.Visible = false;
        }

        private void btn_SeleccPatron_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = buscarTablas();
            generarReporte(tabla);
            lbl_Patron.Visible = false;
            txtPatron.Visible = false;
            btn_SeleccPatron.Visible = false;
            btn_SeleccPatron.Enabled = false;
        }
    }
}
