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
    class Grids
    {
        public Grids(DataGridView dgv, conexiondb db, String script)
        {
            try
            {

                //Establecer la conexión al servidor dentro del entorno
                SqlCommand connection = new SqlCommand();

                //Conexión abierta para su manejo
                db.abrir();

                //Comando SQL para solicitar información a la base de datos
                SqlCommand command = new SqlCommand(script, db.conectar);

                //Adapter que toma los datos obtenidos para almacenarlos en un arreglo de tipo DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dgv.DataSource = data;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }
        }
    }
}
