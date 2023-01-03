// Construtores e Destrutores

string nome1;
Console.Write("Digite o nome do Jogador 1: ");
nome1 = Console.ReadLine();
Jogador j1 = new Jogador(nome1); 
Jogador j2 = new Jogador("Téo");

Console.WriteLine("Nome do Jogador 1: {0}", j1.nome);
Console.WriteLine("Nome do Jogador 2: {0}", j2.nome);

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n) // construtor
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~Jogador() // destrutor
    {
        Console.WriteLine("Jogador foi deletado/removido");
    }
}