using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Exercicio08
    {
        public static void Main(string[] args)
        {
            double convertido = 0;

            Console.WriteLine("Conversor de temperatura\n");

            Console.WriteLine("Qual a medida que deseja converter");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");

            int escolha = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nDigite a temperatura");

            double temperatura = Convert.ToDouble(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    convertido = (temperatura - 32) / 1.8;
                    break;
                case 2:
                    convertido = (1.8 * temperatura) + 32;
                    break;
                default:
                    Console.WriteLine("Número não reconhecico para nenhuma das escolhas diponíveis");
                    break;
            }

            Console.WriteLine("\nA escolha foi de "  + (escolha == 1 ? "Celsius para Fahrenheit" : "Fahrenheit para Celsius"));
            Console.WriteLine("A temperatura digitada foi " + temperatura);
            Console.WriteLine("Convertido em " + (escolha == 1 ? "Fahrenheit " : "Celsius ") + "fica: " + (convertido.ToString("N2") + (escolha == 1 ? " °F " : " °C")));

        }
    }
}
