using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05
{
    class Turma
    {
        private string _nomeCurso;
        private int _codigoHorario;
        private int _duracao;
        private List<Aluno> alunos;
        private int maxAlunos = 25;
        private string _dia;
        private string _turno;

        public Turma(string nomeCurso, int duracao, string dia, string turno)
        {
            _nomeCurso = nomeCurso;
            _duracao = duracao;
            alunos = new List<Aluno>();
            string _dia = dia;
            string _turno = turno;
        }

        public bool ValidarTurma()
        {
            bool turmaValida = false;

            if (alunos.Count <= maxAlunos) turmaValida = true;

            return turmaValida;
        }

        public void InserirAluno(Aluno aluno)
        {
            if (ValidarTurma()) alunos.Add(aluno);
        }

        public Aluno LocalizarAluno(int matricula)
        {
            foreach (Aluno a in alunos)
                if (a.GetMatricula() == matricula) return a;

            return null;
        }

        public void LancarNota(int matricula, double valor, int avaliacao)
        {
            Aluno aluno = LocalizarAluno(matricula);

            if (aluno != null) aluno.LancarNota(valor, avaliacao);
            
        }

        public void LancarFalta(int matricula)
        {
            Aluno aluno = LocalizarAluno(matricula);

            if (aluno != null) aluno.LancarFalta();
        }

        public double CalcularMediaTurma()
        {
            if (alunos.Count == 0) return 0;

            double notas = 0;

            foreach (Aluno a in alunos)
            {
                notas += a.NotaFinal();
            }

            return notas / alunos.Count;
        }

        public double PercentualAprovacao()
        {
            int aprovados = 0;

            foreach(Aluno a in alunos)
            {
                if (a.Aprovado(_duracao)) aprovados++;
            }

            return ((double)aprovados / alunos.Count) * 100;
        }

        public int GerarCodigo()
        {

        }

        public string GerarRelatorio()
        {
            string relatorio = "";

            relatorio += $"TURMA: {_nomeCurso}\n" +
                        $"HORÁRIO: {_dia} - {_turno}\n" +
                        $"ALUNOS: \n";
            
            foreach(Aluno a in alunos)
            {
                relatorio += $"{a} \n";
                relatorio += $"-------------------------------";
            }

            return relatorio;
        }
    }
}
