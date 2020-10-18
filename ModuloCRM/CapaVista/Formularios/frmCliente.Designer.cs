namespace CapaVista.Formularios
{
    partial class frmCliente
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
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cod_cli = new System.Windows.Forms.TextBox();
            this.txt_nom_cli = new System.Windows.Forms.TextBox();
            this.txt_ap_cli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_elim = new System.Windows.Forms.Button();
            this.btn_limp = new System.Windows.Forms.Button();
            this.txt_fec_cli = new System.Windows.Forms.TextBox();
            this.btn_ver_todo = new System.Windows.Forms.Button();
            this.btn_vnt_cli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(12, 232);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.RowHeadersWidth = 51;
            this.dgv_cliente.RowTemplate.Height = 24;
            this.dgv_cliente.Size = new System.Drawing.Size(776, 150);
            this.dgv_cliente.TabIndex = 0;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cliente.Location = new System.Drawing.Point(22, 13);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(51, 17);
            this.lbl_cliente.TabIndex = 1;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Location = new System.Drawing.Point(26, 72);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(52, 17);
            this.lbl_cod.TabIndex = 2;
            this.lbl_cod.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // txt_cod_cli
            // 
            this.txt_cod_cli.Location = new System.Drawing.Point(104, 72);
            this.txt_cod_cli.Name = "txt_cod_cli";
            this.txt_cod_cli.Size = new System.Drawing.Size(158, 22);
            this.txt_cod_cli.TabIndex = 5;
            // 
            // txt_nom_cli
            // 
            this.txt_nom_cli.Location = new System.Drawing.Point(104, 126);
            this.txt_nom_cli.Name = "txt_nom_cli";
            this.txt_nom_cli.Size = new System.Drawing.Size(158, 22);
            this.txt_nom_cli.TabIndex = 6;
            // 
            // txt_ap_cli
            // 
            this.txt_ap_cli.Location = new System.Drawing.Point(104, 172);
            this.txt_ap_cli.Name = "txt_ap_cli";
            this.txt_ap_cli.Size = new System.Drawing.Size(158, 22);
            this.txt_ap_cli.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha Nacimiento";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(84, 409);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(80, 29);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Guardar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(497, 184);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(125, 29);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar Codigo";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_elim
            // 
            this.btn_elim.Location = new System.Drawing.Point(223, 409);
            this.btn_elim.Name = "btn_elim";
            this.btn_elim.Size = new System.Drawing.Size(75, 29);
            this.btn_elim.TabIndex = 11;
            this.btn_elim.Text = "Eliminar";
            this.btn_elim.UseVisualStyleBackColor = true;
            // 
            // btn_limp
            // 
            this.btn_limp.Location = new System.Drawing.Point(712, 409);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(75, 29);
            this.btn_limp.TabIndex = 12;
            this.btn_limp.Text = "Limpiar";
            this.btn_limp.UseVisualStyleBackColor = true;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // txt_fec_cli
            // 
            this.txt_fec_cli.Location = new System.Drawing.Point(544, 75);
            this.txt_fec_cli.Name = "txt_fec_cli";
            this.txt_fec_cli.Size = new System.Drawing.Size(187, 22);
            this.txt_fec_cli.TabIndex = 13;
            // 
            // btn_ver_todo
            // 
            this.btn_ver_todo.Location = new System.Drawing.Point(658, 184);
            this.btn_ver_todo.Name = "btn_ver_todo";
            this.btn_ver_todo.Size = new System.Drawing.Size(98, 29);
            this.btn_ver_todo.TabIndex = 14;
            this.btn_ver_todo.Text = "Ver Todo";
            this.btn_ver_todo.UseVisualStyleBackColor = true;
            this.btn_ver_todo.Click += new System.EventHandler(this.btn_ver_todo_Click);
            // 
            // btn_vnt_cli
            // 
            this.btn_vnt_cli.BackColor = System.Drawing.Color.IndianRed;
            this.btn_vnt_cli.Location = new System.Drawing.Point(366, 12);
            this.btn_vnt_cli.Name = "btn_vnt_cli";
            this.btn_vnt_cli.Size = new System.Drawing.Size(156, 28);
            this.btn_vnt_cli.TabIndex = 15;
            this.btn_vnt_cli.Text = "Ver Compras Cliente";
            this.btn_vnt_cli.UseVisualStyleBackColor = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_vnt_cli);
            this.Controls.Add(this.btn_ver_todo);
            this.Controls.Add(this.txt_fec_cli);
            this.Controls.Add(this.btn_limp);
            this.Controls.Add(this.btn_elim);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ap_cli);
            this.Controls.Add(this.txt_nom_cli);
            this.Controls.Add(this.txt_cod_cli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.dgv_cliente);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cliente;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cod_cli;
        private System.Windows.Forms.TextBox txt_nom_cli;
        private System.Windows.Forms.TextBox txt_ap_cli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_elim;
        private System.Windows.Forms.Button btn_limp;
        private System.Windows.Forms.TextBox txt_fec_cli;
        private System.Windows.Forms.Button btn_ver_todo;
        private System.Windows.Forms.Button btn_vnt_cli;
    }
}