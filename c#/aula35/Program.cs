// Cadeia de herança e Construtor da classe base

Carro c1 = new Carro("Rapidão", "Vermelho");
CarroCombate cc1 = new CarroCombate();

c1.ligar();

Console.WriteLine("CARRO COMUM");
Console.WriteLine("Cor:               {0}", c1.cor);
Console.WriteLine("Nome:              {0}", c1.nome);
Console.WriteLine("Rodas:             {0}", c1.getRodas());
Console.WriteLine("Velocidade Máxima: {0}", c1.velMax);
Console.WriteLine("Ligado:            {0}\n", c1.getLigado());

Console.WriteLine("CARRO DE COMBATE");
Console.WriteLine("Cor:               {0}", cc1.cor);
Console.WriteLine("Nome:              {0}", cc1.nome);
Console.WriteLine("Rodas:             {0}", cc1.getRodas());
Console.WriteLine("Velocidade Máxima: {0}", cc1.velMax);
Console.WriteLine("Ligado:            {0}", cc1.getLigado());
Console.WriteLine("Munição:           {0}\n", cc1.municao);


class Veiculo{ // Classe Base
    private int rodas;
    public int velMax;
    private bool ligado;
    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }
    public void ligar()
    {
        ligado = true;
    }
    public void desligar()
    {
        ligado = false;
    }

    public string getLigado()
    {
        return (ligado? "Sim":"Não"); // operador ternário
    }
    public int getRodas()
    {
        return rodas;
    }
    public void setRodas(int rodas)
    {
        if(rodas<0)
        {
            this.rodas = 0;
        }
        else if (rodas > 40)
        {
            this.rodas = 40;
        }
        else{
            this.rodas = rodas;
        }
    }
}

class Carro: Veiculo // classe Derivada - class "Carro" herda class "Veiculo" -> derivada -> base
{
    public string nome;
    public string cor;
    public Carro(string nome, string cor): base(4)
    {
        desligar();
        velMax = 160;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate: Carro // lasse Derivada - class "CarroCombate" herda class "Carro" que herdou class "Veiculo" -> derivada -> base
{
    public int municao;
    public CarroCombate(): base("Carro de Combate", "Azul")
    {
        municao = 100;
        setRodas(6);
    }
}
