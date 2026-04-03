using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dicionario = new Dictionary<string, int>();

        int cont = 0;
        string frase = Console.ReadLine();

        string[] palavras = frase.ToLower().Split(" ");

        foreach(string s in palavras)
        {
            if (dicionario.ContainsKey(s))
            {
                dicionario[s]++;
            }
            else
            {
                dicionario[s] = 1;
            }
        }

        foreach (var item in dicionario)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }

    }        
}
