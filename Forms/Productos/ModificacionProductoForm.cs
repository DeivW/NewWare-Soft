using NewWare_Soft.AccesoADatos;
using NewWare_Soft.Entidades;
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
    public partial class ModificacionProductoForm : Form
    {
        public ModificacionProductoForm()
        {
            InitializeComponent();
        }
        private void ModificacionProductoForm_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            activarDesactivarCampos(false);
            cargarGrilla();
        }
        private void limpiarCampos()
        {
            txtDenominacion.Text = "";
            txtDescripcion.Text = "";
            txtFinalizacion.Text = "";
            txtPrecio.Text = "";
        }
        private void activarDesactivarCampos(bool act)
        {
            if (act)
            {
                txtDescripcion.Enabled = true;
                txtFinalizacion.Enabled = true;
                txtPrecio.Enabled = true;
                btnModificarProducto.Enabled = true;
            }
            else
            {
                txtDenominacion.Enabled = false;
                txtDescripcion.Enabled = false;
                txtFinalizacion.Enabled = false;
                txtPrecio.Enabled = false;
                btnModificarProducto.Enabled = false;
            }
        }

        private void grdProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdProductos.Rows[indice];
            string denominacion = filaSeleccionada.Cells["denominacion"].Value.ToString();
            try
            {
                Producto per = AD_Productos.obtenerProducto(denominacion);
                limpiarCampos();
                cargarCampos(per);
                activarDesactivarCampos(true);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al obtener el producto...");
            }
        }
        private void cargarCampos(Producto prod)
        {
            txtDenominacion.Text = prod.Denominacion;
            txtDescripcion.Text = prod.Descripcion;
            DateTime fecha = prod.FechaDeFinalizacion;
            string dia;
            string mes;
            string año;
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();
            txtFinalizacion.Text = dia + mes + año;
            txtPrecio.Text = prod.Precio.ToString();
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Producto per = obtenerDatosProducto();
            bool resultado = AD_Productos.actualizarProducto(per);
            if (resultado)
            {
                MessageBox.Show("Se actualizo el producto con exito");
                limpiarCampos();
                cargarGrilla();
                activarDesactivarCampos(false);
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto...");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            activarDesactivarCampos(false);
        }
        private Producto obtenerDatosProducto()
        {
            if (txtDenominacion.Text.Equals("") || txtDescripcion.Text.Equals("") || txtFinalizacion.Text.Equals("") || txtPrecio.Text.Equals(""))
            {
                return null;
            }
            else
            {
                Producto prod = new Producto();
                prod.Denominacion = txtDenominacion.Text.Trim();
                prod.Descripcion = txtDescripcion.Text.Trim();
                prod.FechaDeFinalizacion = DateTime.Parse(txtFinalizacion.Text);
                prod.Precio = int.Parse(txtPrecio.Text);
                return prod;
            }
        }
        public void cargarGrilla()
        {
            try
            {
                grdProductos.DataSource = AD_Productos.cargarGrilla();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener productos...");
            }
        }
    }
}
