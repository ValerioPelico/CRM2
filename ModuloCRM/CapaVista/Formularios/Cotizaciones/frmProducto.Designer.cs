namespace CapaVista.Formularios.Cotizaciones
{
    partial class frmProducto
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
            this.dgv_prod = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_limpia = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_todo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cod_p = new System.Windows.Forms.TextBox();
            this.txt_nom_p = new System.Windows.Forms.TextBox();
            this.txt_precio_p = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_prod
            // 
            this.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod.Location = new System.Drawing.Point(12, 167);
            this.dgv_prod.Name = "dgv_prod";
            this.dgv_prod.RowHeadersWidth = 51;
            this.dgv_prod.RowTemplate.Height = 24;
            this.dgv_prod.Size = new System.Drawing.Size(819, 150);
            this.dgv_prod.TabIndex = 0;
            this.dgv_prod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(530, 129);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 32);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_limpia
            // 
            this.btn_limpia.Location = new System.Drawing.Point(683, 129);
            this.btn_limpia.Name = "btn_limpia";
            this.btn_limpia.Size = new System.Drawing.Size(75, 32);
            this.btn_limpia.TabIndex = 2;
            this.btn_limpia.Text = "Limpiar";
            this.btn_limpia.UseVisualStyleBackColor = true;
            this.btn_limpia.Click += new System.EventHandler(this.btn_limpia_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(530, 26);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_todo
            // 
            this.btn_todo.Location = new System.Drawing.Point(683, 25);
            this.btn_todo.Name = "btn_todo";
            this.btn_todo.Size = new System.Drawing.Size(75, 23);
            this.btn_todo.TabIndex = 4;
            this.btn_todo.Text = "Ver Todo";
            this.btn_todo.UseVisualStyleBackColor = true;
            this.btn_todo.Click += new System.EventHandler(this.btn_todo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // txt_cod_p
            // 
            this.txt_cod_p.Location = new System.Drawing.Point(135, 32);
            this.txt_cod_p.Name = "txt_cod_p";
            this.txt_cod_p.Size = new System.Drawing.Size(201, 22);
            this.txt_cod_p.TabIndex = 8;
            // 
            // txt_nom_p
            // 
            this.txt_nom_p.Location = new System.Drawing.Point(135, 69);
            this.txt_nom_p.Name = "txt_nom_p";
            this.txt_nom_p.Size = new System.Drawing.Size(201, 22);
            this.txt_nom_p.TabIndex = 9;
            // 
            // txt_precio_p
            // 
            this.txt_precio_p.Location = new System.Drawing.Point(135, 108);
            this.txt_precio_p.Name = "txt_precio_p";
            this.txt_precio_p.Size = new System.Drawing.Size(201, 22);
            this.txt_precio_p.TabIndex = 10;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(843, 329);
            this.Controls.Add(this.txt_precio_p);
            this.Controls.Add(this.txt_nom_p);
            this.Controls.Add(this.txt_cod_p);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_todo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_limpia);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dgv_prod);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_prod;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_limpia;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_todo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cod_p;
        private System.Windows.Forms.TextBox txt_nom_p;
        private System.Windows.Forms.TextBox txt_precio_p;
    }
}