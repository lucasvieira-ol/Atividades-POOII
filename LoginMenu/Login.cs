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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUser.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                try
                {
                    Functions.ClientFunctions login = new Functions.ClientFunctions();

                    var result =  login.handleLogin(txtUser.Text, txtPassword.Text);

                    if(result)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login e/ou Senha Incorretos");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro Inesperado");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if(btnShowPassword.Text == "Exibir")
            {
                txtPassword.PasswordChar = '\0';
                btnShowPassword.Text = "Ocultar";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShowPassword.Text = "Exibir";
            }
        }
    }
}
