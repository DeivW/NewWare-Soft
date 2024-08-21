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
    public partial class Estadistica_HerramientasMasUtilizadas : Form
    {
        public Estadistica_HerramientasMasUtilizadas()
        {
            InitializeComponent();
        }

        private void Estadistica_HerramientasMasUtilizadas_Load(object sender, EventArgs e)
        {
            this.rpv_HerrMasUtilizadas.Refresh();
            CargarComboEtapa();
        }

        private void CargarComboEtapa()
        {
            try
            {
                cmbEtapa.DataSource = AD_PersonalXEtapa.ObtenerEtapas();
                cmbEtapa.DisplayMember = "IdEtapa";
                cmbEtapa.ValueMember = "IdEtapa";
                cmbEtapa.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box etapas");
            }

        }
        private void button_Generar_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDataSource dato = new ReportDataSource("DataEstadistica", AD_Herramientas.getEstadisticaXProyecto(int.Parse(cmbEtapa.Text)));

                rpv_HerrMasUtilizadas.LocalReport.DataSources.Clear();
                rpv_HerrMasUtilizadas.LocalReport.DataSources.Add(dato);
                rpv_HerrMasUtilizadas.RefreshReport();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el codigo de la etapa para continuar");
            }
        }

        private void button_Siguiente_Click(object sender, EventArgs e)
        {
            if (rbnHerrMasUtili.Checked)
            {

                ReportDataSource dato = new ReportDataSource("DataEstadistica", AD_Herramientas.getEstadistica());
                rpv_HerrMasUtilizadas.LocalReport.DataSources.Clear();
                rpv_HerrMasUtilizadas.LocalReport.DataSources.Add(dato);
                rpv_HerrMasUtilizadas.RefreshReport();
                lblCodigo.Visible = false;
                cmbEtapa.Visible = false;
                button_Generar.Visible = false;
            }
            else if (rbnHerrMasUtili_codigo.Checked)
            {
                lblCodigo.Visible = true;
                cmbEtapa.Visible = true;
                button_Generar.Visible = true;
            }
        }
    }
}
