namespace CapaVista
{
    partial class venta
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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblidEmpleado = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.lblidVenta = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.lblNitCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(263, 255);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(260, 30);
            this.txtFecha.TabIndex = 58;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(44, 263);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 22);
            this.lblFecha.TabIndex = 57;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVentas.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblVentas.Location = new System.Drawing.Point(464, 34);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(96, 36);
            this.lblVentas.TabIndex = 53;
            this.lblVentas.Text = "Ventas";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(746, 135);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(260, 30);
            this.txtIdEmpleado.TabIndex = 50;
            // 
            // lblidEmpleado
            // 
            this.lblidEmpleado.AutoSize = true;
            this.lblidEmpleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblidEmpleado.Location = new System.Drawing.Point(579, 135);
            this.lblidEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidEmpleado.Name = "lblidEmpleado";
            this.lblidEmpleado.Size = new System.Drawing.Size(159, 22);
            this.lblidEmpleado.TabIndex = 49;
            this.lblidEmpleado.Text = "Código Empleado:";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(263, 127);
            this.txtIdVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(260, 30);
            this.txtIdVenta.TabIndex = 46;
            // 
            // lblidVenta
            // 
            this.lblidVenta.AutoSize = true;
            this.lblidVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblidVenta.Location = new System.Drawing.Point(44, 135);
            this.lblidVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidVenta.Name = "lblidVenta";
            this.lblidVenta.Size = new System.Drawing.Size(122, 22);
            this.lblidVenta.TabIndex = 45;
            this.lblidVenta.Text = "Codigo Venta:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(263, 195);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(260, 30);
            this.txtCliente.TabIndex = 62;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCliente.Location = new System.Drawing.Point(44, 203);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(142, 22);
            this.lblCliente.TabIndex = 61;
            this.lblCliente.Text = "Nombre Cliente:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(248, 810);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(260, 30);
            this.txtTotal.TabIndex = 64;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(44, 818);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(148, 22);
            this.lblTotal.TabIndex = 63;
            this.lblTotal.Text = "Total de la venta:";
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(34, 317);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(990, 456);
            this.dgvVentas.TabIndex = 65;
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Location = new System.Drawing.Point(746, 780);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(162, 71);
            this.btnGuardarVenta.TabIndex = 66;
            this.btnGuardarVenta.Text = "Guardar Venta";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            // 
            // txtNitCliente
            // 
            this.txtNitCliente.Location = new System.Drawing.Point(746, 185);
            this.txtNitCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.Size = new System.Drawing.Size(260, 30);
            this.txtNitCliente.TabIndex = 68;
            // 
            // lblNitCliente
            // 
            this.lblNitCliente.AutoSize = true;
            this.lblNitCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNitCliente.Location = new System.Drawing.Point(583, 193);
            this.lblNitCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNitCliente.Name = "lblNitCliente";
            this.lblNitCliente.Size = new System.Drawing.Size(110, 22);
            this.lblNitCliente.TabIndex = 67;
            this.lblNitCliente.Text = "NIT Cliente:";
            // 
            // venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1065, 895);
            this.Controls.Add(this.txtNitCliente);
            this.Controls.Add(this.lblNitCliente);
            this.Controls.Add(this.btnGuardarVenta);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.lblidEmpleado);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.lblidVenta);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "venta";
            this.Text = "venta";
            this.Load += new System.EventHandler(this.venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblidEmpleado;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label lblidVenta;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.TextBox txtNitCliente;
        private System.Windows.Forms.Label lblNitCliente;
    }
}