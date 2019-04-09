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
using Juke.Controller;

namespace menu
{
    public partial class menu : Form
    {
        String script= "SELECT * FROM Tarea ORDER BY Lote DESC";
        Grids grids;
        conexiondb conexiondb = new conexiondb();
        empleados.empleados empleados = new empleados.empleados();
        empleados.nuevouser nuevo = new empleados.nuevouser();
        empleados.modusuario cambio = new empleados.modusuario();
        EncontrarPersonal otra = new EncontrarPersonal();
        Venta venta = new Venta();
        Ajustar_Inventario ajustar_Inventario = new Ajustar_Inventario();
        Asignacion.Emp_Asg_Fij asignacion = new Asignacion.Emp_Asg_Fij(1);
        Captura_Nomina captura_Nomina = new Captura_Nomina();
        Clientes clientes = new Clientes();
        Agregar_Compra agregar_compra = new Agregar_Compra();
        Compra compra = new Compra();
        DetalleCompra detalleCompra = new DetalleCompra();
        DetalleVenta detalleVenta = new DetalleVenta();
        Gastos gastos = new Gastos();
        Agregar_Material agregar_material = new Agregar_Material();

        Inventario inventario = new Inventario();
        Material material = new Material();
        Nomina nomina = new Nomina();
        Proveedores proveedores = new Proveedores();
        Agregar_Material agregar_Material = new Agregar_Material();
        Agregar_Tarea agregar_Tarea = new Agregar_Tarea();
        Tareas tareas = new Tareas();
        

        public menu()
        {
            InitializeComponent();
            grids = new Grids(dgvTareasRecientes, conexiondb, script);
        }
        
        private void altaDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empleados.Show();
        }

        private void modificaciónDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otra.Show();
        }

        private void bajaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo.Show();
        }

        private void modificaciónUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cuerpo.Hide()
            cambio.Show();
        }

        private void bajaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            material.Show();
        }

        private void realizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_compra.Show();
        }

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compra.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajustar_Inventario.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignacion.Show();
        }

        private void cancelaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_Tarea.Show();
        }

        private void consultarTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tareas.Show();
        }

        private void agregarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_material.Show();
        }

        private void consultarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            material.Show();
        }

        private void consultarGastosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gastos.Show();
        }

        private void realizarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venta.Show();
        }
        
    }
}
