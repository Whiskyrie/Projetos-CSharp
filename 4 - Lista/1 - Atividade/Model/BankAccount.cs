namespace Model;
public class BankAccount(string numeroConta, Cliente titular)
{
    private readonly int numeroConta;
    private readonly Cliente? cliente;

    public string NumeroConta { get; } = numeroConta;
    public decimal Saldo { get; private set; } = 0;
    public Cliente Titular { get; private set; } = titular;

    private List<Transacao> Transacoes { get; } = [];

    public void Depositar(decimal valor)
    {
        Saldo += valor;
        Transacoes.Add(new Transacao(valor, TipoTransacao.Deposito));
    }

    public void Sacar(decimal valor)
    {
        if (valor > Saldo)
            throw new Exception("Saldo insuficiente.");

        Saldo -= valor;
        Transacoes.Add(new Transacao(valor, TipoTransacao.Saque));
    }

    public void Transferir(decimal valor, BankAccount contaDestino)
    {
        Sacar(valor);
        contaDestino.Depositar(valor);
        Transacoes.Add(new Transacao(valor, TipoTransacao.Transferencia, contaDestino.NumeroConta));
    }
}