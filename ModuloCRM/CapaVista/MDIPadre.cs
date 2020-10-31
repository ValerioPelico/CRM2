using CapaVista.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MDIPadre : Form
    {
        public MDIPadre()
        {
            InitializeComponent();
        }

        private void MDIPadre_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cli = new frmCliente();
            cli.MdiParent = this;
            cli.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor ven = new frmVendedor();
            ven.MdiParent = this;
            ven.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidos ped = new frmPedidos();
            ped.MdiParent = this;
            ped.Show();
        }
    }
}
