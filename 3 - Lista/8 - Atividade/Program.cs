class Funcionario
{
    private string _nome = string.Empty;
    private double _salario = 0;
    private double _horastrabalhadas = 0;

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

    public double Salario
    {
        get { return _salario; }
        set { _salario = value; }
    }

    public double HorasTrabalhadas
    {
        get { return _horastrabalhadas; }
        set { _horastrabalhadas = value; }
    }

    public double CalcularSalarioTotal()
    {
        return _salario * _horastrabalhadas;
    }
}


class Program
{
    static void Main(string[] args)
    {
        string nome;
        do
        {
            Console.Write("Digite o nome do Funcionário: ");
            nome = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("O nome não pode ser vazio ou conter apenas espaços em branco.");
            }
        } while (string.IsNullOrWhiteSpace(nome));
        double salario;
        Console.Write("Informe o salario do Funcionário: ");
        while (!double.TryParse(Console.ReadLine(), out salario))
        {
            Console.WriteLine("Entrada inválida. Informe um salario válido.");
            Console.Write("Informe o salario do Funcionário: ");
        }
        double horastrabalhadas;
        Console.Write("Informe a quantidade de horas trabalhadas: ");
        while (!double.TryParse(Console.ReadLine(), out horastrabalhadas))
        {
            Console.WriteLine("Entrada inválida. Informe uma carga horária válida.");
            Console.Write("Informe a quantidade de horas trabalhadas: ");
        }

        Funcionario funcionario = new()
        {
            Nome = nome,
            Salario = salario,
            HorasTrabalhadas = horastrabalhadas
        };

        double salarioTotal = funcionario.CalcularSalarioTotal();
        Console.WriteLine($"O salário total de {funcionario.Nome} é: {salarioTotal}");



    }
}