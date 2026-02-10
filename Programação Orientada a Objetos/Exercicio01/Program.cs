using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor da altura do retângulo: ");
            int altura = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor da largura do retângulo: ");
            int largura = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    if (i == 0 || i == altura - 1 || j == 0 || j == largura - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
