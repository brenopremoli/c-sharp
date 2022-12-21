// Loop FOR / Estruturas de iteração

int[] num = new int[5];

for(int i = 0; i < num.Length; i++) // inicializador/contador - qtd. de repetição/condição -  incremento/decremento
{
    num[i] = i;
}

for(int i = 0; i < num.Length; i++) 
{
    Console.WriteLine(num[i]);
}