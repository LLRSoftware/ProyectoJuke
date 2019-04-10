namespace Juke.Vistas
{
    partial class DetalleCompra
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaMaterial = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnTerminarCompra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveCompra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnAgregarCompra);
            this.panel1.Controls.Add(this.btnCancelarCompra);
            this.panel1.Controls.Add(this.btnTerminarCompra);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 534);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.txtClaveCompra);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ListaMaterial);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(15, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 175);
            this.panel3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Clave de compra";
            // 
            // ListaMaterial
            // 
            this.ListaMaterial.FormattingEnabled = true;
            this.ListaMaterial.Location = new System.Drawing.Point(474, 90);
            this.ListaMaterial.Name = "ListaMaterial";
            this.ListaMaterial.Size = new System.Drawing.Size(248, 24);
            this.ListaMaterial.TabIndex = 52;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(133, 42);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(589, 22);
            this.txtCantidad.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label5.Location = new System.Drawing.Point(15, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F);
            this.label4.Location = new System.Drawing.Point(389, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ingrese los datos";
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCompra.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCompra.Location = new System.Drawing.Point(438, 479);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(154, 43);
            this.btnAgregarCompra.TabIndex = 27;
            this.btnAgregarCompra.Text = "Agregar compra";
            this.btnAgregarCompra.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCompra.Location = new System.Drawing.Point(616, 480);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(154, 43);
            this.btnCancelarCompra.TabIndex = 26;
            this.btnCancelarCompra.Text = "Cancelar compra";
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            // 
            // btnTerminarCompra
            // 
            this.btnTerminarCompra.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTerminarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnTerminarCompra.ForeColor = System.Drawing.Color.White;
            this.btnTerminarCompra.Location = new System.Drawing.Point(244, 479);
            this.btnTerminarCompra.Name = "btnTerminarCompra";
            this.btnTerminarCompra.Size = new System.Drawing.Size(154, 43);
            this.btnTerminarCompra.TabIndex = 25;
            this.btnTerminarCompra.Text = "Terminar compra";
            this.btnTerminarCompra.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 48);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle de Compra";
            // 
            // txtClaveCompra
            // 
            this.txtClaveCompra.Location = new System.Drawing.Point(133, 94);
            this.txtClaveCompra.Name = "txtClaveCompra";
            this.txtClaveCompra.ReadOnly = true;
            this.txtClaveCompra.Size = new System.Drawing.Size(250, 22);
            this.txtClaveCompra.TabIndex = 54;
            // 
            // DetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.panel1);
            this.Name = "DetalleCompra";
            this.Text = "Detalle_Compra";
            this.Load += new System.EventHandler(this.DetalleCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnTerminarCompra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ListaMaterial;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveCompra;
    }
}