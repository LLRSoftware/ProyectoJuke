using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class menu : Form
    {
        empleados.empleados nueva = new empleados.empleados();
        public menu()
        {
            InitializeComponent();
        }

        private void modificaciónUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nueva.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
