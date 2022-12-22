// Loop FOREACH / Estruturas de iteração

int[] num = new int[5]{11, 22, 33, 44, 55};

for (int i = 0; i < num.Length; i++) // inicializa/atribui - controle de posições
{
    num[i] = 0;
}


foreach(int n in num) // leitura
{
    Console.WriteLine(n);
}
