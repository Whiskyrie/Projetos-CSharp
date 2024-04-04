using Atividade9;

class Program
{
    static void Main(string[] args)
    {
        string modelo;
        do
        {
            Console.Write("Digite o modelo do carro: ");
            modelo = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(modelo))
            {
                Console.WriteLine("O modelo não pode ser vazio ou conter apenas espaços em branco.");
            }
        } while (string.IsNullOrEmpty(modelo));

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