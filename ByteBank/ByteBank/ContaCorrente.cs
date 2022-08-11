namespace ByteBank;
using titular;

public class ContaCorrente
{
    private string _conta;
    public string Conta
    {
        get
        {
            return _conta;
        }
        set
        {
            if (!String.IsNullOrEmpty(value))
            {
                _conta = value;
            }
        }
    }
    
    
    private Cliente _cliente;
    public Cliente Cliente
    {
        get
        {
            return _cliente;
        }
        set
        {
            if (value != null)
            {
                _cliente = value;
            }
        }
    }
    private int numeroAgencia;

    public int NumeroAgencia
    {
        get
        {
            return numeroAgencia;
        }
        set
        {
            if (value > 0)
            {
                numeroAgencia = value;
            }
        }
    }
    
    public string nomeAgencia;

    public String NomeAgencia
    {
        get
        {
            return nomeAgencia;
        }
        set
        {
            if (!String.IsNullOrEmpty(value))
            {
                nomeAgencia = value;
            }
        }
    }

    private double _saldo;
    public double Saldo
    {
        get
        {
            return _saldo;
        }
        set
        {
            if (validarSaldo(value))
            {
                _saldo = value;
            }
            
        }
    }
    
    public static int TotalContasCriadas { get; set; }
    
    //método construtor
    public ContaCorrente(int numeroAgencia, String nomeAgencia, String contaCliente, Cliente dadosCliente, double saldo)
    {
        Cliente = dadosCliente;
        this.nomeAgencia = nomeAgencia;
        this.NumeroAgencia = numeroAgencia;
        this.Conta = contaCliente;
        this.Saldo = saldo;
        TotalContasCriadas += 1;
    }

    //criando os métodos get e set na mão
    // public void SetSaldo(double saldo)
    // {
    //     if (validarSaldo(saldo))
    //     {
    //         this.saldo = saldo;
    //     }
    // }
    //
    // public double GetSaldo()
    // {
    //     return this.saldo;
    // }


    //utilizando propriedades do .NET para criar o get e set
    
    public bool sacar(double valor)
    {
        if (validarSaldo(valor))
        {
            Saldo -= valor;
            return true;
        }
        return false;
    }

    public void depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
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
            Saldo -= valor;
            contaDestino.Saldo += valor;
            Console.WriteLine("Transferencia realizada com sucesso");
        }
        else
        {
            Console.WriteLine("valor de transferencia invalido");
        }
    }

    private bool validarSaldo(double valor)
    {
        if (valor <= Saldo && valor > 0)
            return true;
        return false;
    }
    
}