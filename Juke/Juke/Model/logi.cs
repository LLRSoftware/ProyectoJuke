using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empleados.Model
{
    class logi
    {
        private String usuario;
        private String password;
        private String status;
        private int perfil;
        private int empleado;
        private String user;
        private String pass;

       

        public logi()
        {
            this.usuario = Usuario;
            this.password = Password;
            this.status = Status;
            this.perfil = Perfil;
            this.empleado = Empleado;
            this.user = User;
            this.pass = Pass;
        }

        public String Usuario { get => usuario; set => usuario = value; }
        public String Password { get => password; set => password = value; }
        public String Status { get => status; set => status = value; }
        public int Perfil { get => perfil; set => perfil = value; }
        public int Empleado { get => empleado; set => empleado = value; }
        public String User { get => user; set => user = value; }
        public String Pass { get => pass; set => pass = value; }
    }
}
