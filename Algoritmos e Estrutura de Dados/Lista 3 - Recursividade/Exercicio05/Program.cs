class Program
{
    static int Negativos(int[] array, int n)
    {
        if (n == 0)
            return 0;

        if (array[n - 1] < 0)
            return 1 + Negativos(array, n - 1);

        Negativos(array, n - 1);

        return Negativos(array, n - 1); ;
    }
    static void Main(string[] args)
    {
        Console.Write("Insira o tamanho que o array terá: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Insira o {i+1}º valor do array: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.WriteLine(Negativos(array, n));
    }
}
