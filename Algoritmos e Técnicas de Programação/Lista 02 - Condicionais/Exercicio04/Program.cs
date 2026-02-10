using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            double n1, n2, result =0;

            Console.WriteLine("Menu de Opções " +
                "\n1. Somar dois números." +
                "\n2. Subtrair dois números. " +
                "\n3. Multiplicação de dois números. " +
                "\n4. Divisão de dois números");
            opc = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());  
            Console.Clear();

            if (opc == 1)
            {
                result = n1 + n2;
            }
            else if (opc == 2)
            {
                result = n1 - n2;
            }
            else if (opc == 3)
            {
                result = n1 * n2;
            }
            else if (opc == 4)
            {
                if (n2 != 0)
                {
                    result = n1 / n2;
                }
                else
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
            Console.WriteLine("O resultado é: " + result);
            Console.ReadLine();
        }
    }
}
