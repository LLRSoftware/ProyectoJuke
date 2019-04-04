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


namespace empleados
{
    public partial class nuevouser : Form
    {

        nuevousuario usuario = new nuevousuario();
        nuevousu dts = new nuevousu();

        public nuevouser()
        {
            InitializeComponent();
        }

        private void nuevouser_Load(object sender, EventArgs e)
        {
            usuario.llenarempleado(Nue_Usu);
            usuario.llenarperfil(Nue_Usu_Per);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void guardar()
        {
            String[] nombre;
            int idemp;
            int idPer;
            String mensaje = "";
            String Accion = "";
            String sms = "";
            dts.Nombre1 = Nue_Usu.Text;
            nombre = dts.Nombre1.Split(' ');
            dts.NuevoUsuario1 = Nue_Usu_Usu.Text;
            dts.NuevoPassword1 = Nue_Usu_Pass.Text;
            dts.Confirmacion1 = Nue_Usu_Conf.Text;
            dts.Perfil = Nue_Usu_Per.Text;

            idemp = usuario.idEmp(nombre[0], nombre[1]);
            idPer = usuario.idPer(dts.Perfil);

            if (dts.NuevoPassword1.Equals(dts.Confirmacion1))
            {
                mensaje = usuario.guardar(dts.NuevoUsuario1, dts.NuevoPassword1, idemp, idPer);
                Accion = mensaje.Substring(0, 2);
                sms = mensaje.Substring(1, mensaje.Length-1);

                if (Accion.Equals("1"))
                {
                    MessageBox.Show(sms);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(sms);
                }
            }
            else
            {
                MessageBox.Show("El Passwor y su confirmacion tienen que ser iguales");
            }
            

        }
    }
}
