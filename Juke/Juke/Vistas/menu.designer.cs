namespace menu
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTareasRecientes = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.nominaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.gastosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.tareasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeEmpleadoToolStripMenuItem,
            this.modificaciónDeEmpleadosToolStripMenuItem,
            this.bajaDeEmpleadosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // altaDeEmpleadoToolStripMenuItem
            // 
            this.altaDeEmpleadoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaDeEmpleadoToolStripMenuItem.Name = "altaDeEmpleadoToolStripMenuItem";
            this.altaDeEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(315, 28);
            this.altaDeEmpleadoToolStripMenuItem.Text = "Alta de Empleado";
            this.altaDeEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.altaDeEmpleadoToolStripMenuItem_Click);
            // 
            // modificaciónDeEmpleadosToolStripMenuItem
            // 
            this.modificaciónDeEmpleadosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaciónDeEmpleadosToolStripMenuItem.Name = "modificaciónDeEmpleadosToolStripMenuItem";
            this.modificaciónDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(315, 28);
            this.modificaciónDeEmpleadosToolStripMenuItem.Text = "Modificación de Empleados";
            this.modificaciónDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.modificaciónDeEmpleadosToolStripMenuItem_Click);
            // 
            // bajaDeEmpleadosToolStripMenuItem
            // 
            this.bajaDeEmpleadosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaDeEmpleadosToolStripMenuItem.Name = "bajaDeEmpleadosToolStripMenuItem";
            this.bajaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(315, 28);
            this.bajaDeEmpleadosToolStripMenuItem.Text = "Baja de Empleados";
            // 
            // nominaToolStripMenuItem
            // 
            this.nominaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.cancelaciónToolStripMenuItem});
            this.nominaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nominaToolStripMenuItem.Name = "nominaToolStripMenuItem";
            this.nominaToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.nominaToolStripMenuItem.Text = "Nomina";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // cancelaciónToolStripMenuItem
            // 
            this.cancelaciónToolStripMenuItem.Name = "cancelaciónToolStripMenuItem";
            this.cancelaciónToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.cancelaciónToolStripMenuItem.Text = "Cancelación";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaUsuarioToolStripMenuItem,
            this.modificaciónUsuarioToolStripMenuItem,
            this.bajaUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // altaUsuarioToolStripMenuItem
            // 
            this.altaUsuarioToolStripMenuItem.Name = "altaUsuarioToolStripMenuItem";
            this.altaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.altaUsuarioToolStripMenuItem.Text = "Alta Usuario";
            this.altaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.altaUsuarioToolStripMenuItem_Click);
            // 
            // modificaciónUsuarioToolStripMenuItem
            // 
            this.modificaciónUsuarioToolStripMenuItem.Name = "modificaciónUsuarioToolStripMenuItem";
            this.modificaciónUsuarioToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.modificaciónUsuarioToolStripMenuItem.Text = "Modificación Usuario";
            this.modificaciónUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificaciónUsuarioToolStripMenuItem_Click);
            // 
            // bajaUsuarioToolStripMenuItem
            // 
            this.bajaUsuarioToolStripMenuItem.Name = "bajaUsuarioToolStripMenuItem";
            this.bajaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.bajaUsuarioToolStripMenuItem.Text = "Baja Usuario";
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarGastosToolStripMenuItem});
            this.gastosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.gastosToolStripMenuItem.Text = "Gastos";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarToolStripMenuItem,
            this.consultarComprasToolStripMenuItem});
            this.comprasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // realizarToolStripMenuItem
            // 
            this.realizarToolStripMenuItem.Name = "realizarToolStripMenuItem";
            this.realizarToolStripMenuItem.Size = new System.Drawing.Size(239, 28);
            this.realizarToolStripMenuItem.Text = "Realizar";
            this.realizarToolStripMenuItem.Click += new System.EventHandler(this.realizarToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVentasToolStripMenuItem,
            this.consultarVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMaterialToolStripMenuItem,
            this.consultarMaterialToolStripMenuItem});
            this.inventariosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTareaToolStripMenuItem,
            this.consultarTareasToolStripMenuItem});
            this.tareasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // consultarGastosToolStripMenuItem
            // 
            this.consultarGastosToolStripMenuItem.Name = "consultarGastosToolStripMenuItem";
            this.consultarGastosToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.consultarGastosToolStripMenuItem.Text = "Consultar Gastos";
            this.consultarGastosToolStripMenuItem.Click += new System.EventHandler(this.consultarGastosToolStripMenuItem_Click);
            // 
            // consultarComprasToolStripMenuItem
            // 
            this.consultarComprasToolStripMenuItem.Name = "consultarComprasToolStripMenuItem";
            this.consultarComprasToolStripMenuItem.Size = new System.Drawing.Size(239, 28);
            this.consultarComprasToolStripMenuItem.Text = "Consultar Compras";
            this.consultarComprasToolStripMenuItem.Click += new System.EventHandler(this.consultarComprasToolStripMenuItem_Click);
            // 
            // realizarVentasToolStripMenuItem
            // 
            this.realizarVentasToolStripMenuItem.Name = "realizarVentasToolStripMenuItem";
            this.realizarVentasToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.realizarVentasToolStripMenuItem.Text = "Realizar Ventas";
            // 
            // consultarVentasToolStripMenuItem
            // 
            this.consultarVentasToolStripMenuItem.Name = "consultarVentasToolStripMenuItem";
            this.consultarVentasToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.consultarVentasToolStripMenuItem.Text = "Consultar Ventas";
            // 
            // agregarMaterialToolStripMenuItem
            // 
            this.agregarMaterialToolStripMenuItem.Name = "agregarMaterialToolStripMenuItem";
            this.agregarMaterialToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.agregarMaterialToolStripMenuItem.Text = "Agregar Material";
            this.agregarMaterialToolStripMenuItem.Click += new System.EventHandler(this.agregarMaterialToolStripMenuItem_Click);
            // 
            // consultarMaterialToolStripMenuItem
            // 
            this.consultarMaterialToolStripMenuItem.Name = "consultarMaterialToolStripMenuItem";
            this.consultarMaterialToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.consultarMaterialToolStripMenuItem.Text = "Consultar Material";
            this.consultarMaterialToolStripMenuItem.Click += new System.EventHandler(this.consultarMaterialToolStripMenuItem_Click);
            // 
            // agregarTareaToolStripMenuItem
            // 
            this.agregarTareaToolStripMenuItem.Name = "agregarTareaToolStripMenuItem";
            this.agregarTareaToolStripMenuItem.Size = new System.Drawing.Size(219, 28);
            this.agregarTareaToolStripMenuItem.Text = "Agregar Tarea";
            this.agregarTareaToolStripMenuItem.Click += new System.EventHandler(this.agregarTareaToolStripMenuItem_Click);
            // 
            // consultarTareasToolStripMenuItem
            // 
            this.consultarTareasToolStripMenuItem.Name = "consultarTareasToolStripMenuItem";
            this.consultarTareasToolStripMenuItem.Size = new System.Drawing.Size(219, 28);
            this.consultarTareasToolStripMenuItem.Text = "Consultar Tareas";
            // 
            // dgvTareasRecientes
            // 
            this.dgvTareasRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareasRecientes.Location = new System.Drawing.Point(13, 69);
            this.dgvTareasRecientes.Name = "dgvTareasRecientes";
            this.dgvTareasRecientes.RowTemplate.Height = 24;
            this.dgvTareasRecientes.Size = new System.Drawing.Size(847, 332);
            this.dgvTareasRecientes.TabIndex = 1;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 512);
            this.Controls.Add(this.dgvTareasRecientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasRecientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTareasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTareasRecientes;
    }
}

