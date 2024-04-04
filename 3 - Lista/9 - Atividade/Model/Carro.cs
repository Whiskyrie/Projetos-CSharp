
namespace Atividade9;

class Carro
{
    public required string Modelo { get; set; }
    public int Ano { get; set; }
    public double Preco { get; set; }

    public double CalcularDesconto()
    {
        double desconto;
        if (Ano <= 2010)
        {
            desconto = Preco * 0.1; // 10% de desconto
        }
        else
        {
            desconto = Preco * 0.05; // 5% de desconto
        }
        return desconto;
    }
}
