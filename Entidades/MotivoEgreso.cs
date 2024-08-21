using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    public class MotivoEgreso
    {
        private int Id;
        private string Nombre;

        public MotivoEgreso()
        {

        }
        public MotivoEgreso(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public string NombreMotivo
        {
            get => Nombre;
            set => Nombre = value;
        }
        public int IdMotivo
        {
            get => Id;
            set => Id = value;
        }
    }
}
