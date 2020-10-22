using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Formularios.Cotizaciones
{
    public partial class frmProducto : Form
    {
        String emp = "TBL_PRODUCTO";
        clsControladorCotizacion cn = new clsControladorCotizacion();
        public frmProducto()
        {
            InitializeComponent();

            txt_nom_p.Enabled = false;
            txt_precio_p.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_cod_p.Text = dgv_prod.CurrentRow.Cells[0].Value.ToString();
                txt_nom_p.Text = dgv_prod.CurrentRow.Cells[1].Value.ToString();
                txt_precio_p.Text = dgv_prod.CurrentRow.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btn_limpia_Click(object sender, EventArgs e)
        {
            txt_cod_p.Text = "";
            txt_nom_p.Text = "";
            txt_precio_p.Text = "";
        }

        private void btn_todo_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dgv_prod.DataSource = dt;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string cod = txt_cod_p.Text;

            if (!(cod == ""))
            {
                frmCotizacion ct = new frmCotizacion();
                ct.txtCodProd.Text = txt_cod_p.Text;
                ct.txtNomProd.Text = txt_nom_p.Text;
                ct.txtPrecProd.Text = txt_precio_p.Text;
                MessageBox.Show("Agregado");
                ct.Show();
                this.Hide();
            }
        }
    }
}
