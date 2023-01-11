// Classes e métodos abstratos

// Base/referência para outras classes que vão herdar a classe abstrata, servem para ser herdadas

Carro carro1 = new Carro();

carro1.aceleracao(1);
carro1.aceleracao(-1);
carro1.aceleracao(1);

Console.WriteLine(carro1.getVelAtual());

abstract class Veiculo // Classe base abstrata
{
    protected int velMax;
    protected int velAtual;
    protected bool ligado;
    public Veiculo()
    {
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }
    public int getVelAtual()
    {
        return velAtual;
    }

    abstract public void aceleracao(int multi);
}

class Carro: Veiculo
{
    public Carro()
    {
        velMax = 120;
    }
    override public void aceleracao(int multi)
    {
        velAtual += 10 *multi;
    }
}