using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMenu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            IsMdiContainer = true;

            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CreateUser>().Count() == 1)
                Application.OpenForms.OfType<CreateUser>().First().Close();

            CreateUser create = new CreateUser();
            create.MdiParent = this;
            create.Show();

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
