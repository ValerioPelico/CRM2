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
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.btnAgrEmp = new System.Windows.Forms.Button();
            this.lbl_cod_emp = new System.Windows.Forms.Label();
            this.txtCodVende = new System.Windows.Forms.TextBox();
            this.lbl_hr_ext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHrExtras = new System.Windows.Forms.TextBox();
            this.btnLimp = new System.Windows.Forms.Button();
            this.txtComisiones = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbl_venta = new System.Windows.Forms.Label();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.btnVentaRealizada = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lbl_comisiones = new System.Windows.Forms.Label();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Location = new System.Drawing.Point(624, 231);
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.RowHeadersWidth = 51;
            this.dgvComisiones.RowTemplate.Height = 24;
            this.dgvComisiones.Size = new System.Drawing.Size(776, 150);
            this.dgvComisiones.TabIndex = 0;
            // 
            // btnAgrEmp
            // 
            this.btnAgrEmp.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrEmp.Image = global::CapaVista.Properties.Resources.find_users_applications_search_2908;
            this.btnAgrEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgrEmp.Location = new System.Drawing.Point(347, 269);
            this.btnAgrEmp.Name = "btnAgrEmp";
            this.btnAgrEmp.Size = new System.Drawing.Size(146, 34);
            this.btnAgrEmp.TabIndex = 1;
            this.btnAgrEmp.Text = "Agregar Empleado";
            this.btnAgrEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgrEmp.UseVisualStyleBackColor = true;
            // 
            // lbl_cod_emp
            // 
            this.lbl_cod_emp.AutoSize = true;
            this.lbl_cod_emp.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_emp.Location = new System.Drawing.Point(53, 263);
            this.lbl_cod_emp.Name = "lbl_cod_emp";
            this.lbl_cod_emp.Size = new System.Drawing.Size(50, 22);
            this.lbl_cod_emp.TabIndex = 2;
            this.lbl_cod_emp.Text = "Codigo";
            // 
            // txtCodVende
            // 
            this.txtCodVende.Location = new System.Drawing.Point(164, 263);
            this.txtCodVende.Name = "txtCodVende";
            this.txtCodVende.Size = new System.Drawing.Size(133, 22);
            this.txtCodVende.TabIndex = 3;
            // 
            // lbl_hr_ext
            // 
            this.lbl_hr_ext.AutoSize = true;
            this.lbl_hr_ext.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hr_ext.Location = new System.Drawing.Point(53, 361);
            this.lbl_hr_ext.Name = "lbl_hr_ext";
            this.lbl_hr_ext.Size = new System.Drawing.Size(78, 20);
            this.lbl_hr_ext.TabIndex = 4;
            this.lbl_hr_ext.Text = "Horas Extras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comisiones";
            // 
            // txtHrExtras
            // 
            this.txtHrExtras.Location = new System.Drawing.Point(164, 361);
            this.txtHrExtras.Name = "txtHrExtras";
            this.txtHrExtras.Size = new System.Drawing.Size(133, 22);
            this.txtHrExtras.TabIndex = 6;
            // 
            // btnLimp
            // 
            this.btnLimp.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.Image = global::CapaVista.Properties.Resources.logo_orange_ccleaner_clean_icon_134365;
            this.btnLimp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimp.Location = new System.Drawing.Point(1095, 405);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(85, 36);
            this.btnLimp.TabIndex = 7;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimp.UseVisualStyleBackColor = true;
            // 
            // txtComisiones
            // 
            this.txtComisiones.Location = new System.Drawing.Point(164, 405);
            this.txtComisiones.Name = "txtComisiones";
            this.txtComisiones.Size = new System.Drawing.Size(133, 22);
            this.txtComisiones.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Image = global::CapaVista.Properties.Resources.construction_project_plan_building_architect_design_develop_73_icon_icons_com_60243;
            this.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalc.Location = new System.Drawing.Point(745, 415);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(95, 26);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(899, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 26);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.Location = new System.Drawing.Point(53, 446);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Size = new System.Drawing.Size(45, 22);
            this.lbl_venta.TabIndex = 11;
            this.lbl_venta.Text = "Venta";
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(164, 447);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(133, 22);
            this.txtVenta.TabIndex = 12;
            // 
            // btnVentaRealizada
            // 
            this.btnVentaRealizada.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaRealizada.Image = global::CapaVista.Properties.Resources.shoppingcart_77968;
            this.btnVentaRealizada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaRealizada.Location = new System.Drawing.Point(322, 318);
            this.btnVentaRealizada.Name = "btnVentaRealizada";
            this.btnVentaRealizada.Size = new System.Drawing.Size(189, 29);
            this.btnVentaRealizada.TabIndex = 13;
            this.btnVentaRealizada.Text = "Agregar Venta Realizada";
            this.btnVentaRealizada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentaRealizada.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Image = global::CapaVista.Properties.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335;
            this.btnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReg.Location = new System.Drawing.Point(1290, 405);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(96, 28);
            this.btnReg.TabIndex = 14;
            this.btnReg.Text = "Registrar";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // lbl_comisiones
            // 
            this.lbl_comisiones.AutoSize = true;
            this.lbl_comisiones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_comisiones.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comisiones.Location = new System.Drawing.Point(38, 210);
            this.lbl_comisiones.Name = "lbl_comisiones";
            this.lbl_comisiones.Size = new System.Drawing.Size(144, 24);
            this.lbl_comisiones.TabIndex = 15;
            this.lbl_comisiones.Text = "Registrar Comisiones";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(4, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 16;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1422, 523);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lbl_comisiones);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnVentaRealizada);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.lbl_venta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtComisiones);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.txtHrExtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_hr_ext);
            this.Controls.Add(this.txtCodVende);
            this.Controls.Add(this.lbl_cod_emp);
            this.Controls.Add(this.btnAgrEmp);
            this.Controls.Add(this.dgvComisiones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.Button btnAgrEmp;
        private System.Windows.Forms.Label lbl_cod_emp;
        private System.Windows.Forms.TextBox txtCodVende;
        private System.Windows.Forms.Label lbl_hr_ext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHrExtras;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.TextBox txtComisiones;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbl_venta;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Button btnVentaRealizada;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lbl_comisiones;
        private CapaVistaNavegador.Navegador navegador1;
    }
}