using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do lado do quadrado:");
            double lado = double.Parse(Console.ReadLine());

            double perimetro = lado * 4;
            double area = lado * lado;
            double diagonal = lado * Math.Sqrt(2);

            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Diagonal: {diagonal}");
            
            Console.ReadLine();

        }

    }

}