// See https://aka.ms/new-console-template for more information

MyClass m = new MyClass();

int i = 5;
m.Trocar(ref i);

Console.WriteLine(i);


class MyClass
{
    public void Trocar(ref int x)
    {           // Fornece o local da memória
        x = 10; // Mudança é feita no método e fora
    } 
}


