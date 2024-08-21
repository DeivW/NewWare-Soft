using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    public class Usuarios
    {
        private string ID;
        private string NombreUsu;
        private string Pass;

        public Usuarios(string nombreUsuario, string password)
        {
            NombreUsu = nombreUsuario;
            Pass = password;
        }

        public Usuarios()
        {

        }

        public string id //
        {
            get => ID;
            set => ID = value;
        }

        public string NombreUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string Password
        {
            get => Pass;
            set => Pass = value;
        }
    }
}
