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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtFecCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApeCli = new System.Windows.Forms.TextBox();
            this.txtNomCli = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnLimp = new System.Windows.Forms.Button();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(534, 259);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(187, 22);
            this.txtEstado.TabIndex = 34;
            this.txtEstado.Tag = "estado";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(367, 259);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 22);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado";
            // 
            // txtFecCli
            // 
            this.txtFecCli.Location = new System.Drawing.Point(534, 208);
            this.txtFecCli.Name = "txtFecCli";
            this.txtFecCli.Size = new System.Drawing.Size(187, 22);
            this.txtFecCli.TabIndex = 30;
            this.txtFecCli.Tag = "fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha Nacimiento";
            // 
            // txtApeCli
            // 
            this.txtApeCli.Location = new System.Drawing.Point(94, 305);
            this.txtApeCli.Name = "txtApeCli";
            this.txtApeCli.Size = new System.Drawing.Size(158, 22);
            this.txtApeCli.TabIndex = 26;
            this.txtApeCli.Tag = "apellido";
            // 
            // txtNomCli
            // 
            this.txtNomCli.Location = new System.Drawing.Point(94, 259);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.Size = new System.Drawing.Size(158, 22);
            this.txtNomCli.TabIndex = 25;
            this.txtNomCli.Tag = "nombre";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(94, 205);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(158, 22);
            this.txtCodCli.TabIndex = 24;
            this.txtCodCli.Tag = "codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.Location = new System.Drawing.Point(16, 205);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(50, 22);
            this.lbl_cod.TabIndex = 21;
            this.lbl_cod.Text = "Codigo";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cliente.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(12, 146);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(64, 29);
            this.lbl_cliente.TabIndex = 20;
            this.lbl_cliente.Text = "Cliente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(769, 196);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(634, 150);
            this.dgvCliente.TabIndex = 19;
            // 
            // btnLimp
            // 
            this.btnLimp.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.Image = global::CapaVista.Properties.Resources.logo_orange_ccleaner_clean_icon_134365;
            this.btnLimp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimp.Location = new System.Drawing.Point(1218, 361);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(87, 29);
            this.btnLimp.TabIndex = 29;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimp.UseVisualStyleBackColor = true;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 35;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1426, 467);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtFecCli);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApeCli);
            this.Controls.Add(this.txtNomCli);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.dgvCliente);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtFecCli;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApeCli;
        private System.Windows.Forms.TextBox txtNomCli;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private CapaVistaNavegador.Navegador navegador1;
    }
}