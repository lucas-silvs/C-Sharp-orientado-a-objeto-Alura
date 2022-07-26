namespace ByteBank;

public class ContaCorrente
{
    public string titular;
    public string conta;
    public int numeroAgencia;
    public string nomeAgencia;
    public double saldo;


    public bool sacar(double valor)
    {
        if (valor > this.saldo)
        {
            Console.WriteLine("valor de saque maior que o saldo");
            return false;
        }

        this.saldo -= valor;
        return true;
    }
    
}