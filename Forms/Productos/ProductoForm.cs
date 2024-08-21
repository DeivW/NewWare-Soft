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
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }
        private void ProductoForm_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            cargarGrilla();
        }
        private void cargarGrilla()
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
        private void limpiarCampos() 
        {
            txtDenominacion.Text = "";
            txtDescripcion.Text = "";
            txtFinalizacion.Text = "";
            txtPrecio.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private Producto obtenerDatosProducto() 
        {
            if (txtDenominacion.Text.Equals("") || txtFinalizacion.Text.Equals("") || txtPrecio.Text.Equals(""))
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
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto prod = obtenerDatosProducto();
            if (prod == null)
            {
                MessageBox.Show("Primero debe llenar los campos...");
            }
            else
            {
                try
                {
                    bool resultado = AD_Productos.agregarProductoABd(prod);
                    if (resultado)
                    {
                        MessageBox.Show("Producto dado de alta con exito.");
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al dar de alta el producto...");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al dar de alta el producto...");
                }
                
            }
        }
    }
}
