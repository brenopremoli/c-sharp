// See https://aka.ms/new-console-template for more information
/* Escreva um programa que imprime na saída os valores assumidos por x. Esta variável x deve
iniciar com algum valor inteiro, fornecido pelo usuário. Se x for par, x deve receber o valor
dele mesmo somado com 5. Já se x for ímpar, x deve receber o valor dele multiplicado por 2.
O programa termina assim que x for maior que 1000. Por exemplo, para x = 10, a saída deve
ser: 15, 30, 35, 70, 75, 150, 155, 310, 315, 630, 635, 1270. Faça este exercício usando blocos if
e depois usando blocos switch. */

Console.Write("Digite um valor: ");
int x = int.Parse(Console.ReadLine());

while (x < 1000)
{
    switch(x % 2)
    {
        case 0:
            x += 5;
            break;
        default:
            x *= 2;
            break;
    }
    Console.WriteLine(x);
}


