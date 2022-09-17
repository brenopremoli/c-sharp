// See https://aka.ms/new-console-template for more information
/* Escreva um programa que solicita que sejam digitadas três notas de um aluno e um peso para
cada nota. Calcule e imprima a média do aluno. */
Console.Write("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine()); 
Console.Write("Digite peso da primeira nota: ");
double peso1 = double.Parse(Console.ReadLine()); 

Console.Write("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine()); 
Console.Write("Digite o peso da segunda nota: ");
double peso2 = double.Parse(Console.ReadLine()); 

Console.Write("Digite a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine()); 
Console.Write("Digite o peso da terceira nota: ");
double peso3 = double.Parse(Console.ReadLine()); 

double media = ((nota1*peso1) + (nota2*peso2) + (nota3*peso3)) / (peso1 + peso2 + peso3);
Console.WriteLine("Média do aluno: "+media);





