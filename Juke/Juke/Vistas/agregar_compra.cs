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
    public partial class Agregar_Compra : Form
    {
        conexiondb conexiondb = new conexiondb();

        DateTime fecha = DateTime.Now;
        DetalleCompra detallecompra = new DetalleCompra();

        String ClaveC = "";
        String FechaCompra = "";
        String FolioCompra = "";
        String GastoC = "";
        String ImporteC = "";
        String UsuarioC = "";


        public Agregar_Compra()
        {
            InitializeComponent();

            FechaCompra = fecha.ToString("yyyy-MM-dd");
            FolioCompra = fecha.ToString("yyyyMMdd");

            txtClaveC.Text = "0";
            txtFechaCompra.Text = FechaCompra;
            txtFolioCompra.Text = FolioCompra;
            txtGastoC.Text = "0";
            txtImporteC.Text = "0.00";
            txtUsuarioC.Text = "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Compra_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarC_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            //try
            //{
            //    conexiondb.abrir();
            //    String Consulta = "DELETE FROM Compra WHERE Id_Compra = (SELECT MAX(Id_Compra) FROM Compra)";
            //    SqlCommand command = new SqlCommand(Consulta,conexiondb.conectar);
            //    SqlDataReader reader = command.ExecuteReader();
            //    conexiondb.cerrar();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            ClaveC = txtClaveC.Text;
            FechaCompra = txtFechaCompra.Text;
            FolioCompra = txtFolioCompra.Text;
            GastoC = txtGastoC.Text;
            ImporteC = txtImporteC.Text;
            UsuarioC = txtUsuarioC.Text;
            int GastoId = Convert.ToInt32(GastoC);
            try
            {
                FechaCompra = fecha.ToString("yyyy-MM-dd");
                FolioCompra = fecha.ToString("yyyyMMdd");
                conexiondb.abrir();
                String ConsultaGasto = " INSERT INTO Gastos (Fecha,Id_Sucursal) VALUES('"+FechaCompra+"', 1)";
                SqlCommand commandG = new SqlCommand(ConsultaGasto, conexiondb.conectar);
                SqlDataReader readerG = commandG.ExecuteReader();
                conexiondb.cerrar();
                conexiondb.abrir();
                String ConsultaCompra = "INSERT INTO Compra (Fecha, Folio, Id_Gasto, Id_Usuario, Importe) VALUES('"+FechaCompra+"', '"+FolioCompra+ "',(SELECT MAX(Id_Gasto) FROM Gastos) , 1, 0)";
                SqlCommand command = new SqlCommand(ConsultaCompra, conexiondb.conectar);
                SqlDataReader reader = command.ExecuteReader();
                conexiondb.cerrar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            detallecompra.Show();
            this.Hide();

        }

        private void btnRegresarC_Click(object sender, EventArgs e)
        {
            this.Limpiar();    
            this.Hide();
        }

        public void Limpiar()
        {
            txtClaveC.Text = "";
            txtFechaCompra.Text = "";
            txtFolioCompra.Text = "";
            txtGastoC.Text = "";
            txtImporteC.Text = "";
            txtUsuarioC.Text = "";
        }
    }
}
