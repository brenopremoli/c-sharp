// Passagem por valor e por referência

static void dobrar1(ref int valor)
{
    valor *= 2;
}

static void dobrar2(int valor)
{
    valor *= 2;
}

int n1 = 50;
dobrar1(ref n1);
Console.WriteLine(n1);
int n2 = 50;
dobrar2(n2);
Console.WriteLine(n2);