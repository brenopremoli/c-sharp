// Exceções (erro) - Try Catch Finally -> tratamento de exceções

// Exceção -> derivada da class "exception" 

int n1, n2, res;
res = n1 = n2 = 0;

n1 = 10;
n2 = 0;

try{
    res = n1 / n2;
    Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
}catch(Exception e){
    Console.WriteLine("ERRO            -> {0}", e.Message);
    Console.WriteLine("Exceção         -> {0}", e);
    Console.WriteLine("Tipo da Exceção -> {0}", e.GetType());
}


