using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Leitor de Classificação Etária\n");

            Console.WriteLine("Digite a classificação");
            string classi = Convert.ToString(Console.ReadLine());

            switch (classi.ToUpper())
            {
                case "G":
                    Console.WriteLine("Livre");
                    break;
                case "PG":
                    Console.WriteLine("Maior de 10 anos");
                    break;
                case "PG-13":
                    Console.WriteLine("Maior de 13 anos");
                    break;
                case "R":
                    Console.WriteLine("Maior de 18 anos");
                    break;
                default:
                    Console.WriteLine("Não reconhecico para nenhuma das escolhas diponíveis");
                    break;
            }
        }
    }
}
