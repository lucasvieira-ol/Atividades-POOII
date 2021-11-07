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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textCPF.Text) || !string.IsNullOrEmpty(textNome.Text))
            {
                Data.Funcionarios dadosFuncionario = new Data.Funcionarios();
                Utils.FuncoesFuncionarios EnviarFuncionario = new Utils.FuncoesFuncionarios();

                dadosFuncionario.CPF = textCPF.Text;
                dadosFuncionario.nomeFuncionario = textNome.Text;
                dadosFuncionario.status = comboBoxStatus.SelectedValue.ToString();
                dadosFuncionario.dataAdmissao = dtAdmissao.Value;
                dadosFuncionario.dataNascimento = dtNascimento.Value;

                if (!string.IsNullOrEmpty(textId.Text))
                {
                    dadosFuncionario.id_funcionario = Convert.ToInt32(textId.Text);
                    EnviarFuncionario.updateFuncionario(dadosFuncionario);
                    MessageBox.Show("Dados Alterados com êxito");
                    reopen();
                }
                else
                {
                    try
                    {
                        EnviarFuncionario.criarFuncionario(dadosFuncionario);
                        MessageBox.Show("Funcionário cadastrado com êxito");
                        reopen();
                    }
                    catch (Exception ex)
                    {
                        Utils.FuncoesError funcoesError = new Utils.FuncoesError();
                        MessageBox.Show(funcoesError.HandleException(ex));
                    }
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            limparCampos();
        }
        private void PreencherComboBoxStatus(object sender, EventArgs e)
        {
            Dictionary<string, string> Status = new Dictionary<string, string>();

            Status.Add("A", "Ativo");
            Status.Add("F", "Férias");
            Status.Add("S", "Suspenso");
            Status.Add("V", "Em Viagem");
            Status.Add("D", "Desligado");


            comboBoxStatus.DataSource = new BindingSource(Status, null);
            comboBoxStatus.DisplayMember = "Value";
            comboBoxStatus.ValueMember = "Key";

        }
        private void HabilitarCampos()
        {
            textNome.Enabled = true;
            textCPF.Enabled = true;
            dtNascimento.Enabled = true;
            dtAdmissao.Enabled = true;
            comboBoxStatus.Enabled = true;
            btnSalvar.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
        }
        private void desabilitarCampos()
        {
            textNome.Enabled = false;
            textCPF.Enabled = false;
            dtNascimento.Enabled = false;
            dtAdmissao.Enabled = false;
            comboBoxStatus.Enabled = false;
            btnSalvar.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
        }

        private void limparCampos()
        {
            textNome.Text = null;
            textCPF.Text = null;
            textBuscarCPF.Text = null;
            textId.Text = null;
            comboBoxStatus.SelectedValue = "A";
            dtAdmissao.Value = DateTime.Now;
            dtNascimento.Value = DateTime.Now;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBuscarCPF.Text) && textBuscarCPF.Text.Length == 14)
            {
                Utils.FuncoesFuncionarios buscarFuncionario = new Utils.FuncoesFuncionarios();

                var result = buscarFuncionario.getFuncionario(textBuscarCPF.Text);

                if (result != null)
                {
                    textId.Text = result.id_funcionario.ToString();
                    textNome.Text = result.nomeFuncionario;
                    textCPF.Text = result.CPF;
                    dtNascimento.Value = result.dataNascimento;
                    dtAdmissao.Value = result.dataAdmissao;
                    comboBoxStatus.SelectedValue = result.status;
                    HabilitarCampos();
                }
            }
            else
            {
                MessageBox.Show("Necessário preencher o CPF por completo para realizar a busca");
            }
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            PreencherComboBoxStatus(sender, e);

            dtAdmissao.Format = DateTimePickerFormat.Custom;
            dtAdmissao.CustomFormat = "dd/MM/yyyy";

            dtNascimento.Format = DateTimePickerFormat.Custom;
            dtNascimento.CustomFormat = "dd/MM/yyyy";

        }
        private void reopen()
        {
            limparCampos();
            desabilitarCampos();
        }

    }
}
