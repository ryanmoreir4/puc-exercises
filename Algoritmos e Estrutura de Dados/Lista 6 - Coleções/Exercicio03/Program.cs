using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();

        int op = 0;
        do
        {
            Console.WriteLine("Op: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Console.WriteLine(fila.Count); break;
                case 2: Console.WriteLine(fila.Peek()); fila.Dequeue(); break;
                case 3: string aviao = Console.ReadLine(); fila.Enqueue(aviao); break;
                case 4: foreach(string a in fila) Console.WriteLine(a); break;
                case 5: Console.WriteLine(fila.Peek()); break;
                case 6: break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        } while (op != 6);
    }
}
