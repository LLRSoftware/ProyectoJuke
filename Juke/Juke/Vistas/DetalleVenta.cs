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
    public partial class DetalleVenta : Form
    {
        conexiondb conexion = new conexiondb();

        int Cantidad;
        int Tarea;
        String Descripcion = "";

        public DetalleVenta()
        {
            InitializeComponent();
            LlenarTarea(ListaTarea);
        }

        private void btnTerminarV_Click(object sender, EventArgs e)
        {

            if (txtCantidadDV.Text != null || txtDescripcion.Text != null)
            {
                try
                {
                    Tarea = Convert.ToInt32(ListaTarea.ValueMember + 1);
                    Cantidad = Convert.ToInt32(txtCantidadDV.Text);
                    Descripcion = txtDescripcion.Text;

                    conexion.abrir();
                    String Consulta = "INSERT INTO Det_Venta (Cantidad, Descripcion, Id_Tarea, Id_Venta) " +
                        "VALUES("+Cantidad+", '"+Descripcion+"', "+Tarea+ ", (SELECT MAX(Id_Venta) FROM Venta))";
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

        private void btnAgregarV_Click(object sender, EventArgs e)
        {
            try
            {
                Tarea = Convert.ToInt32(ListaTarea.ValueMember + 1);
                Cantidad = Convert.ToInt32(txtCantidadDV.Text);
                Descripcion = txtDescripcion.Text;

                conexion.abrir();
                String Consulta = "INSERT INTO Det_Venta (Cantidad, Descripcion, Id_Tarea, Id_Venta) " +
                    "VALUES(" + Cantidad + ", '" + Descripcion + "', " + Tarea + ", (SELECT MAX(Id_Venta) FROM Venta))";
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

        private void btnCancelarV_Click(object sender, EventArgs e)
        {
            BorrarVenta();
            Limpiar();
            this.Hide();
        }

        public void LlenarTarea(ComboBox bc)
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

        private void Limpiar()
        {
            txtCantidadDV.Text = "";
            txtDescripcion.Text = "";
        }


        private void BorrarVenta()
        {
            conexion.abrir();
            String ConsultaCompra = "DELETE FROM Venta WHERE Id_Venta = (SELECT MAX(Id_Vent) FROM Venta);";
            SqlCommand commandC = new SqlCommand(ConsultaCompra, conexion.conectar);
            SqlDataReader readerC = commandC.ExecuteReader();
            conexion.cerrar();
            conexion.abrir();
            String ConsultaDC = "DELETE FROM Det_Venta WHERE Id_Venta = (SELECT MAX(Id_Venta) FROM Venta);";
            SqlCommand commandDC = new SqlCommand(ConsultaDC, conexion.conectar);
            SqlDataReader readerDC = commandDC.ExecuteReader();
            conexion.cerrar();

        }
    }
}
