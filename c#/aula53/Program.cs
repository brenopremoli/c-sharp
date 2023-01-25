// Exceções (erro) - Try Catch Finally 2 -> tratamento de exceções

// Exceção -> derivada da class "exception" 

float area = 0;

try{
    area = Area.Quad(0F, 5F);
    Console.WriteLine("Área do quadrado: {0}", area);
}catch(Exception e){
    Console.WriteLine("ERRO -> {0}", e.Message);
}finally{
    Console.WriteLine("FIM");
}

class Area{
    public static float Quad(float bas, float alt){
        if(bas == 0 || alt == 0){
            throw new Exception("Base ou altura não pode ser 0");
        }
        return bas * alt; // se não executar o "throw"
    }
}

