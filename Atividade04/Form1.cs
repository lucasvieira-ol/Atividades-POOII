using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade04.Data;
using System.Globalization;


namespace Atividade04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            var numerosValidados = verificarCampos();

            if (numerosValidados != null)
            {
                var resultado = new Utils.FuncoesMatematica().Multiplicacao(numerosValidados);

                textResultado.Text = resultado.ToString("#.##").Replace(".", ",");

            }
            else
            {
                MessageBox.Show("Números digitados estão no formato inválido");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            var numerosValidados = verificarCampos();

            if (numerosValidados != null)
            {
                if (numerosValidados.numeroX == 0)
                {
                    MessageBox.Show("Não É possível Dividir por Zero");
                }
                else
                {
                    var resultado = new Utils.FuncoesMatematica().Divisao(numerosValidados);

                    textResultado.Text = resultado.ToString("#.##").Replace(".", ",");

                }

            }
            else
            {
                MessageBox.Show("Números digitados estão no formato inválido");
            }

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            var numerosValidados = verificarCampos();

            if (numerosValidados != null)
            {
                var resultado = new Utils.FuncoesMatematica().Soma(numerosValidados);

                textResultado.Text = resultado.ToString("#.##").Replace(".", ",");

            }
            else
            {
                MessageBox.Show("Números digitados estão no formato inválido");
            }

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            var numerosValidados = verificarCampos();

            if (numerosValidados != null)
            {
                var resultado = new Utils.FuncoesMatematica().Subtracao(numerosValidados);

                textResultado.Text = resultado.ToString("#.##").Replace(".", ",");

            }
            else
            {
                MessageBox.Show("Números digitados estão no formato inválido");
            }

        }

        private numeros verificarCampos()
        {
            numeros validarNumeros = new numeros();
            try
            {
                validarNumeros.numeroX = decimal.Parse(textNumeroX.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                validarNumeros.numeroY = decimal.Parse(textNumeroY.Text.Replace(",", "."), CultureInfo.InvariantCulture);

                return validarNumeros;
            }
            catch
            {
                return validarNumeros;
            }
        }
    }
}
