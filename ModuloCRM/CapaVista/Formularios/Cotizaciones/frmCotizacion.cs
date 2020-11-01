using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Formularios
{
    public partial class frmCotizacion : Form
    {
        public frmCotizacion()
        {
            InitializeComponent();
            txtCodEmp.Enabled = false;
            // txtNomEmp.Enabled = false;
            txtCodProd.Enabled = false;
            txtNomProd.Enabled = false;
            txtPrecProd.Enabled = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*frmEmpleado frm = new frmEmpleado();

            this.Hide();

            frm.Show();*/
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            /*frmProducto fp = new frmProducto();

            this.Hide();
            fp.Show();*/
        }
    }
}
