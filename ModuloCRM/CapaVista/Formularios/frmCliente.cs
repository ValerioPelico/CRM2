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

namespace CapaVista.Formularios
{
    public partial class frmCliente : Form
    {
        String emp = "TBL_CLIENTE";
        clsControladorCotizacion cn = new clsControladorCotizacion();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btn_ver_todo_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dgv_cliente.DataSource = dt;

        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            txt_ap_cli.Text = "";
            txt_cod_cli.Text = "";
            txt_fec_cli.Text = "";
            txt_nom_cli.Text = "";
        }
    }
}
