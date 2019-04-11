using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using empleados.Model;
using empleados.Controller;

namespace login
{
    public partial class Form1 : Form
    {

        logi datos = new logi();           // Mandar llamar clases 
        log proce = new log();             // Mandar llamar clases 
        menu.menu nue = new menu.menu();   // Mandar llamar nueva ventana 
        public Form1() 
        {
            InitializeComponent(); // Ejecuta el login para ingresar credenciales 
        }

        private void Aceptar_Click(object sender, EventArgs e) // Proceso al realizar la acción de aceptar.
        {
            this.login();
        }

        private void Cerrar_Click(object sender, EventArgs e) // Boton para cerrar ventana 
        {
            this.Close(); //Accion para cerrar ventana 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void login()
        {
            datos.Usuario = txtUsuario.Text; // Se guarda la información en la caja de texto en las variables ...
            datos.Password = txtPassword.Text; // Usuario y Password 

            String status = proce.login(datos.Usuario, datos.Password); // Inicializa las variable estatus ingresando el parametro del proceso Log, que se encuentra en la clase Log en la carpeta Controller 

            if (status.Equals("Activo"))
            { // Se realiza la validación del estatus del usuario 
                nue.Show();                 // En caso de ser correcto se abre una nueva ventana es la de menú.
                this.Hide();                // Se cierra Login
            }
            else
            {
                MessageBox.Show("El usuario o contraseña son erroneos, favor de ingresar nuevamente");
                //Mensaje de texto por ingresasr los datos de manera erronea
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
