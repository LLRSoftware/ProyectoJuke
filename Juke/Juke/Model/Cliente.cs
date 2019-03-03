using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke
{
    class Cliente
    {

        private int Id_Cliente;
        private String Nombre;
        private String Direccion;
        private String Telefono;
        private String RFC;
        private String Correo;

        public Cliente()
        {

        }

        public Cliente(int id_Cliente, string nombre, string direccion, string telefono, string rFC, string correo)
        {
            Id_Cliente = id_Cliente;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            RFC = rFC;
            Correo = correo;
        }

        public int Id_Cliente1 { get => Id_Cliente; set => Id_Cliente = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string RFC1 { get => RFC; set => RFC = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
    }
}
