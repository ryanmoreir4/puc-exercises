using System;
using System.Collections;
using System.Collections.Generic;

class Program
{

    static void InserirFinal(LinkedList<string> musicas)
    {
        musicas.AddLast(Console.ReadLine());
    }
    static void InserirInicio(LinkedList<string> musicas)
    {
        musicas.AddFirst(Console.ReadLine());
    }
    static void InserirApos(LinkedList<string> musicas)
    {
        string nova = Console.ReadLine();
        string indice = Console.ReadLine();

        LinkedListNode<string> no = musicas.Find(indice);

        musicas.AddAfter(no, nova);
    }
    static void RemoverInicio(LinkedList<string> musicas)
    {
        musicas.RemoveFirst();
    }
    static void RemoverFinal(LinkedList<string> musicas)
    {
        musicas.RemoveLast();
    }
    static void Remover(LinkedList<string> musicas)
    {
        musicas.Remove(Console.ReadLine());
    }
    static void ListarMusicas(LinkedList<string> musicas)
    {
        foreach(string s in musicas)
            Console.WriteLine(s);
    }
    static void Pesquisar(LinkedList<string> musicas)
    {
        Console.WriteLine(musicas.Contains(Console.ReadLine()) ? "sim" : "não");

    }
    static void Main(string[] args)
    {
        LinkedList<string> musicas = new LinkedList<string>();

        int op = 0;
        do
        {
            Console.WriteLine("Op: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: InserirFinal(musicas); break;
                case 2: InserirInicio(musicas); break;
                case 3: InserirApos(musicas); break;
                case 4: RemoverInicio(musicas); break;
                case 5: RemoverFinal(musicas); break;
                case 6: Remover(musicas); break;
                case 7: ListarMusicas(musicas); break;
                case 8: Pesquisar(musicas); break;
                case 9: break;
                default: Console.WriteLine("Opção Inválida"); break;
            }

        } while (op != 9);

    }
}