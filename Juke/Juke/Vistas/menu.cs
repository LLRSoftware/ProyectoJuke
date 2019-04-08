using Juke.EncontrarPersonal;
using Juke.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juke.Model;
using System.Data.SqlClient;
using Juke.nueva;

namespace menu
{
    public partial class menu : Form
    {
        conexiondb conexiondb = new conexiondb();
        empleados.empleados nueva = new empleados.empleados();
        empleados.nuevouser nuevo = new empleados.nuevouser();
        empleados.modusuario cambio = new empleados.modusuario();
        EncontrarPersonal otra = new EncontrarPersonal();
        Venta venta = new Venta();
        Ajustar_Inventario ajustar_Inventario = new Ajustar_Inventario();
        Asignacion.Emp_Asg_Fij asignacion = new Asignacion.Emp_Asg_Fij(1);
        Inventarios inventarios = new Inventarios();
        Captura_Nomina captura_Nomina = new Captura_Nomina();
        Clientes clientes = new Clientes();
        Compra compra = new Compra();
        DetalleCompra detalleCompra = new DetalleCompra();
        DetalleVenta detalleVenta = new DetalleVenta();
        Gastos gastos = new Gastos();
        Material material = new Material();
        Inventario inventario = new Inventario();
        Material aMaterial = new Material();
        Nomina nomina = new Nomina();
        Proveedores proveedores = new Proveedores();
        Agregar_Material agregar_Material = new Agregar_Material();
        Agregar_Tarea agregar_Tarea = new Agregar_Tarea();

        public menu()
        {
            InitializeComponent();
            LlenarView(dgvTareasRecientes);
        }

        public void LlenarView(DataGridView dgv)
        {
            try
            {

                //Establecer la conexión al servidor dentro del entorno
                SqlCommand connection = new SqlCommand();

                //Conexión abierta para su manejo
                conexiondb.abrir();

                //Comando SQL para solicitar información a la base de datos
                SqlCommand command = new SqlCommand("SELECT * FROM Tarea ORDER BY Lote DESC", conexiondb.conectar);

                //Adapter que toma los datos obtenidos para almacenarlos en un arreglo de tipo DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dgv.DataSource = data;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }
        }
        private void modificaciónUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambio.Show();
        }

        private void altaDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nueva.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo.Show();
        }

        private void modificaciónDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otra.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inventarios.Show();
        }

        private void realizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void realizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compra.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajustar_Inventario.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignacion.Show();
        }

        private void consultarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cMaterial.Show();
        }

        private void agregarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_Tarea.Show();
        }

        private void agregarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            material.Show();
        }
    }
}
