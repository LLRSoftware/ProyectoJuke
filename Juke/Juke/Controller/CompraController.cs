using Juke.nueva;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juke.Controller
{
    class CompraController
    {
        conexiondb nueva = new conexiondb();

        public String inserta(String escolaridad, String Ubicacion, String Categoria, String Plaza, String vacante, String Supervisor, int Estado, String Nomina, String Puesto, int departamento, int Empleado)
        {
            nueva.abrir(); /*Se abre la conexion a la BD*/
            String mensaje = "";
            try
            { /*Insert*/
                String sql = "insert into Asignacion(Escolaridad, Ubicacion, Categoria, Plaza, Vacante, Supervisor, Estado, Tipo_nomina, Puesto, Id_Departamento, Id_Empleado) " +
                     "values('" + escolaridad + "','" + Ubicacion + "','" + Categoria + "','" + Plaza + "','" + vacante + "','" + Supervisor + "','" + Estado + "','" + Nomina + "','" + Puesto + "'," + departamento + "," + Empleado + ");";
                /*Ejecucuón del Insert*/
                SqlCommand ejecuta = new SqlCommand(sql, nueva.conectar);
                ejecuta.ExecuteNonQuery();
                mensaje = "1 Los datos han sido guardados exitosamente";
            }
            catch (Exception ex)
            {
                mensaje = "2 Error al conectar con la bd: " + ex;
            }
            nueva.cerrar(); /*Se cierra la conexion y regresa el mensaje*/
            return mensaje;
        }

        /*Función para la busqueda del Id_Estado*/
        public int idEdo(String Estado)
        {
            int IdEdo = 0;
            nueva.abrir(); /*Se abre la conexión*/
            try
            { /*Se ejecuta la consulta*/
                String sql = "select Id_Estado from Estado where Nombre ='" + Estado + "'";
                SqlCommand leer = new SqlCommand(sql, nueva.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    IdEdo = conn.GetInt16(0); /*Se guarda el valor del ID*/
                }
                nueva.cerrar(); /*Se cierra la conexión*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar con la bd " + ex);
            }
            return IdEdo;
        }

        /*Función para llemar el combo depto */
        public void llenaritem(ComboBox cb)
        {
            nueva.abrir();

            try
            {
                String sql = "select Nombre from Departamento"; /*Gerenera la consulta*/
                SqlCommand leer = new SqlCommand(sql, nueva.conectar); /*Ejecuta  la consulta*/
                SqlDataReader conn = leer.ExecuteReader(); /*Lee los datos*/
                while (conn.Read())
                {
                    cb.Items.Add(conn["Nombre"].ToString()); /* Par mostrar solo el nombre*/
                }
                cb.SelectedIndex = 0; /*Genera el primer valor del combo*/
                nueva.cerrar(); /*Se cierra la conexion a BD*/
            }
            catch (Exception ex)
            {

            }

        }
        /*Información dle combo*/
        public void llenaEstudio(ComboBox bc)
        {
            bc.Items.Add("Primaria");
            bc.Items.Add("Secundaria");
            bc.Items.Add("Preparatoria");
            bc.Items.Add("Universidad/Licenciatura");
            bc.Items.Add("Maestria");
            bc.Items.Add("Doctorado");
            bc.SelectedIndex = 0;
        }

        /*Información dle combo*/
        public void llenaNomina(ComboBox bc)
        {
            bc.Items.Add("Semanal");
            bc.Items.Add("Catorcenal");
            bc.Items.Add("Quincenal");
            bc.Items.Add("Mensual");
            bc.SelectedIndex = 0;
        }

        /*Información dle combo*/
        public void llenaPlaza(ComboBox bc)
        {
            bc.Items.Add("Temporal");
            bc.Items.Add("Fijo");
            bc.SelectedIndex = 0;
        }

        public void llenaEdo(ComboBox bc)
        {
            Juke.nueva.abrir();
            try
            {
                String Sql = "Select Nombre from Estado";
                SqlCommand leer = new SqlCommand(Sql, Juke.nueva.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    bc.Items.Add(conn["Nombre"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar con la bd " + ex);
            }
            Juke.nueva.cerrar();
        }


        public void llenaorganiza(ComboBox bc)
        {
            bc.Items.Add("Leon");
            bc.Items.Add("otro");
            bc.SelectedIndex = 0;
        }


        public int departamento(String nombre)
        {
            int iddep = 0;
            Juke.nueva.abrir();

            try
            {
                String sql = "Select Id_Departamento from Departamento where Nombre='" + nombre + "'";
                SqlCommand leer = new SqlCommand(sql, Juke.nueva.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    iddep = conn.GetInt16(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos" + ex);
            }
            Juke.nueva.cerrar();
            return iddep;
        }

        public void parametro(ComboBox cb)
        {
            cb.Items.Add("CURP");
            cb.Items.Add("RFC");
            cb.Items.Add("Nombre");
            cb.SelectedIndex = 0;
        }

        public void traerdts(String dato, String parametro, DataGridView table)
        {
            nueva.abrir();
            String cnd = "";

            if (parametro.Equals("RFC"))
            {
                cnd += " where Empleado.RFC lIKE '%" + dato + "%'";
            }
            else
            {
                if (parametro.Equals("CURP"))
                {
                    cnd += " where Empleado.CURP LIKE'%" + dato + "%'";
                }
                else
                {
                    if (parametro.Equals("Nombre"))
                    {
                        cnd += " where Empleado.Nombre LIKE '%" + dato + "%'";
                    }
                }
            }
            try
            {
                String sql = "select Empleado.Id_empleado as clave, Empleado.Nombre as Nombre, Empleado.Apellido_p as Paterno, Empleado.Apellido_M as Materno, Empleado.RFC as RFC,Empleado.CURP as CURP,  " +
                    "Datos_Personal.Calle as Calle, Datos_Personal.Numero_Int as Interior, Datos_Personal.Numero_Ext as Exterior, Datos_Personal.colonia as Colonia, Datos_Personal.telefono_R as Recados, " +
                    "Datos_Personal.Telefono_P as Personal from Empleado inner join Datos_Personal on Empleado.Id_Empleado = Datos_Personal.Id_Empleado" + cnd;

                SqlDataAdapter leer = new SqlDataAdapter(sql, nueva.conectar);
                DataTable dt = new DataTable();
                leer.Fill(dt);
                BindingSource form = new BindingSource();
                form.DataSource = dt;
                table.DataSource = form;
                leer.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la bd " + ex);
            }
            nueva.cerrar();
        }
    }
}
