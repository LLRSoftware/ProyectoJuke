using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke
{
    class Compra
    {

        private int Id_Compra;
        private int Id_GastoF;
        private int Id_Usuario;
        private DateTime Fecha;
        private String Folio;

        public Compra()
        {

        }

        public Compra(int id_Compra, int id_GastoF, int id_Usuario, DateTime fecha, string folio)
        {
            Id_Compra = id_Compra;
            Id_GastoF = id_GastoF;
            Id_Usuario = id_Usuario;
            Fecha = fecha;
            Folio = folio;
        }

        public int Id_Compra1 { get => Id_Compra; set => Id_Compra = value; }
        public int Id_GastoF1 { get => Id_GastoF; set => Id_GastoF = value; }
        public int Id_Usuario1 { get => Id_Usuario; set => Id_Usuario = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public string Folio1 { get => Folio; set => Folio = value; }
    }
}
