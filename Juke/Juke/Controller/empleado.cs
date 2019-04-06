using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juke.conexion;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace empleados.Controller

{
    class empleado
    {
        conexiondb nueva = new conexiondb(); /*Conexion a BD*/

        /*Función el Insert*/
        public String inserta(String nombre, String apellidoP, String apellidoM, String rfc, int afiliacion, String curp, int departamento)
        {
            String mensaje = ""; /*Variable local*/
            nueva.abrir();       /*Abre BD*/
            String emple = "";   /*Variable local*/
            DateTime fecha = DateTime.Now;           /*Función interna par generar la fecha actual*/
            String fecha_actual = fecha.ToString("yyyy-MM-dd"); /*Se obtienen datos de la fecha */
           
            /*Se genera consulta*/
            try {
                String validacion = "select * from empleado where curp='"+curp+"'";
            
            SqlCommand lector = new SqlCommand(validacion, nueva.conectar); /*Leer y ejecutar consulta*/
            SqlDataReader conn = lector.ExecuteReader();                    

            while (conn.Read()) {
                emple = conn.GetString(1).ToString(); /*Se guarda en variable local EMPLE*/
            }
                conn.Close(); /*Se cierra conexion*/
            }catch(Exception ex) 
            {
                mensaje = "Error al conectar con la BD" + ex; /*Mensaje*/
            }
             
            if (emple.Equals(null) || emple.Equals("")) /*Validaxión de la existencia del empleado*/
            {
                try
                {

                    String sql = "insert into empleado(Nombre,Apellido_P,Apellido_M,RFC,No_AFILIACION,Fecha_Inicio,Fecha_Final,CURP,Id_Departamento) " +
                    "values('"+nombre+"','"+apellidoP+"', '"+apellidoM+"', '"+rfc+"', "+afiliacion+", '"+fecha_actual+"', '"+fecha_actual+"','"+curp+"',"+departamento+" ); ";

                    SqlCommand insert = new SqlCommand(sql, nueva.conectar);
                    insert.ExecuteNonQuery();
                    mensaje = "1 Los datos han sido insetados correctamente";
                }
                catch (Exception ex)
                {


                    mensaje = "2 error al conectar con la base de datos" + ex;
                }
            }
            else {
                mensaje = "3 Este Empleado ya se encuetra registrado";
            }
            nueva.cerrar();
            return mensaje;
        }

        public int idEmpleado(String curp)
        {

            nueva.abrir();
            int id = 0;
            String sql = "Select Id_empleado from empleado where CURP='"+ curp +"';";
            try {
                SqlCommand leer = new SqlCommand(sql, nueva.conectar);
                SqlDataReader con = leer.ExecuteReader();
                while (con.Read())
                {
                    id = con.GetInt16(0);
                }

            }catch(Exception ex)
            {
                Console.WriteLine("error al conectar con la base de datos: " + ex);
            }
            nueva.cerrar();
            return id;
        }

        public void llenaSexo(ComboBox cb) {
            cb.Items.Add("Femenino");
            cb.Items.Add("Masculino");
            cb.Items.Add("Indistinto");
            cb.SelectedIndex = 0;
        }
        public void llenaEdoCivil(ComboBox cb)
        {
            cb.Items.Add("Soltero");
            cb.Items.Add("Casado");
            cb.Items.Add("Divorciado");
            cb.Items.Add("Viudo");
            cb.SelectedIndex = 0;
        }
    }
}
