using System;


namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira qual será o tamanho dos vetores: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            int[] x = new int[n];
            int[] y = new int[n];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Insira o valor do vetor x na posição {i}: ");
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine($"Insira o valor do vetor y na posição {i}: ");
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            // Soma dos vetores
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"A soma dos vetores na posição {i} é: {x[i] + y[i]}");
            }
            Console.WriteLine();

            //Produto dos vetores
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"O produto dos vetores na posição {i} é: {x[i] * y[i]}");
            }
            Console.WriteLine();

            //Diferença dos vetores
            for (int i = 0; i < x.Length; i++)
            {
                bool repetido = false;
                for (int j = 0; j < n; j++)
                {
                    if (x[i] == y[j])
                    {
                        repetido = true;
                        break;
                    }
                }
                if (!repetido)
                {
                    Console.Write($"Os elementos de X que não estão em Y são: {x[i]} ");
                    Console.WriteLine();
                }
            }

            // Interseção
            Console.WriteLine("Interseção entre x e y:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x[i] == y[j])
                    {
                        Console.Write(x[i] + " ");
                        break;
                    }
                }
            }
            Console.WriteLine();
            // União
            Console.WriteLine("União entre x e y:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(x[i] + " ");
            }
            for (int i = 0; i < n; i++)
            {
                bool encontrado = false;
                for (int j = 0; j < n; j++)
                {
                    if (y[i] == x[j])
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    Console.Write(y[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}