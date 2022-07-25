using ByteBank;

Console.WriteLine("Boas vindas ao ByteBank");

ContaCorrente conta = new ContaCorrente();
conta.titular = "Lucas Santos";
conta.conta = "123456L";
conta.numeroAgencia = 2;
conta.nomeAgencia = "Agencia Central";
conta.saldo = 100.00;

Console.WriteLine("Titular: " + conta.titular );
Console.WriteLine("Conta: " + conta.conta );
Console.WriteLine("numero Agencia: " + conta.numeroAgencia );
Console.WriteLine("nome Agencia: " + conta.nomeAgencia );
Console.WriteLine("saldo conta: " + conta.saldo );


Console.ReadKey();




