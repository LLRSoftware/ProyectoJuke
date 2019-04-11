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
        String script= "SELECT Nombre, Lote FROM Tarea ORDER BY Lote DESC";
        Grids grids;
        conexiondb conexiondb = new conexiondb();
        empleados.empleados empleados = new empleados.empleados();
        empleados.nuevouser nuevo = new empleados.nuevouser();
        empleados.modusuario cambio = new empleados.modusuario();
        EncontrarPersonal otra = new EncontrarPersonal();
        Venta venta = new Venta();
        Asignacion.Emp_Asg_Fij asignacion = new Asignacion.Emp_Asg_Fij(1);
        Captura_Nomina captura_Nomina = new Captura_Nomina();
        Clientes clientes = new Clientes();
        Agregar_Compra agregar_compra = new Agregar_Compra();
        Compra compra = new Compra();
        DetalleCompra detalleCompra = new DetalleCompra();
        Agregar_Venta agregar_venta = new Agregar_Venta();
        DetalleVenta detalleVenta = new DetalleVenta();
        Gastos gastos = new Gastos();
        Agregar_Material agregar_material = new Agregar_Material();
        Captura_Nomina captura_nomina = new Captura_Nomina();
        Proveedores proveedores = new Proveedores();
        Agregar_Material agregar_Material = new Agregar_Material();
        Agregar_Tarea agregar_Tarea = new Agregar_Tarea();
        Tareas tareas = new Tareas();
        Material material = new Material();
        

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

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo.Show();
        }

        private void modificaciónUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cuerpo.Hide()
            cambio.Show();
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
            agregar_material.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            captura_nomina.Show();
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

        private void consultarGastosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gastos.Show();
        }

        private void realizarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_venta.Show();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venta.Show();
        }

        private void consultarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            material.Show();
        }
    }
}
