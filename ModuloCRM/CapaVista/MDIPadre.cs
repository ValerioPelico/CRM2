using CapaVista.Formularios;
using CapaVistaSeguridad;
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
            frmLogin login = new frmLogin();
            login.ShowDialog();
            textBox1.Text = login.usuario();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            //el numero 1 se debe cambiar por el numero de la aplicacion que se tiene asignado en la base de datos 
            if (seguridad.PermisosAcceso("1", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                // SE DEBE CAMBIAR BANCO POR EL FORMULARIO QUE SE DESEA ABRIR
                frmCliente variable = new frmCliente(textBox1.Text, this);
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            //el numero 1 se debe cambiar por el numero de la aplicacion que se tiene asignado en la base de datos 
            if (seguridad.PermisosAcceso("1", textBox1.Text) == 2)
            {
                bit.user(textBox1.Text);
                // SE DEBE CAMBIAR BANCO POR EL FORMULARIO QUE SE DESEA ABRIR
                frmVendedor variable = new frmVendedor(textBox1.Text, this);
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            //el numero 1 se debe cambiar por el numero de la aplicacion que se tiene asignado en la base de datos 
            if (seguridad.PermisosAcceso("1", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                // SE DEBE CAMBIAR BANCO POR EL FORMULARIO QUE SE DESEA ABRIR
                frmPedidos variable = new frmPedidos(textBox1.Text, this);
                variable.MdiParent = this;
                variable.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
    }
}
