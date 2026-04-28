using System;
using System.Collections.Generic;
using System.Text;

namespace ExPontuado1
{
    class Aluno
    {
        private string _nome;
        private int _matricula;
        private int _codCurso;
        private List<AtividadeComplementar> atividades;

        public Aluno(string nome, int matricula, int codCurso)
        {
            _nome = nome;
            _matricula = matricula;
            _codCurso = codCurso;
            atividades = new List<AtividadeComplementar>();
        }

        public void AdicionarAtividade(AtividadeComplementar a)
        {
            atividades.Add(a);
        }

        public int CalcularCreditosTotais()
        {
            int total = 0;

            foreach (AtividadeComplementar atividade in atividades)
                total += atividade.CalcularCreditos();

            return total;
        }
        public bool PossuiMinimoTipos()
        {
            bool temProfissional = false;
            bool temEstagio = false;
            bool temExtensao = false;

            foreach (AtividadeComplementar atividade in atividades)
            {
                if (atividade is Profissional) temProfissional = true;
                if (atividade is Estagio) temEstagio = true;
                if (atividade is Extensao) temExtensao = true;

            }

            int tipos = 0;

            if (temProfissional) tipos++;
            if (temEstagio) tipos++;
            if (temExtensao) tipos++;

            return tipos >= 2;
        }

        public bool PodeFormar()
        {
            return CalcularCreditosTotais() >= 10 && PossuiMinimoTipos();
        }

        public override string ToString()
        {
            return $"\nNome: {_nome} \n" +
                $"Matrícula: {_matricula} \n" +
                $"Código de Curso: {_codCurso} \n" +
                $"----------------------------------";

        }
         
    }
}
