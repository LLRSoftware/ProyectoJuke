using Juke.Controller;
using Juke.nueva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juke.Vistas
{
    public partial class Gastos : Form
    {
        String script = "SELECT Id_Gasto, Fecha, Id_Sucursal FROM Gastos ORDER BY Fecha DESC";
        conexiondb conexiondb = new conexiondb();
        Grids grids;
        Nomina nomina = new Nomina();
        Compra compra = new Compra();

        public Gastos()
        {
            InitializeComponent();
            grids = new Grids(dgvGastos,conexiondb,script);
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            nomina.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            compra.Show();
        }
    }
}
