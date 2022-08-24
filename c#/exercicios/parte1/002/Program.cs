// See https://aka.ms/new-console-template for more information
/* 2- Escreva um programa semelhante ao do exercício 1, mas agora o número de notas e pesos
pode variar. O usuário deve digitar quantas notas ele desejar e, para parar, a nota -1 deve ser
digitada. Neste momento a média das notas e pesos digitados anteriormente deve ser
calculada e o resultado impresso na tela.  */
double somaCalculo = 0.0, somaPeso = 0.0;
int i = 1;

while(true)
{
    Console.Write("Digite a nota "+i+": ");
    double nota = double.Parse(Console.ReadLine()); 

    if (nota == -1) {
        break;
    }

    Console.Write("Digite o peso para a nota "+i+": ");
    double peso = double.Parse(Console.ReadLine());

    i++;

    somaCalculo += nota * peso;
    somaPeso += peso;
}

if (somaPeso > 0)
{
    double media = somaCalculo / somaPeso; 
    Console.WriteLine(media);
}