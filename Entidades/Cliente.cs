using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private int idBarrio;
        private int nroCalle;
        private string nombreCalle;
        private string email;
        private int idCliente;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }
        public string Calle
        {
            get => nombreCalle;
            set => nombreCalle = value;
        }
        public int Barrio
        {
            get => idBarrio;
            set => idBarrio = value;
        }
        public int NroCalle
        {
            get => nroCalle;
            set => nroCalle = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }

        public int IdCliente
        {
            get => idCliente;
            set => idCliente = value;
        }
    }
}