using Microsoft.Reporting.WinForms;
using NewWare_Soft.AccesoADatos_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms
{
    public partial class ListadoDeUsuarios : Form
    {
        public ListadoDeUsuarios()
        {
            InitializeComponent();
        }

        private void ListadoDeUsuarios_Load(object sender, EventArgs e)
        {
            this.reportUsuarios.RefreshReport();
        }

        private void generarReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("DatosUsuarios", tabla);
            reportUsuarios.LocalReport.DataSources.Clear();
            reportUsuarios.LocalReport.DataSources.Add(ds);
            reportUsuarios.RefreshReport();
            reportUsuarios.Visible = true;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (rb_Patron.Checked)
            {
                lbl_Patron.Visible = true;
                txtPatron.Visible = true;
                btn_SeleccPatron.Visible = true;
                btn_SeleccPatron.Enabled = true;
            }

            else
            {
                DataTable tabla = new DataTable();
                tabla = buscarTabla();
                generarReporte(tabla);
                lbl_Patron.Visible = false;
                txtPatron.Visible = false;
                btn_SeleccPatron.Visible = false;
                btn_SeleccPatron.Enabled = false;
            }
        }

        private DataTable buscarTabla()
        {
            if (rb_Patron.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Usuarios.ObtenerUsuariosPorPatron(txtPatron.Text);
                return tabla;
            }

            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_Usuarios.ObtenerUsuarios();
                return tabla;
            }
        }

        private void btn_SeleccPatron_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = buscarTabla();
            generarReporte(tabla);
            lbl_Patron.Visible = false;
            txtPatron.Visible = false;
            btn_SeleccPatron.Visible = false;
            btn_SeleccPatron.Enabled = false;
        }
    }
}
