class Pessoa
{
    private string _nome = string.Empty;

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio ou conter apenas espaços em branco.");
            }
            _nome = value;
        }
    }

    public int Idade { get; set; }

    public bool EhMaiorDeIdade()
    {
        return Idade >= 18;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nome;
        do
        {
            Console.Write("Digite o nome da pessoa: ");
            nome = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("O nome não pode ser vazio ou conter apenas espaços em branco.");
            }
        } while (string.IsNullOrWhiteSpace(nome));

        Console.Write("Digite a idade da pessoa: ");
        int idade;
        while (!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro para a idade.");
            Console.Write("Digite a idade da pessoa: ");
        }

        Pessoa pessoa = new() { Nome = nome, Idade = idade };

        if (pessoa.EhMaiorDeIdade())
        {
            Console.WriteLine($"{pessoa.Nome} é maior de idade.");
        }
        else
        {
            Console.WriteLine($"{pessoa.Nome} é menor de idade.");
        }
    }
}