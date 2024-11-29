using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Exercicio02
    {       
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculadora \n");

            double resultado = 0;
            bool reconhecido = true;

            Console.WriteLine("Digite o primeiro número");
            double numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha um operador");
            char operador = Convert.ToChar(Console.ReadLine());

            switch(operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '/':
                    resultado = numero1 / numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                default:
                    Console.WriteLine("Operador não reconhecido");
                    reconhecido = false;
                    break;
            }

            if (reconhecido)
            {
                Console.WriteLine("O resultado é " + resultado);
            }
        }
    }
}
