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
    public partial class Captura_Nomina : Form
    {
        conexiondb conexion = new conexiondb();
        DateTime fecha = DateTime.Now;
        String FechaNomina = "";
        decimal CajaAhorro;
        decimal Fondo_Ahorro;
        decimal ISR;
        decimal Seguro;

        public Captura_Nomina()
        {
            InitializeComponent();
            FechaNomina = fecha.ToString("yyyy-MM-dd");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarCN_Click(object sender, EventArgs e)
        {
            CajaAhorro = Convert.ToDecimal(txtCajaAhorro.Text);
            Fondo_Ahorro = Convert.ToDecimal(txtFondo_Ahorro.Text);
            ISR = Convert.ToDecimal(txtISR.Text);
            Seguro = Convert.ToDecimal(txtSeguro.Text);
            try
            {
                CrearGasto();
                conexion.abrir();
                String Consulta = "INSERT INTO Nomina (Fondo_Ahorro, ISR, C_Seguro, D_CajaAhorro, Id_Gasto) " +
                    "VALUES(" + Fondo_Ahorro + "," + ISR + "," + Seguro + ", " + CajaAhorro + ", (SELECT MAX(Id_Gasto) FROM Gastos))";
                SqlCommand command = new SqlCommand(Consulta, conexion.conectar);
                SqlDataReader reader = command.ExecuteReader();
                conexion.cerrar();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Limpiar();
        }

        private void btnCancelarCN_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegresarCN_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Hide();
        }

        private void CrearGasto()
        {

            FechaNomina = fecha.ToString("yyyy-MM-dd");
            conexion.abrir();
            String ConsultaGasto = " INSERT INTO Gastos (Fecha,Id_Sucursal) VALUES('" + FechaNomina + "', 1)";
            SqlCommand commandG = new SqlCommand(ConsultaGasto, conexion.conectar);
            SqlDataReader readerG = commandG.ExecuteReader();
            conexion.cerrar();
        }

        private void Limpiar()
        {
            txtCajaAhorro.Text = "";
            txtFondo_Ahorro.Text = "";
            txtISR.Text = "";
            txtSeguro.Text = "";
        }
    }
}
