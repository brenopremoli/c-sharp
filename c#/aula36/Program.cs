// Membros Protected -> semelhante ao private

Carro carro = new Carro("Bonitão", 120);

Console.WriteLine("Nome:              {0}", carro.nome);
Console.WriteLine("Velocidade Máxima: {0}", carro.getVelMax());
Console.WriteLine("Ligado:           {0}", carro.getLigado());

class Veiculo // classe Base
{
    public int velAtual;
    private int velMax; // restringe o acesso somente a própria classe
    protected bool ligado; // permite acesso aos membros pelas classes derivadas e pela própria classe
    public Veiculo(int velMax)
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false; 
        }
        public bool getLigado()
        {
            return ligado;
        }
        public int getVelMax()
        {
            return velMax;
        }
}

class Carro: Veiculo // Derivada de veiculo
{
    public string nome;
    public Carro(string nome, int vm): base(vm) // vm = velMax
    {
        this.nome = nome;
        ligado = true; // protected 
    }
}