// Métodos e Variáveis estáticos (static) -> usar em qualquer lugar do programa

double vpi = Mat.pi; // pi -> vantagem do static
int num = 10;

// Mat m = new Mat();

Console.WriteLine("Pi: {0}", vpi);
Console.WriteLine("Dobro: {0}", Mat.dobro(num));

class Mat{
    public static double pi = 3.14;

    public static int dobro(int n){
        return n * 2;
    }
}