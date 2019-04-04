using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_personales.Model
{
    class Datos_Personales
    {
        private int Id_D_Personales;
        private int Id_EmpleadoF;
        private String Calle;
        private int Numero_Int;
        private int Numero_Ext;
        private String Colonia;
        private String Ciudad;
        private String Pais;
        private String telefono_P;
        private String telefono_R;


        public Datos_Personales() {
        Id_D_Personales = this.Id_D_Personales1;
        Id_EmpleadoF = this.Id_EmpleadoF1;
        Calle = this.Calle1;
        Numero_Int = this.Numero_Ext1;
        Numero_Ext = this.Numero_Ext1;
        Colonia = this.Colonia1;
        Ciudad = this.Ciudad1;
        Pais = this.Pais1;
        telefono_P = this.Telefono_P;
        telefono_R = this.Telefono_R;

    }


        public int Id_D_Personales1 { get => Id_D_Personales; set => Id_D_Personales = value; }
        public int Id_EmpleadoF1 { get => Id_EmpleadoF; set => Id_EmpleadoF = value; }
        public String Calle1 { get => Calle; set => Calle = value; }
        public int Numero_Int1 { get => Numero_Int; set => Numero_Int = value; }
        public int Numero_Ext1 { get => Numero_Ext; set => Numero_Ext = value; }
        public String Colonia1 { get => Colonia; set => Colonia = value; }
        public String Ciudad1 { get => Ciudad; set => Ciudad = value; }
        public String Pais1 { get => Pais; set => Pais = value; }
        public String Telefono_P { get => telefono_P; set => telefono_P = value; }
        public String Telefono_R { get => telefono_R; set => telefono_R = value; }
    }

}
