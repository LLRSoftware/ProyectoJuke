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



namespace empleados
{
    public partial class modusuario : Form
    {

        ModificarUser nuevo = new ModificarUser();
        public modusuario()
        {
            InitializeComponent();
        }

        private void modusuario_Load(object sender, EventArgs e)
        {
            nuevo.llenarPerfil(Per_mod);
            nuevo.llenarUsuario(Usu_mod);
            nuevo.estatus(Est_mod_usu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pass();
        }

        private void pass() {

            String Usuario = Usu_mod.Text;
            String NewPass = Pass_mod.Text;
            String Conf = Conf_mod.Text;
            String estatus = Est_mod_usu.Text;
            String perfil = Per_mod.Text;
            String PassAnt = "";
            Boolean val;
            String mensaje = "";
            int accion;
            String sms = "";

            PassAnt = nuevo.PassAnt(Usuario);

            val = nuevo.validar(NewPass);


            if (PassAnt.Equals(NewPass))
            {
                MessageBox.Show("El Password actual no puede ser igual que el Anterior");
            }
            else
            {
                if (NewPass.Length < 8)
                {
                    MessageBox.Show("El Password debe de tener 8 caracteres como minimo");
                }
                else
                {
                    if (val)
                    {
                        if (NewPass.Equals(Conf))
                        {
                            mensaje = nuevo.modificar(Usuario, NewPass, perfil, estatus);
                            accion = int.Parse(mensaje.Substring(0, 2));
                            sms = mensaje.Substring(1, mensaje.Length - 1);
                            if (accion == 1)
                            {
                                MessageBox.Show(sms);
                                this.Close();
                            }
                            else {
                                MessageBox.Show(sms);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El Password y su confirmacion tienen que ser iguales");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Password debe de tener por lo menos una mayuscula una minuscula y un numero");
                    }
                    
                }
            }
        }

       
    }

}
