using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke
{
    class Empleado
    {
        private int Id_empleado;
        private String Nombre;
        private String ApellidoP;
        private String ApellidoM;
        private String Sexo;
        private String foto;
        private String IFE;
        private String CURP;
        private String Fecha_Na;
        private String Pais_Na;
        private String Fecha_ini;
        private String Fecha_Fin;
        private String Nacionalidad;
        private String RFC;
        private String CiudadNac;
        private String EstadoNac;
        private String Civil;

        public Emple()
        {
            Id_empleado = this.Id_empleado1;
            Nombre = this.Nombre1;
            ApellidoP = this.ApellidoP1;
            ApellidoM = this.ApellidoM1;
            Sexo = this.Sexo1;
            foto = this.Foto;
            IFE = this.IFE1;
            CURP = this.CURP1;
            Fecha_Na = this.Fecha_Na1;
            Pais_Na = this.Pais_Na1;
            Fecha_ini = this.Fecha_ini1;
            Fecha_Fin = this.Fecha_Fin1;
            Nacionalidad = this.Nacionalidad1;
            RFC = this.RFC1;
            CiudadNac = this.CiudadNac1;
            EstadoNac = this.EstadoNac1;
            Civil = this.Civil1;
        }

        public int Id_empleado1 { get => Id_empleado; set => Id_empleado = value; }
        public String Nombre1 { get => Nombre; set => Nombre = value; }
        public String ApellidoP1 { get => ApellidoP; set => ApellidoP = value; }
        public String ApellidoM1 { get => ApellidoM; set => ApellidoM = value; }
        public String Sexo1 { get => Sexo; set => Sexo = value; }
        public String Foto { get => foto; set => foto = value; }
        public String IFE1 { get => IFE; set => IFE = value; }
        public String CURP1 { get => CURP; set => CURP = value; }
        public String Fecha_Na1 { get => Fecha_Na; set => Fecha_Na = value; }
        public String Pais_Na1 { get => Pais_Na; set => Pais_Na = value; }
        public String Fecha_ini1 { get => Fecha_ini; set => Fecha_ini = value; }
        public String Fecha_Fin1 { get => Fecha_Fin; set => Fecha_Fin = value; }
        public String Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
        public String RFC1 { get => RFC; set => RFC = value; }
        public String CiudadNac1 { get => CiudadNac; set => CiudadNac = value; }
        public String EstadoNac1 { get => EstadoNac; set => EstadoNac = value; }
        public String Civil1 { get => Civil; set => Civil = value; }
    }
}
