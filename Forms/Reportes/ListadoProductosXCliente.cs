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
    public partial class ListadoProductosXCliente : Form
    {
        public ListadoProductosXCliente()
        {
            InitializeComponent();
        }

        private void ListadoProductosXCliente_Load(object sender, EventArgs e)
        {

            this.ProdXClientes.RefreshReport();
        }


        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (rb_FullListado.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = getTablas();
                generarReporte(tabla);
                btn_Client.Enabled = false;
                btn_Client.Visible = false;
                btn_Lider.Enabled = false;
                btn_Lider.Visible = false;
                btn_Prod.Enabled = false;
                btn_Prod.Visible = false;
                txtLider.Visible = false;
                txtCliente.Visible = false;
                txtProd.Visible = false;
                lbl_Cliente.Visible = false;
                lbl_Lider.Visible = false;
                lbl_Prod.Visible = false;

            }
            if (rb_IdCliente.Checked)
            {
                btn_Client.Enabled = true;
                btn_Client.Visible = true;
                btn_Lider.Enabled = false;
                btn_Lider.Visible = false;
                btn_Prod.Enabled = false;
                btn_Prod.Visible = false;
                txtLider.Visible = false;
                txtCliente.Visible = true;
                txtProd.Visible = false;
                lbl_Cliente.Visible = true;
                lbl_Lider.Visible = false;
                lbl_Prod.Visible = false;

            }
            if (rb_IdProducto.Checked)
            {
                btn_Client.Enabled = false;
                btn_Client.Visible = false;
                btn_Lider.Enabled = false;
                btn_Lider.Visible = false;
                btn_Prod.Enabled = true;
                btn_Prod.Visible = true;
                txtLider.Visible = false;
                txtCliente.Visible = false;
                txtProd.Visible = true;
                lbl_Cliente.Visible = false;
                lbl_Lider.Visible = false;
                lbl_Prod.Visible = true;
            }
            if (rb_LiderInst.Checked)
            {
                btn_Client.Enabled = false;
                btn_Client.Visible = false;
                btn_Lider.Enabled = true;
                btn_Lider.Visible = true;
                btn_Prod.Enabled = false;
                btn_Prod.Visible = false;
                txtLider.Visible = true;
                txtCliente.Visible = false;
                txtProd.Visible = false;
                lbl_Cliente.Visible = false;
                lbl_Lider.Visible = true;
                lbl_Prod.Visible = false;
            }
        }

        private void generarReporte(DataTable tabla)
        {
            ReportDataSource ds = new ReportDataSource("prodXcliente", tabla);
            ProdXClientes.LocalReport.DataSources.Clear();
            ProdXClientes.LocalReport.DataSources.Add(ds);
            ProdXClientes.RefreshReport();
            ProdXClientes.Visible = true;
        }
        private DataTable getTablas()
        {
            if (rb_FullListado.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_ProductosXCliente.obtenerListadoProductosXCliente();
                return tabla;
            }
            if (rb_IdCliente.Checked)
            {
                int var = int.Parse(txtCliente.Text);
                DataTable tabla = new DataTable();
                tabla = AD_ProductosXCliente.pXcCLiente(var);
                return tabla;
            }
            if (rb_IdProducto.Checked)
            {
                int var = int.Parse(txtProd.Text);
                DataTable tabla = new DataTable();
                tabla = AD_ProductosXCliente.pXcProd(var);
                return tabla;
            }
            else
            {
                int var = int.Parse(txtLider.Text);
                DataTable tabla = new DataTable();
                tabla = AD_ProductosXCliente.pXcLider(var);
                return tabla;
            }
        }

        private void btn_Prod_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = getTablas();
            generarReporte(tabla);
            lbl_Prod.Visible = false;
            txtProd.Visible = false;
            btn_Prod.Visible = false;
            btn_Prod.Enabled = false;
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = getTablas();
            generarReporte(tabla);
            lbl_Cliente.Visible = false;
            txtCliente.Visible = false;
            btn_Client.Visible = false;
            btn_Client.Enabled = false;
        }

        private void btn_Lider_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = getTablas();
            generarReporte(tabla);
            lbl_Lider.Visible = false;
            txtLider.Visible = false;
            btn_Lider.Visible = false;
            btn_Lider.Enabled = false;
        }
    }
    
}
