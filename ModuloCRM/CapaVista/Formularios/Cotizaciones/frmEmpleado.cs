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
    public partial class frmEmpleado : Form
    {
        String emp = "TBL_EMPLEADO";
        clsControladorCotizacion cn = new clsControladorCotizacion();
        public frmEmpleado()
        {
            InitializeComponent();
            txt_nomemp.Enabled = false;
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dgv_emp.DataSource = dt;

        }

        private void btn_bus_todo_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void dgv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_codemp.Text = dgv_emp.CurrentRow.Cells[0].Value.ToString();
                txt_nomemp.Text = dgv_emp.CurrentRow.Cells[1].Value.ToString();
            } catch
            {

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_codemp.Text = "";
            txt_nomemp.Text = "";
        }

        private void btn_ag_emp_Click(object sender, EventArgs e)
        {
            string cod = txt_codemp.Text;

            if (!(cod == "")) {
                frmCotizacion ct = new frmCotizacion();
                ct.txtCodEmp.Text = txt_codemp.Text;
                ct.txtNomEmp.Text = txt_nomemp.Text;
                MessageBox.Show("Agregado");
                ct.Show();
                this.Hide();
            }
        }
    }
}
