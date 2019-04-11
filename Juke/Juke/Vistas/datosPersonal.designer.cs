namespace WindowsFormsApp1
{
    partial class datosPersonal
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
            this.btnRegresarDP = new System.Windows.Forms.Button();
            this.btnCancelarDP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_DP_sig = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaEmpleado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Emp_DP_TelR = new System.Windows.Forms.TextBox();
            this.Emp_DP_TelP = new System.Windows.Forms.TextBox();
            this.Emp_DP_Ciu = new System.Windows.Forms.TextBox();
            this.Emp_DP_Col = new System.Windows.Forms.TextBox();
            this.Emp_DP_NumExt = new System.Windows.Forms.TextBox();
            this.Emp_DP_NumInt = new System.Windows.Forms.TextBox();
            this.Emp_DP_Calle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnRegresarDP);
            this.panel1.Controls.Add(this.btnCancelarDP);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btn_DP_sig);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 538);
            this.panel1.TabIndex = 0;
            // 
            // btnRegresarDP
            // 
            this.btnRegresarDP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegresarDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarDP.ForeColor = System.Drawing.Color.White;
            this.btnRegresarDP.Location = new System.Drawing.Point(421, 487);
            this.btnRegresarDP.Name = "btnRegresarDP";
            this.btnRegresarDP.Size = new System.Drawing.Size(90, 36);
            this.btnRegresarDP.TabIndex = 85;
            this.btnRegresarDP.Text = "Regresar";
            this.btnRegresarDP.UseVisualStyleBackColor = false;
            this.btnRegresarDP.Click += new System.EventHandler(this.btnRegresarDP_Click);
            // 
            // btnCancelarDP
            // 
            this.btnCancelarDP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelarDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDP.ForeColor = System.Drawing.Color.White;
            this.btnCancelarDP.Location = new System.Drawing.Point(551, 487);
            this.btnCancelarDP.Name = "btnCancelarDP";
            this.btnCancelarDP.Size = new System.Drawing.Size(90, 36);
            this.btnCancelarDP.TabIndex = 84;
            this.btnCancelarDP.Text = "Cancelar";
            this.btnCancelarDP.UseVisualStyleBackColor = false;
            this.btnCancelarDP.Click += new System.EventHandler(this.btnCancelarDP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Juke.Properties.Resources.Maps2;
            this.pictureBox1.Location = new System.Drawing.Point(19, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(15, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 19);
            this.label10.TabIndex = 82;
            this.label10.Text = "Ubicación de la empresa";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label17.Location = new System.Drawing.Point(11, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(764, 17);
            this.label17.TabIndex = 81;
            this.label17.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // btn_DP_sig
            // 
            this.btn_DP_sig.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_DP_sig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DP_sig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_DP_sig.ForeColor = System.Drawing.Color.White;
            this.btn_DP_sig.Location = new System.Drawing.Point(680, 487);
            this.btn_DP_sig.Name = "btn_DP_sig";
            this.btn_DP_sig.Size = new System.Drawing.Size(90, 36);
            this.btn_DP_sig.TabIndex = 80;
            this.btn_DP_sig.Text = "Siguiente";
            this.btn_DP_sig.UseVisualStyleBackColor = false;
            this.btn_DP_sig.Click += new System.EventHandler(this.btn_DP_sig_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ListaEmpleado);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.Emp_DP_TelR);
            this.panel3.Controls.Add(this.Emp_DP_TelP);
            this.panel3.Controls.Add(this.Emp_DP_Ciu);
            this.panel3.Controls.Add(this.Emp_DP_Col);
            this.panel3.Controls.Add(this.Emp_DP_NumExt);
            this.panel3.Controls.Add(this.Emp_DP_NumInt);
            this.panel3.Controls.Add(this.Emp_DP_Calle);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 213);
            this.panel3.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = "Ingrese la información";
            // 
            // ListaEmpleado
            // 
            this.ListaEmpleado.FormattingEnabled = true;
            this.ListaEmpleado.Location = new System.Drawing.Point(385, 15);
            this.ListaEmpleado.Name = "ListaEmpleado";
            this.ListaEmpleado.Size = new System.Drawing.Size(345, 24);
            this.ListaEmpleado.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "Clave empleado";
            // 
            // Emp_DP_TelR
            // 
            this.Emp_DP_TelR.Location = new System.Drawing.Point(538, 90);
            this.Emp_DP_TelR.Name = "Emp_DP_TelR";
            this.Emp_DP_TelR.Size = new System.Drawing.Size(192, 22);
            this.Emp_DP_TelR.TabIndex = 73;
            // 
            // Emp_DP_TelP
            // 
            this.Emp_DP_TelP.Location = new System.Drawing.Point(538, 54);
            this.Emp_DP_TelP.Name = "Emp_DP_TelP";
            this.Emp_DP_TelP.Size = new System.Drawing.Size(192, 22);
            this.Emp_DP_TelP.TabIndex = 72;
            // 
            // Emp_DP_Ciu
            // 
            this.Emp_DP_Ciu.Location = new System.Drawing.Point(101, 54);
            this.Emp_DP_Ciu.Name = "Emp_DP_Ciu";
            this.Emp_DP_Ciu.Size = new System.Drawing.Size(251, 22);
            this.Emp_DP_Ciu.TabIndex = 71;
            // 
            // Emp_DP_Col
            // 
            this.Emp_DP_Col.Location = new System.Drawing.Point(101, 144);
            this.Emp_DP_Col.Multiline = true;
            this.Emp_DP_Col.Name = "Emp_DP_Col";
            this.Emp_DP_Col.Size = new System.Drawing.Size(251, 45);
            this.Emp_DP_Col.TabIndex = 70;
            // 
            // Emp_DP_NumExt
            // 
            this.Emp_DP_NumExt.Location = new System.Drawing.Point(538, 169);
            this.Emp_DP_NumExt.Name = "Emp_DP_NumExt";
            this.Emp_DP_NumExt.Size = new System.Drawing.Size(192, 22);
            this.Emp_DP_NumExt.TabIndex = 69;
            // 
            // Emp_DP_NumInt
            // 
            this.Emp_DP_NumInt.Location = new System.Drawing.Point(538, 130);
            this.Emp_DP_NumInt.Name = "Emp_DP_NumInt";
            this.Emp_DP_NumInt.Size = new System.Drawing.Size(192, 22);
            this.Emp_DP_NumInt.TabIndex = 68;
            // 
            // Emp_DP_Calle
            // 
            this.Emp_DP_Calle.Location = new System.Drawing.Point(101, 90);
            this.Emp_DP_Calle.Multiline = true;
            this.Emp_DP_Calle.Name = "Emp_DP_Calle";
            this.Emp_DP_Calle.Size = new System.Drawing.Size(251, 45);
            this.Emp_DP_Calle.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Teléfono Personal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Teléfono Recados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Colonia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Numero Exterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Numero Interior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Calle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 48);
            this.panel2.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(8, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Datos personales";
            // 
            // datosPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.panel1);
            this.Name = "datosPersonal";
            this.Text = "Datos Personales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListaEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Emp_DP_TelR;
        private System.Windows.Forms.TextBox Emp_DP_TelP;
        private System.Windows.Forms.TextBox Emp_DP_Ciu;
        private System.Windows.Forms.TextBox Emp_DP_Col;
        private System.Windows.Forms.TextBox Emp_DP_NumExt;
        private System.Windows.Forms.TextBox Emp_DP_NumInt;
        private System.Windows.Forms.TextBox Emp_DP_Calle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_DP_sig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresarDP;
        private System.Windows.Forms.Button btnCancelarDP;
    }
}

