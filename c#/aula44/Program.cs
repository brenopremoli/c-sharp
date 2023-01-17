// Struct 

// Permite armazenamento de diferentes tipos de dados - tipo especial, é semelhante a classe porém struct é acessado por valor e class por referência

Carro c1;

c1.marca = "Jeep";
c1.modelo = "Compass";
c1.cor = "Preto";

Console.WriteLine("Marca:  {0}", c1.marca);
Console.WriteLine("Modelo: {0}", c1.modelo);
Console.WriteLine("Cor:    {0}\n", c1.cor);

Carro c2 = new Carro("Honda", "HRV", "Prata");

Console.WriteLine("Marca:  {0}", c2.marca);
Console.WriteLine("Modelo: {0}", c2.modelo);
Console.WriteLine("Cor:    {0}\n", c2.cor);

Carro c3 = new Carro("VW", "Golf", "Azul");

c3.info();

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo, string cor) // Construtor
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info()
    {
        Console.WriteLine("Marca:  {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor:    {0}", this.cor);
    }
}

