namespace Juke.Vistas
{
    partial class Agregar_Tarea
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.agregarTarea = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pMateriales = new System.Windows.Forms.Panel();
            this.Emp_Sexo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLote = new System.Windows.Forms.Label();
            this.agregarTarea.SuspendLayout();
            this.pMateriales.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción";
            // 
            // agregarTarea
            // 
            this.agregarTarea.Controls.Add(this.lbLote);
            this.agregarTarea.Controls.Add(this.panel2);
            this.agregarTarea.Controls.Add(this.pMateriales);
            this.agregarTarea.Controls.Add(this.btnAgregar);
            this.agregarTarea.Controls.Add(this.label4);
            this.agregarTarea.Location = new System.Drawing.Point(-1, 0);
            this.agregarTarea.Name = "agregarTarea";
            this.agregarTarea.Size = new System.Drawing.Size(927, 474);
            this.agregarTarea.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(463, 89);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(26, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(174, 85);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(187, 94);
            this.txtDescripcion.TabIndex = 7;
            // 
            // pMateriales
            // 
            this.pMateriales.Controls.Add(this.label6);
            this.pMateriales.Controls.Add(this.Emp_Sexo);
            this.pMateriales.Location = new System.Drawing.Point(496, 89);
            this.pMateriales.Name = "pMateriales";
            this.pMateriales.Size = new System.Drawing.Size(334, 86);
            this.pMateriales.TabIndex = 8;
            // 
            // Emp_Sexo
            // 
            this.Emp_Sexo.FormattingEnabled = true;
            this.Emp_Sexo.Location = new System.Drawing.Point(104, 24);
            this.Emp_Sexo.Name = "Emp_Sexo";
            this.Emp_Sexo.Size = new System.Drawing.Size(207, 24);
            this.Emp_Sexo.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(23, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 349);
            this.panel2.TabIndex = 9;
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
            // lbLote
            // 
            this.lbLote.AutoSize = true;
            this.lbLote.Location = new System.Drawing.Point(63, 49);
            this.lbLote.Name = "lbLote";
            this.lbLote.Size = new System.Drawing.Size(0, 17);
            this.lbLote.TabIndex = 10;
            // 
            // Agregar_Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 476);
            this.Controls.Add(this.agregarTarea);
            this.Name = "Agregar_Tarea";
            this.Text = "Tarea Nueva";
            this.Load += new System.EventHandler(this.Agregar_Tarea_Load);
            this.agregarTarea.ResumeLayout(false);
            this.agregarTarea.PerformLayout();
            this.pMateriales.ResumeLayout(false);
            this.pMateriales.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel agregarTarea;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pMateriales;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Emp_Sexo;
        private System.Windows.Forms.Label lbLote;
    }
}