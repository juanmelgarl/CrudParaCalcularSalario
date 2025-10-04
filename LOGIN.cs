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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }
        private bool esvalido()
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Usuario no valido");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtcontra.Text))
            {
                MessageBox.Show("Contraseña invalida");
                return false;

            }
            return true;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
           
            string usuariocorrecto = "juani";
            string contraseñacorrecta = "123456";
            if (esvalido())
            {
                if (txtnombre.Text.ToLower() == usuariocorrecto && txtcontra.Text.ToLower() == contraseñacorrecta)
                {
                    MessageBox.Show("Inicio de sesiòn con exito.Bienvenido...");
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos.Intenta de nuevo por favor");
                }
            }
        }
    }
}
