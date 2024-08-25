class Musica{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public double Duracao { get; set; }
    public bool Disponivel { get ; set; } //propriedade com PascalCase
    public string DescricaoResumida  => $"A música {Nome} pertence a banda {Artista}"; // => lambda 
         // prop tab que só existe o get (leitura) a parte de escrita (set) nao tem = {get;}

    public void ExibirFichaTecnica(){
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel){
            Console.WriteLine("Música está disponível no plano.");
        }
        else {
            Console.WriteLine("A música não está disponível no plano.");
        }
    }
}