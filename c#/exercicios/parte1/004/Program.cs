// See https://aka.ms/new-console-template for more information
/*Escreva um programa que calcule o fatorial de 10. */

int n = 10;
long fat = 1;
int cont = 1;
while (cont <= n)
{
    fat *= cont;
    cont++;
}
Console.WriteLine("Fatorial de " + n + " = " + fat);

// Outro jeito
Console.WriteLine();
int valor = 10;
long resposta = 1;
for (int i = 2; i <= valor; i++) {
	resposta *= i;
}
Console.WriteLine("O fatorial de " + valor + " igual a " + resposta);

