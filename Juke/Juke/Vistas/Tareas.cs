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
    public partial class Tareas : Form
    {
        String script = "SELECT * FROM Tarea";
        conexiondb conexion = new conexiondb();
        Grids grids;
        Agregar_Tarea agregar_tarea = new Agregar_Tarea();
        Modificar_Tarea modificar_tarea = new Modificar_Tarea();

        public Tareas()
        {
            InitializeComponent();
            grids = new Grids(dgvTareas,conexion,script);
        }

       
        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregar_tarea.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }
    }
}
