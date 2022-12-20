// SWITCH case

float tempo = 0;
int escolha = 0;

Console.WriteLine("Presidente Prudente/SP -> São Paulo/SP");
Console.WriteLine("Escolha o transporte:");
Console.WriteLine("1. Avião");
Console.WriteLine("2. Carro");
Console.WriteLine("3. Ônibus");
Console.Write("Digite a opção: ");
escolha = int.Parse(Console.ReadLine());
// escolha = Convert.ToInt32(Console.ReadLine());

switch(escolha)
{
    case 1:
    {
        tempo = 50;
        break;
    }
    
    case 2:
    {
        tempo = 480;
        break;
    }

    case 3:
    {
        tempo = 660;
        break;
    }

    default:
    {
        tempo = -1;
        break;
    }
}

if (tempo < 0)
{
    Console.WriteLine("Transporte Indisponível");
}
else
{
    Console.WriteLine("Tempo de viagem: {0} minutos ou {1} horas.", tempo, tempo/60);
}