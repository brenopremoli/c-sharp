// Loop DO WHILE / Estruturas de iteração 

int num = 5;

do 
{
    Console.WriteLine("Olá Mundo!");
}
while(num < 5);

string senha = "123";
string digitada;
int tentativa = 0;


do 
{
    Console.Clear();
    Console.Write("Digite a senha: ");
    digitada = Console.ReadLine();
    tentativa++;
}
while(senha != digitada);

Console.WriteLine("Senha Correta! Tentativas: {0} ",tentativa);
