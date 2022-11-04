// Comando condicional IF (SE)

/*
int nota;
string resultado = "REPROVADO";

Console.Write("Nota: ");
nota = int.Parse(Console.ReadLine());

if (nota >= 6)
{
    resultado = "APROVADO";
}

Console.WriteLine("Resultado: {0}", resultado);
*/


int n1, n2, n3, n4, res;
string resultado = "REPROVADO";

n1 = n2 = n3 = n4 = res = 0;

Console.Write("Nota 1: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
n2 = int.Parse(Console.ReadLine());

Console.Write("Nota 3: ");
n3 = int.Parse(Console.ReadLine());

Console.Write("Nota 4: ");
n4 = int.Parse(Console.ReadLine());

res = n1 + n2 + n3 + n4;

if (res >= 60)
{
    resultado = "APROVADO";
}

Console.WriteLine("Resultado: {0}\nNota: {1}", resultado, res);


