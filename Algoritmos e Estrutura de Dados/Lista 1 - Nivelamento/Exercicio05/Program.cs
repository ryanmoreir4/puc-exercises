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
            int num, ultimoNum = -1, seqAtual = 1, seqFinal = 1;

            Console.WriteLine("Digite uma sequência de números inteiros positivos (digite -1 para parar): ");
            
            while (true)
            {
                num = int.Parse(Console.ReadLine());

                if (num == -1)
                {
                    break;
                }

                if (ultimoNum != -1  && num > ultimoNum)
                {
                    seqAtual++;
                }
                else
                {
                    seqAtual = 1;
                }
            }

        }
    }
}
