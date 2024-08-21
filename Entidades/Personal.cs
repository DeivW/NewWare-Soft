using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    public class Personal
    {
        private int legajo;
        private string nroDni;
        private string apellido;
        private string nombre;
        private int idUsuario;
        private DateTime fechaIngreso;
        private DateTime fechaEgreso;
        private int idMotivoEgreso;
        private int idCargo;
        private string nroCalle;
        private string calle;
        private int idBarrio;
        private DateTime fechaNacimiento;
        private int cantHoras;

        public Personal()
        {

        }

        public int CantidadHoras
        {
            get => cantHoras;
            set => cantHoras = value;
        }
        public DateTime FechaNacimientoPersonal
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }

        public DateTime FechaEgresoPersonal
        {
            get => fechaEgreso;
            set => fechaEgreso = value;
        }

        public DateTime FechaIngresoPersonal
        {
            get => fechaIngreso;
            set => fechaIngreso = value;
        }

        public int IdBarrioPersonal
        {
            get => idBarrio;
            set => idBarrio = value;
        }

        public int IdCargoPersonal
        {
            get => idCargo;
            set => idCargo = value;
        }

        public int IdMotivoEgresoPersonal
        {
            get => idMotivoEgreso;
            set => idMotivoEgreso = value;
        }

        public int IdUsuarioPersonal
        {
            get => idUsuario;
            set => idUsuario = value;
        }

        public int LegajoPersonal
        {
            get => legajo;
            set => legajo = value;
        }

        public string NroDniPersonal
        {
            get => nroDni;
            set => nroDni = value;
        }

        public string ApellidoPersonal
        {
            get => apellido;
            set => apellido = value;
        }

        public string NombrePersonal
        {
            get => nombre;
            set => nombre = value;
        }

        public string NroCallePersonal
        {
            get => nroCalle;
            set => nroCalle = value;
        }

        public string CallePersonal
        {
            get => calle;
            set => calle = value;
        }
    }
}

