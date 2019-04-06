using Juke.nueva;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juke.Controller
{
    class ClienteController
    {
        conexiondb nueva = new conexiondb();

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
