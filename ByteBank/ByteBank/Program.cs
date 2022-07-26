using ByteBank;

Console.WriteLine("Boas vindas ao ByteBank");

ContaCorrente conta = new ContaCorrente();
conta.titular = "Lucas Santos";
conta.conta = "123456L";
conta.numeroAgencia = 2;
conta.nomeAgencia = "Agencia Central";
conta.saldo = 100.00;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Lucas Santos2";
conta2.conta = "123456L";
conta2.numeroAgencia = 2;
conta2.nomeAgencia = "Agencia Central";
conta2.saldo = 1000;

Console.WriteLine("Titular: " + conta.titular );
Console.WriteLine("Conta: " + conta.conta );
Console.WriteLine("numero Agencia: " + conta.numeroAgencia );
Console.WriteLine("nome Agencia: " + conta.nomeAgencia );
Console.WriteLine("saldo conta: " + conta.saldo );

double valorSaque = 50;

if (conta.sacar(valorSaque))
{
    Console.WriteLine("Saque realizado com sucesso, saldo atual: " + conta.saldo);
}
else
{
    Console.WriteLine("Falha ao tentar sacar");
}
conta.depositar( 1000);
Console.WriteLine("Saldo apos o depósito de 1000: " + conta.saldo);

conta.transferir(conta2, 20000);
Console.WriteLine("Saldo conta 1 após a transferencia: " + conta.saldo);
Console.WriteLine("Saldo conta 2 após a transferencia: " + conta2.saldo);

Console.ReadKey();




