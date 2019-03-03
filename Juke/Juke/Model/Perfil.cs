using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke
{
    class Perfil
    {

        private int Id_Perfil;
        private String Nombre;

        public Perfil()
        {

        }

        public Perfil(int id_Perfil, string nombre)
        {
            Id_Perfil = id_Perfil;
            Nombre = nombre;
        }

        public int Id_Perfil1 { get => Id_Perfil; set => Id_Perfil = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
    }
}
