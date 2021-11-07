using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.FuncoesLogin funcaoLogin = new Utils.FuncoesLogin();

                var resultado = funcaoLogin.LoginSistema(textLogin.Text, textSenha.Text);

                if (resultado != null)
                {
                    Views.Master master = new Views.Master();
                    master.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Usuário e/ou Senha Inválidos");
            }
            catch
            {
                MessageBox.Show("Erro inesperado");
            }
        }

        private void textSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }

        }
    }
}
