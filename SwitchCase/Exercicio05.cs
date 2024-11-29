using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Exercicio05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Classificador de nota\n");

            Console.WriteLine("Digite uma nota");
            int nota = Convert.ToInt16(Console.ReadLine());

            switch (nota)
            {
                case <= 2:
                    Console.WriteLine("F");
                    break;
                case <= 4:
                    Console.WriteLine("D");
                    break;
                case <= 6:
                    Console.WriteLine("C");
                    break;
                case <= 8:
                    Console.WriteLine("B");
                    break;
                case <= 10:
                    Console.WriteLine("A");
                    break;
                default:
                    Console.WriteLine("Nota não reconhecida");
                    break;
            }
        }
    }
}
