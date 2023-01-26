// Coleção Dictionary -> relação de valor através de chaves

Dictionary <int, string> veiculos = new Dictionary <int, string>();

// dicionario.método(int chave, string valor)
veiculos.Add(10, "Carro");
veiculos.Add(5, "Avião");
veiculos.Add(0, "Navio");
veiculos.Add(20, "Moto");
veiculos.Add(15, "Helicóptero");

// veiculos.Clear(); // limpa o Dictionary

veiculos.Remove(20); //Remoção

// Propriedade 
Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
int chave = 20;
if(veiculos.ContainsKey(chave)){
    Console.Write("Chave {0} está na coleção", chave);
}else{
    Console.Write("Chave {0} NÃO está na coleção", chave);
}

veiculos[15] = "Bike"; // substituição 

string valor = "Bike";
Console.WriteLine("\n");
if(veiculos.ContainsValue(valor)){
    Console.Write("Valor {0} está na coleção", valor);
}else{
    Console.Write("Valor {0} NÃO está na coleção", valor);
}

Dictionary <int, string>.ValueCollection valores = veiculos.Values;

Console.WriteLine("\n");
foreach(string v in valores){
    Console.WriteLine("{0}", v);
}

Console.WriteLine("\n");
foreach(KeyValuePair<int, string> v in veiculos){
    Console.WriteLine("{0} - {1}", v.Value, v.Key);
}