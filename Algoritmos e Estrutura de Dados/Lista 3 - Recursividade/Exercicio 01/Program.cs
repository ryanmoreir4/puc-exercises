/// <summary>
/// Código recursivo que recebe base e expoente
/// e calcula a potência
/// </summary>

class Program
{
    static int Potencia(int a, int n){
        int resp = 0;

        if (n == 0)
            return 1;

        if (n == 1)
            return a;
        else
            resp = a * Potencia(a, n - 1);

        return resp;
    }

    static void Main(string[] args)
    {
        Console.Write("Insira o valor da base: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Insira o expoente: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Potencia(a, n));
    }
}