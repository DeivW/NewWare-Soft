using NewWare_Soft.AccesoADatos;
using NewWare_Soft.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void button_agregarCliente_Click(object sender, EventArgs e)
        {
            bool tieneNombre = false;
            bool tieneApellido = false;
            bool tieneTelefono = false;
            bool tieneEmail = false;
            bool tieneNroCalle = false;
            bool tieneNombreCalle = false;

            if (textBox_nombre.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un nombre! ");
                textBox_nombre.Focus();
            }
            else
            {
                tieneNombre = true;
            }
            if (textBox_apellido.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un apellido! ");
                textBox_apellido.Focus();
            }
            else
            {
                tieneApellido = true;
            }
            if (textBox_Email.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un email! ");
                textBox_Email.Focus();
            }
            else
            {
                tieneEmail = true;
            }
            if (textBox_nombreCalle.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un nombre de calle ! ");
                textBox_nombreCalle.Focus();
            }
            else
            {
                tieneNombreCalle = true;
            }
            if (textBox_nroCalle.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un numero de calle! ");
                textBox_nroCalle.Focus();
            }
            else
            {
                tieneNroCalle = true;
            }
            if (textBox_telefono.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un numero de telefono! ");
                textBox_telefono.Focus();
            }
            else
            {
                tieneTelefono = true;
            }
            bool existe = AD_Cliente.EncontrarCliente_Bool_DB(textBox_Email.Text);
            if (existe)
            {
                MessageBox.Show("El cliente que esta intentando agregar ya existe, porfavor intentelo de nuevo.");
                limpiarCampos();
                textBox_nombre.Focus();
            }
            else
            {
                insertarCliente(tieneApellido, tieneEmail, tieneNombre, tieneNombreCalle, tieneNroCalle, tieneTelefono);
            }


        }

        private void insertarCliente(bool tieneApellido, bool tieneEmail, bool tieneNombre, bool tieneNombreCalle, bool tieneNroCalle, bool tieneTelefono)
        {
            if (tieneNombre && tieneApellido && tieneTelefono  && tieneEmail && tieneNombreCalle && tieneNroCalle)
            {
                Cliente client = obtenerData_Cliente();
                bool result = AD_Cliente.AgregarCliente_DB(client);
                if (result)
                {
                    MessageBox.Show("El cliente fue ingresado a la base de datos de forma exitosa");
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("ERROR ! El cliente no fue ingresado en la base de datos. Por favor, intentelo de nuevo.");
                }

            }
        }

        private void limpiarCampos()
        {
            textBox_nombre.Text = "";
            textBox_apellido.Text = "";
            textBox_telefono.Text = "";
            textBox_Email.Text = "";
            textBox_nombreCalle.Text = "";
            textBox_nroCalle.Text = "";
        }

        private Cliente obtenerData_Cliente()
        {
            Cliente client = new Cliente();
            client.Nombre = textBox_nombre.Text.Trim();
            client.Apellido = textBox_apellido.Text.Trim();
            client.Telefono = textBox_telefono.Text.Trim();
            client.Email = textBox_Email.Text.Trim();
            client.Calle = textBox_nombreCalle.Text.Trim();
            //falta validar que los ints
            client.Telefono = textBox_telefono.Text;
            //try catch
            client.NroCalle = int.Parse(textBox_nroCalle.Text);
            client.Barrio = (int)comboBox_Barrio.SelectedValue;
            return client;


            //VALIDAR INTS
            //bool sePudo = validarTelefono(textBox_telefono.Text);
            //bool sePudo2 = validarNroCalle(textBox_nroCalle.Text);
            //if (sePudo && sePudo2 )
            //{
            //    client.Telefono = textBox_telefono.Text;
            //    client.NroCalle = int.Parse(textBox_telefono.Text);
            //    return client;
            //}
            //else
            //{
            //    textBox_telefono.Text = "";
            //    textBox_telefono.Focus();
            //}
        }

        //private bool validarNroCalle(string text)
        //{
        //    if (validarCampos(text) == false)
        //    {
        //        MessageBox.Show("Solo debe ingresar valores numericos en el cuadro de texto que corresponde al numero de calle. Intentelo de nuevo");
        //        textBox_telefono.Text = "";
        //        textBox_telefono.Focus();
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }

        //}

        //private bool validarTelefono(string text)
        //{
        //    if (validarCampos(text) == false)
        //    {
        //        MessageBox.Show("Solo debe ingresar valores numericos en el cuadro de texto que corresponde al numero de telefono. Intentelo de nuevo");
        //        textBox_telefono.Text = "";
        //        textBox_telefono.Focus();
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //private bool validarCampos(string cadena)
        //{
        //    bool isValid = false;
        //    if (cadena.Length != 0)
        //    {
        //        isValid = Regex.IsMatch(cadena, @"^[0-9]*$");
        //    }
        //    return isValid;
        //}

        private void button_limpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            llenarComboBarrio();
        }

        private void llenarComboBarrio()
        {
            try
            {
                comboBox_Barrio.DataSource = AD_Cliente.getData_Barrio_Combos();
                comboBox_Barrio.DisplayMember = "NombreBarrio";
                comboBox_Barrio.ValueMember = "IdBarrio";
                comboBox_Barrio.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! No pudimos obtener los datos de los barrios. Intentelo de nuevo.");
            }
        }
    }
}
