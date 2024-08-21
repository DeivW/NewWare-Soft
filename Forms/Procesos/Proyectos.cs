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
    public partial class Proyectos : Form
    {
        public Proyectos()
        {
            InitializeComponent();
        }

        private void Proyectos_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            ObtenerUltimoIdProyecto();
            CargarComboEtapas();
            CargarFechaInicio();
            CargarComboClientes();
        }

        private void CargarFechaInicio()
        {
            txtInicio.Text = DateTime.Now.ToShortDateString();
        }

        private void LimpiarCampos()
        {
            cmbClientes.SelectedIndex = -1;
            txtDescripcion.Clear();
            txtInicio.Clear();
            txtFin.Clear();
            txtFinReal.Clear();
        }

        private void ObtenerUltimoIdProyecto()
        {
            int id = AD_Proyectos.obtenerUltimoProyectoId();
            txtIDProyecto.Text = (id + 1).ToString();
        }

        private void CargarComboEtapas()
        {
            try
            {
                cmbEtapas.DataSource = AD_Proyectos.ObtenerEtapa();
                cmbEtapas.DisplayMember = "NombreEtapa";
                cmbEtapas.ValueMember = "IdEtapa";
                cmbEtapas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de etapas");
            }
        }
        private void CargarComboClientes()
        {
            try
            {
                DataTable tabla = AD_Proyectos.obtenerTablaClientes();
                tabla.Columns.Add("nombreCompleto", typeof(string), "Nombre + ' ' + Apellido");
                cmbClientes.DataSource = tabla;
                cmbClientes.DisplayMember = "nombreCompleto";
                cmbClientes.ValueMember = "IdCliente";
                cmbClientes.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo de clientes");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregarEtapa_Click(object sender, EventArgs e)
        {
            if (cmbEtapas.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("No ha seleccionado una etapa");
            }
            else
            {
                int id = AD_Proyectos.ObtenerIDEtapa(cmbEtapas.Text.Trim());
                if (!existeEnGrilla(cmbEtapas.Text))
                {
                    grdEtapas.Rows.Add(id, cmbEtapas.Text);
                    btnAgregarProyecto.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Esta etapa ya se encuntra en la grilla...");
                }
            }
        }

        private bool existeEnGrilla(string aBuscar)
        {
            bool resultado = false;
            for (int i = 0; i < grdEtapas.Rows.Count; i++)
            {
                if (grdEtapas.Rows[i].Cells["nombre"].Value.Equals(aBuscar))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }

        private Proyecto obtenerDatosProyecto()
        {
            if (cmbClientes.SelectedIndex == -1 || txtDescripcion.Text.Equals("") || txtInicio.Text.Equals("") || txtFin.Text.Equals("") || txtFinReal.Text.Equals(""))
            {
                return null;
            }
            else
            {
                Proyecto pro = new Proyecto();
                pro.IdCliente = (int)cmbClientes.SelectedValue;
                pro.Descripcion = txtDescripcion.Text.Trim();
                pro.FechaDeInicio = DateTime.Parse(txtInicio.Text);
                pro.FechaDeFinProbable = DateTime.Parse(txtFin.Text);
                pro.FechaDeFinReal = DateTime.Parse(txtFinReal.Text);
                return pro;
            }

        }

        private void btnAgregarProyecto_Click(object sender, EventArgs e)
        {
            Proyecto pro = obtenerDatosProyecto();
            if (pro == null)
            {
                MessageBox.Show("Primero debe llenar los campos...");
            }
            else
            {
                List<int> listaEtapas = new List<int>();
                for (int i = 0; i < grdEtapas.Rows.Count; i++)
                {
                    listaEtapas.Add(int.Parse(grdEtapas.Rows[i].Cells[0].Value.ToString()));
                }
                try
                {
                    bool resultado = AD_Proyectos.agregarProyectoABD(pro, listaEtapas, int.Parse(txtIDProyecto.Text));
                    if (resultado)
                    {
                        MessageBox.Show("Proyecto dado de alta con exito.");
                        LimpiarCampos();
                        ObtenerUltimoIdProyecto();
                    }
                    else
                    {
                        MessageBox.Show("Error al dar de alta el proyecto...");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al dar de alta el proyecto...");
                }

            }
        }
    }
}
