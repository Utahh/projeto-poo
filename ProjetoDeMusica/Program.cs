Episodio ep1 = new(1, "Tecnicas de facilitacao", 45);
ep1.AdicionaConvidados("Maria");
ep1.AdicionaConvidados("Marcelo");


Episodio ep2 = new(2, "Tecnicas de aprendizado", 67);
ep2.AdicionaConvidados("Fernando");
ep2.AdicionaConvidados("Marcos");
ep2.AdicionaConvidados("Flavio");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

