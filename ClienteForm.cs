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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }
        private void ClienteForm_Load(object sender, EventArgs e)
        {
            Cargardatos();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Cargardatos();
        }
        public void Cargardatos()
        {
            dgv.DataSource = null;
            dgv.DataSource = Form1.personalst;

        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                var persona = dgv.CurrentRow.DataBoundItem as Persona;
                if (persona != null)
                {
                    var confirm = MessageBox.Show("¿Desea borrar el registro?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (confirm == DialogResult.OK)
                    {
                        Form1.personalst.Remove(persona);
                        Cargardatos();
                    }
                }
            }
        }
        public void actualizar(List<Persona> filtrados)
        {
            dgv.DataSource = null;
            dgv.DataSource = filtrados;
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            var sueldo = Form1.personalst.Where(x => x.aumento > 20).ToList();

            dgv.DataSource = sueldo;

        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            linqForm frm = new linqForm(this);
            frm.ShowDialog();
        }

        private void BTNEXPORTAR_Click(object sender, EventArgs e)
        {
            Exportation.ExportarJson(Form1.personalst.ToList());
        }
    }
}