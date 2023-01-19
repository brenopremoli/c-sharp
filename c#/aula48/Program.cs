// Recursividade 

// A função chama ela mesma

Calc  c = new Calc();

var res = c.fat(9); // var = coringa

Console.WriteLine("Fatorial: {0}", res);

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

    // 4! = 4*3*2*1
    public int fat(int n)
    {
        int res;
        if(n <= 1)
        {
            res = 1;
        }
        else
        {
            res = n * fat(n - 1);
        }
        return res;
    }
}
