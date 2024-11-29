using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Exercicio04
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Menu de Opções \n");
            bool desicao = true;

            while (desicao)
            {
                Console.WriteLine("1 - Olá, Mundo");
                Console.WriteLine("2 - Bem-vindo ao C#");
                Console.WriteLine("3 - Sair do programa\n");

                int escolha = Convert.ToInt16(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Olá, Mundo \n");
                        break;
                    case 2:
                        Console.WriteLine("Bem-vindo ao C# \n");
                        break;
                    case 3:
                        Console.WriteLine("Saindo do programa \n");
                        desicao = false;
                        break;
                    default:
                        Console.WriteLine("Número não reconhecico para nenhuma das escolhas diponíveis \n");
                        break;
                }
            }

        }
    }
}
