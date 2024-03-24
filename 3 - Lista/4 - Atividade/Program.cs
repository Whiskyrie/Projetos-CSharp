class Produto
{

    public required string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public void CalcularTotal()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Total: {Preco * Quantidade}");
    }


}

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Informe o Nome do produto:");
        string Nome = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Informe o Preço do produto:");
        double Preco = 0;
        while (!double.TryParse(Console.ReadLine(), out Preco))
        {
            Console.WriteLine("Entrada inválida. Digite um número válido para o preço.");
            Console.Write("Digite o Preço do produto: ");
        }

        Console.Write("Digite a Quantidade: ");
        int Quantidade = 0;
        while (!int.TryParse(Console.ReadLine(), out Quantidade))
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro para a quantidade.");
            Console.Write("Digite a Quantidade: ");
        }

        Produto produto1 = new()
        {
            Nome = Nome,
            Preco = Preco,
            Quantidade = Quantidade
        };

        // Imprimindo os dados
        produto1.CalcularTotal();


    }

}
