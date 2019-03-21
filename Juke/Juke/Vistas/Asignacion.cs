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
using Búsqueda_de_personal;
using WindowsFormsApp1;
using empleados.Controller;

namespace Asignación
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

            
        }

        public void guardar() {

            String mensaje = "";
            String accion = "";
            String msm = "";
            String nomina = "";
            String Estado = ""; 

            objeto.Id_DepartamentoF1 = int.Parse(Emp_Asi_Depto.Text);
            objeto.Escolaridad1 = Emp_Asg_Esc.Text;
            objeto.Ubicacion1 = Emp_Asg_Ubi.Text;
            objeto.Categoria1 = Emp_Asg_Cat.Text;
            objeto.Puesto1 = Emp_Asg_Pues.Text;
            objeto.Tipo_Nomina1 = int.Parse(Emp_Asg_Nomi.Text); //buscar como se guarda un valor con combox
            objeto.Estado1 = int.Parse(Emp_Asg_Edo.Text);
            objeto.Vacante1 = Emp_Asg_Edo.Text;
            objeto.Supervisor1 = Emp_Asg_Pues.Text;
            objeto.Plaza1 = Emp_Asi_Plaza.Text;

            Estado += objeto.Estado1;
            nomina += objeto.Tipo_Nomina1;

            mensaje = guarda.inserta(objeto.Escolaridad1,objeto.Ubicacion1,objeto.Categoria1,objeto.Plaza1,objeto.Vacante1,objeto.Supervisor1,Estado,nomina,objeto.Puesto1,objeto.Id_DepartamentoF1,idEmpleado) ;
            accion = mensaje.Substring(0, 1);
            msm = mensaje.Substring(1, mensaje.Length - 1);

            this.Hide(); // Cerrar vista
            // Checar con Leo y Lili los campos de la base de datos a insertar, puesto que asigne más de los propuestos anteriomente.
        }

        private void Emp_Asg_Fij_Load(object sender, EventArgs e)
        {
            guarda.llenaritem(Emp_Asi_Depto);
            guarda.llenaEstudio(Emp_Asg_Esc);
        }
    }
}

