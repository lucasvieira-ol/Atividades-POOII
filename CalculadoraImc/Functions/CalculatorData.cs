using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImc.Functions
{
    public class CalculatorData
    {
        public string calculatedData { get; set; }
        public string status { get; set; }

        public CalculatorData CalculateData(double height, double weight)
        {
            CalculatorData result = new CalculatorData();

            double imc = (weight / (height * height));

            result.calculatedData = imc.ToString("N2").Replace(".",",");

            if (imc < 16)
            {
                result.status = "Subpeso Severo";
            }
            else if (imc >= 16 && imc <= 19.9)
            {
                result.status = "Subpeso";
            }
            else if (imc >= 20 && imc <= 24.9)
            {
                result.status = "Normal";
            }
            else if (imc >= 25 && imc <= 29.99)
            {
                result.status = "Sobrepeso";
            }
            else if (imc >= 30 && imc <= 39.99)
            {
                result.status = "Obeso";
            }
            else
            {
                result.status = "Obeso Mórbido";
            }

            return result;
        }
    }
}
