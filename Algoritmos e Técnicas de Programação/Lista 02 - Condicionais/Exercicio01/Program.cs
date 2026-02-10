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
            Console.Write("Insira a primeira idade: ");
            int idade1 = int.Parse(Console.ReadLine());

            Console.Write("Insira a segunda idade: ");
            int idade2 = int.Parse(Console.ReadLine());

            Console.Write("Insira a terceira idade: ");
            int idade3 = int.Parse(Console.ReadLine());
            Console.Clear();

            int menor = Math.Min(idade1, Math.Min(idade2, idade3));
            int maior = Math.Max(idade1, Math.Max(idade2, idade3));

            Console.WriteLine($"A menor idade é: {menor} \nA maior idade é {maior}");

        }
    }
}
