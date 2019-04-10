using Juke.nueva;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juke.Vistas
{
    public partial class Agregar_Material : Form
    {
        conexiondb conexion = new conexiondb();

        String Nombre;
        String unidadMedida;
        int Existencias;
        String Marca;
        decimal Precio;
        int Proveedor;


        public Agregar_Material()
        {
            InitializeComponent();
            llenaProveedor(ListaProveedores);
        }

        private void Agregar_Material_Load(object sender, EventArgs e)
        {

        }

        

        public void llenaProveedor(ComboBox bc)
        {
            try
            {
                conexion.abrir();
                String Sql = "SELECT Nombre_Contac, Id_Proveedor from Proveedor";
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

        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            Nombre = txtNombreMat.Text;
            unidadMedida = txtUnidad_Medida.Text;
            Existencias = Convert.ToInt32(txtExistencias.Text);
            Marca = txtMarca.Text;
            Precio = Convert.ToDecimal(txtPrecio.Text);
            Proveedor = Convert.ToInt32(ListaProveedores.ValueMember+1);

            try
            {
                
                conexion.abrir();
                String Consulta = "INSERT INTO Material (Nombre, Marca, Precio, Existencias, Uni_Medida, Id_Proveedor) " +
                    "VALUES('"+Nombre+"', '"+Marca+"', "+Precio+", "+Existencias+", '"+unidadMedida+"', "+Proveedor+"); ";
                SqlCommand command = new SqlCommand(Consulta, conexion.conectar);
                SqlDataReader reader = command.ExecuteReader();
                conexion.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Limpiar();

        }

        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegresarM_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Hide();
        }

        private void Limpiar()
        {
            txtNombreMat.Text = "";
            txtUnidad_Medida.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";

        }
    }
}

/*conexiondb conexion = new conexiondb();

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

        public void llenaTarea(ComboBox bc)
        {
            conexion.abrir();
            try
            {
                String Sql = "Select Nombre, Id_Tarea from Tarea";
                SqlCommand leer = new SqlCommand(Sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    bc.Items.Add(conn["Nombre"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la bd " + ex);
            }
            conexion.cerrar();
        }
*/
