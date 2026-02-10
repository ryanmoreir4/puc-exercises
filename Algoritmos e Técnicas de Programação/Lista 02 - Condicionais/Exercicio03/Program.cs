using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, tempoHabilitacao;
            char tipoHabilitacao;

            Console.WriteLine("Digite a idade do motorista:");
            idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tipo de habilitação do motorista: ");
            tipoHabilitacao = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Digite o tempo de habilitação do motorista (em meses):");
            tempoHabilitacao = double.Parse(Console.ReadLine());
            Console.Clear();

            if (idade >= 21)
            {
                if ((tipoHabilitacao == 'B' && tempoHabilitacao < 24) | (tipoHabilitacao == 'C' && tempoHabilitacao < 12))
                {
                    Console.WriteLine("Você não possui os requisitos mínimos de tempo de habilitação.");
                }
                else
                {
                    Console.WriteLine("Você possui os requisitos mínimos de tempo de habilitação.");
                }
            }
            else
            {
                Console.WriteLine("Você não possui os requisitos mínimos de idade.");
            }
        }
    }
}
