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
            Console.Write("Informe a base do retângulo:");
            double baseRetangulo = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do retângulo:");
            double alturaRetangulo = double.Parse(Console.ReadLine());

            double perimetro = 2 * (baseRetangulo + alturaRetangulo);
            double area = baseRetangulo * alturaRetangulo;
            double diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(alturaRetangulo, 2));

            Console.WriteLine($"Perimetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Diagonal: {diagonal}");
            Console.ReadLine();

        }
    }
}
