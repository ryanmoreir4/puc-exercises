
class Teste
{
    static void Main(string[] args)
    {
        Estacionamento est = new Estacionamento("Central Park", 30);

        est.Estacionar("ABC1234");
        est.Estacionar("DEF5678");
        est.Estacionar("GHI9012");
        est.Estacionar("JKL3456");
        est.Estacionar("MNO7890");

        est.ExibirOcupacao();

        Console.WriteLine("\nBuscar placa DEF5678:");
        int vaga = est.BuscarNumVaga("DEF5678");

        if (vaga != -1)
        {
            Console.WriteLine("Encontrado na vaga " + vaga);
        }
        else
        {
            Console.WriteLine("Não encontrado");
        }

        Console.WriteLine("\nRetirando placa DEF5678...");
        est.Retirar("DEF5678");

        Console.WriteLine("\nOcupação após remoção: ");
        est.ExibirOcupacao();

        est.Estacionar("PQR1111");
        est.Estacionar("STU2222");
        est.Estacionar("VWX3333");

        Console.WriteLine("\nOcupação após as 3 inserções: ");
        est.ExibirOcupacao();

        Console.WriteLine($"\nVagas livres: {est.NumVagasLivres}");
    }
}
