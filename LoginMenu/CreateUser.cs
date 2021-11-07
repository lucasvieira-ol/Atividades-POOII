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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) || !string.IsNullOrEmpty(txtUser.Text) || !string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtPassword.Text) || !string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                if (txtPassword.Text.Length > 7)
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        Functions.ClientFunctions createClient = new Functions.ClientFunctions();

                        var result = createClient.createUser(txtName.Text, txtUser.Text, txtEmail.Text, txtPassword.Text);

                        MessageBox.Show(result);
                    }
                    else
                    {
                        MessageBox.Show("As senhas digitadas não são iguais");
                    }

                }
                else
                {
                    MessageBox.Show("Digite uma senha maior que 7 caracteres");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados");
            }

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (btnShowPassword.Text == "Exibir")
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

        private void btnShowConfirmPassword_Click(object sender, EventArgs e)
        {
            if (btnShowConfirmPassword.Text == "Exibir")
            {
                txtConfirmPassword.PasswordChar = '\0';
                btnShowConfirmPassword.Text = "Ocultar";
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
                btnShowConfirmPassword.Text = "Exibir";
            }
        }
    }
}
