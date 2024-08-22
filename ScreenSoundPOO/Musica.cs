class Musica{
    public String nome;
    public String artista;
    public double duracao;
    public bool disponivel;

    public void ExibirFichaTecnica(){
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel){
            Console.WriteLine("Música está disponível no plano.");
        }
        else {
            Console.WriteLine("A música não está disponível no plano.");
        }
    }
}