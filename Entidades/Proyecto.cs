using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    class Proyecto
    {
        private int idCliente;
        private string descripcion;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private DateTime fechaFinReal;
        public Proyecto(int idCliente, string descripcion, DateTime fechaInicio, DateTime fechaFin, DateTime fechaFinReal)
        {
            this.idCliente = idCliente;
            this.descripcion = descripcion;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.fechaFinReal = fechaFinReal;
        }
        public Proyecto() { }
        public int IdCliente
        {
            get => idCliente;
            set => idCliente = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public DateTime FechaDeInicio
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }
        public DateTime FechaDeFinProbable
        {
            get => fechaFin;
            set => fechaFin = value;
        }
        public DateTime FechaDeFinReal
        {
            get => fechaFinReal;
            set => fechaFinReal = value;
        }
    }
}
