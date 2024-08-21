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
using System.Data.SqlClient;
using System.Threading;

namespace NewWare_Soft.Forms
{
    public partial class NuevaVenta : Form
    {

        #region Variables globales
        Producto productoGlobal = new Producto();

        Cliente clienteGlobal = new Cliente();

        List<int> listGlobal = new List<int>();
        #endregion

        public NuevaVenta()
        {
            InitializeComponent();
            textBox_Precio.Enabled = false;
            comboBox_Producto.Enabled = false;
            button_AgregarProducto.Enabled = false;
        }

        #region Boton Encontrar Cliente
        private void button_EncontrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente comprador = AD_Cliente.EncontrarCliente_DB(textBox_Email1.Text);
                clienteGlobal = comprador;
                if (comprador.Email == null)
                {
                    MessageBox.Show("El cliente que ingreso no existe");
                    showGroupBox(true);
                    showButtons(true);

                }
                else
                {
                    textBox_nombre.Text = comprador.Nombre;
                    textBox_apellido.Text = comprador.Apellido;
                    comboBox_Producto.Enabled = true;
                    textBox_Email1.Enabled = false;
                    button_EncontrarCliente.Enabled = false;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error inesperado. Intentelo de nuevo");
                throw;
            }

        }
        #endregion

        #region Cargar Combo Producto
        private void cargarComboProducto()
        {
            try
            {
                comboBox_Producto.DataSource = AD_Cliente.getData_Producto_Combo();
                comboBox_Producto.DisplayMember = "Denominacion";
                comboBox_Producto.ValueMember = "IdProducto";
                comboBox_Producto.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! No pudimos obtener los datos de los productos. Intentelo de nuevo.");
            }
        }
        #endregion

        #region Boton Si (Si Agrega cliente)
        private void button_Si_Click(object sender, EventArgs e)
        {
            AltaCliente ventana = new AltaCliente();
            ventana.ShowDialog();
            showGroupBox(false);
            showButtons(false);
        }
        #endregion

        #region Boton No (No Agrega Cliente)
        private void button_No_Click(object sender, EventArgs e)
        {
            textBox_Email1.Text = "";
            textBox_Email1.Focus();
            showGroupBox(false);
            showButtons(false);
        }
        #endregion

        #region Load Ventana
        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            cargarComboProducto();
            CargarComboFormaPago();
            fechaFacturacion();
            nroFacturacion();
            this.comboBox_Producto.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_Precio.Text = "0";
        }
        #endregion

        #region Cargar Combo Forma Pago
        private void CargarComboFormaPago()
        {

            try
            {
                cmbFormaPago.DataSource = AD_FPago.ObtenerTiposPago();
                cmbFormaPago.DisplayMember = "NombreFormaPago";
                cmbFormaPago.ValueMember = "idFormaPago";
                cmbFormaPago.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipos de pago");
            }
        }
        #endregion

        #region Show Botones
        private void showButtons(bool activado)
        {
            button_No.Enabled = activado;
            button_No.Visible = activado;
            button_Si.Enabled = activado;
            button_Si.Visible = activado;
        }
        #endregion

        #region Show GroupBox
        private void showGroupBox(bool activado)
        {
            groupBox_Alta.Enabled = activado;
            groupBox_Alta.Visible = activado;
        }
        #endregion

        #region Nro Siguiente Facturacion
        private void nroFacturacion()
        {
            try
            {
                int nro = AD_Cliente.ultimoNroFactura();
                textBox_NroFactura.Enabled = false;
                if (nro != -1)
                {
                    textBox_NroFactura.Text = (nro + 1).ToString();
                }
                else
                {
                    textBox_NroFactura.Text = 0.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Fecha Facturacion
        private void fechaFacturacion()
        {
            textBox_Fecha.Enabled = false;
            DateTime date = DateTime.Now;
            textBox_Fecha.Text = date.ToString();
        }
        #endregion

        #region Boton Buscar Precio
        private void button1_Click(object sender, EventArgs e)
        {
            Producto prod = AD_Productos.obtenerDatosProductoSeleccionado(comboBox_Producto.Text);
            textBox_Precio.Text = prod.Precio.ToString();
            productoGlobal = prod;
            if (textBox_Precio.Text.Equals("0"))
            {
                MessageBox.Show("Debe cargar datos del producto...");
            }
            else
            {
                button_AgregarProducto.Enabled = true;
            }
        }
        #endregion

        #region boton Agregar Producto Detalle Facturacion
        private void button_AgregarProducto_Click(object sender, EventArgs e)
        {
            if (ExistsGrid(productoGlobal.IdProducto.ToString()))
            {
                MessageBox.Show("El producto ya se encuentra en el detalle");
                comboBox_Producto.SelectedIndex = -1;
                textBox_Precio.Text = "0";
                button_AgregarProducto.Enabled = false;

            }
            else
            {
                cargarDetalle(productoGlobal);
                List<int> lista = obtenerDatosProductosGrilla(dgvProductos,2);
                listGlobal = lista;
                int total = calcularPrecioTotal(lista);
                textBox_Total.Text = total.ToString();
                comboBox_Producto.SelectedIndex = -1;
                textBox_Precio.Text = "0";
                button_AgregarProducto.Enabled = false;
            }
            
        }
        #endregion

        #region Cargar Grilla Detalle Facturacion
        private void cargarDetalle(Producto prodcto)
        {
            DataGridViewRow fila = new DataGridViewRow();
            DataGridViewTextBoxCell columnaID = new DataGridViewTextBoxCell();
            columnaID.Value = prodcto.IdProducto;
            fila.Cells.Add(columnaID);

            DataGridViewTextBoxCell columnaNombre = new DataGridViewTextBoxCell();
            columnaNombre.Value = prodcto.Denominacion;
            fila.Cells.Add(columnaNombre);

            DataGridViewTextBoxCell columnaPrecioVenta = new DataGridViewTextBoxCell();
            columnaPrecioVenta.Value = prodcto.Precio;
            fila.Cells.Add(columnaPrecioVenta);

            dgvProductos.Rows.Add(fila);
        }
        #endregion

        #region Boton Confirmar
        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            Factura factura = crearFactura();
            FormaPago fp = crearFormPago();
            List<int> listProduct = new List<int>();         
            listProduct = obtenerDatosProductosGrilla(dgvProductos, 0);            
            try
            {
                if (agregarFacturaDB(factura, listProduct, listGlobal,fp))
                {
                    MessageBox.Show("Operacion exitosa");
                    Thread.Sleep(2000);
                    this.Close();                    
                }
                else 
                {
                    MessageBox.Show("Operacion cancelada");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
        #endregion

        #region Ciclo For
        private List<int> obtenerDatosProductosGrilla(DataGridView grilla, int column)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < grilla.Rows.Count; i++)
            {
                list.Add(int.Parse(grilla.Rows[i].Cells[column].Value.ToString()));
            }
            return list;
        }
        #endregion

        #region Instanciar Factura
        private Factura crearFactura()
        {
            Factura factura = new Factura();
            factura.IdCliente = clienteGlobal.IdCliente;
            factura.FechaFacturacion = DateTime.Parse(textBox_Fecha.Text);
            factura.NroFactura = int.Parse(textBox_NroFactura.Text);

            return factura;
        }
        #endregion

        #region Instanciar Forma Pago
        private FormaPago crearFormPago()
        {
            FormaPago fp = new FormaPago();
            fp.NroFacturaPersona = int.Parse(textBox_NroFactura.Text);
            fp.IdFormaPagoPersona = (int)cmbFormaPago.SelectedValue;
            fp.DescripcionPersona = txtDescripcion.Text.Trim();
            fp.MontoPersona = int.Parse(textBox_Total.Text);

            return fp;
        }
        #endregion

        #region Agregar Factura a DB
        private bool agregarFacturaDB(Factura factura, List<int> listaProductos, List<int> listPrecios, FormaPago fp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction cmdTransaccion = null;
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand command = new SqlCommand();
                string query = "SET IDENTITY_INSERT [facturas] ON " +
                    " insert into facturas (NroFactura, IdCliente, FechaFactura) values (@nroFactura, @idCliente, @fechaFactura)";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nroFactura", factura.NroFactura);
                command.Parameters.AddWithValue("@idCliente", factura.IdCliente);
                command.Parameters.AddWithValue("@fechaFactura", factura.FechaFacturacion);
                command.CommandType = CommandType.Text;
                command.CommandText = query;


                canalConexion.Open();
                cmdTransaccion = canalConexion.BeginTransaction("AltaFactura");
                command.Transaction = cmdTransaccion;

                command.Connection = canalConexion;
                command.ExecuteNonQuery();
                int i = 0;
                foreach (var item in listaProductos)
                {                
                    string query2 = "insert into detalle_factura (NroFactura, IdCliente, IdProducto, Precio) values (@idFactura, @nroCliente, @idProducto, @precioProducto)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@idFactura", factura.NroFactura);
                    command.Parameters.AddWithValue("@nroCliente", factura.IdCliente);                   
                    command.Parameters.AddWithValue("@idProducto", item);
                    command.Parameters.AddWithValue("@precioProducto", listPrecios[i]);                     
                    command.CommandText = query2;
                    command.ExecuteNonQuery();
                    i++;
                }

                string query3 = "INSERT into formas_pago_factura (NroFactura,IdFormaPago,Descripcion,Monto) VALUES(@nroFactura,@idFormaPago,@descripcion,@monto)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nroFactura", fp.NroFacturaPersona);
                command.Parameters.AddWithValue("@idFormaPago", fp.IdFormaPagoPersona);
                command.Parameters.AddWithValue("@descripcion", fp.DescripcionPersona);
                command.Parameters.AddWithValue("@monto", fp.MontoPersona);
                command.CommandText = query3;
                command.ExecuteNonQuery();

                cmdTransaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cmdTransaccion.Rollback();
                return false;
            }
            finally 
            {
                canalConexion.Close();
            }
        }
        #endregion

        #region Existe grilla
        private bool ExistsGrid(string identification)
        {
            bool result = false;
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                if (dgvProductos.Rows[i].Cells["IdProducto"].Value.Equals(int.Parse(identification)))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        #endregion

        #region Calcular Total
        private int calcularPrecioTotal(List<int> listaPrecios)
        {
            int total = 0;
            for (int i = 0; i < listaPrecios.Count; i++)
            {
                total += listaPrecios[i];
            }
            return total;
        }
        #endregion

        #region Boton Confirmar Pago
        private void BtConfirmarDatosPago_Click(object sender, EventArgs e)
        {
            cmbFormaPago.Enabled = false;
            txtDescripcion.Enabled = false;
        }
        #endregion

        #region Boton Eliminar Datos Pago
        private void BtborrarCamposPago_Click(object sender, EventArgs e)
        {
            cmbFormaPago.SelectedIndex = -1;
            txtDescripcion.Text = "";
            cmbFormaPago.Enabled = true;
            txtDescripcion.Enabled = true;
        }
        #endregion

        #region Boton Cancelar Venta
        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operacion cancelada");
            Thread.Sleep(2000);
            this.Close();
        }
        #endregion
    }
}
