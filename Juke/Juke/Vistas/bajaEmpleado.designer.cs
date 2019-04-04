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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Emp_BE_FecIni = new System.Windows.Forms.DateTimePicker();
            this.Emp_BE_FecFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Emp_BE_Mot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Emp_BE_Anos = new System.Windows.Forms.TextBox();
            this.Emp_BE_Dias = new System.Windows.Forms.TextBox();
            this.Emp_BE_Mes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Emp_BE_Nom = new System.Windows.Forms.TextBox();
            this.Emp_BE_Fec = new System.Windows.Forms.DateTimePicker();
            this.Emp_BE_Cve = new System.Windows.Forms.TextBox();
            this.btn_BE_Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baja de empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duración del servicio";
            // 
            // Emp_BE_FecIni
            // 
            this.Emp_BE_FecIni.Location = new System.Drawing.Point(199, 152);
            this.Emp_BE_FecIni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_FecIni.Name = "Emp_BE_FecIni";
            this.Emp_BE_FecIni.Size = new System.Drawing.Size(282, 27);
            this.Emp_BE_FecIni.TabIndex = 2;
            this.Emp_BE_FecIni.ValueChanged += new System.EventHandler(this.Emp_BE_FecIni_ValueChanged);
            // 
            // Emp_BE_FecFin
            // 
            this.Emp_BE_FecFin.Location = new System.Drawing.Point(615, 152);
            this.Emp_BE_FecFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_FecFin.Name = "Emp_BE_FecFin";
            this.Emp_BE_FecFin.Size = new System.Drawing.Size(282, 27);
            this.Emp_BE_FecFin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Inicial ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de baja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Motivo de baja";
            // 
            // Emp_BE_Mot
            // 
            this.Emp_BE_Mot.Location = new System.Drawing.Point(106, 229);
            this.Emp_BE_Mot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_Mot.Name = "Emp_BE_Mot";
            this.Emp_BE_Mot.Size = new System.Drawing.Size(791, 27);
            this.Emp_BE_Mot.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Años";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Meses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(665, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Días";
            // 
            // Emp_BE_Anos
            // 
            this.Emp_BE_Anos.Location = new System.Drawing.Point(162, 349);
            this.Emp_BE_Anos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_Anos.Name = "Emp_BE_Anos";
            this.Emp_BE_Anos.Size = new System.Drawing.Size(173, 27);
            this.Emp_BE_Anos.TabIndex = 11;
            // 
            // Emp_BE_Dias
            // 
            this.Emp_BE_Dias.Location = new System.Drawing.Point(724, 349);
            this.Emp_BE_Dias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_Dias.Name = "Emp_BE_Dias";
            this.Emp_BE_Dias.Size = new System.Drawing.Size(173, 27);
            this.Emp_BE_Dias.TabIndex = 12;
            this.Emp_BE_Dias.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Emp_BE_Mes
            // 
            this.Emp_BE_Mes.Location = new System.Drawing.Point(450, 351);
            this.Emp_BE_Mes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_Mes.Name = "Emp_BE_Mes";
            this.Emp_BE_Mes.Size = new System.Drawing.Size(173, 27);
            this.Emp_BE_Mes.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Finalizado por:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 530);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nombre: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(86, 564);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Clave:";
            // 
            // Emp_BE_Nom
            // 
            this.Emp_BE_Nom.Location = new System.Drawing.Point(162, 524);
            this.Emp_BE_Nom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_Nom.Name = "Emp_BE_Nom";
            this.Emp_BE_Nom.Size = new System.Drawing.Size(173, 27);
            this.Emp_BE_Nom.TabIndex = 18;
            this.Emp_BE_Nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Emp_BE_Fec
            // 
            this.Emp_BE_Fec.Location = new System.Drawing.Point(162, 489);
            this.Emp_BE_Fec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_Fec.Name = "Emp_BE_Fec";
            this.Emp_BE_Fec.Size = new System.Drawing.Size(173, 27);
            this.Emp_BE_Fec.TabIndex = 19;
            // 
            // Emp_BE_Cve
            // 
            this.Emp_BE_Cve.Location = new System.Drawing.Point(162, 558);
            this.Emp_BE_Cve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_BE_Cve.Name = "Emp_BE_Cve";
            this.Emp_BE_Cve.Size = new System.Drawing.Size(173, 27);
            this.Emp_BE_Cve.TabIndex = 20;
            // 
            // btn_BE_Guardar
            // 
            this.btn_BE_Guardar.Location = new System.Drawing.Point(735, 546);
            this.btn_BE_Guardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BE_Guardar.Name = "btn_BE_Guardar";
            this.btn_BE_Guardar.Size = new System.Drawing.Size(145, 38);
            this.btn_BE_Guardar.TabIndex = 21;
            this.btn_BE_Guardar.Text = "Guardar";
            this.btn_BE_Guardar.UseVisualStyleBackColor = true;
            this.btn_BE_Guardar.Click += new System.EventHandler(this.btn_BE_Guardar_Click);
            // 
            // bajaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 618);
            this.Controls.Add(this.btn_BE_Guardar);
            this.Controls.Add(this.Emp_BE_Cve);
            this.Controls.Add(this.Emp_BE_Fec);
            this.Controls.Add(this.Emp_BE_Nom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Emp_BE_Mes);
            this.Controls.Add(this.Emp_BE_Dias);
            this.Controls.Add(this.Emp_BE_Anos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Emp_BE_Mot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Emp_BE_FecFin);
            this.Controls.Add(this.Emp_BE_FecIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "bajaEmpleado";
            this.Text = "Baja de empleado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Emp_BE_FecIni;
        private System.Windows.Forms.DateTimePicker Emp_BE_FecFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Emp_BE_Mot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Emp_BE_Anos;
        private System.Windows.Forms.TextBox Emp_BE_Dias;
        private System.Windows.Forms.TextBox Emp_BE_Mes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Emp_BE_Nom;
        private System.Windows.Forms.DateTimePicker Emp_BE_Fec;
        private System.Windows.Forms.TextBox Emp_BE_Cve;
        private System.Windows.Forms.Button btn_BE_Guardar;
    }
}

