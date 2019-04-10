using Juke.Controller;
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

namespace Juke.Vistas
{
    public partial class Compra : Form
    {
        String script = "SELECT * FROM Compra";
        conexiondb conexiondb = new conexiondb();
        Grids grids;

        public Compra()
        {
            InitializeComponent();

            grids = new Grids(dgvCompra, conexiondb, script);
        }

        private void btnRegresarC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
