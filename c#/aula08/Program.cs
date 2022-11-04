// Lendo valores do teclado

int v1, v2, soma;
string nome;

Console.Write("Digite o primeiro valor: ");
v1 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
v2 = Convert.ToInt32(Console.ReadLine());
soma = v1 + v2;
Console.WriteLine("A soma de {0} + {1} = {2}", v1, v2, soma);

Console.Write("Digite seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Nome: {0}", nome);

