using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    class FormasPago
    {
        private int idFormaPago;
        private string nombre;

        public FormasPago()
        {

        }

        public int IdFormaPagoPersona
        {
            get => idFormaPago;
            set => idFormaPago = value;
        }
        public string NombreFormaPago
        {
            get => nombre;
            set => nombre = value;
        }
    }
}
