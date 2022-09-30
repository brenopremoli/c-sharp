// See https://aka.ms/new-console-template for more information

Matematica m = new Matematica();

int result; // Variável de saída não precisa inicializar
int a = 10;
int b = 2;
m.Multiplicar(a, b, out result);
Console.WriteLine(result);

int r1;
int r2;

m.MultiplicarESomar(3, 6, out r1, out r2); //modificador "out"
Console.WriteLine(r1);
Console.WriteLine(r2);

double pot = m.Elevar(2);
Console.WriteLine(pot);

class Matematica
{
    public void Multiplicar(int a, int b, out int c) //modificador "out"
    {
        c = a * b; //saída de 1
    }

    public void MultiplicarESomar(int a, int b, out int rm, out int rs)
    {
        rm = a * b; //saída de + de um
        rs = a + b;
    }

    public double Elevar(double n, double pot = 2) // "2" opcional
    {
        return Math.Pow(n, pot);

    }
}
