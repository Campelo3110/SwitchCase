using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para calcular seu fatorial:");

            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                switch (i)
                {
                    case int n when n > 0:
                        resultado *= i;
                        break;

                    default:
                        Console.WriteLine("Número inválido");
                        break;
                }
            }

            Console.WriteLine($"O fatorial de {numero} é {resultado}");
        }
    }

}


