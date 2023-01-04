// Public vs Private

Jogador j1 = new Jogador("Breno");

j1.setEnergia(-40);
j1.setEnergia(60);

Console.WriteLine("Nome:    {0}", j1.getNome());
Console.WriteLine("Energia: {0}", j1.getEnergia());

class Jogador{
    private int energia;
    private string nome;
    public Jogador(string nome){
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia() // get -> obter -> método para obter o valor
    {
        return energia;
    }

    public string getNome() // get -> obter -> método para obter o valor
    {
        return nome;
    }

    public void setEnergia(int e) // set -> alterar ->método para alterar o valor
    {
        if (e < 0)
        {
            if (energia + e < 0)
            {
                energia = 0;
            }
            else
            {
                energia = energia + e;
            }
        }
        else if (e > 0)
        {
            if (energia + e > 100)
            {
                energia = 100;
            }
            else
            {
                energia = energia + e;
            }
        }
    }
}
