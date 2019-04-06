using Juke.EncontrarPersonal;
using Juke.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juke.Model;



namespace menu
{
    public partial class menu : Form
    {
        empleados.empleados nueva = new empleados.empleados();
        empleados.nuevouser nuevo = new empleados.nuevouser();
        empleados.modusuario cambio = new empleados.modusuario();
        EncontrarPersonal otra = new EncontrarPersonal();
        Venta venta = new Venta();
        Ajustar_Inventario ajustar_Inventario = new Ajustar_Inventario();
        Asignacion.Emp_Asg_Fij asignacion = new Asignacion.Emp_Asg_Fij(1);


        public menu()
        {
            InitializeComponent();
        }

        private void modificaciónUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambio.Show();
        }

        private void altaDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nueva.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo.Show();
        }

        private void modificaciónDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otra.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void realizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void realizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
