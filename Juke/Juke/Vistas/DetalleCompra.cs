using Juke.nueva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Juke.Vistas
{
    public partial class DetalleCompra : Form
    {
        conexiondb conexion = new conexiondb();

        int Cantidad;
        int Material;


        public DetalleCompra()
        {
            InitializeComponent();
            llenarMaterial(ListaMaterial);
        }


        public void llenarMaterial(ComboBox bc)
        {
            conexion.abrir();
            try
            {
                String Sql = "Select Nombre, Id_Material from Material";
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


        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {

            try
            {
                Material = Convert.ToInt32(ListaMaterial.ValueMember+1);
                Cantidad = Convert.ToInt32(txtCantidad.Text);

                conexion.abrir();
                String Consulta = "INSERT INTO Det_Compra (Id_Compra, Id_Material,Cantidad) " +
                    "VALUES((SELECT MAX(Id_Compra) FROM Compra), " + Material + ", " + Cantidad + ")";
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

        private void btnTerminarCompra_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != null)
            {
                try
                {
                    Material = Convert.ToInt32(ListaMaterial.ValueMember + 1);
                    Cantidad = Convert.ToInt32(txtCantidad.Text);

                    conexion.abrir();
                    String Consulta = "INSERT INTO Det_Compra (Id_Compra, Id_Material,Cantidad) " +
                        "VALUES((SELECT MAX(Id_Compra) FROM Compra), " + Material + ", " + Cantidad + ")";
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

            this.Hide();
        }

        private void BorrarCompra()
        {
            conexion.abrir();
            String ConsultaCompra = "DELETE FROM Compra WHERE Id_Compra = (SELECT MAX(Id_Compra) FROM Compra);";
            SqlCommand commandC = new SqlCommand(ConsultaCompra, conexion.conectar);
            SqlDataReader readerC = commandC.ExecuteReader();
            conexion.cerrar();
            conexion.abrir();
            String ConsultaDC = "DELETE FROM Det_Compra WHERE Id_Compra = (SELECT MAX(Id_Compra) FROM Compra);";
            SqlCommand commandDC = new SqlCommand(ConsultaDC, conexion.conectar);
            SqlDataReader readerDC = commandDC.ExecuteReader();
            conexion.cerrar();

        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            BorrarCompra();
            Limpiar();
            this.Hide();
        }

        private void Limpiar()
        {
            txtCantidad.Text = "";
        }
    }
}
