using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    public class Cargos
    {
        private int IdCargo;
        private string NombreCargo;
        private string DescripcionCargo;

        public Cargos(string nombreCargo, string descripcionCargo)
        {
            NombreCargo = nombreCargo;
            DescripcionCargo = descripcionCargo;
        }

        public Cargos()
        {

        }

        public int IdCargoEmpleado
        {
            get => IdCargo;
            set => IdCargo = value;
        }
        public string NombreCargoEmpleado
        {
            get => NombreCargo;
            set => NombreCargo = value;
        }

        public string DescripcionCargoEmpleado
        {
            get => DescripcionCargo;
            set => DescripcionCargo = value;
        }
    }


}
