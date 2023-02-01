// Coleção Queue (Fila) - first in first out -> primeiro a entrar é o primeiro a sair


string[] vs = {"Carro", "Moto", "Navio", "Avião"};
Queue<string> veiculos1 = new Queue<string>(vs);

Queue<string> veiculos2 = new Queue<string>();

veiculos2.Enqueue("Carro"); // Adiciona no final da fila
veiculos2.Enqueue("Moto");
veiculos2.Enqueue("Navio");
veiculos2.Enqueue("Avião");

string v = "Avião";
if(veiculos2.Contains(v)){
    Console.WriteLine("Veículo " + v + " encontrado");
}else{
    Console.WriteLine("Veículo " + v + " não encontrado");
}

Console.WriteLine("Tamanho da fila: "+ veiculos2.Count);
//veiculos1.Clear();
//Console.WriteLine("Primeiro veículo: " + veiculos2.Dequeue()); // Dequeue -> pega o primeiro elemento e retorna, tirando-o da fila
//Console.WriteLine("Primeiro veículo: " + veiculos2.Dequeue());
//Console.WriteLine("Primeiro veículo: " + veiculos2.Peek()); // Dequeue -> pega o primeiro elemento e retorna
foreach(string veic in veiculos2){
    Console.WriteLine("Veículo: " + veic);
}

while(veiculos2.Count > 0){
    Console.WriteLine("Veículo removido: " + veiculos2.Dequeue());
}
Console.WriteLine("Tamanho da fila: "+ veiculos2.Count);