namespace CapaVista.Formularios.Cotizaciones
{
    partial class frmEmpleado
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
            this.dgv_emp = new System.Windows.Forms.DataGridView();
            this.btn_ag_emp = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_nomemp = new System.Windows.Forms.Label();
            this.lbl_codemp = new System.Windows.Forms.Label();
            this.txt_nomemp = new System.Windows.Forms.TextBox();
            this.txt_codemp = new System.Windows.Forms.TextBox();
            this.btn_bus = new System.Windows.Forms.Button();
            this.btn_bus_todo = new System.Windows.Forms.Button();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_emp
            // 
            this.dgv_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp.Location = new System.Drawing.Point(23, 354);
            this.dgv_emp.Name = "dgv_emp";
            this.dgv_emp.RowHeadersWidth = 51;
            this.dgv_emp.RowTemplate.Height = 24;
            this.dgv_emp.Size = new System.Drawing.Size(820, 150);
            this.dgv_emp.TabIndex = 0;
            this.dgv_emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_CellContentClick);
            // 
            // btn_ag_emp
            // 
            this.btn_ag_emp.Location = new System.Drawing.Point(497, 318);
            this.btn_ag_emp.Name = "btn_ag_emp";
            this.btn_ag_emp.Size = new System.Drawing.Size(94, 30);
            this.btn_ag_emp.TabIndex = 1;
            this.btn_ag_emp.Text = "Agregar";
            this.btn_ag_emp.UseVisualStyleBackColor = true;
            this.btn_ag_emp.Click += new System.EventHandler(this.btn_ag_emp_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(637, 318);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(95, 30);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_nomemp
            // 
            this.lbl_nomemp.AutoSize = true;
            this.lbl_nomemp.Location = new System.Drawing.Point(24, 262);
            this.lbl_nomemp.Name = "lbl_nomemp";
            this.lbl_nomemp.Size = new System.Drawing.Size(58, 17);
            this.lbl_nomemp.TabIndex = 3;
            this.lbl_nomemp.Text = "Nombre";
            // 
            // lbl_codemp
            // 
            this.lbl_codemp.AutoSize = true;
            this.lbl_codemp.Location = new System.Drawing.Point(27, 201);
            this.lbl_codemp.Name = "lbl_codemp";
            this.lbl_codemp.Size = new System.Drawing.Size(52, 17);
            this.lbl_codemp.TabIndex = 4;
            this.lbl_codemp.Text = "Codigo";
            // 
            // txt_nomemp
            // 
            this.txt_nomemp.Location = new System.Drawing.Point(101, 262);
            this.txt_nomemp.Name = "txt_nomemp";
            this.txt_nomemp.Size = new System.Drawing.Size(184, 22);
            this.txt_nomemp.TabIndex = 5;
            // 
            // txt_codemp
            // 
            this.txt_codemp.Location = new System.Drawing.Point(101, 201);
            this.txt_codemp.Name = "txt_codemp";
            this.txt_codemp.Size = new System.Drawing.Size(184, 22);
            this.txt_codemp.TabIndex = 6;
            // 
            // btn_bus
            // 
            this.btn_bus.Location = new System.Drawing.Point(437, 198);
            this.btn_bus.Name = "btn_bus";
            this.btn_bus.Size = new System.Drawing.Size(75, 23);
            this.btn_bus.TabIndex = 7;
            this.btn_bus.Text = "Buscar";
            this.btn_bus.UseVisualStyleBackColor = true;
            // 
            // btn_bus_todo
            // 
            this.btn_bus_todo.Location = new System.Drawing.Point(559, 198);
            this.btn_bus_todo.Name = "btn_bus_todo";
            this.btn_bus_todo.Size = new System.Drawing.Size(93, 25);
            this.btn_bus_todo.TabIndex = 8;
            this.btn_bus_todo.Text = "Ver Todos";
            this.btn_bus_todo.UseVisualStyleBackColor = true;
            this.btn_bus_todo.Click += new System.EventHandler(this.btn_bus_todo_Click);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1418, 119);
            this.navegador1.TabIndex = 9;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1444, 522);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.btn_bus_todo);
            this.Controls.Add(this.btn_bus);
            this.Controls.Add(this.txt_codemp);
            this.Controls.Add(this.txt_nomemp);
            this.Controls.Add(this.lbl_codemp);
            this.Controls.Add(this.lbl_nomemp);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_ag_emp);
            this.Controls.Add(this.dgv_emp);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_emp;
        private System.Windows.Forms.Button btn_ag_emp;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_nomemp;
        private System.Windows.Forms.Label lbl_codemp;
        private System.Windows.Forms.TextBox txt_nomemp;
        private System.Windows.Forms.TextBox txt_codemp;
        private System.Windows.Forms.Button btn_bus;
        private System.Windows.Forms.Button btn_bus_todo;
        private CapaVistaNavegador.Navegador navegador1;
    }
}