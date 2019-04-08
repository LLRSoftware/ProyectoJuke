//Vista Asignacion 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using empleados.Controller;

namespace Asignacion
{
    public partial class Emp_Asg_Fij : Form
    {
        Juke.Asignacion objeto = new Juke.Asignacion(); // Se crea una variable para mandar llamar los campos
        asig guarda = new asig();

        public Emp_Asg_Fij(int idEmp) // Se inicaliza la vista Asignación
        {
            InitializeComponent();
            this.idEmpleado = idEmp;
        }

        int idEmpleado;
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_Asg_Guardar_Click(object sender, EventArgs e) // Botón para guardar los datos de los campos
        {
            guardar();
        }

        public void guardar() {

            String mensaje = "";
            String accion = "";
            String msm = "";
            //String nomina = "";
            String Estado = "";
            String depa = "";

            depa = Emp_Asi_Depto.Text;
            objeto.Escolaridad1 = Emp_Asg_Esc.Text;
            objeto.Ubicacion1 = Emp_Asg_Ubi.Text;
            objeto.Categoria1 = Emp_Asg_Cat.Text;
            objeto.Puesto1 = Emp_Asg_Pues.Text;
            objeto.Tipo_Nomina1 = Emp_Asg_Nomi.Text;
            Estado = Cbo_Asi_Emp.Text;
            objeto.Vacante1 = Emp_Asg_Vac.Text;
            objeto.Supervisor1 = Emp_Asg_Pues.Text;
            objeto.Plaza1 = Emp_Asi_Plaza.Text;

            objeto.Id_DepartamentoF1 = guarda.departamento(depa);

            objeto.Estado1 = guarda.idEdo(Estado);
            mensaje = guarda.inserta(objeto.Escolaridad1,objeto.Ubicacion1,objeto.Categoria1,objeto.Plaza1,objeto.Vacante1,objeto.Supervisor1,objeto.Estado1,objeto.Tipo_Nomina1,objeto.Puesto1,objeto.Id_DepartamentoF1,idEmpleado) ;
            accion = mensaje.Substring(0, 1);
            msm = mensaje.Substring(1, mensaje.Length - 1);

            MessageBox.Show(msm);
            this.Hide(); // Cerrar vista
            // Checar con Leo y Lili los campos de la base de datos a insertar, puesto que asigne más de los propuestos anteriomente.
        }

        private void Emp_Asg_Fij_Load(object sender, EventArgs e)
        {
            guarda.llenaritem(Emp_Asi_Depto);
            guarda.llenaEstudio(Emp_Asg_Esc);
            guarda.llenaNomina(Emp_Asg_Nomi);
            guarda.llenaPlaza(Emp_Asi_Plaza);
            guarda.llenaorganiza(Emp_Asi_Org);
            guarda.llenaEdo(Cbo_Asi_Emp);
        }
    }
}

