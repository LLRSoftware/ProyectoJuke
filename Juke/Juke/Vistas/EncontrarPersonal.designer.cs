namespace Juke.EncontrarPersonal
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
            ((System.ComponentModel.ISupportInitialize)(this.table_dts_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encontrar Personal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Elija el dato a buscar";
            // 
            // Emp_EP_Dato
            // 
            this.Emp_EP_Dato.FormattingEnabled = true;
            this.Emp_EP_Dato.Location = new System.Drawing.Point(330, 103);
            this.Emp_EP_Dato.Name = "Emp_EP_Dato";
            this.Emp_EP_Dato.Size = new System.Drawing.Size(318, 24);
            this.Emp_EP_Dato.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ingrese el dato a buscar";
            // 
            // Emp_EP_Cve
            // 
            this.Emp_EP_Cve.Location = new System.Drawing.Point(156, 197);
            this.Emp_EP_Cve.Name = "Emp_EP_Cve";
            this.Emp_EP_Cve.Size = new System.Drawing.Size(500, 22);
            this.Emp_EP_Cve.TabIndex = 9;
            // 
            // btn_EP_Lim
            // 
            this.btn_EP_Lim.Location = new System.Drawing.Point(496, 448);
            this.btn_EP_Lim.Name = "btn_EP_Lim";
            this.btn_EP_Lim.Size = new System.Drawing.Size(160, 30);
            this.btn_EP_Lim.TabIndex = 10;
            this.btn_EP_Lim.Text = "Limpiar";
            this.btn_EP_Lim.UseVisualStyleBackColor = true;
            this.btn_EP_Lim.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btn_EP_Nvo
            // 
            this.btn_EP_Nvo.Location = new System.Drawing.Point(299, 448);
            this.btn_EP_Nvo.Name = "btn_EP_Nvo";
            this.btn_EP_Nvo.Size = new System.Drawing.Size(160, 30);
            this.btn_EP_Nvo.TabIndex = 11;
            this.btn_EP_Nvo.Text = "Nuevo";
            this.btn_EP_Nvo.UseVisualStyleBackColor = true;
            this.btn_EP_Nvo.Click += new System.EventHandler(this.btn_EP_Nvo_Click);
            // 
            // btn_EP_Bus
            // 
            this.btn_EP_Bus.Location = new System.Drawing.Point(685, 197);
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
            this.table_dts_emp.Location = new System.Drawing.Point(12, 251);
            this.table_dts_emp.Name = "table_dts_emp";
            this.table_dts_emp.RowTemplate.Height = 24;
            this.table_dts_emp.Size = new System.Drawing.Size(909, 174);
            this.table_dts_emp.TabIndex = 13;
            this.table_dts_emp.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_dts_emp_CellMouseClick);
            // 
            // EncontrarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 502);
            this.Controls.Add(this.table_dts_emp);
            this.Controls.Add(this.btn_EP_Bus);
            this.Controls.Add(this.btn_EP_Nvo);
            this.Controls.Add(this.btn_EP_Lim);
            this.Controls.Add(this.Emp_EP_Cve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Emp_EP_Dato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "EncontrarPersonal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EncontrarPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_dts_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

