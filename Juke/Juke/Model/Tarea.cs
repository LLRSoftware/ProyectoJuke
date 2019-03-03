using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke
{
    class Tarea
    {

        private int Id_Tarea;
        private String Nombre;
        private String Descripcion;
        private Double Precio;
        private String Lote;

        public Tarea()
        {

        }

        public Tarea(int id_Tarea, string nombre, string descripcion, double precio, string lote)
        {
            Id_Tarea = id_Tarea;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Lote = lote;
        }

        public int Id_Tarea1 { get => Id_Tarea; set => Id_Tarea = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
        public string Lote1 { get => Lote; set => Lote = value; }
    }
}
