using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite a sequência: ");
        string entrada = Console.ReadLine();

        Stack<char> pilha = new Stack<char>();
        bool correta = true;

        foreach (char c in entrada)
        {
            if (c == '(' || c == '[')
                pilha.Push(c);

            if (c == ')' || c == ']')
            {
                char topo = pilha.Pop();

                if ((c == ')' && topo != '(') ||
                    (c == ']' && topo != '['))
                {
                    correta = false;
                    break;
                }
            }
        }

        Console.WriteLine(correta ? "correta" : "errada");
    }
}