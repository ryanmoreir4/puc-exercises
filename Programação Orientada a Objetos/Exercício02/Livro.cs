class Livro
{
    private string _titulo;
    private string _autor;
    private int _paginas;

    private int somaAvaliacoes = 0;
    private int quantAvaliacoes = 0;

    public Livro(string titulo, string autor, int paginas)
    {
        _titulo = titulo;
        _autor = autor;
        _paginas = paginas;
    }

    public string TipoLivro()
    {
        if (_paginas <= 90)
            return "Curto";

        if (_paginas <= 200)
            return "Médio";

        return "Longo";
    }


    /* Dúvida: é melhor eu lançar uma exceção, ou ler novamente
     * o valor inserido dentro da função de AvaliarLivro()
     * ou tratar essa condição diretamente no Main()?
    */
    public void AvaliarLivro(int estrelas)
    {
        somaAvaliacoes += estrelas;
        quantAvaliacoes++;
    }

    public double CalcularMedia()
    {
        return (double)somaAvaliacoes / quantAvaliacoes;
    }
}

