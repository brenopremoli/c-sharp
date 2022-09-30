// See https://aka.ms/new-console-template for more information

Matematica m = new Matematica();
double r1 = m.Somar(5.5, 8);

Console.WriteLine(r1);

class Matematica
{
    public int Somar(int a, int b)
    {
        Console.WriteLine("[int, int]");
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        Console.WriteLine("[int, int, int]");
        return a + b + c;
    }

    public double Somar(double a, double b)
    {
        Console.WriteLine("[double, double]");
        return a + b;
    }

    public long Somar(long a, long b)
    {
        Console.WriteLine("[long, long]");
        return a + b;
    }
}
