class Pessoa
{
    // Propriedades
    public required string Nome { get; set; }
    public int Idade { get; set; }
    public double Altura { get; set; }

    // Método para imprimir os dados
    public void ImprimirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Altura: {Altura}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Solicitar dados ao usuário
        Console.Write("Digite o nome da pessoa: ");
        string nome = Console.ReadLine() ?? string.Empty;

        Console.Write("Digite a idade da pessoa: ");
        int idade = 0;
        while (!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro para a idade.");
            Console.Write("Digite a idade da pessoa: ");
        }

        Console.Write("Digite a altura da pessoa: ");
        double altura;
        while (!double.TryParse(Console.ReadLine(), out altura))
        {
            Console.WriteLine("Entrada inválida. Digite um número decimal para a altura.");
            Console.Write("Digite a altura da pessoa: ");
        }

        // Criando uma instância da classe Pessoa com os dados do usuário
        Pessoa pessoa1 = new()
        {
            Nome = nome,
            Idade = idade,
            Altura = altura
        };

        // Imprimindo os dados
        pessoa1.ImprimirDados();
    }
}