using System.ComponentModel;

namespace WinFormsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static BindingList<Persona> personalst = new BindingList<Persona>();
        private bool esvalido()
        {

            if (string.IsNullOrWhiteSpace(tctnombre.Text))
            {
                MessageBox.Show("error");
                return false;
            }
            if (!decimal.TryParse(txtsueldo.Text, out _))
            {
                MessageBox.Show("Ingrese un sueldo válido.");
                return false;
            }
            if (!decimal.TryParse(txtaumento.Text, out _))
            {
                MessageBox.Show("Ingrese un sueldo válido.");
                return false;
            }
            return true;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tctnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (esvalido())
            {
                decimal sueldo = decimal.Parse(txtsueldo.Text);
                decimal aumento = decimal.Parse(txtaumento.Text);
                Persona prs = new Persona
                {
                    Nombre = tctnombre.Text,
                    sueldo = sueldo,
                    aumento = aumento

                };
                personalst.Add(prs);
                txtresultado.Text = prs.sueldoFinal.ToString("C");
                ClienteForm CLT = new ClienteForm();
                CLT.ShowDialog();

            }

        }

        private void txtsueldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}