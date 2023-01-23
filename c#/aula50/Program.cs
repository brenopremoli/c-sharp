// Delegates 

// Fazer referências a métodos, contém o endereço de memória do ponto de entrada do método

int res; // v -> variável

Op d1 = new Op(Mat.soma);

res = d1(10,50);

Console.WriteLine("Soma: {0}", res);

d1 = new Op(Mat.multi);

res = d1(10,50);

Console.WriteLine("Multiplicação: {0}", res);

delegate int Op(int n1, int n2);

class Mat{
    public static int soma(int n1, int n2){
        return n1 + n2;
    }

    public static int multi(int n1, int n2){
        return n1 * n2;
    }
}
