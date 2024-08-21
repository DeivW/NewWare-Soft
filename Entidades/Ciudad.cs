using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    class Ciudad
    {
        private string Nombre;
       

        public Ciudad()
        {

        }
        public Ciudad(string nombre)
        {
            Nombre = nombre;
           
        }
        public string NombreCiudad
        {
            get => Nombre;
            set => Nombre = value;
        }
      
    }
}
