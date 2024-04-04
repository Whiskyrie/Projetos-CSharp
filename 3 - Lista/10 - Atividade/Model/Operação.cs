namespace Model;

class Operacao
{
    public Moeda MoedaDeCompra { get; }
    public Moeda MoedaDeVenda { get; }
    public double TaxaDeConversao { get; }
    public bool EhCompra { get; }

    public Operacao(Moeda moedaDeCompra, Moeda moedaDeVenda, double taxaDeConversao, bool ehCompra)
    {
        MoedaDeCompra = moedaDeCompra;
        MoedaDeVenda = moedaDeVenda;
        TaxaDeConversao = taxaDeConversao;
        EhCompra = ehCompra;
    }

    public double CalcularValorConvertido(double valor)
    {
        if (EhCompra)
            return valor * TaxaDeConversao;
        else
            return valor / TaxaDeConversao;
    }
}