// See https://aka.ms/new-console-template for more information
ContaBancaria c1 = new ContaBancaria();
ContaBancaria c2 = new ContaBancaria();

c1.numConta = 4567;
c1.titular = "Breno";

c2.numConta = 8900;
c2.titular = "Bruna";

c1.Depositar(200);
c1.Depositar(50);
c1.Sacar(150);

c2.Depositar(1000);
c2.Sacar(100);

c2.Transferir(200, c1);

Console.WriteLine("Nome do titular: "+c1.titular);
Console.WriteLine("Número da conta: "+c1.numConta);
Console.WriteLine("Saldo da conta: R$ "+c1.saldo);
Console.WriteLine();
Console.WriteLine("Nome do titular: "+c2.titular);
Console.WriteLine("Número da conta: "+c2.numConta);
Console.WriteLine("Saldo da conta: R$ "+c2.saldo);