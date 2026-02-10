using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a qtde de eleitores do município:");
            int eleitores = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Insira a quantidade de votos brancos:");
            double votosBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de votos nulos:");
            double votosNulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de votos válidos:");
            double votosValidos = int.Parse(Console.ReadLine());

            Console.Clear();

            double percentualBrancos = (votosBrancos / eleitores) * 100;
            double percentualNulos = (votosNulos / eleitores) * 100;
            double percentualValidos = (votosValidos / eleitores) * 100;

            Console.WriteLine("Percentual de votos:\n");

            Console.WriteLine($"Votos brancos: {percentualBrancos}%");
            Console.WriteLine($"Votos nulos: {percentualNulos}%");
            Console.WriteLine($"Votos válidos: {percentualValidos}%");


        }
    }
}
