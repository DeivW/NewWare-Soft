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
    public partial class AltaPersonal : Form
    {
        public AltaPersonal()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNroDoc.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtFechaNacimiento.Text = "";
            txtFechaIngreso.Text = "";
            txtFechaEgreso.Text = "";
            cmbEgreso.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            cmbCargo.SelectedIndex = -1;
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            cmbBarrio.SelectedIndex = -1;
        }

        private void AltaPersonal_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarCombos2();
            CargarCombos3();
            CargarCombos4();
            LimpiarCampos();
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

        private Personal ObtenerPersonal()
        {
            Personal per = new Personal();
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

        private void btAddPersonal_Click(object sender, EventArgs e)
        {
            Personal per = ObtenerPersonal();
            bool res = DAOpersonal.InsertarPersonal(per);
            if (res)
            {
                MessageBox.Show("Personal agregado correctamente a la BD!");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar personal!");
            }
        }

        private void btLimpiarPersonal_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
