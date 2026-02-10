using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numerador: ");
            double numerador = double.Parse(Console.ReadLine());

            Console.Write("Digite o denominador: ");
            double denominador = double.Parse(Console.ReadLine());

            Console.Clear();

            double resultado = numerador / denominador;

            Console.WriteLine($"O restultado da fração é: {resultado.ToString("F")}");


        }
    }
}
