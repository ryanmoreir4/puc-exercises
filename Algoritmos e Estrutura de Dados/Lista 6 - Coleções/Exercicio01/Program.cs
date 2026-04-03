using System;
using System.Collections.Generic;

namespace Exercício01
{
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1) Inserir no início");
            Console.WriteLine("2) Inserir no final");
            Console.WriteLine("3) Inserir em posição específica");
            Console.WriteLine("4) Remover primeiro");
            Console.WriteLine("5) Remover último");
            Console.WriteLine("6) Remover por posição");
            Console.WriteLine("7) Remover por valor");
            Console.WriteLine("8) Contar ocorrências");
            Console.WriteLine("9) Mostrar lista");
            Console.WriteLine("10) Ordenar crescente");
            Console.WriteLine("11) Ordenar decrescente");
            Console.WriteLine("12) Sair");
            Console.WriteLine("Op: ");
            return int.Parse(Console.ReadLine());

        }
        
        static void ExecutarOpcao(int op, List<double> tempos)
        {
            switch (op)
            {
                case 1: InserirInicio(tempos); break;
                case 2: InserirFinal(tempos); break;
                case 3: InserirPosicao(tempos); break;
                case 4: RemoverInicio(tempos); break;
                case 5: RemoverFinal(tempos); break;
                case 6: RemoverPosicao(tempos); break;
                case 7: RemoverValor(tempos); break;
                case 8: ContarOcorrencias(tempos); break;
                case 9: MostrarLista(tempos); break;
                case 10: OrdenarCrescente(tempos); break;
                case 11: OrdenarDecrescente(tempos); break;
                case 12: break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
        
        static void InserirInicio(List<double> tempos)
        {
            tempos.Insert(0, double.Parse(Console.ReadLine()));
        }

        static void InserirFinal(List<double> tempos)
        {
            tempos.Add(double.Parse(Console.ReadLine()));
        }

        static void InserirPosicao(List<double> tempos)
        {
            double t = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            tempos.Insert(p, t);
        }

        static void RemoverInicio(List<double> tempos)
        {
            Console.WriteLine(tempos[0]);
            tempos.RemoveAt(0);
        }

        static void RemoverFinal(List<double> tempos)
        {
            int ultimo = tempos.Count - 1;

            Console.WriteLine(tempos[ultimo]);
            tempos.RemoveAt(ultimo);
        }

        static void RemoverPosicao(List<double> tempos)
        {
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(tempos[p]);
            tempos.RemoveAt(p);
        }

        static void RemoverValor(List<double> tempos)
        {
            tempos.Remove(double.Parse(Console.ReadLine()));
        }

        static void ContarOcorrencias(List<double> tempos)
        {
            double valor = double.Parse(Console.ReadLine());
            int cont = 0;

            foreach (double t in tempos)
                if (t == valor) cont++;

            Console.WriteLine(cont);
        }

        static void MostrarLista(List<double> tempos)
        {
            foreach(double t in tempos)
                Console.WriteLine(t);
        }

        static void OrdenarCrescente(List<double> tempos)
        {
            tempos.Sort();
            MostrarLista(tempos);
        }

        static void OrdenarDecrescente(List<double> tempos)
        {
            tempos.Sort();
            tempos.Reverse();
            MostrarLista(tempos);
        }

        static void Main(string[] args)
        {
            List<double> tempos = new List<double>();
            int op;

            do
            {
                op = Menu();
                ExecutarOpcao(op, tempos);

            }while (op != 12);
        }
    }
}