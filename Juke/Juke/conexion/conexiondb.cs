using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/*Conexion a Base de datos*/
namespace empleados.conexion
{
    class conexiondb
    {
        string cadena = "Data Source=DESKTOP-G28IBSO;Initial Catalog=JukeDB;Integrated Security=True";
        public SqlConnection conectar = new SqlConnection();

        public conexiondb()
        {
            conectar.ConnectionString = cadena;
        }

        public void abrir()
        {
            try {
                conectar.Open();
                Console.WriteLine("Conexion Establecida");
            } catch (Exception ex) {
                Console.WriteLine("Error al establecer conexion con la DB " + ex.Message);
            }
        }

        public void cerrar() {
            conectar.Close();
        }
        
    }
}
