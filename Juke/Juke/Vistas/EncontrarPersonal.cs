using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpleadosBajaUsuario;

namespace Búsqueda_de_personal
{
    public partial class EncontrarPersonal : Form
    {

        bajaEmpleado bjaemp;
        public EncontrarPersonal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn_EP_Bus_Click(object sender, EventArgs e)
        {
            bjaemp = new bajaEmpleado();
            bjaemp.Show();
            this.Hide();
        }
    }
}
