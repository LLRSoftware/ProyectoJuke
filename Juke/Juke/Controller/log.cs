using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using empleados.conexion;
using empleados.Model;


namespace empleados.Controller
{
    class log
    {/*Login*/
        conexiondb nueva = new conexiondb();
        logi datos = new logi();

        public String login(String usuario, String password)
        {
            String estatus = "";

            try
            {
                nueva.abrir();
                String query = "select * from usuario where Nombre='" + usuario +"' and Contraseña='"+password+"';";
                /*Validación*/          
            
                SqlCommand lector = new SqlCommand(query, nueva.conectar);
                SqlDataReader conecc = lector.ExecuteReader();
                while (conecc.Read()) {
                    datos.User = conecc.GetValue(1).ToString();
                    datos.Pass = conecc.GetValue(3).ToString();
                    estatus = conecc.GetValue(2).ToString();
                    datos.Empleado = int.Parse(conecc.GetValue(4).ToString());
                    datos.Perfil = int.Parse(conecc.GetValue(5).ToString());
                }

                
            } catch(Exception ex) {
                Console.WriteLine("Error al conectar con la base de datos " + ex.Message);
            }
            nueva.cerrar();
            return estatus;
        }
    }
}
