using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Lista
    {
        private double[] array;
        private int tamanho;

        public Lista(int capacidade)
        {
            array = new double[capacidade];
            tamanho = 0;
        }

        // Insere no início da lista
        public void InserirInicio(double x)
        {
            if (tamanho == array.Length)
                throw new Exception("Erro: lista cheia.");

            // Desloca todos os elementos uma posição para a direita
            for (int i = tamanho; i > 0; i--)
                array[i] = array[i - 1];

            array[0] = x;
            tamanho++;
        }

        // Insere no final da lista
        public void InserirFinal(double x)
        {
            if (tamanho == array.Length)
                throw new Exception("Erro: lista cheia.");

            array[tamanho] = x;
            tamanho++;
        }

        // Insere em uma posição específica
        public void InserirPosicao(double x, int posicao)
        {
            if (tamanho == array.Length)
                throw new Exception("Erro: lista cheia.");

            if (posicao < 0 || posicao > tamanho)
                throw new Exception("Erro: posição inválida.");

            // Desloca os elementos a partir da posição para a direita
            for (int i = tamanho; i > posicao; i--)
                array[i] = array[i - 1];

            array[posicao] = x;
            tamanho++;
        }

        // Remove o primeiro elemento e retorna seu valor
        public double RemoverInicio()
        {
            if (tamanho == 0)
                throw new Exception("Erro: lista vazia.");

            double removido = array[0];

            for (int i = 0; i < tamanho - 1; i++)
                array[i] = array[i + 1];

            tamanho--;
            return removido;
        }

        // Remove o último elemento e retorna seu valor
        public double RemoverFinal()
        {
            if (tamanho == 0)
                throw new Exception("Erro: lista vazia.");

            double removido = array[tamanho - 1];
            tamanho--;
            return removido;
        }

        // Remove o elemento de uma posição específica e retorna seu valor
        public double RemoverPosicao(int posicao)
        {
            if (tamanho == 0)
                throw new Exception("Erro: lista vazia.");

            if (posicao < 0 || posicao >= tamanho)
                throw new Exception("Erro: posição inválida.");

            double removido = array[posicao];

            for (int i = posicao; i < tamanho - 1; i++)
                array[i] = array[i + 1];

            tamanho--;
            return removido;
        }

        // Remove a primeira ocorrência de um valor específico
        public void RemoverItem(double x)
        {
            int indice = -1;

            for (int i = 0; i < tamanho; i++)
            {
                if (array[i] == x)
                {
                    indice = i;
                    break;
                }
            }

            if (indice == -1)
                throw new Exception("Erro: elemento não encontrado.");

            for (int i = indice; i < tamanho - 1; i++)
                array[i] = array[i + 1];

            tamanho--;
        }

        // Conta quantas vezes um valor aparece na lista
        public int Contar(double x)
        {
            int count = 0;

            for (int i = 0; i < tamanho; i++)
            {
                if (array[i] == x)
                    count++;
            }

            return count;
        }

        // Mostra todos os elementos da lista
        public void Mostrar()
        {
            for (int i = 0; i < tamanho; i++)
                Console.WriteLine(array[i]);
        }
    }

}
