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
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {

        }
    }
}
