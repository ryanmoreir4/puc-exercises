using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05
{
    class Aluno
    {
        private static int s_proxMatricula;
        private double notaAprovacao = 60d;
        private double freqMinima = 0.75d;
        private int quantAvaliacoes = 4;
        private string _nome;
        private int _matricula;
        private int _codCurso;
        private double[] _notas;
        private int _faltas;

        public Aluno(string nome, int matricula, int codCurso)
        {
            _nome = nome;
            _matricula = matricula;
            _codCurso = codCurso;
            _notas = new double[quantAvaliacoes];
            _faltas = 0;
        }

        public int GetMatricula()
        {
            return _matricula;
        }

        public double LancarNota(double valor, int avaliacao)
        {
            if((valor >= 0 && valor <= 25) &&
                avaliacao >= 1 && avaliacao <= 4)
            {
                _notas[avaliacao - 1] = valor;
                
                return valor;
            } 
        }

        public double NotaFinal()
        {
            double notaTotal = 0;

            foreach (double n in _notas)
                notaTotal += _notas[n];

            return notaTotal;
        }

        public bool Aprovado(int totalAulas)
        {
            bool aprovado = false;

            if (Frequencia(totalAulas) >= freqMinima &&
                NotaFinal() >= notaAprovacao) aprovado = true;
            
            return aprovado;
        }

        public void LancarFalta()
        {
            _faltas++;
        }

        public double Frequencia(int totalAulas)
        {
            return 1.0 - ((double)_faltas / totalAulas);
        }

        public override string ToString()
        {
            return $"Nome: {_nome} \n" +
                    $"Mtrícula: {_matricula} \n" +
                    $"Nota Final: {NotaFinal()} \n" +
                    $"Faltas: {_faltas} \n";
        }
    }
}
