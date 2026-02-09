using System;

namespace Exericio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura (em ºF) a ser convertida em ºC: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = 5 * (fahrenheit - 32) / 9;

            Console.WriteLine($"{fahrenheit}ºF convertido em ºC é: {celsius}");

        }
    }
}
