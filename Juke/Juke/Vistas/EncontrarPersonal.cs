using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using empleados.Controller;

namespace Juke.EncontrarPersonal
{
    public partial class EncontrarPersonal : Form
    {

        buscar emple = new buscar();
        empleados.ModDatosEmpleado mod = new empleados.ModDatosEmpleado();
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
            String parametro = Emp_EP_Dato.Text;
            String dato = Emp_EP_Cve.Text;


            emple.traerdts(dato,parametro,table_dts_emp);
        }

        private void EncontrarPersonal_Load(object sender, EventArgs e)
        {
            emple.parametro(Emp_EP_Dato);
        }



        private void table_dts_emp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mod.Idd.Text = table_dts_emp.CurrentRow.Selected.ToString();
        }

        private void btn_EP_Nvo_Click(object sender, EventArgs e)
        {

        }
    }
}
