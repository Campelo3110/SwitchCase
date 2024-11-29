using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Exercicio07
    {
        public static void Main(string[] args)
        {
            double imposto;

            Console.WriteLine("Calculadora de Imposto\n");

            Console.WriteLine("Digite seu sálario");
            double salario = Convert.ToDouble(Console.ReadLine());

            switch(salario)
            {
                case <= 1500:
                    imposto = (5 * salario) / 100;
                    break;
                case <= 3000:
                    imposto = (10 * salario) / 100;
                    break;
                default:
                    imposto = (15 * salario) / 100;
                    break;
            }

            Console.WriteLine("O salário digitado foi de " + (salario.ToString("C", CultureInfo.CurrentCulture)) + "\nO imposto do salário é " + (imposto.ToString("C", CultureInfo.CurrentCulture)) + "\nTotal:" + ((salario - imposto).ToString("C", CultureInfo.CurrentCulture)));
        }
    }
}
