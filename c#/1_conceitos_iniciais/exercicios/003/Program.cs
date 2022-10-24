// See https://aka.ms/new-console-template for more information
/* 3.1- Imprima todos os números de 10 a 25. */ 
for(int w = 10; w <= 25; w++)
{
    Console.WriteLine(w);
}

/* 3.2- Imprima a soma dos números de 1 a 100, pulando de dois em dois (1, 3, 5, 7, etc.).  */ 
int soma1 = 0;
for(int x = 1; x <= 100; x+=2)
{
    soma1 += x;
}
Console.WriteLine();
Console.WriteLine(soma1);

/* 3.3- Começando em 0, imprima os números seguintes, enquanto a soma dos números já
impressos for menor que 100.  */ 
Console.WriteLine();
int soma2 = 0;
int y = 0;
while (soma2 < 100)
{
    Console.WriteLine(soma2);
    soma2 += y;
    y++;
}

/* 3.4-  Imprima a tabuada do 9 (até o décimo valor).  */ 
Console.WriteLine();
int i = 0;
int z = 0;
for(z = 0; i <= 10; z+=9)
{
Console.WriteLine("9 X "+i+" = "+z);
    i++;
}

