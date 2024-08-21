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
    public partial class EstadisticaProyectoMes : Form
    {
        public EstadisticaProyectoMes()
        {
            InitializeComponent();
        }

        private void EstadisticaProyectoMes_Load(object sender, EventArgs e)
        {

            this.rp1.RefreshReport();
        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {
            ReportDataSource dato = new ReportDataSource("DataEstadistica", AD_Proyectos.getEstadisticaCli(int.Parse(txt.Text)));
            if (chk_barras.Checked == true)
            {
                rp1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaProyectoMes2.rdlc";
            }
            else
            {
                rp1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaProyectoMes.rdlc";
            }
            rp1.LocalReport.DataSources.Clear();
            rp1.LocalReport.DataSources.Add(dato);
            rp1.RefreshReport();
        }


        private void bt_Seleccionar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ReportDataSource dato = new ReportDataSource("DataEstadistica", AD_Proyectos.getEstadistica());
                if (chk_barras.Checked == true)
                {
                    rp1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaProyectoMes2.rdlc";
                }
                else
                {
                    rp1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaProyectoMes.rdlc";
                }
                rp1.LocalReport.DataSources.Clear();
                rp1.LocalReport.DataSources.Add(dato);
                rp1.RefreshReport();
                label1.Visible = false;
                txt.Visible = false;
                bt_Buscar.Enabled = false;
            }
            else if (rb_clie.Checked)
            {
                label1.Visible = true;
                txt.Visible = true;
                bt_Buscar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione una opcion de grafico!");
            }
        }
    }
}
