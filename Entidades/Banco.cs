using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    public class Banco
    {
        private int Id;
        private string Nombre;

        public Banco()
        {

        }
        public Banco(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public string NombreBanco
        {
            get => Nombre;
            set => Nombre = value;
        }
        public int IdBanco
        {
            get => Id;
            set => Id = value;
        }
    }
}
