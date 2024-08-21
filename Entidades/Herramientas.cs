using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    public class Herramientas
    {
        private string NombreHer;
        private string Descrip;

        public Herramientas(string nombreHerramienta, string descripcion)
        {
            NombreHer = nombreHerramienta;
            Descrip = descripcion;
        }

        public string NombreHerramienta
        {
            get => NombreHer;
            set => NombreHer = value;
        }

        public string Descripcion
        {
            get => Descrip;
            set => Descrip = value;
        }
    }
}
