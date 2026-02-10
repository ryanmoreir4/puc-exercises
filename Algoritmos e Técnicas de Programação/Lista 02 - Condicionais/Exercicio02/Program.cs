using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um valor entre 0 e 5: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0 && valor <= 5)
            {
                if (valor == 0)
                {
                    Console.WriteLine("Zero");
                }
                else if (valor == 1)
                {
                    Console.WriteLine("Um");
                }
                else if(valor == 2)
                {
                    Console.WriteLine("Dois");
                }
                else if (valor == 3)
                {
                    Console.WriteLine("Três");
                }
                else if (valor == 4)
                {
                    Console.WriteLine("Quatro");
                }
                else if (valor == 5)
                {
                    Console.WriteLine("Cinco");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}
