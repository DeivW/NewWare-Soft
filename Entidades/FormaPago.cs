using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    class FormaPago
    {
        private int NroFactura;
        private int IdFormaPago;
        private string Descripcion;
        private int Monto;


        public FormaPago()
        {

        }

        public int NroFacturaPersona
        {
            get => NroFactura;
            set => NroFactura = value;
        }
        public int IdFormaPagoPersona
        {
            get => IdFormaPago;
            set => IdFormaPago = value;
        }
        public string DescripcionPersona
        {
            get => Descripcion;
            set => Descripcion = value;
        }
        public int MontoPersona
        {
            get => Monto;
            set => Monto = value;
        }
    }
}
