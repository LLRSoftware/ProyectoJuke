namespace empleados
{
    partial class nuevouser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nue_Usu = new System.Windows.Forms.ComboBox();
            this.Nue_Usu_Usu = new System.Windows.Forms.TextBox();
            this.Nue_Usu_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nue_Usu_Conf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nue_Usu_Per = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nue_Usu
            // 
            this.Nue_Usu.FormattingEnabled = true;
            this.Nue_Usu.Location = new System.Drawing.Point(190, 57);
            this.Nue_Usu.Name = "Nue_Usu";
            this.Nue_Usu.Size = new System.Drawing.Size(276, 24);
            this.Nue_Usu.TabIndex = 0;
            // 
            // Nue_Usu_Usu
            // 
            this.Nue_Usu_Usu.Location = new System.Drawing.Point(190, 135);
            this.Nue_Usu_Usu.Name = "Nue_Usu_Usu";
            this.Nue_Usu_Usu.Size = new System.Drawing.Size(276, 22);
            this.Nue_Usu_Usu.TabIndex = 1;
            // 
            // Nue_Usu_Pass
            // 
            this.Nue_Usu_Pass.Location = new System.Drawing.Point(190, 203);
            this.Nue_Usu_Pass.Name = "Nue_Usu_Pass";
            this.Nue_Usu_Pass.Size = new System.Drawing.Size(276, 22);
            this.Nue_Usu_Pass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(134, 393);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(90, 28);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(318, 393);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(95, 28);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Nue_Usu_Conf
            // 
            this.Nue_Usu_Conf.Location = new System.Drawing.Point(190, 276);
            this.Nue_Usu_Conf.Name = "Nue_Usu_Conf";
            this.Nue_Usu_Conf.Size = new System.Drawing.Size(276, 22);
            this.Nue_Usu_Conf.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ConfirmarPass";
            // 
            // Nue_Usu_Per
            // 
            this.Nue_Usu_Per.FormattingEnabled = true;
            this.Nue_Usu_Per.Location = new System.Drawing.Point(190, 342);
            this.Nue_Usu_Per.Name = "Nue_Usu_Per";
            this.Nue_Usu_Per.Size = new System.Drawing.Size(276, 24);
            this.Nue_Usu_Per.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Perfil";
            // 
            // nuevouser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nue_Usu_Per);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nue_Usu_Conf);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nue_Usu_Pass);
            this.Controls.Add(this.Nue_Usu_Usu);
            this.Controls.Add(this.Nue_Usu);
            this.Name = "nuevouser";
            this.Text = "nuevouser";
            this.Load += new System.EventHandler(this.nuevouser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Nue_Usu;
        private System.Windows.Forms.TextBox Nue_Usu_Usu;
        private System.Windows.Forms.TextBox Nue_Usu_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox Nue_Usu_Conf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Nue_Usu_Per;
        private System.Windows.Forms.Label label5;
    }
}