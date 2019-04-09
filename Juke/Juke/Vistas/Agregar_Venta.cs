using Juke.nueva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Juke.Vistas
{
    public partial class Agregar_Venta : Form
    {
        conexiondb conexion = new conexiondb();

        public Agregar_Venta()
        {
            InitializeComponent();
        }

        private void Agregar_Venta_Load(object sender, EventArgs e)
        {

        }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void llenaCliente(ComboBox bc)
        {
            conexion.abrir();
            try
            {
                String Sql = "Select Nombre, Id_Cliente from Cliente";
                SqlCommand leer = new SqlCommand(Sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    bc.Items.Add(conn["Nombre"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la bd " + ex);
            }
            conexion.cerrar();
        }


    }
}
