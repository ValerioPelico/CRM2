namespace CapaVista.Formularios
{
    partial class frmCotizacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_generar = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.lbl_cod_emp = new System.Windows.Forms.Label();
            this.lbl_nom_emp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_prod = new System.Windows.Forms.Label();
            this.btn_prod = new System.Windows.Forms.Button();
            this.txt_nom_prod = new System.Windows.Forms.TextBox();
            this.txt_prec_prod = new System.Windows.Forms.TextBox();
            this.txt_cod_prod = new System.Windows.Forms.TextBox();
            this.lbl_prec_prod = new System.Windows.Forms.Label();
            this.lbl_nom_prod = new System.Windows.Forms.Label();
            this.lbl_cod_prod = new System.Windows.Forms.Label();
            this.txt_cod_emp = new System.Windows.Forms.TextBox();
            this.txt_nom_emp = new System.Windows.Forms.TextBox();
            this.btn_agregar_cot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lbl_emp = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_generar
            // 
            this.lbl_generar.AutoSize = true;
            this.lbl_generar.Location = new System.Drawing.Point(512, 551);
            this.lbl_generar.Name = "lbl_generar";
            this.lbl_generar.Size = new System.Drawing.Size(130, 17);
            this.lbl_generar.TabIndex = 1;
            this.lbl_generar.Text = "Generar Cotizacion";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(648, 545);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(96, 23);
            this.btn_generar.TabIndex = 2;
            this.btn_generar.UseVisualStyleBackColor = true;
            // 
            // lbl_cod_emp
            // 
            this.lbl_cod_emp.AutoSize = true;
            this.lbl_cod_emp.Location = new System.Drawing.Point(29, 51);
            this.lbl_cod_emp.Name = "lbl_cod_emp";
            this.lbl_cod_emp.Size = new System.Drawing.Size(119, 17);
            this.lbl_cod_emp.TabIndex = 3;
            this.lbl_cod_emp.Text = "Codigo Empleado";
            // 
            // lbl_nom_emp
            // 
            this.lbl_nom_emp.AutoSize = true;
            this.lbl_nom_emp.Location = new System.Drawing.Point(28, 85);
            this.lbl_nom_emp.Name = "lbl_nom_emp";
            this.lbl_nom_emp.Size = new System.Drawing.Size(125, 17);
            this.lbl_nom_emp.TabIndex = 4;
            this.lbl_nom_emp.Text = "Nombre Empleado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_prod);
            this.panel1.Controls.Add(this.btn_prod);
            this.panel1.Controls.Add(this.txt_nom_prod);
            this.panel1.Controls.Add(this.txt_prec_prod);
            this.panel1.Controls.Add(this.txt_cod_prod);
            this.panel1.Controls.Add(this.lbl_prec_prod);
            this.panel1.Controls.Add(this.lbl_nom_prod);
            this.panel1.Controls.Add(this.lbl_cod_prod);
            this.panel1.Location = new System.Drawing.Point(0, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 147);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_prod
            // 
            this.lbl_prod.AutoSize = true;
            this.lbl_prod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_prod.Location = new System.Drawing.Point(32, 4);
            this.lbl_prod.Name = "lbl_prod";
            this.lbl_prod.Size = new System.Drawing.Size(65, 17);
            this.lbl_prod.TabIndex = 7;
            this.lbl_prod.Text = "Producto";
            // 
            // btn_prod
            // 
            this.btn_prod.Location = new System.Drawing.Point(397, 102);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(175, 32);
            this.btn_prod.TabIndex = 6;
            this.btn_prod.Text = "Agregar Producto";
            this.btn_prod.UseVisualStyleBackColor = true;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // txt_nom_prod
            // 
            this.txt_nom_prod.Location = new System.Drawing.Point(533, 53);
            this.txt_nom_prod.Name = "txt_nom_prod";
            this.txt_nom_prod.Size = new System.Drawing.Size(220, 22);
            this.txt_nom_prod.TabIndex = 5;
            // 
            // txt_prec_prod
            // 
            this.txt_prec_prod.Location = new System.Drawing.Point(131, 104);
            this.txt_prec_prod.Name = "txt_prec_prod";
            this.txt_prec_prod.Size = new System.Drawing.Size(167, 22);
            this.txt_prec_prod.TabIndex = 4;
            // 
            // txt_cod_prod
            // 
            this.txt_cod_prod.Location = new System.Drawing.Point(131, 54);
            this.txt_cod_prod.Name = "txt_cod_prod";
            this.txt_cod_prod.Size = new System.Drawing.Size(168, 22);
            this.txt_cod_prod.TabIndex = 3;
            // 
            // lbl_prec_prod
            // 
            this.lbl_prec_prod.AutoSize = true;
            this.lbl_prec_prod.Location = new System.Drawing.Point(13, 104);
            this.lbl_prec_prod.Name = "lbl_prec_prod";
            this.lbl_prec_prod.Size = new System.Drawing.Size(109, 17);
            this.lbl_prec_prod.TabIndex = 2;
            this.lbl_prec_prod.Text = "Precio Producto";
            // 
            // lbl_nom_prod
            // 
            this.lbl_nom_prod.AutoSize = true;
            this.lbl_nom_prod.Location = new System.Drawing.Point(394, 54);
            this.lbl_nom_prod.Name = "lbl_nom_prod";
            this.lbl_nom_prod.Size = new System.Drawing.Size(119, 17);
            this.lbl_nom_prod.TabIndex = 1;
            this.lbl_nom_prod.Text = "Nombre Producto";
            // 
            // lbl_cod_prod
            // 
            this.lbl_cod_prod.AutoSize = true;
            this.lbl_cod_prod.Location = new System.Drawing.Point(12, 54);
            this.lbl_cod_prod.Name = "lbl_cod_prod";
            this.lbl_cod_prod.Size = new System.Drawing.Size(113, 17);
            this.lbl_cod_prod.TabIndex = 0;
            this.lbl_cod_prod.Text = "Codigo Producto";
            // 
            // txt_cod_emp
            // 
            this.txt_cod_emp.Location = new System.Drawing.Point(169, 48);
            this.txt_cod_emp.Name = "txt_cod_emp";
            this.txt_cod_emp.Size = new System.Drawing.Size(189, 22);
            this.txt_cod_emp.TabIndex = 6;
            // 
            // txt_nom_emp
            // 
            this.txt_nom_emp.Location = new System.Drawing.Point(169, 82);
            this.txt_nom_emp.Name = "txt_nom_emp";
            this.txt_nom_emp.Size = new System.Drawing.Size(189, 22);
            this.txt_nom_emp.TabIndex = 7;
            // 
            // btn_agregar_cot
            // 
            this.btn_agregar_cot.Location = new System.Drawing.Point(503, 333);
            this.btn_agregar_cot.Name = "btn_agregar_cot";
            this.btn_agregar_cot.Size = new System.Drawing.Size(221, 33);
            this.btn_agregar_cot.TabIndex = 8;
            this.btn_agregar_cot.Text = "Agregar Producto";
            this.btn_agregar_cot.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar Vendedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 588);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // lbl_emp
            // 
            this.lbl_emp.AutoSize = true;
            this.lbl_emp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_emp.Location = new System.Drawing.Point(32, 9);
            this.lbl_emp.Name = "lbl_emp";
            this.lbl_emp.Size = new System.Drawing.Size(71, 17);
            this.lbl_emp.TabIndex = 11;
            this.lbl_emp.Text = "Empleado";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(252, 551);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(40, 17);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 551);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(879, 588);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_emp);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregar_cot);
            this.Controls.Add(this.txt_nom_emp);
            this.Controls.Add(this.txt_cod_emp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_nom_emp);
            this.Controls.Add(this.lbl_cod_emp);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.lbl_generar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCotizacion";
            this.Text = "frmCotizacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_generar;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label lbl_cod_emp;
        private System.Windows.Forms.Label lbl_nom_emp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_prec_prod;
        private System.Windows.Forms.Label lbl_nom_prod;
        private System.Windows.Forms.Label lbl_cod_prod;
        private System.Windows.Forms.Button btn_agregar_cot;
        private System.Windows.Forms.Label lbl_prod;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lbl_emp;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txt_cod_emp;
        public System.Windows.Forms.TextBox txt_nom_emp;
        public System.Windows.Forms.TextBox txt_nom_prod;
        public System.Windows.Forms.TextBox txt_prec_prod;
        public System.Windows.Forms.TextBox txt_cod_prod;
    }
}