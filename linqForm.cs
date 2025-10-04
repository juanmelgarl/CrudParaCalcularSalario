using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApps
{
    public partial class linqForm : Form
    {
        private ClienteForm clienteForm;
        public linqForm(ClienteForm form)
        {
            InitializeComponent();
            clienteForm = form;
        }

        private void linqForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            var buscar = Form1.personalst.Where(x => x.Nombre.ToLower() == nombre).ToList();
            clienteForm.actualizar(buscar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var aumento = Form1.personalst.Where(x => x.aumento > 10).ToList();

            clienteForm.actualizar(aumento);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var busqueda = Form1.personalst.OrderByDescending(x => x.sueldo).ToList();
            clienteForm.actualizar(busqueda);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var buscar = Form1.personalst.Where(x => x.sueldoFinal > 5000).ToList();
        }
    }
}
