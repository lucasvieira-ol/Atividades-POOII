using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalculadoraImc
{
    public partial class CalculadoraImc : Form
    {
        public CalculadoraImc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHeight.Text) || !string.IsNullOrEmpty(txtWeight.Text))
            {
                try
                {
                    double height = double.Parse(txtHeight.Text.Replace(",","."), CultureInfo.InvariantCulture);
                    double weight = double.Parse(txtWeight.Text.Replace(",", "."), CultureInfo.InvariantCulture);

                    if (height * 100 > 270)
                        height = height / 100;

                    Functions.CalculatorData result = new Functions.CalculatorData();

                    result = result.CalculateData(height, weight);

                    txtResult.Text = result.calculatedData;
                    lblResultStatus.Text = result.status;

                    switch (result.status)
                    {
                        case "Subpeso Severo":
                            lblResultStatus.ForeColor = Color.FromArgb(0, 0, 255);
                            break;
                        case "Subpeso":
                            lblResultStatus.ForeColor = Color.FromArgb(0, 255, 255);
                            break;
                        case "Normal":
                            lblResultStatus.ForeColor = Color.FromArgb(0, 255, 0);
                            break;
                        case "Sobrepeso":
                            lblResultStatus.ForeColor = Color.FromArgb(160, 121, 0);
                            break;
                        case "Obeso":
                            lblResultStatus.ForeColor = Color.FromArgb(255, 173, 0);
                            break;
                        case "Obeso Mórbido":
                            lblResultStatus.ForeColor = Color.FromArgb(255, 0, 0);
                            break;
                        default:
                            break;
                    }
                    

                }
                catch
                {
                    MessageBox.Show("Os dados inseridos estão em um formato inválido");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos para realizar o calculo");
            }
                
        }
    }
}
