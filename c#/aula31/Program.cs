// Classes static

Jogador.iniciar("Breno");
Jogador.info();

Inimigo i1 = new Inimigo("Crazy");
Inimigo i2 = new Inimigo("Saul");
Inimigo i3 = new Inimigo("GoodCrazy");

Inimigo.alerta = true;

i1.info();
i2.info();
i3.info();

static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;
    static public void iniciar(string n) // construtor
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void info()
    {
        Console.WriteLine("Jogador: {0}", nome);
        Console.WriteLine("Energia: {0}", energia);
        Console.WriteLine("Estado:  {0}\n", vivo);
    }
}

class Inimigo
{
    static public bool alerta;
    public string nome;
    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }
    public void info()
    {
        Console.WriteLine("Inimigo: {0}", nome);
        Console.WriteLine("Alerta:  {0}\n", alerta);
    }
}
