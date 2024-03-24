class Aluno
{
    private string _nome = string.Empty;
    private List<double> _notas = [];

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

    public List<double> Notas
    {
        get { return _notas; }
        set { _notas = value; }
    }

    public double CalcularMedia()
    {
        if (_notas.Count == 0)
            return 0;

        double soma = 0;
        foreach (double nota in _notas)
        {
            soma += nota;
        }

        return soma / _notas.Count;
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

        Aluno aluno = new() { Nome = nome };

        Console.WriteLine("Digite as notas do aluno (digite 'fim' para encerrar):");
        string? entrada;
        while ((entrada = Console.ReadLine()) != "fim")
        {
            if (double.TryParse(entrada, out double nota))
            {
                aluno.Notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número ou 'fim' para encerrar.");
            }
        }

        double media = aluno.CalcularMedia();
        Console.WriteLine($"A média das notas de {aluno.Nome} é {media.ToString("N2")}");
    }
}