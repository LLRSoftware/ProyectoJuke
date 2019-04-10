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
    public partial class Detalle_Tarea : Form
    {
        conexiondb conexion = new conexiondb();
        //Agregar_Tarea agregar_tarea = new Agregar_Tarea();
        int Tarea;
        int Material;
        String Fecha;
        int Cantidad;

        public Detalle_Tarea()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Now;
            txtFechaDT.Text = fecha.ToString("yyyy-MM-dd");
            Fecha = txtFechaDT.Text;
            llenaMaterial(ListaMaterial);
            llenaTarea(ListaTarea);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Cantidad = Convert.ToInt32(txtCantidadDT.Text);
            Tarea = Convert.ToInt32(ListaTarea.ValueMember + 1);
            Material = Convert.ToInt32(ListaMaterial.ValueMember + 1);

            try
            {

                conexion.abrir();
                String Consulta = "INSERT INTO Det_Tarea (Fecha, Cantidad, Id_Tarea, Id_Material) VALUES('" + Fecha + "', " + Cantidad + ", " + Tarea + ", " + Material + ")";
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
        
        private void btnCancelarDT_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegresarDT_Click(object sender, EventArgs e)
        {

            Limpiar();
            this.Hide();
            //agregar_tarea.Show();
        }

        private void Limpiar()
        {
            txtCantidadDT.Text = " ";
        }

        public void llenaTarea(ComboBox bc)
        {
            try
            {
                conexion.abrir();
                String Sql = "SELECT Lote, Id_Tarea FROM Tarea WHERE Id_Tarea = (SELECT MAX(Id_Tarea) FROM Tarea)";
                SqlCommand leer = new SqlCommand(Sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    bc.Items.Add(conn["Lote"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar con la bd " + ex);
            }
            conexion.cerrar();
        }

        public void llenaMaterial(ComboBox bc)
        {
            try
            {
                conexion.abrir();
                String Sql = "SELECT Nombre, Id_Material FROM Material";
                SqlCommand leer = new SqlCommand(Sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    bc.Items.Add(conn["Nombre"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar con la bd " + ex);
            }
            conexion.cerrar();
        }
    }
}
