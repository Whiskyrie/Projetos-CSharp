namespace Model;

class Conversor
{
    private readonly Operacao operacaoCompra;
    private readonly Operacao operacaoVenda;

    public double TaxaCompra { get; private set; }
    public double TaxaVenda { get; private set; }
    public Moeda MoedaCompra { get; private set; }
    public Moeda MoedaVenda { get; private set; }

    public Conversor(Moeda moedaCompra, Moeda moedaVenda, double taxaCompra, double taxaVenda)
    {
        MoedaCompra = moedaCompra;
        MoedaVenda = moedaVenda;
        TaxaCompra = taxaCompra;
        TaxaVenda = taxaVenda;

        operacaoCompra = new Operacao(moedaCompra, moedaVenda, taxaCompra, true);
        operacaoVenda = new Operacao(moedaVenda, moedaCompra, 1 / taxaVenda, false);
    }

    public double CalcularValorCompra(double valor)
    {
        return operacaoCompra.CalcularValorConvertido(valor);
    }

    public double CalcularValorVenda(double valor)
    {
        return operacaoVenda.CalcularValorConvertido(valor);
    }
}