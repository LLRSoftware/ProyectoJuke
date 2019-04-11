namespace empleados
{
    partial class modusuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresarDP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Est_mod_usu = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.Per_mod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Conf_mod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pass_mod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Usu_mod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btnRegresarDP);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 539);
            this.panel1.TabIndex = 27;
            // 
            // btnRegresarDP
            // 
            this.btnRegresarDP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegresarDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarDP.ForeColor = System.Drawing.Color.White;
            this.btnRegresarDP.Location = new System.Drawing.Point(685, 472);
            this.btnRegresarDP.Name = "btnRegresarDP";
            this.btnRegresarDP.Size = new System.Drawing.Size(90, 36);
            this.btnRegresarDP.TabIndex = 77;
            this.btnRegresarDP.Text = "Regresar";
            this.btnRegresarDP.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.Est_mod_usu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Usu_mod);
            this.panel2.Controls.Add(this.Pass_mod);
            this.panel2.Controls.Add(this.Per_mod);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Conf_mod);
            this.panel2.Location = new System.Drawing.Point(18, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 300);
            this.panel2.TabIndex = 74;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(1, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 48);
            this.panel3.TabIndex = 73;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(8, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(180, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Modificar Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label5.Location = new System.Drawing.Point(36, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 89;
            this.label5.Text = "Estatus";
            // 
            // Est_mod_usu
            // 
            this.Est_mod_usu.FormattingEnabled = true;
            this.Est_mod_usu.Location = new System.Drawing.Point(40, 238);
            this.Est_mod_usu.Name = "Est_mod_usu";
            this.Est_mod_usu.Size = new System.Drawing.Size(224, 24);
            this.Est_mod_usu.TabIndex = 88;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Location = new System.Drawing.Point(546, 472);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(90, 36);
            this.btn_aceptar.TabIndex = 87;
            this.btn_aceptar.Text = "Guardar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(408, 472);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 36);
            this.btn_cancelar.TabIndex = 86;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // Per_mod
            // 
            this.Per_mod.FormattingEnabled = true;
            this.Per_mod.Location = new System.Drawing.Point(362, 140);
            this.Per_mod.Name = "Per_mod";
            this.Per_mod.Size = new System.Drawing.Size(224, 24);
            this.Per_mod.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label4.Location = new System.Drawing.Point(358, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "Perfil";
            // 
            // Conf_mod
            // 
            this.Conf_mod.Location = new System.Drawing.Point(362, 60);
            this.Conf_mod.Name = "Conf_mod";
            this.Conf_mod.Size = new System.Drawing.Size(224, 22);
            this.Conf_mod.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label3.Location = new System.Drawing.Point(358, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Confirmar contraseña";
            // 
            // Pass_mod
            // 
            this.Pass_mod.Location = new System.Drawing.Point(40, 142);
            this.Pass_mod.Name = "Pass_mod";
            this.Pass_mod.PasswordChar = '*';
            this.Pass_mod.Size = new System.Drawing.Size(224, 22);
            this.Pass_mod.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nuevo Password";
            // 
            // Usu_mod
            // 
            this.Usu_mod.FormattingEnabled = true;
            this.Usu_mod.Location = new System.Drawing.Point(40, 60);
            this.Usu_mod.Name = "Usu_mod";
            this.Usu_mod.Size = new System.Drawing.Size(224, 24);
            this.Usu_mod.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Usuario";
            // 
            // modusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.panel1);
            this.Name = "modusuario";
            this.Text = "modusuario";
            this.Load += new System.EventHandler(this.modusuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btnRegresarDP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Est_mod_usu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Usu_mod;
        private System.Windows.Forms.TextBox Pass_mod;
        private System.Windows.Forms.ComboBox Per_mod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Conf_mod;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
    }
}