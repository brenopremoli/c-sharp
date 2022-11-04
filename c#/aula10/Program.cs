// Enumeradores (enum) 

class Aula10{

enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
static void Main(){

    int ds = (int)DiasSemana.Sexta; // imprime o valor

    //DiasSemana ds = (DiasSemana)3; // índice 3

    Console.WriteLine(ds);
    }
}