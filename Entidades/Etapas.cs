using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    class Etapas
    {
        private string nombre;
        public Etapas(string nombre)
        {
            this.nombre = nombre;        
        }
        public Etapas()
        { 
        
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

    }
}
