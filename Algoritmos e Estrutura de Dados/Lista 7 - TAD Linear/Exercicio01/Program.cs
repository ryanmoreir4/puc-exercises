using System;

namespace Exercicio01
{

    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista(100);
            int op = 0;

            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        double tempoInicio = double.Parse(Console.ReadLine());
                        lista.InserirInicio(tempoInicio);
                        break;

                    case 2:
                        double tempoFinal = double.Parse(Console.ReadLine());
                        lista.InserirFinal(tempoFinal);
                        break;

                    case 3:
                        double tempoPosicao = double.Parse(Console.ReadLine());
                        int posicaoInserir = int.Parse(Console.ReadLine());
                        lista.InserirPosicao(tempoPosicao, posicaoInserir);
                        break;

                    case 4:
                        double removidoInicio = lista.RemoverInicio();
                        Console.WriteLine(removidoInicio);
                        break;

                    case 5:
                        double removidoFinal = lista.RemoverFinal();
                        Console.WriteLine(removidoFinal);
                        break;

                    case 6:
                        int posicaoRemover = int.Parse(Console.ReadLine());
                        double removidoPosicao = lista.RemoverPosicao(posicaoRemover);
                        Console.WriteLine(removidoPosicao);
                        break;

                    case 7:
                        double tempoRemover = double.Parse(Console.ReadLine());
                        lista.RemoverItem(tempoRemover);
                        break;

                    case 8:
                        double tempoContar = double.Parse(Console.ReadLine());
                        int qtd = lista.Contar(tempoContar);
                        Console.WriteLine(qtd);
                        break;

                    case 9:
                        lista.Mostrar();
                        break;

                    case 10:
                        break;
                }
            } while (op != 10);
        }
    }
}
