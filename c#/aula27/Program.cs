// Argumento params

static void soma(params int[] n)
{
    int res = 0;

    if (n.Length < 1  || n.Length == 0)
    {
        Console.WriteLine("Não existem valores a serem somados.");
    }

    else if (n.Length < 2)
    {
       Console.WriteLine("Valores Insuficientes para soma: {0}", n[0]); 
    }
    else
    {
        for(int i = 0; i < n.Length; i++)
        {
            res += n[i];
        }
        Console.WriteLine("Total da soma: {0}", res);
    }
}

soma(7, 10, 30, 3, 54, 12, 65, 3);