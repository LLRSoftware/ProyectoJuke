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
    public partial class Agregar_Tarea : Form
    {
        conexiondb conexion = new conexiondb();
        Detalle_Tarea detalle_tarea = new Detalle_Tarea();
        String Lote = "";
        String Nombre = "";
        String Descripcion = "";
        decimal Precio = 0;
        decimal Costo = 0;

        public Agregar_Tarea()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Now;
            txtLote.Text = fecha.ToString("mmss");
            Lote = txtLote.Text;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Tarea_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarT_Click(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            Descripcion = txtDescripcion.Text;
            Precio = Convert.ToDecimal(txtPrecio.Text);
            Costo = Convert.ToDecimal(txtCosto.Text);
            
            try
            {

                conexion.abrir();
                String Consulta = "INSERT INTO Tarea (Nombre, Descripcion, Precio, Costo, Lote) " +
                    "VALUES('"+Nombre+"', '"+Descripcion+"', "+Precio+", "+Costo+", "+Lote+")";
                SqlCommand command = new SqlCommand(Consulta, conexion.conectar);
                SqlDataReader reader = command.ExecuteReader();
                conexion.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Limpiar();
            this.Hide();
            detalle_tarea.Show();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnRegresarT_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Hide();
        }

        private void btnCancelarT_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
