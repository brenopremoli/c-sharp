// Acessors GET e SET

// Como se fosse uma propriedade junto com um método no mesmo elemento, em uma propriedade privada -> obter, alterar (Calcular)

// get - propriedade somente de leitura
// set - propriedade somente de escrita
// get e set - propriedade de leitura e escrita

Carro c1 = new Carro();

c1.vm = 400;
Console.WriteLine("Velocidade: {0}", c1.vm);

class Carro
{
    private int velMax;

    public int vm
    {
        get // propriedade somente de leitura
        {
            return velMax;
        }
        set // propriedade somente de escrita
        {
            if (value < 0)
            {
                velMax = 0;
            }
            else if (value > 300)
            {
                velMax = 300;
            }
            else
            {
                velMax = value;
            }
        }
    }
    public Carro() // Construtor
    {
        vm = 120;
    }
}