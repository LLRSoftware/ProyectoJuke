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
        String script = "SELECT g.Fecha, c.Folio, c.Importe FROM Gastos AS g INNER JOIN Compra AS c ON g.Id_Gasto = c.Id_Gasto";
        conexiondb conexiondb = new conexiondb();
        Grids grids;
        Nomina nomina = new Nomina();
        Agregar_Compra agregar_compra = new Agregar_Compra();

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
            this.Hide();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            agregar_compra.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
