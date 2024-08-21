using NewWare_Soft.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms
{
    public partial class Alta_Cargo : Form
    {
        public Alta_Cargo()
        {
            InitializeComponent();
        }
        private void Alta_Cargo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {

            try
            {
                grillaListaCargos.DataSource = AD_Cargo.ObtenerListadoCargos();
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo cargar tabla");
            }

            
        }
       

        private void btnAltaPersona_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Nombre de Cargo");
                txtCargo.Focus();
            }
            else
            {
                string nombreCargo = txtCargo.Text;
                
                bool busqueda = false;
                try
                {
                    busqueda = AD_Cargo.ValidarCargo(nombreCargo);
                    
                    if(busqueda == true)
                    {
                        MessageBox.Show("El cargo ya existe");
                        txtCargo.Focus();
                    }
                    else
                    {
                        try
                        {
                            bool resultado = AD_Cargo.InsertarCargo(txtCargo.Text, txtDescripcionCargo.Text);
                            if (resultado)
                            { 
                                MessageBox.Show("Cargo dado de alta con exito");
                                LimpiarCampos();
                                CargarGrilla();
                                txtCargo.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Error al insertar cargo");
                                txtCargo.Focus();
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al insertar nuevo cargo");
                    txtCargo.Focus();
                }
            }
        }

        private void LimpiarCampos()
        {
            txtCargo.Text = "";
            txtDescripcionCargo.Text = "";
            txtCargo.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        
    }
}
