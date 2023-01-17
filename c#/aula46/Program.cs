// // Métodos que retornam objetos

Galinha g1 = new Galinha("Cleuza");
Galinha g2 = new Galinha("Judite");
Galinha g3 = new Galinha("Marilu");

g1.botar();
g3.botar();
g2.botar();
g1.botar();
g2.botar();
g1.botar();
g2.botar();

class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar()
    {
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo
{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha)
    {
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo Criado: {0} - {1}", this.numOvo, this.minhaGalinha);
    }
}
