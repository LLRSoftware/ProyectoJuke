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
    public partial class Agregar_Tarea : Form
    {
        public Agregar_Tarea()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Now;
            lbLote.Text = fecha.ToString("yyyyMMdd-"+txtNombre.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Tarea_Load(object sender, EventArgs e)
        {

        }
    }
}
