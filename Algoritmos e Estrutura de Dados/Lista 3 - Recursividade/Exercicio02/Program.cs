/// <summary>
/// Programa que retorna a soma dos números de um intervalo,
/// utilizando recursividade. O programa solicita ao usuário os 
/// limites do intervalo e exibe o resultado da soma dos números dentro desse intervalo.
/// </summary>
class Program
{
    static int CalcIntervalo(int m, int n)
    {
        if (n == m)
            return m;

        return m + CalcIntervalo(m + 1, n);
    }
    static void Main(string[] args)
    {
        Console.Write("Insira o primeiro número do intervalo: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Insira o segundo número do intervalo: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(CalcIntervalo(m, n));
    }
}