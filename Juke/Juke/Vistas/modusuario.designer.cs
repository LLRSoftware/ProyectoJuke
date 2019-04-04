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
            this.label1 = new System.Windows.Forms.Label();
            this.Usu_mod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass_mod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Conf_mod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Per_mod = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.Est_mod_usu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // Usu_mod
            // 
            this.Usu_mod.FormattingEnabled = true;
            this.Usu_mod.Location = new System.Drawing.Point(198, 74);
            this.Usu_mod.Name = "Usu_mod";
            this.Usu_mod.Size = new System.Drawing.Size(224, 24);
            this.Usu_mod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo Password";
            // 
            // Pass_mod
            // 
            this.Pass_mod.Location = new System.Drawing.Point(198, 128);
            this.Pass_mod.Name = "Pass_mod";
            this.Pass_mod.PasswordChar = '*';
            this.Pass_mod.Size = new System.Drawing.Size(224, 22);
            this.Pass_mod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar Password";
            // 
            // Conf_mod
            // 
            this.Conf_mod.Location = new System.Drawing.Point(198, 175);
            this.Conf_mod.Name = "Conf_mod";
            this.Conf_mod.Size = new System.Drawing.Size(224, 22);
            this.Conf_mod.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perfil";
            // 
            // Per_mod
            // 
            this.Per_mod.FormattingEnabled = true;
            this.Per_mod.Location = new System.Drawing.Point(198, 225);
            this.Per_mod.Name = "Per_mod";
            this.Per_mod.Size = new System.Drawing.Size(224, 24);
            this.Per_mod.TabIndex = 7;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(117, 343);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(281, 343);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Est_mod_usu
            // 
            this.Est_mod_usu.FormattingEnabled = true;
            this.Est_mod_usu.Location = new System.Drawing.Point(198, 270);
            this.Est_mod_usu.Name = "Est_mod_usu";
            this.Est_mod_usu.Size = new System.Drawing.Size(224, 24);
            this.Est_mod_usu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estatus";
            // 
            // modusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 431);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Est_mod_usu);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.Per_mod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Conf_mod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pass_mod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usu_mod);
            this.Controls.Add(this.label1);
            this.Name = "modusuario";
            this.Text = "modusuario";
            this.Load += new System.EventHandler(this.modusuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Usu_mod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pass_mod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Conf_mod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Per_mod;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.ComboBox Est_mod_usu;
        private System.Windows.Forms.Label label5;
    }
}