using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class exercicio01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dia da semana");
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Domingo");
                        break;
                    case 2:
                        Console.WriteLine("Segunda");
                        break;
                    case 3:
                        Console.WriteLine("Terça");
                        break;
                    case 4:
                        Console.WriteLine("Quarta");
                        break;
                    case 5:
                        Console.WriteLine("Quinta");
                        break;
                    case 6:
                        Console.WriteLine("Sexta");
                        break;
                    case 7:
                        Console.WriteLine("Sabado");
                        break;
                    default:
                        Console.WriteLine("Número inválido! Por favor, digite um número entre 1 e 7.");
                        break;
                }
        }
    }
}
