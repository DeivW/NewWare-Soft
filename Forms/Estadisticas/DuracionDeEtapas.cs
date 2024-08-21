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

namespace NewWare_Soft.Forms.Estadisticas
{
    public partial class DuracionDeEtapas : Form
    {
        public DuracionDeEtapas()
        {
            InitializeComponent();
        }
        private void Estadistica_EtapasQueMasTardaron_Load(object sender, EventArgs e)
        {

            this.reporte_Etapas.RefreshReport();
        }

        private void btnSelecc_Click(object sender, EventArgs e)
        {
            if (rbTodas.Checked)
            {
                label2.Visible = false;
                txtNombre.Visible = false;
                label3.Visible = false;
                txtNumero.Visible = false;
                label1.Visible = true;
                btnConfirmar.Visible = true;
                btnConfirmar.Enabled = true;
            }
            if (rdbNombre.Checked)
            {
                label3.Visible = false;
                txtNumero.Visible = false;
                label1.Visible = false;
                label2.Visible = true;
                txtNombre.Visible = true;
                txtNombre.Enabled = true;
                btnConfirmar.Visible = true;
                btnConfirmar.Enabled = true;
            }
            if (rdbDuracionMayor.Checked)
            {
                label2.Visible = false;
                txtNombre.Visible = false;
                label1.Visible = false;
                label3.Visible = true;
                txtNumero.Visible = true;
                txtNumero.Enabled = true;
                btnConfirmar.Visible = true;
                btnConfirmar.Enabled = true;
            }

        }
        private void armarReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("DuracionDeEtapas", tabla);
            reporte_Etapas.LocalReport.DataSources.Clear();
            reporte_Etapas.LocalReport.DataSources.Add(ds);
            //reporte_Etapas.LocalReport.Refresh();
            reporte_Etapas.RefreshReport();
            reporte_Etapas.Visible = true;
        }

        private DataTable buscarTablas()
        {
            if (rbTodas.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Etapas.duracionEtapa();
                return tabla;
            }

            if (rdbNombre.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Etapas.duracionEtapasPorProyectos(txtNombre.Text.Trim());
                return tabla;
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_Etapas.duracionMayoRA(txtNumero.Text.Trim());
                return tabla;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (rbTodas.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = buscarTablas();
                armarReporte(tabla);
                label1.Visible = false;
                btnConfirmar.Visible = false;
            
            }
            if (rdbNombre.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = buscarTablas();
                armarReporte(tabla);
                txtNombre.Text = "";
                txtNombre.Focus();
                
            }
            if (rdbDuracionMayor.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = buscarTablas();
                armarReporte(tabla);
                txtNumero.Text = "";
                txtNumero.Focus();

            }

        }
    }

}
    

