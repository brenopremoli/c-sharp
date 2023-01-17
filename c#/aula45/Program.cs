// Array de estruturas

int[] numeros = new int[10];
Carro[] carros = new Carro[4];

carros[0].modelo = "HRV";
carros[0].cor = "Prata";

carros[1].modelo = "Golf";
carros[1].cor = "Azul";

carros[2].modelo = "Renegade";
carros[2].cor = "Preto";

carros[3].modelo = "Compass";
carros[3].cor = "Laranja";

for(int i = 0; i < carros.Length; i++)
{
    carros[i].info();
}

struct Carro
{
    public string modelo;
    public string cor;
    public void info()
    {
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor:    {0}\n", this.cor);
    }
}