// Vista de Datos Personales 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asignacion;
using WindowsFormsApp1;
using Datos_personales.Model; // Importar la clase Datos_Personales para mandar llamar los campos 
using empleados.Controller;
using emple.Model;

namespace WindowsFormsApp1 
{
    public partial class datosPersonal : Form
    {

        Emp_Asg_Fij asig; // Variable para llamar la vista Asignación
        Datos_Personales objeto = new Datos_Personales();
        dtPersonales procesos = new dtPersonales();
        

        Emple otros = new Emple();

       
        public datosPersonal(int id_empleado) // Inicializar la vista Datos Personal.
        {
            InitializeComponent();
            this.idEmpleado = id_empleado;

        }

        int idEmpleado;
 
        private void btn_DP_sig_Click(object sender, EventArgs e) // Boton siguiente para guardar los datos de las cajas de texto
        {

            insertaDatos();
            Limpiar();
        }



        public void insertaDatos() {
            String mensaje="";
            String accion = "";
            String msm = "";

            objeto.Calle1 = Emp_DP_Calle.Text;
            objeto.Ciudad1 = Emp_DP_Ciu.Text;
            objeto.Colonia1 = Emp_DP_Col.Text;
            objeto.Numero_Int1 = int.Parse(Emp_DP_NumInt.Text);
            objeto.Numero_Ext1 = int.Parse(Emp_DP_NumExt.Text);
            //objeto.Pais1 = Emp_DP_Pais.Text;
            objeto.Telefono_P = Emp_DP_TelP.Text;
            objeto.Telefono_R = Emp_DP_TelR.Text;

            mensaje = procesos.inserta(idEmpleado,objeto.Calle1,objeto.Numero_Int1,objeto.Numero_Ext1,objeto.Colonia1,objeto.Ciudad1,objeto.Pais1,objeto.Telefono_R,objeto.Telefono_P);
            accion = mensaje.Substring(0, 1);
            msm = mensaje.Substring(1, mensaje.Length - 1);
            if (accion.Equals("1"))
            {
                MessageBox.Show(msm);
                asig = new Emp_Asg_Fij(idEmpleado); // Complemento para mandar llamar la vista asignación
                asig.Show();  // manda llamar la ventana Asignación
                this.Hide(); // Cierra la vista Datos Personal.
            }
        }
        

        private void btnRegresarDP_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Hide();
        }

        private void btnCancelarDP_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {

        }
    }
}
