namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hora h1 = new Hora(10, 30, 20);

            Hora h2 = h1.IncrementarMinutos(50);

            Console.WriteLine(h1); // 10:30:20
            Console.WriteLine(h2); // 11:20:20

            Console.WriteLine(h2.Comparar(h1));
        }
    }
}
