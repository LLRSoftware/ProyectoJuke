using Juke.nueva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juke.Vistas
{
    public partial class Material : Form
    {
        private void btnGuardarM_Click(object sender, EventArgs e)
        {

        }


        //public void guardar()
        //{
        //    String[] nombre;
        //    int idemp;
        //    int idPer;
        //    String mensaje = "";
        //    String Accion = "";
        //    String sms = "";
        //    dts.Nombre1 = Nue_Usu.Text;
        //    nombre = dts.Nombre1.Split(' ');
        //    dts.NuevoUsuario1 = Nue_Usu_Usu.Text;
        //    dts.NuevoPassword1 = Nue_Usu_Pass.Text;
        //    dts.Confirmacion1 = Nue_Usu_Conf.Text;
        //    dts.Perfil = Nue_Usu_Per.Text;

        //    idemp = usuario.idEmp(nombre[0], nombre[1]);
        //    idPer = usuario.idPer(dts.Perfil);

        //    if (dts.NuevoPassword1.Equals(dts.Confirmacion1))
        //    {
        //        mensaje = usuario.guardar(dts.NuevoUsuario1, dts.NuevoPassword1, idemp, idPer);
        //        Accion = mensaje.Substring(0, 2);
        //        sms = mensaje.Substring(1, mensaje.Length - 1);

        //        if (Accion.Equals("1"))
        //        {
        //            MessageBox.Show(sms);
        //            this.Hide();
        //        }
        //        else
        //        {
        //            MessageBox.Show(sms);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("El Passwor y su confirmacion tienen que ser iguales");
        //    }


        //}
    }

}
