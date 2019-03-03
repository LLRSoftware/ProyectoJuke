using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke
{
    class Gastos
    {

        private int Id_Gastos;
        private int Id_Sucursal;
        private DateTime Fecha;

        public Gastos()
        {

        }

        public Gastos(int id_Gastos, int id_Sucursal, DateTime fecha)
        {
            Id_Gastos = id_Gastos;
            Id_Sucursal = id_Sucursal;
            Fecha = fecha;
        }

        public int Id_Gastos1 { get => Id_Gastos; set => Id_Gastos = value; }
        public int Id_Sucursal1 { get => Id_Sucursal; set => Id_Sucursal = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
    }
}
