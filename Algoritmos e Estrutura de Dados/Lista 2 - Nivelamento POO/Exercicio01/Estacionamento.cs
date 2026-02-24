using System;
using System.Collections.Generic;
using System.Text;

  class Estacionamento
  {
    private string nome;
    private int numVagasLivres;
    private string[] vagas;

    public Estacionamento(string nome, int numTotalVagas)
    {
        this.nome = nome;
        this.numVagasLivres = numTotalVagas;
        this.vagas = new string[numTotalVagas];
    }

    public int Estacionar(string placa)
    {
        if (numVagasLivres <= 0) return -1;

        for (int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] == null)
            {
                vagas[i] = placa;
                numVagasLivres--;
                return i;
            }
        }

        return -1;
    }

    public int BuscarNumVaga(string placa)
    {
        int numVaga = 0;

        for(int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] == placa)
            {
                numVaga = i;

                return numVaga;
            }
        }
        return -1;
    }

    public void Retirar(string placa)
    {
        for(int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] == placa)
            {
                vagas[i] = null;
            }
        }
    }

    public int NumVagasLivres
    {
        get { return numVagasLivres; }
    }

    public void ExibirOcupacao()
    {
        for(int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] != null)
            {
                Console.Write($"Vaga {i+1} -- {vagas[i]}\n");
            }
            Console.Write($"Vaga {i+1} -- Vazia\n");
        }
    }
}
