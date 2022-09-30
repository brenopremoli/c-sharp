// See https://aka.ms/new-console-template for more information

MyClass m = new MyClass();

int i = 5;
m.Trocar(i);

Console.WriteLine(i);


class MyClass
{
    public void Trocar(int x)
    {           // Troca do valor da cópia
        x = 10; // Mudança só é feita no método
    } 
}

