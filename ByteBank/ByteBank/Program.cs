using ByteBank;
using ByteBank.titular;
Console.WriteLine("Boas vindas ao ByteBank");
Cliente cliente = new Cliente();
cliente.nome = "Lucas Santos";

String numeroConta= "123456L";
int numeroAgencia = 2;
String nomeAgencia = "Agencia Central";
double saldo = 100.00;

ContaCorrente conta = new ContaCorrente(numeroAgencia, nomeAgencia, numeroConta, cliente, saldo);

Cliente cliente2 = new Cliente();
cliente.nome = "Lucas Santos";
String numeroConta2 = "123456L";
int numeroAgencia2 = 2;
String nomeAgenciaCentral = "Agencia Central";
double saldo2 = 1000;

ContaCorrente conta2 = new ContaCorrente(numeroAgencia2, nomeAgenciaCentral, numeroConta2, cliente2, saldo2);
Console.WriteLine("Titular: " + conta.Cliente.nome );
Console.WriteLine("Conta: " + conta.Conta );
Console.WriteLine("numero Agencia: " + conta.NumeroAgencia );
Console.WriteLine("nome Agencia: " + conta.nomeAgencia );
Console.WriteLine("saldo conta: " + conta2.Saldo );

double valorSaque = 50;

if (conta.sacar(valorSaque))
{
    Console.WriteLine("Saque realizado com sucesso, saldo atual: " + conta2.Saldo);
}
else
{
    Console.WriteLine("Falha ao tentar sacar");
}
conta.depositar( 1000);
Console.WriteLine("Saldo apos o depósito de 1000: " + conta2.Saldo);

conta.transferir(conta2, 20000);
Console.WriteLine("Saldo conta 1 após a transferencia: " + conta2.Saldo);
Console.WriteLine("Saldo conta 2 após a transferencia: " + conta2.Saldo);


Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalContasCriadas);
Console.ReadKey();




