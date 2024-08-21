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
    public partial class EstadisticaDuracionProyectos : Form
    {
        public EstadisticaDuracionProyectos()
        {
            InitializeComponent();
        }

        private void EstadisticaDuracionProyectos_Load(object sender, EventArgs e)
        {
            this.rv1.RefreshReport();
            int promedio = AD_Proyectos.getPromDuracion();
            txtPromedio.Text = promedio.ToString();
        }

        private void btnSelecc_Click(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                ReportDataSource data = new ReportDataSource("DatosDuracion", AD_Proyectos.getDuracion1());
                if (chk_barras.Checked == true)
                {
                    rv1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaDuracion1.rdlc";
                }
                else
                {
                    rv1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaDuracion2.rdlc";
                }
                rv1.LocalReport.DataSources.Clear();
                rv1.LocalReport.DataSources.Add(data);
                rv1.RefreshReport();
                lblProm.Visible = true;
                txtPromedio.Visible = true;
                rv1.Visible = true;
            }
            else if (rbMayores.Checked)
            {
                ReportDataSource data = new ReportDataSource("DatosDuracion", AD_Proyectos.getDuracion2());
                if (chk_barras.Checked == true)
                {
                    rv1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaDuracion1.rdlc";
                }
                else
                {
                    rv1.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaDuracion2.rdlc";
                }
                rv1.LocalReport.DataSources.Clear();
                rv1.LocalReport.DataSources.Add(data);
                rv1.RefreshReport();
                lblProm.Visible = true;
                txtPromedio.Visible = true;
                rv1.Visible = true;

            }
            else
            {
                MessageBox.Show("Seleccione una opcion de grafico!");
            }
        }
    }
}
