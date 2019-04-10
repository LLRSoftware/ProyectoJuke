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

namespace EmpleadosBajaUsuario
{
    public partial class bajaEmpleado : Form
    {

        conexiondb conexion = new conexiondb();

        DateTime Fecha;
        String FechaFin;
        String Nombre;

        public bajaEmpleado()
        {
            InitializeComponent();
            LlenarEmpleado(ListaEmpleado);
        }

        private void btn_BE_Guardar_Click(object sender, EventArgs e)
        {
            Fecha = Convert.ToDateTime(dateEmp_BE_FecFin.Text);
            FechaFin = Fecha.ToString("yyyy-Mm-dd");
            Nombre = ListaEmpleado.SelectedItem.ToString();
            try
            {
                conexion.abrir();
                String Consulta = "UPDATE Empleado SET Fecha_Final = '"+FechaFin+"' WHERE Nombre = "+Nombre+" ";
                SqlCommand command = new SqlCommand(Consulta, conexion.conectar);
                SqlDataReader reader = command.ExecuteReader();
                conexion.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarBE_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegresarBE_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Hide();
        }

        private void LlenarEmpleado(ComboBox bc)
        {
            conexion.abrir();
            try
            {
                String Sql = "SELECT Nombre, Id_Cliente from Empleado";
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
            txtEmp_BE_Mot.Text = "";
            txtEmp_BE_Anos.Text = "";
            txtEmp_BE_Dias.Text = "";
            txtEmp_BE_Mes.Text = "";
        }
    }
}
