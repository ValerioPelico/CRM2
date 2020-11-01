namespace CapaVista.Formularios
{
    partial class frmVendedor
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
            this.lbl_comisiones = new System.Windows.Forms.Label();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.lbl_venta = new System.Windows.Forms.Label();
            this.txtComisiones = new System.Windows.Forms.TextBox();
            this.btnLimp = new System.Windows.Forms.Button();
            this.txtHrExtras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_hr_ext = new System.Windows.Forms.Label();
            this.txtCodVende = new System.Windows.Forms.TextBox();
            this.lbl_cod_emp = new System.Windows.Forms.Label();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_comisiones
            // 
            this.lbl_comisiones.AutoSize = true;
            this.lbl_comisiones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_comisiones.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comisiones.Location = new System.Drawing.Point(112, 157);
            this.lbl_comisiones.Name = "lbl_comisiones";
            this.lbl_comisiones.Size = new System.Drawing.Size(144, 24);
            this.lbl_comisiones.TabIndex = 31;
            this.lbl_comisiones.Text = "Registrar Comisiones";
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(238, 340);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(133, 22);
            this.txtVenta.TabIndex = 28;
            this.txtVenta.Tag = "venta";
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.Location = new System.Drawing.Point(127, 339);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Size = new System.Drawing.Size(45, 22);
            this.lbl_venta.TabIndex = 27;
            this.lbl_venta.Text = "Venta";
            // 
            // txtComisiones
            // 
            this.txtComisiones.Location = new System.Drawing.Point(238, 298);
            this.txtComisiones.Name = "txtComisiones";
            this.txtComisiones.Size = new System.Drawing.Size(133, 22);
            this.txtComisiones.TabIndex = 24;
            this.txtComisiones.Tag = "comisiones";
            // 
            // btnLimp
            // 
            this.btnLimp.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.Image = global::CapaVista.Properties.Resources.logo_orange_ccleaner_clean_icon_134365;
            this.btnLimp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimp.Location = new System.Drawing.Point(906, 375);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(85, 36);
            this.btnLimp.TabIndex = 23;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimp.UseVisualStyleBackColor = true;
            // 
            // txtHrExtras
            // 
            this.txtHrExtras.Location = new System.Drawing.Point(238, 254);
            this.txtHrExtras.Name = "txtHrExtras";
            this.txtHrExtras.Size = new System.Drawing.Size(133, 22);
            this.txtHrExtras.TabIndex = 22;
            this.txtHrExtras.Tag = "horas_extras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Comisiones";
            // 
            // lbl_hr_ext
            // 
            this.lbl_hr_ext.AutoSize = true;
            this.lbl_hr_ext.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hr_ext.Location = new System.Drawing.Point(127, 254);
            this.lbl_hr_ext.Name = "lbl_hr_ext";
            this.lbl_hr_ext.Size = new System.Drawing.Size(78, 20);
            this.lbl_hr_ext.TabIndex = 20;
            this.lbl_hr_ext.Text = "Horas Extras";
            // 
            // txtCodVende
            // 
            this.txtCodVende.Location = new System.Drawing.Point(238, 210);
            this.txtCodVende.Name = "txtCodVende";
            this.txtCodVende.Size = new System.Drawing.Size(133, 22);
            this.txtCodVende.TabIndex = 19;
            this.txtCodVende.Tag = "pk_idvendedor";
            // 
            // lbl_cod_emp
            // 
            this.lbl_cod_emp.AutoSize = true;
            this.lbl_cod_emp.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_emp.Location = new System.Drawing.Point(127, 210);
            this.lbl_cod_emp.Name = "lbl_cod_emp";
            this.lbl_cod_emp.Size = new System.Drawing.Size(50, 22);
            this.lbl_cod_emp.TabIndex = 18;
            this.lbl_cod_emp.Text = "Codigo";
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Location = new System.Drawing.Point(590, 213);
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.RowHeadersWidth = 51;
            this.dgvComisiones.RowTemplate.Height = 24;
            this.dgvComisiones.Size = new System.Drawing.Size(776, 150);
            this.dgvComisiones.TabIndex = 16;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(8, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 32;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(238, 390);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(133, 22);
            this.txtEstado.TabIndex = 36;
            this.txtEstado.Tag = "estado";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(130, 389);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 22);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado";
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1420, 459);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lbl_comisiones);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.lbl_venta);
            this.Controls.Add(this.txtComisiones);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.txtHrExtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_hr_ext);
            this.Controls.Add(this.txtCodVende);
            this.Controls.Add(this.lbl_cod_emp);
            this.Controls.Add(this.dgvComisiones);
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_comisiones;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label lbl_venta;
        private System.Windows.Forms.TextBox txtComisiones;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.TextBox txtHrExtras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_hr_ext;
        private System.Windows.Forms.TextBox txtCodVende;
        private System.Windows.Forms.Label lbl_cod_emp;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}