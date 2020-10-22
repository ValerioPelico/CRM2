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
            this.lbl_cod_emp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_prod = new System.Windows.Forms.Label();
            this.btnProd = new System.Windows.Forms.Button();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.txtPrecProd = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.lbl_prec_prod = new System.Windows.Forms.Label();
            this.lbl_nom_prod = new System.Windows.Forms.Label();
            this.lbl_cod_prod = new System.Windows.Forms.Label();
            this.txtCodEmp = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lbl_emp = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAgregarCot = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.btnVerTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 471);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_generar
            // 
            this.lbl_generar.AutoSize = true;
            this.lbl_generar.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generar.Location = new System.Drawing.Point(510, 650);
            this.lbl_generar.Name = "lbl_generar";
            this.lbl_generar.Size = new System.Drawing.Size(125, 22);
            this.lbl_generar.TabIndex = 1;
            this.lbl_generar.Text = "Generar Cotizacion";
            // 
            // lbl_cod_emp
            // 
            this.lbl_cod_emp.AutoSize = true;
            this.lbl_cod_emp.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_emp.Location = new System.Drawing.Point(29, 51);
            this.lbl_cod_emp.Name = "lbl_cod_emp";
            this.lbl_cod_emp.Size = new System.Drawing.Size(113, 22);
            this.lbl_cod_emp.TabIndex = 3;
            this.lbl_cod_emp.Text = "Codigo Empleado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVerTodo);
            this.panel1.Controls.Add(this.dgvProducto);
            this.panel1.Controls.Add(this.lbl_prod);
            this.panel1.Controls.Add(this.btnProd);
            this.panel1.Controls.Add(this.txtNomProd);
            this.panel1.Controls.Add(this.txtPrecProd);
            this.panel1.Controls.Add(this.txtCodProd);
            this.panel1.Controls.Add(this.lbl_prec_prod);
            this.panel1.Controls.Add(this.lbl_nom_prod);
            this.panel1.Controls.Add(this.lbl_cod_prod);
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 311);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_prod
            // 
            this.lbl_prod.AutoSize = true;
            this.lbl_prod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_prod.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prod.Location = new System.Drawing.Point(32, 4);
            this.lbl_prod.Name = "lbl_prod";
            this.lbl_prod.Size = new System.Drawing.Size(66, 24);
            this.lbl_prod.TabIndex = 7;
            this.lbl_prod.Text = "Producto";
            // 
            // btnProd
            // 
            this.btnProd.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.Image = global::CapaVista.Properties.Resources.find_users_applications_search_2908;
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProd.Location = new System.Drawing.Point(398, 123);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(131, 32);
            this.btnProd.TabIndex = 6;
            this.btnProd.Text = "Buscar Codigo";
            this.btnProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // txtNomProd
            // 
            this.txtNomProd.Location = new System.Drawing.Point(533, 53);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(220, 22);
            this.txtNomProd.TabIndex = 5;
            // 
            // txtPrecProd
            // 
            this.txtPrecProd.Location = new System.Drawing.Point(131, 104);
            this.txtPrecProd.Name = "txtPrecProd";
            this.txtPrecProd.Size = new System.Drawing.Size(167, 22);
            this.txtPrecProd.TabIndex = 4;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(131, 54);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(168, 22);
            this.txtCodProd.TabIndex = 3;
            // 
            // lbl_prec_prod
            // 
            this.lbl_prec_prod.AutoSize = true;
            this.lbl_prec_prod.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prec_prod.Location = new System.Drawing.Point(13, 104);
            this.lbl_prec_prod.Name = "lbl_prec_prod";
            this.lbl_prec_prod.Size = new System.Drawing.Size(107, 22);
            this.lbl_prec_prod.TabIndex = 2;
            this.lbl_prec_prod.Text = "Precio Producto";
            // 
            // lbl_nom_prod
            // 
            this.lbl_nom_prod.AutoSize = true;
            this.lbl_nom_prod.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_prod.Location = new System.Drawing.Point(394, 54);
            this.lbl_nom_prod.Name = "lbl_nom_prod";
            this.lbl_nom_prod.Size = new System.Drawing.Size(114, 22);
            this.lbl_nom_prod.TabIndex = 1;
            this.lbl_nom_prod.Text = "Nombre Producto";
            // 
            // lbl_cod_prod
            // 
            this.lbl_cod_prod.AutoSize = true;
            this.lbl_cod_prod.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_prod.Location = new System.Drawing.Point(12, 54);
            this.lbl_cod_prod.Name = "lbl_cod_prod";
            this.lbl_cod_prod.Size = new System.Drawing.Size(109, 22);
            this.lbl_cod_prod.TabIndex = 0;
            this.lbl_cod_prod.Text = "Codigo Producto";
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.Location = new System.Drawing.Point(169, 48);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.Size = new System.Drawing.Size(189, 22);
            this.txtCodEmp.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 685);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // lbl_emp
            // 
            this.lbl_emp.AutoSize = true;
            this.lbl_emp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_emp.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp.Location = new System.Drawing.Point(32, 9);
            this.lbl_emp.Name = "lbl_emp";
            this.lbl_emp.Size = new System.Drawing.Size(71, 24);
            this.lbl_emp.TabIndex = 11;
            this.lbl_emp.Text = "Empleado";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(250, 650);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(41, 22);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(297, 650);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 13;
            // 
            // btnAgregarCot
            // 
            this.btnAgregarCot.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCot.Image = global::CapaVista.Properties.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335;
            this.btnAgregarCot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCot.Location = new System.Drawing.Point(501, 432);
            this.btnAgregarCot.Name = "btnAgregarCot";
            this.btnAgregarCot.Size = new System.Drawing.Size(221, 33);
            this.btnAgregarCot.TabIndex = 8;
            this.btnAgregarCot.Text = "Registrar Producto";
            this.btnAgregarCot.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = global::CapaVista.Properties.Resources.construction_project_plan_building_architect_design_develop_73_icon_icons_com_60243;
            this.btnGenerar.Location = new System.Drawing.Point(641, 641);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(96, 40);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(100, 161);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.RowTemplate.Height = 24;
            this.dgvProducto.Size = new System.Drawing.Size(600, 150);
            this.dgvProducto.TabIndex = 8;
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.Image = global::CapaVista.Properties.Resources.search_locate_find_icon_icons_com_67287;
            this.btnVerTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTodo.Location = new System.Drawing.Point(609, 123);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(99, 32);
            this.btnVerTodo.TabIndex = 9;
            this.btnVerTodo.Text = "Ver Todo";
            this.btnVerTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerTodo.UseVisualStyleBackColor = true;
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(882, 685);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_emp);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnAgregarCot);
            this.Controls.Add(this.txtCodEmp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_cod_emp);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lbl_generar);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCotizacion";
            this.Text = "frmCotizacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_generar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lbl_cod_emp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_prec_prod;
        private System.Windows.Forms.Label lbl_nom_prod;
        private System.Windows.Forms.Label lbl_cod_prod;
        private System.Windows.Forms.Button btnAgregarCot;
        private System.Windows.Forms.Label lbl_prod;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lbl_emp;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtCodEmp;
        public System.Windows.Forms.TextBox txtNomProd;
        public System.Windows.Forms.TextBox txtPrecProd;
        public System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.DataGridView dgvProducto;
    }
}