// See https://aka.ms/new-console-template for more information
for (int x = 0; x <= 10; x+=1)
{
    Console.WriteLine(x);
}

for (int x = 0, y = 10; x <= 10; x++, y--)
{
    Console.WriteLine("Linha x = "+x);
    Console.WriteLine("Linha y = "+y);
}