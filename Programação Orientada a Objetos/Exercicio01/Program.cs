namespace Exercicio01
{
    class Program
    {
        static void LerValores(int[] num, int tam)
        {
            for (int i = 0; i < tam; i++)
            {
                Console.Write($"Insira o {i+1}º número: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        static int Soma(int[] num)
        {
            int soma = 0;

            foreach(int n in num)
            {
                soma += n;  

            }
            return soma;

        }

        static double Media(int[] num, int soma)
        {
            double media = 0;

            media = (double)soma / num.Length;

            return media;
        }

        static int MaiorMedia(int[] num, double media)
        {
            int maiorMedia = 0;

            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] > media)
                    maiorMedia++;
            }

            return maiorMedia;
        }

        static int MenorMetadeMedia(int[] num, double media)
        {
            int menorMetadeMedia = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < (media / 2))
                    menorMetadeMedia++;
            }

            return menorMetadeMedia;
        }

        static int ContarParImpar(int[] num)
        {
            int par = 0;


            foreach(int i in num)
            {
                if(i % 2 == 0)               
                    par++;
            }

            return par;
        }

        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de números que deseja ler: ");
            int tam = int.Parse(Console.ReadLine());

            int[] num = new int[tam];

            LerValores(num, tam);

            int soma = Soma(num);
            double media = Media(num, soma);

            int par = ContarParImpar(num);
            int impar = num.Length - par;

            int maiorMedia = MaiorMedia(num, media);
            int menorMetadeMedia = MenorMetadeMedia(num, media);

            Console.WriteLine("==== RESULTADO ====");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Pares: {par}");
            Console.WriteLine($"Ímpar: {impar}");
            Console.WriteLine($"Maiores que a média: {maiorMedia}");
            Console.WriteLine($"Menores que a metade da média: {menorMetadeMedia}");
            Console.ReadLine();

        }
    }
}