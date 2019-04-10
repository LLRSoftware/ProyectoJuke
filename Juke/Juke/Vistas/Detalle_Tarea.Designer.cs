namespace Juke.Vistas
{
    partial class Detalle_Tarea
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
            this.pMateriales = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Emp_Sexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pMateriales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMateriales
            // 
            this.pMateriales.Controls.Add(this.btnGuardar);
            this.pMateriales.Controls.Add(this.textBox1);
            this.pMateriales.Controls.Add(this.label1);
            this.pMateriales.Controls.Add(this.label6);
            this.pMateriales.Controls.Add(this.Emp_Sexo);
            this.pMateriales.Location = new System.Drawing.Point(1, 2);
            this.pMateriales.Name = "pMateriales";
            this.pMateriales.Size = new System.Drawing.Size(350, 178);
            this.pMateriales.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Material";
            // 
            // Emp_Sexo
            // 
            this.Emp_Sexo.FormattingEnabled = true;
            this.Emp_Sexo.Location = new System.Drawing.Point(104, 24);
            this.Emp_Sexo.Name = "Emp_Sexo";
            this.Emp_Sexo.Size = new System.Drawing.Size(207, 24);
            this.Emp_Sexo.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 44;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(104, 131);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Detalle_Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 181);
            this.Controls.Add(this.pMateriales);
            this.Name = "Detalle_Tarea";
            this.Text = "Detalle_Tarea";
            this.pMateriales.ResumeLayout(false);
            this.pMateriales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMateriales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Emp_Sexo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
    }
}