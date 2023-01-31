// Coleção List P2 - array dinâmico

List<string> carros1 = new List<string>();
List<string> carros2 = new List<string>();
string[] carros3 = new string[7];


carros1.Add("Ferrari");
carros1.Add("Fusca");
carros1.Add("Porsche");
carros1.Add("Bugatti");
carros1.Add("Fusca");

//carros2.AddRange(carros1);
//carros2.Clear();

if(carros1.Contains("Porsche")){
    Console.WriteLine("Está na lista\n");
}else{
    Console.WriteLine("Não está na lista\n");
}

carros1.CopyTo(carros3, 2);

carros1.Insert(1, "Corvette");

int pos2 = carros1.LastIndexOf("Fusca");

//carros1.Remove("Porsche");
//carros1.RemoveAt(0); // remove o valor do index

//carros1.Reverse(); // inverte a ordem

carros1.Sort(); // ordem alfabética 

int tamanho = carros1.Count; // tamanho da lista
carros1.Capacity = 10;
int capacidade = carros1.Capacity;

foreach(string c in carros1){
    Console.WriteLine("Carro: {0}", c);
}

string car = "Fusca";
int pos1 = 0;
pos1 = carros1.IndexOf(car);
Console.WriteLine("\nCarro: {0} -> Posição: {1}", car, pos1);
Console.WriteLine("Carro: {0} -> Última Posição: {1}", car, pos2);
Console.WriteLine("Quantidade de carros: {0}", tamanho);
Console.WriteLine("Capacidade de elementos que pode ser armazenado: {0}", capacidade);