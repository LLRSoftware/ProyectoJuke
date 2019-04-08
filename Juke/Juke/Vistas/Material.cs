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
        conexiondb conexion = new conexiondb();

        String Nombre;
        int Cantidad;
        decimal Precio;
        String Marca;
        String unidadMedida;

        public Material()
        {
            
            InitializeComponent();
        }

        public void ObtenerDatos(String nombre, int cantidad, decimal precio, String marca, String unidadmedida)
        {
            if (txtNombreMat.Text != null && txtCantidad.Text != null && txtPrecio.Text != null && txtMarca.Text != null && txtUnidad_Medida.Text != null)
            {
                nombre = txtNombreMat.Text;
                cantidad = Convert.ToInt32(txtCantidad.Text);
                precio = Convert.ToDecimal(txtPrecio.Text);
                marca = txtMarca.Text;
                unidadmedida = txtUnidad_Medida.Text;
            }
            else
            {
                MessageBox.Show("Favor de llenar los datos");
            }

        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            ObtenerDatos(Nombre, Cantidad, Precio, Marca, unidadMedida);
            //Establecer la conexión al servidor dentro del entorno
            conexiondb connection = new conexiondb();

            try
            {
                //Conexión abierta para su manejo
                connection.abrir();

                SqlCommand command = new SqlCommand("INSERT INTO Usuarios (Nombre, Marca, Cantidad, Uni_Medida,) VALUES+" +
                    " (@Nombre,@Marca,@Cantidad,@Uni_Medida)", connection.conectar);
                //Parametros para la busqueda dentro de la base de datos
                command.Parameters.AddWithValue("Nombre",Nombre);
                command.Parameters.AddWithValue("Marca", Marca);
                command.Parameters.AddWithValue("Cantidad",Cantidad);
                command.Parameters.AddWithValue("Uni_Medida",unidadMedida);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        public void llenaProveedor(ComboBox bc)
        {
            conexion.abrir();
            try
            {
                String Sql = "Select Nombre, Id_Proveedor from Proveedor";
                SqlCommand leer = new SqlCommand(Sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    bc.Items.Add(conn["Nombre_Contac"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar con la bd " + ex);
            }
            conexion.cerrar();
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
