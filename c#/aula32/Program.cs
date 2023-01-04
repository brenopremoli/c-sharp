// This 

Calculos c = new Calculos(10,2);
Console.WriteLine(c.Somar());

class Calculos{
    public int v1; // "this" pertence
    public int v2; // "this" pertence

    public Calculos(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public int Somar()
    {
        return v1 + v2;
    }
}

