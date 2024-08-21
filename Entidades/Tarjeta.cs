using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    public class Tarjeta
    {
        private int NumeroTarjeta;
        private int IdBanco;
        private DateTime FechaVencimiento;
        private int CodigoSeguridad;

        public Tarjeta()
        {

        }

        public Tarjeta(int nroTarjeta, int idBanco, DateTime fechaVenc, int codSeguridad)
        {
            NumeroTarjeta = nroTarjeta;
            IdBanco = idBanco;
            FechaVencimiento = fechaVenc;
            CodigoSeguridad = codSeguridad;
        }

        public int NroTarjeta
        {
            get => NumeroTarjeta;
            set => NumeroTarjeta = value;
        }
        public int ID_Banco
        {
            get => IdBanco;
            set => IdBanco = value;
        }
        public DateTime Fecha_vencimiento
        {
            get => FechaVencimiento;
            set => FechaVencimiento = value;
        }
        public int Cod_seguridad
        {
            get => CodigoSeguridad;
            set => CodigoSeguridad = value;
        }


    }
}
