/// <summary>
/// Prorama recursivo que calcula o MDC (Máximo Divisor Comum) 
/// entre X e Y (definidos pelo usuário)
/// </summary>
class Program
{
    static int MDC(int x, int y)
    {
        if (x == y)
            return x;

        if (x < y)
           return MDC(y, x);

        return MDC(x - y, y);
    }
    static void Main(string[] args)
    {
        Console.Write("Insira o primeiro valor: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Insira o segundo valor: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine(MDC(x, y));
    }
}