using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    class Factura
    {
        private int nroFactura;
        private DateTime fechaFacturacion;
        private int idCliente;

        public int NroFactura
        {
            get => nroFactura;
            set => nroFactura = value;
        }

        public DateTime FechaFacturacion
        {
            get => fechaFacturacion;
            set => fechaFacturacion = value;
        }

        public int IdCliente
        {
            get => idCliente;
            set => idCliente = value;             
        }
    }
}
