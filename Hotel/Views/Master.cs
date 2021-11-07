using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Funcionario>().Count() == 1)
                Application.OpenForms.OfType<Funcionario>().First().Close();

            Funcionario funcionario = new Funcionario();
            funcionario.MdiParent = this;
            funcionario.Show();
        }

        private void criarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Hospede>().Count() == 1)
                Application.OpenForms.OfType<Hospede>().First().Close();

            Hospede hospede = new Hospede();
            hospede.MdiParent = this;
            hospede.Show();
        }

        private void Master_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ListaHospedes>().Count() == 1)
                Application.OpenForms.OfType<ListaHospedes>().First().Close();

            ListaHospedes hospede = new ListaHospedes();
            hospede.MdiParent = this;
            hospede.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ListaFuncionarios>().Count() == 1)
                Application.OpenForms.OfType<ListaFuncionarios>().First().Close();

            ListaFuncionarios funcionarios = new ListaFuncionarios();
            funcionarios.MdiParent = this;
            funcionarios.Show();

        }
    }
}
