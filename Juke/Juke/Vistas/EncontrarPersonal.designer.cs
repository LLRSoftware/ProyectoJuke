namespace Búsqueda_de_personal
{
    partial class EncontrarPersonal
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
            this.label5 = new System.Windows.Forms.Label();
            this.Emp_EP_Dato = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Emp_EP_Cve = new System.Windows.Forms.TextBox();
            this.btn_EP_Lim = new System.Windows.Forms.Button();
            this.btn_EP_Nvo = new System.Windows.Forms.Button();
            this.btn_EP_Bus = new System.Windows.Forms.Button();
            this.table_dts_emp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_dts_emp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encontrar Personal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Elija el dato a buscar";
            // 
            // Emp_EP_Dato
            // 
            this.Emp_EP_Dato.FormattingEnabled = true;
            this.Emp_EP_Dato.Location = new System.Drawing.Point(204, 47);
            this.Emp_EP_Dato.Name = "Emp_EP_Dato";
            this.Emp_EP_Dato.Size = new System.Drawing.Size(318, 24);
            this.Emp_EP_Dato.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ingrese el dato a buscar";
            // 
            // Emp_EP_Cve
            // 
            this.Emp_EP_Cve.Location = new System.Drawing.Point(30, 141);
            this.Emp_EP_Cve.Name = "Emp_EP_Cve";
            this.Emp_EP_Cve.Size = new System.Drawing.Size(500, 22);
            this.Emp_EP_Cve.TabIndex = 9;
            // 
            // btn_EP_Lim
            // 
            this.btn_EP_Lim.Location = new System.Drawing.Point(370, 392);
            this.btn_EP_Lim.Name = "btn_EP_Lim";
            this.btn_EP_Lim.Size = new System.Drawing.Size(160, 30);
            this.btn_EP_Lim.TabIndex = 10;
            this.btn_EP_Lim.Text = "Limpiar";
            this.btn_EP_Lim.UseVisualStyleBackColor = true;
            this.btn_EP_Lim.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btn_EP_Nvo
            // 
            this.btn_EP_Nvo.Location = new System.Drawing.Point(173, 392);
            this.btn_EP_Nvo.Name = "btn_EP_Nvo";
            this.btn_EP_Nvo.Size = new System.Drawing.Size(160, 30);
            this.btn_EP_Nvo.TabIndex = 11;
            this.btn_EP_Nvo.Text = "Nuevo";
            this.btn_EP_Nvo.UseVisualStyleBackColor = true;
            // 
            // btn_EP_Bus
            // 
            this.btn_EP_Bus.Location = new System.Drawing.Point(559, 141);
            this.btn_EP_Bus.Name = "btn_EP_Bus";
            this.btn_EP_Bus.Size = new System.Drawing.Size(160, 30);
            this.btn_EP_Bus.TabIndex = 12;
            this.btn_EP_Bus.Text = "Buscar";
            this.btn_EP_Bus.UseVisualStyleBackColor = true;
            this.btn_EP_Bus.Click += new System.EventHandler(this.btn_EP_Bus_Click);
            // 
            // table_dts_emp
            // 
            this.table_dts_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_dts_emp.Location = new System.Drawing.Point(30, 195);
            this.table_dts_emp.Name = "table_dts_emp";
            this.table_dts_emp.RowTemplate.Height = 24;
            this.table_dts_emp.Size = new System.Drawing.Size(689, 174);
            this.table_dts_emp.TabIndex = 13;
            this.table_dts_emp.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_dts_emp_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.table_dts_emp);
            this.panel1.Controls.Add(this.btn_EP_Bus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_EP_Nvo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_EP_Lim);
            this.panel1.Controls.Add(this.Emp_EP_Dato);
            this.panel1.Controls.Add(this.Emp_EP_Cve);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(183, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 451);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 500);
            this.panel3.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(33, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Material";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(33, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "R.R.H.H.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(33, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ventas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(26, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = " Compras";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "<- Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(47, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menú";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 48);
            this.panel2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Busqueda de Personal";
            // 
            // EncontrarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "EncontrarPersonal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EncontrarPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_dts_emp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Emp_EP_Dato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Emp_EP_Cve;
        private System.Windows.Forms.Button btn_EP_Lim;
        private System.Windows.Forms.Button btn_EP_Nvo;
        private System.Windows.Forms.Button btn_EP_Bus;
        private System.Windows.Forms.DataGridView table_dts_emp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}

