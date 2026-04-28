using System;
using System.Collections.Generic;
using System.Text;

namespace ExPontuado1
{
    internal class Program
    {
        static void EstatisticasAlunos(List<Aluno> alunos)
        {
            int totalAlunos = alunos.Count;
            int alunosOK = 0;
            
            foreach(Aluno a in alunos)
            {
                if (a.PodeFormar()) alunosOK++;
            }

            double porcentagem = ((double)alunosOK / totalAlunos) * 100;

            Console.WriteLine($"Quantidade de alunos totais: {totalAlunos}");
            Console.WriteLine($"Porcentagem de alunos que podem formar: {porcentagem}%");

            foreach(Aluno a in alunos)
            {
                if(!a.PodeFormar()) Console.WriteLine(a);
            }
                
        }


        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();

            // ✔️ Aluno 1 - DEVE FORMAR (>=10 créditos e >=2 tipos)
            Aluno a1 = new Aluno("Ryan", 864103, 555);
            a1.AdicionarAtividade(new Profissional("Trabalho empresa", 120)); // 4 créditos
            a1.AdicionarAtividade(new Estagio("Estágio XPTO", 180)); // 4 créditos
            a1.AdicionarAtividade(new Extensao("Projeto social", 80)); // 4 créditos
            alunos.Add(a1);

            // ✔️ Aluno 2 - NÃO FORMA (poucos créditos)
            Aluno a2 = new Aluno("Ana", 123456, 111);
            a2.AdicionarAtividade(new Estagio("Estágio pequeno", 40)); // 0 créditos
            a2.AdicionarAtividade(new Extensao("Evento", 20)); // 1 crédito
            alunos.Add(a2);

            // ✔️ Aluno 3 - NÃO FORMA (apenas 1 tipo)
            Aluno a3 = new Aluno("Carlos", 789101, 222);
            a3.AdicionarAtividade(new Profissional("Empresa A", 120)); // 4 créditos
            a3.AdicionarAtividade(new Profissional("Empresa B", 120)); // 4 créditos
            alunos.Add(a3);

            // ✔️ Aluno 4 - DEVE FORMAR
            Aluno a4 = new Aluno("Marina", 456789, 333);
            a4.AdicionarAtividade(new Extensao("Curso", 200)); // 4 créditos
            a4.AdicionarAtividade(new Estagio("Estágio longo", 200)); // 4 créditos
            a4.AdicionarAtividade(new Profissional("Freelancer", 120)); // 4 créditos
            alunos.Add(a4);

            // 🔹 Chamada do método de estatísticas
            EstatisticasAlunos(alunos);
        }
    }
}
