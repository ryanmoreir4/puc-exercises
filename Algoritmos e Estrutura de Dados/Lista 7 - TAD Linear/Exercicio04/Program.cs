using System;

namespace Exercicio04
{
    class Arquivo
    {
        private string nome;
        private int paginas;

        public Arquivo(string nome, int paginas)
        {
            this.nome = nome;
            this.paginas = paginas;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }

        public override string ToString()
        {
            return nome + " " + paginas;
        }
    }

    class Fila
    {
        private Arquivo[] array;
        private int primeiro;
        private int ultimo;

        public Fila(int tamanho)
        {
            array = new Arquivo[tamanho + 1];
            primeiro = ultimo = 0;
        }

        // Insere um arquivo no final da fila
        public void Inserir(Arquivo a)
        {
            if (((ultimo + 1) % array.Length) == primeiro)
                throw new Exception("Erro: fila cheia.");

            array[ultimo] = a;
            ultimo = (ultimo + 1) % array.Length;
        }

        // Remove e retorna o primeiro arquivo da fila
        public Arquivo Remover()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro: fila vazia.");

            Arquivo removido = array[primeiro];
            primeiro = (primeiro + 1) % array.Length;
            return removido;
        }

        // Mostra todos os arquivos da fila
        public void Mostrar()
        {
            int i = primeiro;
            while (i != ultimo)
            {
                Console.WriteLine(array[i]);
                i = (i + 1) % array.Length;
            }
        }

        public bool Vazia()
        {
            return primeiro == ultimo;
        }
    }

    class Teste
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila(100);
            int op = 0;

            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        string nome = Console.ReadLine();
                        int paginas = int.Parse(Console.ReadLine());
                        Arquivo arquivo = new Arquivo(nome, paginas);
                        fila.Inserir(arquivo);
                        break;

                    case 2:
                        if (fila.Vazia())
                        {
                            Console.WriteLine("Fila de impressão vazia.");
                        }
                        else
                        {
                            Arquivo impresso = fila.Remover();
                            Console.WriteLine(impresso.Nome);
                        }
                        break;

                    case 3:
                        fila.Mostrar();
                        break;

                    case 4:
                        break;
                }

            } while (op != 4);
        }
    }
}
