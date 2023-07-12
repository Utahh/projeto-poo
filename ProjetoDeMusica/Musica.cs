class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome 
    { get; } // Utilizando propriedade somente leitura passando metodos dentro deles
    public Banda Artista { get; }
    public int Duracao { get; set; }    
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"A musica {Nome} pertence  a banda {Artista}"; //Utilizando o Lambda com " => "

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}"); //atributo(propriedade)
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano!");
        }else
        {
            Console.WriteLine("Adquira o plano plus!");
        }
    }
}
