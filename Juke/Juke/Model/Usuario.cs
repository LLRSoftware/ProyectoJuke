using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke
{
    class Usuario
    {

        private int Id_Usuario;
        private int Id_EmpleadoF;
        private int Id_PerfilF;
        private String Contrasena;
        private String Nombre;
        private int Estatus;

        public Usuario()
        {

        }

        public Usuario(int id_Usuario, int id_EmpleadoF, int id_PerfilF, string contrasena, string nombre, int estatus)
        {
            Id_Usuario = id_Usuario;
            Id_EmpleadoF = id_EmpleadoF;
            Id_PerfilF = id_PerfilF;
            Contrasena = contrasena;
            Nombre = nombre;
            Estatus = estatus;
        }

        public int Id_Usuario1 { get => Id_Usuario; set => Id_Usuario = value; }
        public int Id_EmpleadoF1 { get => Id_EmpleadoF; set => Id_EmpleadoF = value; }
        public int Id_PerfilF1 { get => Id_PerfilF; set => Id_PerfilF = value; }
        public string Contrasena1 { get => Contrasena; set => Contrasena = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Estatus1 { get => Estatus; set => Estatus = value; }
    }
}
