namespace Model;


public class Transacao
{
    public decimal Valor { get; }
    public TipoTransacao Tipo { get; }
    public int ContaDestino { get; }
    public DateTime DataHora { get; }

    public Transacao(decimal valor, TipoTransacao tipo, int contaDestino = 0)
    {
        Valor = valor;
        Tipo = tipo;
        ContaDestino = contaDestino;
        DataHora = DateTime.Now;
    }

    public Transacao(decimal valor, TipoTransacao transferencia, string? numeroConta)
    {
        Valor = valor;
    }
}

public enum TipoTransacao
{
    Deposito,
    Saque,
    Transferencia
}