namespace Juke.Vistas
{
    partial class Compra
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
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolioC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImporteC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGastoC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegresarC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnRegresarC);
            this.panel1.Controls.Add(this.btnCancelarC);
            this.panel1.Controls.Add(this.btnGuardarC);
            this.panel1.Controls.Add(this.dgvCompra);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 533);
            this.panel1.TabIndex = 4;
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarC.ForeColor = System.Drawing.Color.White;
            this.btnCancelarC.Location = new System.Drawing.Point(523, 471);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(90, 36);
            this.btnCancelarC.TabIndex = 18;
            this.btnCancelarC.Text = "Cancelar";
            this.btnCancelarC.UseVisualStyleBackColor = false;
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarC.ForeColor = System.Drawing.Color.White;
            this.btnGuardarC.Location = new System.Drawing.Point(680, 471);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(90, 36);
            this.btnGuardarC.TabIndex = 17;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.UseVisualStyleBackColor = false;
            // 
            // dgvCompra
            // 
            this.dgvCompra.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(12, 89);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowTemplate.Height = 24;
            this.dgvCompra.Size = new System.Drawing.Size(758, 128);
            this.dgvCompra.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.txtGastoC);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtUsuarioC);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtIDCompra);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtFolioC);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtImporteC);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtFechaC);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(15, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(755, 171);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(692, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "MXN";
            // 
            // txtIDCompra
            // 
            this.txtIDCompra.Location = new System.Drawing.Point(133, 35);
            this.txtIDCompra.Name = "txtIDCompra";
            this.txtIDCompra.ReadOnly = true;
            this.txtIDCompra.Size = new System.Drawing.Size(204, 22);
            this.txtIDCompra.TabIndex = 14;
            this.txtIDCompra.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Clave compra";
            // 
            // txtFolioC
            // 
            this.txtFolioC.Location = new System.Drawing.Point(133, 72);
            this.txtFolioC.Name = "txtFolioC";
            this.txtFolioC.ReadOnly = true;
            this.txtFolioC.Size = new System.Drawing.Size(204, 22);
            this.txtFolioC.TabIndex = 12;
            this.txtFolioC.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Folio";
            // 
            // txtImporteC
            // 
            this.txtImporteC.Location = new System.Drawing.Point(448, 118);
            this.txtImporteC.Name = "txtImporteC";
            this.txtImporteC.ReadOnly = true;
            this.txtImporteC.Size = new System.Drawing.Size(228, 22);
            this.txtImporteC.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label4.Location = new System.Drawing.Point(373, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Importe";
            // 
            // txtFechaC
            // 
            this.txtFechaC.Location = new System.Drawing.Point(448, 36);
            this.txtFechaC.Name = "txtFechaC";
            this.txtFechaC.ReadOnly = true;
            this.txtFechaC.Size = new System.Drawing.Size(228, 22);
            this.txtFechaC.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label11.Location = new System.Drawing.Point(373, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Revise los datos de la compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Listado de las compras realizadas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 48);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra";
            // 
            // txtUsuarioC
            // 
            this.txtUsuarioC.Location = new System.Drawing.Point(133, 117);
            this.txtUsuarioC.Name = "txtUsuarioC";
            this.txtUsuarioC.ReadOnly = true;
            this.txtUsuarioC.Size = new System.Drawing.Size(204, 22);
            this.txtUsuarioC.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label8.Location = new System.Drawing.Point(16, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Usuario";
            // 
            // txtGastoC
            // 
            this.txtGastoC.Location = new System.Drawing.Point(448, 71);
            this.txtGastoC.Name = "txtGastoC";
            this.txtGastoC.ReadOnly = true;
            this.txtGastoC.Size = new System.Drawing.Size(228, 22);
            this.txtGastoC.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label9.Location = new System.Drawing.Point(373, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Gasto";
            // 
            // btnRegresarC
            // 
            this.btnRegresarC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegresarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarC.ForeColor = System.Drawing.Color.White;
            this.btnRegresarC.Location = new System.Drawing.Point(356, 471);
            this.btnRegresarC.Name = "btnRegresarC";
            this.btnRegresarC.Size = new System.Drawing.Size(90, 36);
            this.btnRegresarC.TabIndex = 19;
            this.btnRegresarC.Text = "Regresar";
            this.btnRegresarC.UseVisualStyleBackColor = false;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.panel1);
            this.Name = "Compra";
            this.Text = "Compra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFechaC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImporteC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolioC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button btnRegresarC;
        private System.Windows.Forms.TextBox txtGastoC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsuarioC;
        private System.Windows.Forms.Label label8;
    }
}