namespace Model;
public class BankAccount(string numeroConta, Cliente titular)
{
    public string NumeroConta { get; } = numeroConta;
    public decimal Saldo { get; private set; } = 0;
    public Cliente Titular { get; private set; } = titular;

    private List<Transacao> Transacoes { get; } = [];

    public void Depositar(decimal valor)
    {
        Saldo += valor;
        Transacoes.Add(new Transacao(valor, TipoTransacao.Deposito));
    }
    public bool Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Saldo)
        {
            return false; // Saque inválido
        }

        Saldo -= valor; // Deduz o valor do saldo
        Transacoes.Add(new Transacao(valor, TipoTransacao.Saque));
        return true; // Saque bem-sucedido
    }

    public void Transferir(decimal valor, BankAccount contaDestino)
    {
        Sacar(valor);
        contaDestino.Depositar(valor);
        Transacoes.Add(new Transacao(valor, TipoTransacao.Transferencia, contaDestino.NumeroConta));
    }
}