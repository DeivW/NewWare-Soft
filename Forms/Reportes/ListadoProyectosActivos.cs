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
    public partial class ListadoProyectosActivos : Form
    {
        public ListadoProyectosActivos()
        {
            InitializeComponent();
        }

        private void ListadoProyectosActivos_Load(object sender, EventArgs e)
        {

            this.reportProyActivos.RefreshReport();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (rb_ProyectosActivos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = getTablas();
                generarReporte(tabla);
                btn_SelecFecha.Enabled = false;
                btn_SelecFecha.Visible = false;
                btn_SelecID.Enabled = false;
                btn_SelecID.Visible = false;
                txtFecha.Visible = false;
                txtID.Visible = false;
                lbl_FechaInicio.Visible = false;
                lbl_ID.Visible = false;

            }
            if (rb_FechaInicio.Checked)
            {
                btn_SelecFecha.Enabled = true;
                btn_SelecFecha.Visible = true;
                btn_SelecID.Enabled = false;
                btn_SelecID.Visible = false;
                txtFecha.Visible = true;
                txtID.Visible = false;
                lbl_FechaInicio.Visible = true;
                lbl_ID.Visible = false;

            }
            if (rb_IDCliente.Checked)
            {
                btn_SelecFecha.Enabled = false;
                btn_SelecFecha.Visible = false;
                btn_SelecID.Enabled = true;
                btn_SelecID.Visible = true;
                txtFecha.Visible = false;
                txtID.Visible = true;
                lbl_FechaInicio.Visible = false;
                lbl_ID.Visible = true;
            }
        }

        private void generarReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("ProyectosActivos", tabla);
            reportProyActivos.LocalReport.DataSources.Clear();
            reportProyActivos.LocalReport.DataSources.Add(ds);
            reportProyActivos.RefreshReport();
            reportProyActivos.Visible = true;
        }

        private DataTable getTablas()
        {
            if (rb_ProyectosActivos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Proyectos.ObtenerProyectosActivos();
                return tabla;
            }
            if (rb_FechaInicio.Checked)
            {
                DateTime fecha = DateTime.Parse(txtFecha.Text);
                DataTable tabla = new DataTable();
                tabla = AD_Proyectos.ObtenerProyectoActivoXFecha(fecha);
                return tabla;
            }
            else
            {
                int var = int.Parse(txtID.Text);
                DataTable tabla = new DataTable();
                tabla = AD_Proyectos.ObtenerProyectosXID(var);
                return tabla;
            }
        }

        private void btn_SelecFecha_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = getTablas();
            generarReporte(tabla);
            lbl_FechaInicio.Visible = false;
            txtFecha.Visible = false;
            btn_SelecFecha.Visible = false;
            btn_SelecFecha.Enabled = false;
        }

        private void btn_SelecID_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = getTablas();
            generarReporte(tabla);
            lbl_ID.Visible = false;
            txtID.Visible = false;
            btn_SelecID.Visible = false;
            btn_SelecID.Enabled = false;
        }
    }
}

