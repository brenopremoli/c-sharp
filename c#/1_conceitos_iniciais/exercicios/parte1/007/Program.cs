// See https://aka.ms/new-console-template for more information
/* Verifique a validade de uma data e mostre uma mensagem na tela dizendo se a data é válida ou
inválida. Devem existir três variáveis para armazenar o dia, o mês e o ano, e o usuário deve
fornecer os valores para estas variáveis via console. Considerar que fevereiro pode ter
somente 28 dias e que anos válidos estão compreendidos entre 1900 e 2999 */

Console.Write("Digite o dia: ");
int dia = int.Parse(Console.ReadLine());
Console.Write("Digite o mês: ");
int mes = int.Parse(Console.ReadLine());
Console.Write("Digite o ano: ");
int ano = int.Parse(Console.ReadLine());

if (dia < 0 || dia > 31 || mes < 0 || mes > 12 || ano < 1900 || ano > 2999)
{
    Console.WriteLine("Data inválida");
}
else if ((dia < 32) && (mes < 13)){
    if (dia > 28 && mes == 2)
    {
        Console.WriteLine("Data inválida");
    }
    else if ((dia == 31) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
    {
        {
            Console.WriteLine("Data inválida");
        }
    }
    else
    {
        Console.WriteLine("Data válida");
    }
}
else
{
    Console.WriteLine("Data inválida");
}