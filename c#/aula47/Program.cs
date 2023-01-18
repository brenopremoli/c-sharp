// Sobrecarga de métodos

// double res;

Calc  c = new Calc();

var res = c.soma(10.2, 5.4, 7.3, 8.3, 54.2); // var = coringa

Console.WriteLine("Soma: {0}", res);

class Calc
{
    public int soma(params int[]n)
    {
        int s = 0;
        for(int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }
        return s;
    }
    public double soma(params double[]n)
    {
        double s = 0;
        for(int i = 0; i < n.Length; i++)
        {
            s += n[i];
        }
        return s;
    }
}