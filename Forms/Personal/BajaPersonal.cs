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
    public partial class BajaPersonal : Form
    {
        public BajaPersonal()
        {
            InitializeComponent();
        }

        private void BajaPersonal_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrBaja.DataSource = DAOpersonal.ObtenerListadoPersonalGrillaBaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener listado de personas!");
            }
        }

        private void gdrBaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrBaja.Rows[indice];
            string legajo = filaSeleccionada.Cells["Legajo"].Value.ToString();
            Personal p = DAOpersonal.ObtenerPersonal(legajo);
            DialogResult opt = new DialogResult();
            opt = MessageBox.Show("Realmente desea eliminar al empleado: " + p.NombrePersonal + " " + p.ApellidoPersonal + " - Legajo: " + p.LegajoPersonal + "?", "Eliminar Personal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opt == DialogResult.Yes)
            {
                DialogResult opt2 = new DialogResult();
                opt2 = MessageBox.Show("No podrá revertir los cambios una vez eliminado!", "Eliminar Personal", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (opt2 == DialogResult.OK)
                {
                    DAOpersonal.EliminarPersonal(p);
                }
                else
                {
                    MessageBox.Show("Operacion Cancelada!");
                }
            }
            else
            {
                MessageBox.Show("Operacion Cancelada!");
            }
            CargarGrilla();
        }
    }
}
