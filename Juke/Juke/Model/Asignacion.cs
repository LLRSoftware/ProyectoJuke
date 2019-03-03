using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke
{
    class Asignacion
    {
        private int Id_Asignacion;
        private int Id_DepartamentoF;
        private String Escolaridad;
        private String Ubicacion;
        private String Categoria;
        private String Plaza;
        private String Puesto;
        private int Tipo_Nomina;
        private int Estado;
        private String Vacante;
        private String Supervisor;

        public Asignacion()
        {

        }

        public Asignacion(int id_Asignacion, int id_DepartamentoF, string escolaridad, string ubicacion, string categoria, string plaza, string puesto, int tipo_Nomina, int estado, string vacante, string supervisor)
        {
            Id_Asignacion = id_Asignacion;
            Id_DepartamentoF = id_DepartamentoF;
            Escolaridad = escolaridad;
            Ubicacion = ubicacion;
            Categoria = categoria;
            Plaza = plaza;
            Puesto = puesto;
            Tipo_Nomina = tipo_Nomina;
            Estado = estado;
            Vacante = vacante;
            Supervisor = supervisor;
        }

        public int Id_Asignacion1 { get => Id_Asignacion; set => Id_Asignacion = value; }
        public int Id_DepartamentoF1 { get => Id_DepartamentoF; set => Id_DepartamentoF = value; }
        public string Escolaridad1 { get => Escolaridad; set => Escolaridad = value; }
        public string Ubicacion1 { get => Ubicacion; set => Ubicacion = value; }
        public string Categoria1 { get => Categoria; set => Categoria = value; }
        public string Plaza1 { get => Plaza; set => Plaza = value; }
        public string Puesto1 { get => Puesto; set => Puesto = value; }
        public int Tipo_Nomina1 { get => Tipo_Nomina; set => Tipo_Nomina = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
        public string Vacante1 { get => Vacante; set => Vacante = value; }
        public string Supervisor1 { get => Supervisor; set => Supervisor = value; }

    }
}
