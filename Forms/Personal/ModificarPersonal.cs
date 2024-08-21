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
    public partial class ModificarPersonal : Form
    {
        public ModificarPersonal()
        {
            InitializeComponent();
        }

        private void ModificarPersonal_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarCombos2();
            CargarCombos3();
            CargarCombos4();
            CargarGrilla();
            DeshabilitarCampos();
        }

        private void CargarCombos()
        {
            try
            {
                cmbUsuario.DataSource = DAOpersonal.ObtenerTiposUsuarios();
                cmbUsuario.DisplayMember = "NombreUsuario";
                cmbUsuario.ValueMember = "IdUsuario";
                cmbUsuario.SelectedIndex = -1;
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
                cmbEgreso.DataSource = DAOpersonal.ObtenerTiposEgreso();
                cmbEgreso.DisplayMember = "NombreMotivoEgreso";
                cmbEgreso.ValueMember = "IdMotivoEgreso";
                cmbEgreso.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box IdTipoEgreso");
            }
        }

        private void CargarCombos3()
        {
            try
            {
                cmbCargo.DataSource = DAOpersonal.ObtenerTiposCargo();
                cmbCargo.DisplayMember = "Nombre";
                cmbCargo.ValueMember = "IdCargo";
                cmbCargo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box IdCargo");
            }
        }

        private void CargarCombos4()
        {
            try
            {
                cmbBarrio.DataSource = DAOpersonal.ObtenerTiposBarrio();
                cmbBarrio.DisplayMember = "NombreBarrio";
                cmbBarrio.ValueMember = "IdBarrio";
                cmbBarrio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar box IdBarrios");
            }
        }

        private void CargarGrilla()
        {
            try
            {
                gdrPersonal.DataSource = DAOpersonal.ObtenerListadoPersonalGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener listado de personas!");
            }
        }

        private void gdrPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            HabilitarCampos();
            DataGridViewRow filaSeleccionada = gdrPersonal.Rows[indice];
            string legajo = filaSeleccionada.Cells["Legajo"].Value.ToString();
            Personal p = DAOpersonal.ObtenerPersonal(legajo);
            LimpiarCampos();
            CargarCampos(p);
        }

        private void CargarCampos(Personal per)
        {
            txtLegajo.Text = per.LegajoPersonal.ToString();
            txtNroDoc.Text = per.NroDniPersonal;
            txtApellido.Text = per.ApellidoPersonal;
            txtNombre.Text = per.NombrePersonal;

            //txtFechaNacimiento.Text = per.FechaNacimientoPersonal.ToString();
            DateTime fecha = per.FechaNacimientoPersonal;
            string dia = "";
            string mes = "";
            string anio = "";
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
            anio = fecha.Date.Year.ToString();
            txtFechaNacimiento.Text = dia + mes + anio;

            //txtFechaIngreso.Text = per.FechaIngresoPersonal.ToString();
            DateTime fecha2 = per.FechaIngresoPersonal;
            string dia2 = "";
            string mes2 = "";
            string anio2 = "";
            dia2 = fecha2.Date.Day.ToString();
            if (dia2.Length == 1)
            {
                dia2 = "0" + dia2;
            }
            mes2 = fecha2.Date.Month.ToString();
            if (mes2.Length == 1)
            {
                mes2 = "0" + mes2;
            }
            anio2 = fecha2.Date.Year.ToString();
            txtFechaIngreso.Text = dia2 + mes2 + anio2;

            //txtFechaEgreso.Text = per.FechaEgresoPersonal.ToString();
            DateTime fecha3 = per.FechaEgresoPersonal;
            string dia3 = "";
            string mes3 = "";
            string anio3 = "";
            dia3 = fecha3.Date.Day.ToString();
            if (dia3.Length == 1)
            {
                dia3 = "0" + dia3;
            }
            mes3 = fecha3.Date.Month.ToString();
            if (mes3.Length == 1)
            {
                mes3 = "0" + mes3;
            }
            anio3 = fecha3.Date.Year.ToString();
            txtFechaEgreso.Text = dia3 + mes3 + anio3;

            cmbEgreso.SelectedValue = per.IdMotivoEgresoPersonal.ToString();
            cmbCargo.SelectedValue = per.IdCargoPersonal.ToString();
            cmbUsuario.SelectedValue = per.IdUsuarioPersonal.ToString();
            txtCalle.Text = per.CallePersonal;
            txtNroCalle.Text = per.NroCallePersonal;
            cmbBarrio.SelectedValue = per.IdBarrioPersonal.ToString();
        }

        private void LimpiarCampos()
        {
            txtLegajo.Text = "";
            txtNroDoc.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtFechaNacimiento.Text = "";
            txtFechaIngreso.Text = "";
            txtFechaEgreso.Text = "";
            cmbEgreso.SelectedIndex = -1;
            cmbCargo.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            cmbBarrio.SelectedIndex = -1;
        }

        private Personal ObtenerPersonal()
        {
            Personal per = new Personal();
            per.LegajoPersonal = int.Parse(txtLegajo.Text);
            per.NroDniPersonal = txtNroDoc.Text.Trim();
            per.ApellidoPersonal = txtApellido.Text.Trim();
            per.NombrePersonal = txtNombre.Text.Trim();
            per.CallePersonal = txtCalle.Text.Trim();
            per.NroCallePersonal = txtNroCalle.Text.Trim();
            per.IdBarrioPersonal = (int)cmbBarrio.SelectedValue;
            per.IdCargoPersonal = (int)cmbCargo.SelectedValue;
            per.IdMotivoEgresoPersonal = (int)cmbEgreso.SelectedValue;
            per.IdUsuarioPersonal = (int)cmbUsuario.SelectedValue;
            per.FechaNacimientoPersonal = DateTime.Parse(txtFechaNacimiento.Text);
            per.FechaIngresoPersonal = DateTime.Parse(txtFechaIngreso.Text);
            per.FechaEgresoPersonal = DateTime.Parse(txtFechaEgreso.Text);

            return per;
        }

        private void DeshabilitarCampos()
        {
            txtApellido.Enabled = false;
            txtCalle.Enabled = false;
            txtFechaEgreso.Enabled = false;
            txtFechaIngreso.Enabled = false;
            txtFechaNacimiento.Enabled = false;
            txtNombre.Enabled = false;
            txtNroCalle.Enabled = false;
            txtNroDoc.Enabled = false;
            cmbBarrio.Enabled = false;
            cmbCargo.Enabled = false;
            cmbEgreso.Enabled = false;
            cmbUsuario.Enabled = false;
            btActualizar.Enabled = false;
            btLimpiar.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtApellido.Enabled = true;
            txtCalle.Enabled = true;
            txtFechaEgreso.Enabled = true;
            txtFechaIngreso.Enabled = true;
            txtFechaNacimiento.Enabled = true;
            txtNombre.Enabled = true;
            txtNroCalle.Enabled = true;
            txtNroDoc.Enabled = true;
            cmbBarrio.Enabled = true;
            cmbCargo.Enabled = true;
            cmbEgreso.Enabled = true;
            cmbUsuario.Enabled = true;
            btActualizar.Enabled = true;
            btLimpiar.Enabled = true;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Personal p = ObtenerPersonal();
            bool res = DAOpersonal.ActualizarPersonal(p);
            if (res)
            {
                MessageBox.Show("Persona actualizada!");
                LimpiarCampos();
                CargarGrilla();
                DeshabilitarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar persona");
            }
        }
    }
}
