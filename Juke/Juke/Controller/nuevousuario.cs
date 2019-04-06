using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Juke.nueva;

namespace empleados.Controller
{
    class nuevousuario
    {
        conexiondb conexion = new conexiondb();


        public void llenarempleado(ComboBox cb)
        {
            conexion.abrir();

            try
            {
                String sql = "Select Nombre,Apellido_P,Apellido_M from empleado";
                SqlCommand leer = new SqlCommand(sql,conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    cb.Items.Add(conn.GetSqlString(0).ToString()+" "+conn.GetSqlString(1).ToString()+" "+ conn.GetSqlString(2).ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos " + ex);
            }
            conexion.cerrar();
           

        }


        public void llenarperfil(ComboBox cb)
        {
            conexion.abrir();

            try
            {
                String sql = "Select Nombre from Perfil";
                SqlCommand leer = new SqlCommand(sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    cb.Items.Add(conn["Nombre"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos " + ex);
            }
            conexion.cerrar();


        }

        public int idEmp(String Nombre,String Paterno)
        {
            conexion.abrir();
            int idEmp = 0;
            try
            {
                String sql = "Select Id_empleado from empleado where Nombre='" + Nombre + "' and Apellido_P = '" + Paterno + "'";
                SqlCommand leer = new SqlCommand(sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    idEmp = conn.GetInt16(0);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al conectar con la bd" + ex);
            }
            conexion.cerrar();
            return idEmp;

        }

        public int idPer(String Nombre)
        {
            int idper = 0;
            conexion.abrir();
            try
            {
                String sql = "Select Id_Perfil from Perfil where Nombre='" + Nombre + "'";
                SqlCommand leer = new SqlCommand(sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    idper = conn.GetInt16(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la bd" + ex);
            }
            conexion.cerrar();
            return idper;

        }

        public String guardar(String Nombre,String Contraseña,int idemp,int idper)
        {
            String mensaje = "";
            conexion.abrir();
            try
            {
                String sql = "insert into Usuario (Nombre,Estatus,Contraseña,Id_empleado,Id_Perfil)" +
                    "values('"+Nombre+"','Activo','"+Contraseña+"',"+idemp+","+idper+")";

                SqlCommand nueva = new SqlCommand(sql, conexion.conectar);
                nueva.ExecuteNonQuery();
                mensaje = "1 Los datos se guardaron correctamente";
            }catch(Exception ex)
            {
                mensaje = "2 Error al conectar con la bd " + ex;
            }
            conexion.cerrar();
            return mensaje;

        }



    }
}
