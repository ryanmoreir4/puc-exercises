class Program
{
    static void DecimalBinario(int n)
    {
        if(n == 0)
            return;

        DecimalBinario(n / 2);

        Console.Write(n % 2);
    } 
    static void Main(string[] args)
    {
        Console.Write("Insira o número a ser convetido para binário: ");
        int n = int.Parse(Console.ReadLine());
        
        DecimalBinario(n);
    }
}