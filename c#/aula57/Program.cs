// Coleção List P1 - array dinâmico

List<string> carros1 = new List<string>();
List<string> carros2 = new List<string>();
string[] carros3 = new string[6];


carros1.Add("Ferrari");
carros1.Add("Fusca");
carros1.Add("Porsche");
carros1.Add("Bugatti");

//carros2.AddRange(carros1);
//carros2.Clear();

if(carros1.Contains("Porsche")){
    Console.WriteLine("Está na lista");
}else{
    Console.WriteLine("Não está na lista");
}

carros1.CopyTo(carros3, 2);

foreach(string c in carros1){
    Console.WriteLine("Carro: {0}", c);
}

string car = "Fusca";
int pos = 0;
pos = carros1.IndexOf(car);
Console.WriteLine("Carro: {0} -> Posição: {1}", car, pos);