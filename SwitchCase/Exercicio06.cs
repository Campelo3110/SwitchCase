using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Menu de Opções \n");

            Console.WriteLine("1 - Café");
            Console.WriteLine("2 - Chá");
            Console.WriteLine("3 - Suco\n");

            int escolha = Convert.ToInt16(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Café");
                    break;
                case 2:
                    Console.WriteLine("Chá");
                    break;
                case 3:
                    Console.WriteLine("Suco");
                    break;
                default:
                    Console.WriteLine("Número não reconhecico para nenhuma das escolhas diponíveis");
                    break;
            }
        }

    }
}

