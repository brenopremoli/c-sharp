// Métodos

static void ola() // void = sem retorno
{
    Console.WriteLine("Olá Mundo!");
    Console.WriteLine("Curso de C#");
}

static void soma(int x, int y)
{
    Console.WriteLine("Resultado da soma de {0} + {1} = {2}", x, y, x+y);
}

static int somaRetorno(int x, int y) // int = com retorno
{
    int res = x + y;
    return res;
}

static double nome(int n1, double n2, string texto)
{
    double t = 0;
    return t;
}

/*
int n1, n2;
n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());
soma(n1, n2);
*/

int n1, n2;
n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Resultado da soma de {0} + {1} = {2}", n1, n2, somaRetorno(n1, n2));