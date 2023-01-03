// Sobrecarga de Construtores

Jogador j1 = new Jogador(); 
Jogador j2 = new Jogador("Breno");
Jogador j3 = new Jogador("Téo", 78);
Jogador j4 = new Jogador("Mercy", 0, false);

j1.info();
j2.info();
j3.info();
j4.info();

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador() // construtor
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    public Jogador(string n) // sobrecarga de construtor 
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e) // sobrecarga de construtor
    {
        energia = e;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e, bool v) // sobrecarga de construtor
    {
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info()
    {
        Console.WriteLine("Jogador: {0}", nome);
        Console.WriteLine("Energia: {0}", energia);
        Console.WriteLine("Estado:  {0}\n", vivo);
    }

    public void info(int n) // Sobrecarga de métodos
    {
        Console.WriteLine("Jogador: {0}", nome);
        Console.WriteLine("Energia: {0}", energia);
        Console.WriteLine("Estado:  {0}\n", vivo);
    }
}
