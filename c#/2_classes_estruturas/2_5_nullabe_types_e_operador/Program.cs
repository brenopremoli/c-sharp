int? n = null; // ? - null

if (n == null)
{
    Console.WriteLine("Valor NULO - 'null'");
}

if (!n.HasValue)
{
    Console.WriteLine("Valor NULO - 'null'");
}

int  x = n ?? 0;  // Se n for "null" x = 0 

Console.WriteLine(x);