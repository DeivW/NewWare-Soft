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
using NewWare_Soft.Entidades;
namespace NewWare_Soft.Forms
{
    public partial class PersonalXEtapa : Form
    {
        public PersonalXEtapa()
        {
            InitializeComponent();
        }

        private void PersonalXEtapa_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarCombos2();
            chkEtapa.Checked = false;
        }
        

        private void LimpiarForm()
        {
            cmbEtapa.SelectedIndex = -1;
            cmbProyecto.SelectedIndex = -1;
            LimpiarCamposPersonal();
            chkEtapa.Checked = false;
        }

        private void CargarCombos()
        {
            try
            {
                cmbEtapa.DataSource = AD_PersonalXEtapa.ObtenerEtapas();
                cmbEtapa.DisplayMember = "NombreEtapa";
                cmbEtapa.ValueMember = "IdEtapa";
                cmbEtapa.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box IdUsuarios");
            }
        }

        private void CargarCombos2()
        {
            try
            {
                cmbProyecto.DataSource = AD_PersonalXEtapa.ObtenerProyectos();
                cmbProyecto.DisplayMember = "CodigoProyecto";
                cmbProyecto.ValueMember = "CodigoProyecto";
                cmbProyecto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box IdUsuarios");
            }
        }

        private void LimpiarCamposPersonal()
        {
            txtLegajo.Text = "";
            txtNombrePersonal.Text = "";
            txtApellido.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFinal.Text = "";
            txtIdCargo.Text = "";
            txtHoras.Text = "";
        }

        
        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            if (chkEtapa.Checked == false)
            {
                MessageBox.Show("Aun no ha confirmado si la etapa pertenece al proyecto");
            }
            else
            {
                if (txtLegajo.Text.Equals(""))
                {
                    MessageBox.Show("No ha ingresado ningun valor al campo de legajo, por favor carguelo");
                    txtLegajo.Focus();
                }
                else
                {
                    try
                    {
                        DataTable tablaResultado = AD_PersonalXEtapa.ObtenerPersonalXLegajo(int.Parse(txtLegajo.Text.Trim()));
                        if (tablaResultado.Rows.Count > 0)
                        {
                            txtNombrePersonal.Text = tablaResultado.Rows[0][3].ToString();
                            txtApellido.Text = tablaResultado.Rows[0][2].ToString();
                            txtIdCargo.Text = tablaResultado.Rows[0][8].ToString();
                            txtFechaInicio.Text = tablaResultado.Rows[0][5].ToString();
                            DataTable tablaPersonalenEtapa = AD_PersonalXEtapa.BuscarPersonalEnTablaPXE(int.Parse(txtLegajo.Text.Trim()));
                            try
                            {
                                if (tablaPersonalenEtapa.Rows.Count > 0)
                                {
                                    MessageBox.Show("El personal buscado existe pero ya esta asignado a un proyecto. " +
                                        "Un empleado puede solo trabajar en un proyecto a la vez. Por favor seleccione otro Empleado.");
                                    txtLegajo.Focus();
                                    LimpiarCamposPersonal();
                                }
                                else
                                {
                                    MessageBox.Show("El personal buscado existe y no esta asignado a ningun proyecto");
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("El personal buscado no existe");
                            txtLegajo.Focus();
                            txtLegajo.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al verificar personal");
                    }
                }

            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCamposPersonal();
        }

        private void btnAgregarPersonaGrilla_Click(object sender, EventArgs e)
        {
            if (txtIdCargo.Text.Equals("") || txtLegajo.Text.Equals("") || txtFechaFinal.Text.Equals("") || txtHoras.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacios! por favor cargue los datos correspondientes antes de cargar el personal a la grilla.");
                txtFechaFinal.Focus();
            }
            else
            {
                if (existeEnGrilla(txtLegajo.Text))
                {
                    MessageBox.Show("El personal que quiere cargar ya se encuentra en la grilla");
                    txtLegajo.Focus();
                    LimpiarCamposPersonal();
                }
                else
                {
                    gdrPersonal.Rows.Add(txtLegajo.Text.Trim(), txtFechaInicio.Text, txtFechaFinal.Text, txtIdCargo.Text.Trim(), txtHoras.Text.Trim());
                    LimpiarCamposPersonal();
                }
            }
        }
        
        private bool existeEnGrilla(string legajo)
        {
            bool resultado = false;
            for (int i = 0; i < gdrPersonal.Rows.Count; i++)
            {
                if (gdrPersonal.Rows[i].Cells["Legajo"].Value.Equals(legajo))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            if (cmbEtapa.SelectedIndex.Equals(-1) || cmbProyecto.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("No ha selecionado una etapa o proyecto");
                cmbEtapa.Focus();
            }
            else
            {
                if (gdrPersonal.Rows.Count < 1)
                {
                    MessageBox.Show("Aun no ha cargado ningun dato a la grilla, por favor carguelos antes de realizar la transaccion");
                    txtLegajo.Focus();
                }
                else
                {
                    
                    List<Personal> listaPersonal = new List<Personal>();
                    foreach (DataGridViewRow row in gdrPersonal.Rows)
                    {
                        Personal personal = new Personal();

                        personal.LegajoPersonal = int.Parse(row.Cells["Legajo"].Value.ToString());
                        personal.FechaIngresoPersonal = DateTime.Parse(row.Cells["FechaIni"].Value.ToString());
                        personal.FechaEgresoPersonal = DateTime.Parse(row.Cells["FechaFin"].Value.ToString());
                        personal.IdCargoPersonal = int.Parse(row.Cells["IdCargo"].Value.ToString());
                        personal.CantidadHoras = int.Parse(row.Cells["CantHoras"].Value.ToString());
                        listaPersonal.Add(personal);
                    }

                    try
                    {
                        if (AD_PersonalXEtapa.TransaccionPersonalXEtapa((int)cmbEtapa.SelectedValue, (int)cmbProyecto.SelectedValue, listaPersonal))
                        {
                            MessageBox.Show("Operacion Exitosa");
                            gdrPersonal.Rows.Clear();
                            LimpiarForm();
                            
                        }
                        else
                        {
                            MessageBox.Show("Fallo la operacion");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }

            
        }

        private void btnConfirmarEtapaxProyecto_Click(object sender, EventArgs e)
        {
            if (cmbProyecto.SelectedIndex.Equals(-1) || cmbEtapa.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("No ha seleccionado una etapa o proyecto");
            }
            else
            {
                
                try
                {
                    DataTable tablaResultados = AD_PersonalXEtapa.ConfirmarEtapaxProyecto((int)cmbProyecto.SelectedValue, (int)cmbEtapa.SelectedValue);
                    if (tablaResultados.Rows.Count > 0)
                    {
                        MessageBox.Show("La etapa es parte del proyecto");
                        chkEtapa.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("La etapa seleccionada no es parte del proyecto");
                        chkEtapa.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar Etapa");
                }

            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
