﻿using System;
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
        empleados.nuevouser nuevo = new empleados.nuevouser();
        empleados.modusuario cambio = new empleados.modusuario();
        Búsqueda_de_personal.EncontrarPersonal otra = new Búsqueda_de_personal.EncontrarPersonal();
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

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
