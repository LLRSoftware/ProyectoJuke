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
using Juke.nueva;

namespace Juke.Vistas
{
    public partial class Inventarios : Form
    {

        conexiondb conexiondb = new conexiondb();

        public Inventarios()
        {
            InitializeComponent();

            LlenarView(dgvInventario);
        }

        public void LlenarView(DataGridView dgv)
        {
            try
            {
                
                //Establecer la conexión al servidor dentro del entorno
                SqlCommand connection = new SqlCommand();

                //Conexión abierta para su manejo
                conexiondb.abrir();

                //Comando SQL para solicitar información a la base de datos
                SqlCommand command = new SqlCommand("SELECT * FROM Material", conexiondb.conectar);

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


        private void Inventarios_Load(object sender, EventArgs e)
        {

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
