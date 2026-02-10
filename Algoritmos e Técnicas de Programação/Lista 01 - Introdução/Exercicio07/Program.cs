using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira (em R$) o valor das despesas: ");
            double despesas = double.Parse(Console.ReadLine());

            Console.Write("Insira o percentual de gorjetas: ");
            double percentualGorjetas = double.Parse(Console.ReadLine());

            Console.Clear();

            double valorGorjetas = despesas * (percentualGorjetas / 100);
            double valorTotal = despesas + valorGorjetas;

            Console.WriteLine($"Valor das despesas: R${despesas:F2}");

        }
    }
}
