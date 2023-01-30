// LinkedList / Lista duplamente encadeada

// Cada elemento é um nó da lista que tem link para o elemento anterior e posterior

LinkedList<string> transp = new LinkedList<string>();

transp.AddFirst("Carro");
transp.AddFirst("Avião");
transp.AddFirst("Navio");
transp.AddFirst("Moto"); // Início

transp.AddLast("Bicicleta"); // Fim

LinkedListNode<string> no;
no = transp.FindLast("Navio").Next; // next -> aponta para o próximo valor
no = transp.FindLast("Navio").Previous; // value -> aponta o valor anterior
transp.AddAfter(no, "Patinete"); // Após
no = transp.FindLast("Navio");
transp.AddBefore(no, "Patins"); // Antes

// transp.Clear(); // apaga tudo

if (transp.Find("Carro") == null){
    Console.WriteLine("Não Encontrado");
}else{
    Console.WriteLine("Encontrado");
}

// transp.Remove("Navio"); // apaga o valor escrito
transp.RemoveFirst(); // remove o primeiro
transp.RemoveLast(); // remove o último 

foreach(string t in transp){
    Console.WriteLine("Transporte: {0}", t);
}