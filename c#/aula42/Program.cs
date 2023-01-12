// Indexadores de Classes

// Membro de uma classe que permite aos objetos desta classe ser indexados como se fossem arrays

Carro c1 = new Carro();

c1[4] = 200;
Console.WriteLine("Velocidade: {0}", c1[4]);

class Carro
{
    private int[] velMax = new int[5]{80, 120, 160, 240, 300};

    public int this[int i]
    {
        get // propriedade somente de leitura
        {
            return velMax[i];
        }
        set // propriedade somente de escrita
        {
            if (value < 0)
            {
                velMax[i] = 0;
            }
            else if (value > 300)
            {
                velMax[i] = 300;
            }
            else
            {
                velMax[i] = value;
            }
        }
    }
    public Carro() // Construtor
    {
    }
}