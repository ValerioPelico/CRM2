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
                ct.txt_nomemp.Text = txt_nomemp.Text;
                MessageBox.Show("Agregado");
                ct.Show();
                this.Hide();
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //el numero de aplicacion se debe cambiar por el numero asignado en la base de datos 
            navegador1.aplicacion = 1;
            //banco se debe cambiar por la tabla a la que se quiere hacer el mantenimiento
            navegador1.tbl = "banco";
            //estado_banco se debe cambiar por el estado de la tabla a la que se desea hacer mantenimiento
            navegador1.campoEstado = "estado_banco";
            //navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
                {
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);
                    }
                }
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            //el dataGridView1 se debe cambiar por el que se tiene en el formulario
            navegador1.DatosActualizar = dgv_emp;
            navegador1.procActualizarData();
            navegador1.procCargar();
            //en la variable ayuda ruta debe colocar la carpeta y el archivo.chm de su proyecto de ayuda
            navegador1.ayudaRuta = "AyudasSeguridad/Modulo/ayuda.chm";
            //en ruta debe colocar la pagina html que quiere que se muestre cuendo se presione el boton ayuda
            navegador1.ruta = "Ayuda-Modulo.html";
        }
    }
}
