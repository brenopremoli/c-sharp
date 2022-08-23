// See https://aka.ms/new-console-template for more information
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