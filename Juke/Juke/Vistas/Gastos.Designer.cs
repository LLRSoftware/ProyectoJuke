namespace Juke.Vistas
{
    partial class Gastos
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
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.btnNomina = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompra);
            this.panel1.Controls.Add(this.btnNomina);
            this.panel1.Controls.Add(this.dgvGastos);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 454);
            this.panel1.TabIndex = 0;
            // 
            // dgvGastos
            // 
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Location = new System.Drawing.Point(12, 160);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.RowTemplate.Height = 24;
            this.dgvGastos.Size = new System.Drawing.Size(776, 280);
            this.dgvGastos.TabIndex = 0;
            this.dgvGastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNomina
            // 
            this.btnNomina.Location = new System.Drawing.Point(89, 55);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(186, 68);
            this.btnNomina.TabIndex = 1;
            this.btnNomina.Text = "Agregar Nómina";
            this.btnNomina.UseVisualStyleBackColor = true;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(507, 55);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(186, 68);
            this.btnCompra.TabIndex = 2;
            this.btnCompra.Text = "Agregar Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Gastos";
            this.Text = "Gastos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnNomina;
    }
}