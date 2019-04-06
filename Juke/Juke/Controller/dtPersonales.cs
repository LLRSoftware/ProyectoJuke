using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juke.nueva;
using System.Data.SqlClient;
using emple.Model;

namespace empleados.Controller
{
    class dtPersonales
    {
        Emple datos = new Emple();
        conexiondb nueva = new conexiondb();


        public String inserta(int idEmp,String calle, int numeroInt, int numeroExt,String colonia,String Ciudad,String Pais,String telR,String telP)
        {
            String mensaje = "";
            nueva.abrir(); /*Abrir BD*/

            /*Genera consulta*/
            String sql = "insert into Datos_Personal(Id_Empleado,Calle,Numero_Int,Numero_Ext,Colonia,Ciudad,Pais,Telefono_R,Telefono_P) " +
                   "values(" + idEmp + ", '" + calle + "', " + numeroInt + ", " + numeroExt + ", '" + colonia + "', '" + Ciudad + "', '" + Pais + "', '" + telR + "', '" + telP + "');";
            try
                {
                    SqlCommand insert = new SqlCommand(sql, nueva.conectar); /*Gardar consulta y conexión*/
                    insert.ExecuteNonQuery();                         /*Ejecuta consulta*/
                    mensaje = "1 Los datos han sido insetados correctamente";   /**Mensaje*/
                }
                catch (Exception ex)
                {
                    mensaje = "2 error al conectar con la base de datos" + ex;
                }
            
            nueva.cerrar(); /*Cierra BD */
            return mensaje; /*Regresa mensaje*/
        }



    }
}
