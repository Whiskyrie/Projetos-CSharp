class Carro
{
    public required string Modelo { get; set; }
    public int Ano { get; set; }
    public double Preco { get; set; }

    public double CalcularDesconto()
    {
        double desconto;
        if (Ano < 2010)
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

class Program
{
    static void Main(string[] args)
    {
        string modelo;
        do
        {
            Console.Write("Digite o modelo do carro: ");
            modelo = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(modelo))
            {
                Console.WriteLine("O modelo não pode ser vazio ou conter apenas espaços em branco.");
            }
        } while (string.IsNullOrWhiteSpace(modelo));

        int ano;
        Console.Write("Informe o ano do carro: ");
        while (!int.TryParse(Console.ReadLine(), out ano))
        {
            Console.WriteLine("Entrada inválida. Informe um ano válido.");
            Console.Write("Informe o ano do carro: ");
        }

        double preco;
        Console.Write("Informe o preço do carro: ");
        while (!double.TryParse(Console.ReadLine(), out preco))
        {
            Console.WriteLine("Entrada inválida. Informe um preço válido.");
            Console.Write("Informe o preço do carro: ");
        }

        Carro carro = new()
        {
            Modelo = modelo,
            Ano = ano,
            Preco = preco
        };

        double descontoAplicado = carro.CalcularDesconto();
        Console.WriteLine($"O desconto para o carro {carro.Modelo} é de R$ {descontoAplicado}");
    }
}