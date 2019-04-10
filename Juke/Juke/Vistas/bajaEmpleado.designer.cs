namespace EmpleadosBajaUsuario
{
    partial class bajaEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresarBE = new System.Windows.Forms.Button();
            this.btnCancelarBE = new System.Windows.Forms.Button();
            this.btn_BE_Guardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListaEmpleado = new System.Windows.Forms.ComboBox();
            this.Emp_BE_Fec = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmp_BE_Mes = new System.Windows.Forms.TextBox();
            this.txtEmp_BE_Dias = new System.Windows.Forms.TextBox();
            this.txtEmp_BE_Anos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmp_BE_Mot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEmp_BE_FecFin = new System.Windows.Forms.DateTimePicker();
            this.Emp_BE_FecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnRegresarBE);
            this.panel1.Controls.Add(this.btnCancelarBE);
            this.panel1.Controls.Add(this.btn_BE_Guardar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 538);
            this.panel1.TabIndex = 23;
            // 
            // btnRegresarBE
            // 
            this.btnRegresarBE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegresarBE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarBE.ForeColor = System.Drawing.Color.White;
            this.btnRegresarBE.Location = new System.Drawing.Point(364, 476);
            this.btnRegresarBE.Name = "btnRegresarBE";
            this.btnRegresarBE.Size = new System.Drawing.Size(90, 36);
            this.btnRegresarBE.TabIndex = 66;
            this.btnRegresarBE.Text = "Regresar";
            this.btnRegresarBE.UseVisualStyleBackColor = false;
            this.btnRegresarBE.Click += new System.EventHandler(this.btnRegresarBE_Click);
            // 
            // btnCancelarBE
            // 
            this.btnCancelarBE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelarBE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarBE.ForeColor = System.Drawing.Color.White;
            this.btnCancelarBE.Location = new System.Drawing.Point(523, 476);
            this.btnCancelarBE.Name = "btnCancelarBE";
            this.btnCancelarBE.Size = new System.Drawing.Size(90, 36);
            this.btnCancelarBE.TabIndex = 65;
            this.btnCancelarBE.Text = "Cancelar";
            this.btnCancelarBE.UseVisualStyleBackColor = false;
            this.btnCancelarBE.Click += new System.EventHandler(this.btnCancelarBE_Click);
            // 
            // btn_BE_Guardar
            // 
            this.btn_BE_Guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_BE_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BE_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_BE_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_BE_Guardar.Location = new System.Drawing.Point(678, 476);
            this.btn_BE_Guardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BE_Guardar.Name = "btn_BE_Guardar";
            this.btn_BE_Guardar.Size = new System.Drawing.Size(90, 38);
            this.btn_BE_Guardar.TabIndex = 63;
            this.btn_BE_Guardar.Text = "Guardar";
            this.btn_BE_Guardar.UseVisualStyleBackColor = false;
            this.btn_BE_Guardar.Click += new System.EventHandler(this.btn_BE_Guardar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.ListaEmpleado);
            this.panel3.Controls.Add(this.Emp_BE_Fec);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtEmp_BE_Mes);
            this.panel3.Controls.Add(this.txtEmp_BE_Dias);
            this.panel3.Controls.Add(this.txtEmp_BE_Anos);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtEmp_BE_Mot);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dateEmp_BE_FecFin);
            this.panel3.Controls.Add(this.Emp_BE_FecIni);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 384);
            this.panel3.TabIndex = 44;
            // 
            // ListaEmpleado
            // 
            this.ListaEmpleado.FormattingEnabled = true;
            this.ListaEmpleado.Location = new System.Drawing.Point(189, 308);
            this.ListaEmpleado.Name = "ListaEmpleado";
            this.ListaEmpleado.Size = new System.Drawing.Size(300, 28);
            this.ListaEmpleado.TabIndex = 62;
            // 
            // Emp_BE_Fec
            // 
            this.Emp_BE_Fec.Location = new System.Drawing.Point(189, 268);
            this.Emp_BE_Fec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_Fec.Name = "Emp_BE_Fec";
            this.Emp_BE_Fec.Size = new System.Drawing.Size(300, 27);
            this.Emp_BE_Fec.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Fecha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Finalizado por";
            // 
            // txtEmp_BE_Mes
            // 
            this.txtEmp_BE_Mes.Location = new System.Drawing.Point(473, 191);
            this.txtEmp_BE_Mes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmp_BE_Mes.Name = "txtEmp_BE_Mes";
            this.txtEmp_BE_Mes.Size = new System.Drawing.Size(79, 27);
            this.txtEmp_BE_Mes.TabIndex = 55;
            // 
            // txtEmp_BE_Dias
            // 
            this.txtEmp_BE_Dias.Location = new System.Drawing.Point(645, 191);
            this.txtEmp_BE_Dias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmp_BE_Dias.Name = "txtEmp_BE_Dias";
            this.txtEmp_BE_Dias.Size = new System.Drawing.Size(79, 27);
            this.txtEmp_BE_Dias.TabIndex = 54;
            // 
            // txtEmp_BE_Anos
            // 
            this.txtEmp_BE_Anos.Location = new System.Drawing.Point(268, 191);
            this.txtEmp_BE_Anos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmp_BE_Anos.Name = "txtEmp_BE_Anos";
            this.txtEmp_BE_Anos.Size = new System.Drawing.Size(79, 27);
            this.txtEmp_BE_Anos.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(585, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Días";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Meses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Años";
            // 
            // txtEmp_BE_Mot
            // 
            this.txtEmp_BE_Mot.Location = new System.Drawing.Point(189, 100);
            this.txtEmp_BE_Mot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmp_BE_Mot.Multiline = true;
            this.txtEmp_BE_Mot.Name = "txtEmp_BE_Mot";
            this.txtEmp_BE_Mot.Size = new System.Drawing.Size(535, 65);
            this.txtEmp_BE_Mot.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Motivo de baja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Fecha de baja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fecha Inicial ";
            // 
            // dateEmp_BE_FecFin
            // 
            this.dateEmp_BE_FecFin.Location = new System.Drawing.Point(189, 61);
            this.dateEmp_BE_FecFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEmp_BE_FecFin.Name = "dateEmp_BE_FecFin";
            this.dateEmp_BE_FecFin.Size = new System.Drawing.Size(291, 27);
            this.dateEmp_BE_FecFin.TabIndex = 45;
            // 
            // Emp_BE_FecIni
            // 
            this.Emp_BE_FecIni.Location = new System.Drawing.Point(189, 16);
            this.Emp_BE_FecIni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_FecIni.Name = "Emp_BE_FecIni";
            this.Emp_BE_FecIni.Size = new System.Drawing.Size(291, 27);
            this.Emp_BE_FecIni.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Duración del servicio";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 48);
            this.panel2.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(8, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Baja de empleado";
            // 
            // bajaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "bajaEmpleado";
            this.Text = "Baja de empleado";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_BE_Guardar;
        private System.Windows.Forms.DateTimePicker Emp_BE_Fec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmp_BE_Mes;
        private System.Windows.Forms.TextBox txtEmp_BE_Dias;
        private System.Windows.Forms.TextBox txtEmp_BE_Anos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmp_BE_Mot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEmp_BE_FecFin;
        private System.Windows.Forms.DateTimePicker Emp_BE_FecIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancelarBE;
        private System.Windows.Forms.Button btnRegresarBE;
        private System.Windows.Forms.ComboBox ListaEmpleado;
    }
}

