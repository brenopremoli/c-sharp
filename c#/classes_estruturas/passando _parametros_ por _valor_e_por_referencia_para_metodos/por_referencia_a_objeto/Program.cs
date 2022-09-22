// See https://aka.ms/new-console-template for more information

MyClass m = new MyClass();

Numero num = new Numero(); // num Referencia a variável (referência ao objeto)
num.n = 5; // n Referencia a field do objeto
m.Mudar(num);

Console.WriteLine(num.n);

class MyClass
{
    public void Mudar(Numero x)
    {
        x.n = 10;
    }
}

class Numero
{
    public int n;
}

