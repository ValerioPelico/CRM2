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
    public partial class frmCuentasPorCobrar : Form
    {
        public frmCuentasPorCobrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCuentasPorCobrar_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //el numero de aplicacion se debe cambiar por el numero asignado en la base de datos 
            navegador1.aplicacion = 1;
            //banco se debe cambiar por la tabla a la que se quiere hacer el mantenimiento
            navegador1.tbl = "cuentas_por_cobrar";
            //estado_banco se debe cambiar por el estado de la tabla a la que se desea hacer mantenimiento
            //navegador1.campoEstado = "";            
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
            navegador1.DatosActualizar = dtgDatos;
            navegador1.procActualizarData();
            navegador1.procCargar();
            //en la variable ayuda ruta debe colocar la carpeta y el archivo.chm de su proyecto de ayuda
            navegador1.ayudaRuta = "AyudasSeguridad/Modulo/ayuda.chm";
            //en ruta debe colocar la pagina html que quiere que se muestre cuendo se presione el boton ayuda
            navegador1.ruta = "Ayuda-Modulo.html";
        }
    }
}
