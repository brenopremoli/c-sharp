// See https://aka.ms/new-console-template for more information
/* Imprima os 15 primeiros números da série de Fibonacci. A série de Fibonacci possui a seguinte
sequência numérica: 0, 1, 1, 2, 3, 5, 8, 13, 21, etc.
Para calculá-la, o primeiro e segundo elementos valem 1, daí por diante, o n-ésimo elemento
vale o (n-1)-ésimo elemento somado ao (n-2)-ésimo elemento (ex: 8 = 5 + 3). */ 

int n = 0;
int m = 1;
int cont = 15;
Console.WriteLine(n);
while (cont >= 2)
{
    int x = m + n;
    Console.WriteLine(x);
    m = n;
    n = x;
    cont--;
}

// Outro jeito

int j = 1;
for (int i = 0, cont1 = 0; cont1 < 15; cont1++)
	{
	Console.WriteLine(i);
	i = i + j;
	j = i - j;
	}