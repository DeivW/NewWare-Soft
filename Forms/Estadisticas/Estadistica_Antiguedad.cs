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
using Microsoft.Reporting.WinForms;

namespace NewWare_Soft
{
    public partial class Estadistica_Antiguedad : Form
    {
        public Estadistica_Antiguedad()
        {
            InitializeComponent();
        }

        private void Estadistica_Antiguedad_Load(object sender, EventArgs e)
        {

            this.reportViewer_Ant.RefreshReport();
        }

        private void button_Siguiente_Click(object sender, EventArgs e)
        {
            if (radioButton_Todos.Checked)
            {
                DataTable tablaa = new DataTable();
                tablaa = buscarTablas();
                armarReporte(tablaa);
            }
            if (radioButton_TodosAño.Checked)
            {
                DataTable tablaa = new DataTable();
                tablaa = buscarTablas();
                armarReporte(tablaa);
            }
            if (radioButton_viaje.Checked)
            {
                label2.Visible = true;
                button_Generar.Enabled = true;
                button_Generar.Visible = true;
                maskedTextBox_Años.Enabled = true;
                maskedTextBox_Años.Visible = true;
            }
        }
        private void armarReporte(DataTable tablaa)
        {
            ReportDataSource ds = new ReportDataSource("DataSet_Antiguedad", tablaa);
            reportViewer_Ant.LocalReport.DataSources.Clear();
            reportViewer_Ant.LocalReport.DataSources.Add(ds);
            //reportViewer_Ant.LocalReport.Refresh();
            reportViewer_Ant.RefreshReport();
            reportViewer_Ant.Visible = true;
        }
        private DataTable buscarTablas()
        {
            if (radioButton_Todos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Personal.ObtenerDataGrid_Antiguedad_Todos();
                return tabla;
            }

            if (radioButton_TodosAño.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Personal.ObtenerDataGrid_Antiguedad_Todos_Año();
                return tabla;
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_Personal.obtenerDataGrid_Antiguedad_Viaje(int.Parse(maskedTextBox_Años.Text));
                return tabla;
            }
        }

        private void button_Generar_Click(object sender, EventArgs e)
        {
            DataTable tablaa = new DataTable();
            tablaa = buscarTablas();
            armarReporte(tablaa);
        }
    }
}
