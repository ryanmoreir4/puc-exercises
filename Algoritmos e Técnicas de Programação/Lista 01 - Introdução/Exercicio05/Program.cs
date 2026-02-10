using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro número: ");
            double varA = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double varB = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"Antes:\nvarA: {varA} \nvarB: {varB}\n");

            double temp = varA;

            varA = varB;
            varB = temp;

            Console.WriteLine($"Depois:\nvarA: {varA} \nvarB: {varB}");

        }
    }
}
