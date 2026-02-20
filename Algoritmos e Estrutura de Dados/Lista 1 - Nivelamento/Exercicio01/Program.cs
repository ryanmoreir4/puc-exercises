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
            int n, aux = 1;

            Console.WriteLine("Insira quantas linhas deseja que o triângulo de Floyd possua: ");
            n = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(aux + " ");
                    aux++;
                }
            }
        }
    }
}
