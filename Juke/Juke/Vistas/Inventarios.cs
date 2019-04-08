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
using Juke.Controller;

namespace Juke.Vistas
{
    public partial class Inventarios : Form
    {
        String script = "SELECT Nombre, Marca, Cantidad FROM material";
        conexiondb conexiondb = new conexiondb();
        Grids grids;

        public Inventarios()
        {
            InitializeComponent();
            grids = new Grids(dgvInventario, conexiondb,script);
        }


        private void Inventarios_Load(object sender, EventArgs e)
        {

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
