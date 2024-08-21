using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    class Barrio
    {
        private string Nombre;
        private string Ciudad;
        private string IdBarrio;

        public Barrio()
        {

        }
        public Barrio(string nombre, string ciudad)
        {
            Nombre = nombre;
            Ciudad = ciudad;
        }
        public string NombreBarrio
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string CiudadBarrio
        {
            get => Ciudad;
            set => Ciudad = value;
        }
        public string Id
        {
            get => IdBarrio;
            set => IdBarrio = value;
        }
    }
}

