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
        if (validarSaldo(valor))
        {
            this.saldo -= valor;
            return true;
        }
        return false;
    }

    public void depositar(double valor)
    {
        if (valor > 0)
        {
            this.saldo += valor;
        }
        else
        {
            Console.WriteLine("Valor de deposito menor ou igual a zero");
        }
    }

    public void transferir(ContaCorrente contaDestino, double valor)
    {
        if(validarSaldo(valor))
        {
            this.saldo -= valor;
            contaDestino.saldo += valor;
            Console.WriteLine("Transferencia realizada com sucesso");
        }
        else
        {
            Console.WriteLine("valor de transferencia invalido");
        }
    }

    private bool validarSaldo(double valor)
    {
        if (valor <= this.saldo && valor > 0)
            return true;
        return false;
    }
    
}