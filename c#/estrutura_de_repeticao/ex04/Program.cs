// See https://aka.ms/new-console-template for more information
for (int i = 1; i < 100; i++)
{
    if (i % 2 != 0)
    {
        continue; // faz uma nova interação, um novo loop
    }
    Console.WriteLine(i);
}

for (int i = 1; i < 100; i++)
{
    if (i % 2 == 0)
    {
        break; // sai do loop
    }
    
    Console.WriteLine(i);
}